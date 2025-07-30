# MinimalApiExample

Este é um projeto de exemplo simples que demonstra os conceitos básicos da abordagem MinimalAPI no ASP.NET Core. Ele serve como uma introdução para entender como funciona o padrão MinimalAPI antes de mergulhar em implementações mais complexas.

## O que é MinimalAPI?

MinimalAPI é uma abordagem para construir APIs HTTP em ASP.NET Core com um código mais conciso e menos cerimonial, comparado ao padrão de Controllers tradicional. É ideal para microserviços e APIs simples onde você deseja reduzir a quantidade de código boilerplate.

## Estrutura do Projeto

- **Program.cs** - Ponto de entrada da aplicação e configuração dos endpoints
- **appsettings.json** - Configurações da aplicação

## Exemplos Implementados

O projeto contém exemplos de:
- Definição de rotas básicas (GET, POST, PUT, DELETE)
- Leitura de parâmetros de rota e query
- Retorno de diferentes tipos de resposta
- Validação básica
- Injeção de dependência

## Principais Benefícios do MinimalAPI

- Código mais conciso e menos boilerplate
- Fácil de entender e manter
- Performance melhorada por ter menos camadas de abstração
- Ótimo para APIs simples e microserviços
- Integração perfeita com .NET 6+ e recursos modernos da linguagem C#

## Limitações do MinimalAPI

- Menos adequado para APIs complexas com muitos endpoints
- Menos suporte para filtros e recursos avançados (em comparação com Controllers)
- Organização pode se tornar difícil com o crescimento da aplicação (embora isso possa ser mitigado com boas práticas de organização)

Este projeto serve como um trampolim para entender os conceitos fundamentais antes de explorar a implementação mais complexa e estruturada nos outros projetos da solução.
