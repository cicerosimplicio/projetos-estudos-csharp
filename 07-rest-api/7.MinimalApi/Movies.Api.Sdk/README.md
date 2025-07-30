# Movies.Api.Sdk

Este projeto implementa um SDK (Software Development Kit) que facilita o consumo da API Movies pelos clientes. Ele encapsula a lógica de comunicação com a API, oferecendo uma interface tipada e de fácil uso.

## Estrutura do Projeto

- **ApiEndpoints.cs** - Constantes com os caminhos dos endpoints da API
- **IMoviesApi.cs** - Interface que define os métodos disponíveis no SDK

## Funcionalidades

O SDK oferece métodos para interagir com todos os endpoints da API:

- Gerenciamento de filmes (criar, obter, listar, atualizar, excluir)
- Gerenciamento de avaliações (avaliar filmes, obter avaliações, excluir avaliações)

O SDK simplifica a integração com a API, abstraindo detalhes como gerenciamento de HTTP, serialização/desserialização e tratamento de erros.
