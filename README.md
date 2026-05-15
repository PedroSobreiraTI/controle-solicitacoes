# Sistema de Controle de Solicitações

Sistema full-stack para cadastro e gerenciamento de solicitações.

## Tecnologias

- Front-end: HTML + JavaScript puro
- Back-end: C# com ASP.NET Core 8
- Persistência: In-memory

## Como rodar localmente

### Pré-requisitos
- .NET 8 SDK instalado

### 1. Rodar o Back-end
cd backend
dotnet run

A API estará em: http://localhost:5000

### 2. Abrir o Front-end
Abra o arquivo frontend/index.html no navegador.

O back-end precisa estar rodando antes.

## Endpoints da API

GET    /solicitacoes        - Lista todas
POST   /solicitacoes        - Cria nova
PUT    /solicitacoes/{id}   - Atualiza status

### Exemplo POST
{
  "titulo": "Compra notebook",
  "solicitante": "João",
  "status": "Pendente"
}

### Exemplo PUT
{
  "status": "Concluída"
}

## Funcionalidades

- Cadastro com validação de campos obrigatórios
- Listagem em tabela
- Filtro por status
- Alteração de status na tabela
- Resumo dinâmico com total, pendentes e concluídas