namespace Movies.Api;

// Classe estática que contém os endpoints da API organizados por recurso
public static class ApiEndpoints
{
    // Base comum para todos os endpoints da API
    private const string ApiBase = "api";
    
    // Endpoints relacionados ao recurso "Movies"
    public static class Movies
    {
        // Base para os endpoints de filmes
        private const string Base = $"{ApiBase}/movies";

        // Endpoint para criar um novo filme (POST)
        public const string Create = Base;

        // Endpoint para obter um filme específico por id ou slug (GET)
        public const string Get = $"{Base}/{{idOrSlug}}";

        // Endpoint para obter todos os filmes (GET)
        public const string GetAll = Base;

        // Endpoint para atualizar um filme existente por id (PUT/PATCH)
        public const string Update = $"{Base}/{{id:guid}}";

        // Endpoint para deletar um filme por id (DELETE)
        public const string Delete = $"{Base}/{{id:guid}}";

        // Endpoint para avaliar (dar nota) a um filme por id (POST)
        public const string Rate = $"{Base}/{{id:guid}}/ratings";

        // Endpoint para remover uma avaliação de um filme por id (DELETE)
        public const string DeleteRating = $"{Base}/{{id:guid}}/ratings";
    }
    
    // Endpoints relacionados ao recurso "Ratings"
    public static class Ratings
    {
        // Base para os endpoints de avaliações
        private const string Base = $"{ApiBase}/ratings";

        // Endpoint para obter as avaliações do usuário autenticado (GET)
        public const string GetUserRatings = $"{Base}/me";
    }
}
