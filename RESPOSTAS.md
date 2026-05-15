# Respostas - Avaliação Conceitual

## 1. O que é automação de processos de negócios?

É o uso de tecnologia para executar tarefas repetitivas ou estruturadas de forma automática, reduzindo a necessidade de intervenção humana. O objetivo é tornar os processos mais rápidos, consistentes e menos suscetíveis a erros.

## 2. Principais considerações de segurança

- Autenticação e autorização: garantir que só usuários autorizados acessem ou modifiquem dados
- Validação de entrada: nunca confiar nos dados enviados pelo usuário, validar no front e no back
- Logs de auditoria: registrar quem fez o que e quando
- Proteção contra injeção: evitar SQL Injection e outros ataques via inputs maliciosos
- HTTPS: trafegar dados sempre criptografados

## 3. Exemplo de aplicação de automação

Um sistema de aprovação de compras: quando um colaborador abre uma solicitação, o sistema automaticamente notifica o gestor responsável, registra o pedido e atualiza o status conforme as aprovações acontecem, sem precisar de e-mails manuais ou planilhas.

## 4. Vantagens e desvantagens

**Vantagens:**
- Redução de erros humanos
- Maior velocidade nos processos
- Padronização e rastreabilidade
- Libera pessoas para tarefas estratégicas

**Desvantagens:**
- Custo inicial de implementação
- Resistência à mudança por parte da equipe
- Dependência de manutenção técnica
- Pode ser inflexível a exceções

## 5. Exemplo de automação que desenvolvi

Desenvolvi um script em Python para automatizar o envio e organização de relatórios em um ambiente de servidor Linux. O maior desafio foi lidar com variações no formato dos arquivos de entrada, que resolvi implementando validações antes do processamento e tratamento de exceções para os casos fora do padrão.

## 6. Experiência com C# ou JavaScript

Tenho mais contato com JavaScript ao longo do curso de Engenharia de Software na UCB, tendo utilizado em projetos acadêmicos para manipulação do DOM, consumo de APIs REST e validação de formulários. Com C# tive contato introdutório, mas compreendo a estrutura de uma API REST e os fundamentos da linguagem orientada a objetos, aplicados nesta prova técnica.
