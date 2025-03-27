## Título: "API de To-Do List com ASP.NET Core"

## Descrição: "Esta é uma API RESTful simples para gerenciamento de tarefas (To-Do List) construída com ASP.NET Core e Entity Framework Core (banco de dados em memória)."

## Tecnologias:

    ASP.NET Core
    Entity Framework Core (In-Memory Database)
    C#
    Swagger/OpenAPI

## Como executar:

    Certifique-se de ter o .NET SDK instalado.
    Clone o repositório.
    Navegue até o diretório do projeto.
    Execute dotnet run.
    Acesse a documentação do Swagger em https://localhost:[porta]/swagger.

## Endpoints:

    GET /api/Tasks: Retorna todas as tarefas.
    GET /api/Tasks/{id}: Retorna uma tarefa específica.
    POST /api/Tasks: Cria uma nova tarefa.
    POST /api/Tasks/{id}: Cria uma nova tarefa com id definido.
    PUT /api/Tasks: Atualiza uma tarefa existente.
    PUT /api/Tasks/{id}: Atualiza uma tarefa existente pelo id.
    DELETE /api/Tasks: Deleta todas as tarefas.
    DELETE /api/Tasks/{id}: Deleta uma tarefa específica.

## Licença:

    MIT License