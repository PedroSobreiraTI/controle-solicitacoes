using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
var app = builder.Build();
app.UseCors();

var solicitacoes = new List<Solicitacao>();
var nextId = 1;

app.MapGet("/solicitacoes", () => Results.Ok(solicitacoes));

app.MapPost("/solicitacoes", async (HttpRequest request) => {
    var body = await JsonSerializer.DeserializeAsync<SolicitacaoInput>(
        request.Body,
        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
    );
    if (body == null || string.IsNullOrWhiteSpace(body.Titulo)
        || string.IsNullOrWhiteSpace(body.Status))
        return Results.BadRequest(new { erro = "Titulo e status sao obrigatorios." });
    var nova = new Solicitacao {
        Id = nextId++,
        Titulo = body.Titulo.Trim(),
        Solicitante = body.Solicitante?.Trim() ?? "",
        Status = body.Status.Trim()
    };
    solicitacoes.Add(nova);
    return Results.Created($"/solicitacoes/{nova.Id}", nova);
});

app.MapPut("/solicitacoes/{id:int}", async (int id, HttpRequest request) => {
    var body = await JsonSerializer.DeserializeAsync<SolicitacaoUpdate>(
        request.Body,
        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
    );
    if (body == null || string.IsNullOrWhiteSpace(body.Status))
        return Results.BadRequest(new { erro = "Status e obrigatorio." });
    var s = solicitacoes.FirstOrDefault(x => x.Id == id);
    if (s == null) return Results.NotFound();
    s.Status = body.Status.Trim();
    return Results.Ok(s);
});

app.Run("http://localhost:5000");

class Solicitacao {
    public int Id { get; set; }
    public string Titulo { get; set; } = "";
    public string Solicitante { get; set; } = "";
    public string Status { get; set; } = "Pendente";
}
class SolicitacaoInput {
    public string? Titulo { get; set; }
    public string? Solicitante { get; set; }
    public string? Status { get; set; }
}
class SolicitacaoUpdate { public string? Status { get; set; } }