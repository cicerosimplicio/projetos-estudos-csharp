# Projeto MinimalAPI - ASP.NET Core

Este é um projeto de exemplo de API RESTful usando o padrão MinimalAPI do ASP.NET Core. O projeto está estruturado em várias camadas para demonstrar boas práticas de desenvolvimento.

## Estrutura do Projeto

1. **Movies.Api** - Camada de API que implementa os endpoints usando MinimalAPI
2. **Movies.Application** - Camada de aplicação que contém a lógica de negócios
3. **Movies.Contracts** - Camada de contratos/DTOs compartilhados
4. **Movies.Api.Sdk** - SDK para consumir a API
5. **Movies.Api.Sdk.Consumer** - Aplicação cliente de exemplo para consumir o SDK
6. **MinimalApiExample** - Projeto de exemplo básico para demonstrar o conceito de MinimalAPI

## Tecnologias Utilizadas

- ASP.NET Core 7.0+
- MinimalAPI
- Entity Framework Core
- JWT Authentication
- Swagger/OpenAPI
- API Versioning
- Output Cache

## Recursos Principais

- Autenticação JWT
- Versionamento de API
- Documentação com Swagger
- Cache de resposta
- Validação de entradas
- Health Checks
- Padrão de repositório
- Mapeamento de objetos

Consulte os READMEs individuais em cada projeto para informações específicas sobre cada componente.
