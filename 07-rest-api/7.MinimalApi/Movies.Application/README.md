# Movies.Application

Este projeto contém a camada de aplicação que implementa a lógica de negócios do sistema. Ele atua como uma camada intermediária entre a API e o acesso a dados.

## Estrutura do Projeto

- **ApplicationServiceCollectionExtensions.cs** - Extensão para configurar serviços da aplicação
- **Database/** - Classes para acesso e inicialização do banco de dados
- **IApplicationMarker.cs** - Interface marcadora para o assembly
- **Models/** - Modelos de domínio da aplicação
- **Repositories/** - Implementações de repositórios para acesso a dados
- **Services/** - Serviços que implementam a lógica de negócios
- **Validators/** - Classes de validação para as entradas

## Serviços Implementados

### IMovieService
Implementa toda a lógica relacionada aos filmes:
- Criar filmes
- Obter filmes por ID ou slug
- Listar filmes com filtros e paginação
- Atualizar filmes
- Excluir filmes

### IRatingService
Implementa a lógica relacionada às avaliações de filmes:
- Avaliar um filme
- Obter avaliações de um usuário
- Excluir uma avaliação

## Repositórios

A aplicação usa o padrão Repository para acesso a dados:
- **IMovieRepository** - Acesso a dados de filmes
- **IRatingRepository** - Acesso a dados de avaliações

## Modelos de Domínio

Os principais modelos de domínio são:
- **Movie** - Representa um filme
- **Rating** - Representa uma avaliação de um filme

## Validações

O projeto inclui validações para garantir a integridade dos dados:
- Validação de campos obrigatórios
- Validação de formato
- Validação de regras de negócio
