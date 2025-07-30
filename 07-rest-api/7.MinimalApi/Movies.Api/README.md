# Movies.Api

Este é o projeto principal da API que implementa a abordagem MinimalAPI do ASP.NET Core. Ele fornece endpoints RESTful para gerenciar filmes e avaliações.

## Estrutura do Projeto

- **ApiEndpoints.cs** - Constantes com os caminhos dos endpoints da API
- **Auth/** - Classes relacionadas à autenticação e autorização
- **Endpoints/** - Implementação dos endpoints da API usando MinimalAPI
- **Health/** - Health checks para monitoramento da saúde da aplicação
- **Mapping/** - Classes para mapeamento entre modelos de domínio e DTOs
- **Swagger/** - Configuração do Swagger/OpenAPI

## Endpoints Implementados

### Filmes
- `GET /api/movies` - Obter todos os filmes (com paginação e filtros)
- `GET /api/movies/{idOrSlug}` - Obter um filme específico por ID ou slug
- `POST /api/movies` - Criar um novo filme
- `PUT /api/movies/{id}` - Atualizar um filme existente
- `DELETE /api/movies/{id}` - Excluir um filme

### Avaliações
- `POST /api/movies/{id}/ratings` - Avaliar um filme
- `DELETE /api/movies/{id}/ratings` - Excluir uma avaliação
- `GET /api/ratings/me` - Obter todas as avaliações do usuário atual

## Como Implementar

1. **Configuração Inicial**
   - O arquivo `Program.cs` contém toda a configuração da aplicação, incluindo autenticação, autorização, cache e serviços.

2. **Definição de Endpoints**
   - Os endpoints são organizados em classes estáticas por recurso (Movies, Ratings)
   - Cada endpoint é implementado como um método de extensão para `IEndpointRouteBuilder`

3. **Mapeamento**
   - As classes em `Mapping/` ajudam a converter entre os modelos de domínio e as respostas/solicitações da API

4. **Autenticação/Autorização**
   - JWT é usado para autenticação
   - Políticas de autorização são definidas para diferentes níveis de acesso

5. **Cache**
   - A API implementa Output Cache para melhor desempenho

## Recursos Adicionais

- Versionamento de API usando Media Type
- Documentação completa com Swagger
- Health checks para monitoramento da saúde da aplicação
