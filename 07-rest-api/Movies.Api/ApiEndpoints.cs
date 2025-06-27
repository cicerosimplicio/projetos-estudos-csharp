using System;

namespace Movies.Api;

public static class ApiEndpoints
{
    // Classe que evita a mágica de strings nos endpoints

    private const string ApiBase = "api";

    public static class Movies
    {
        private const string Base = $"{ApiBase}/movies";
        public const string Create = Base;
        public const string Get = $"{Base}/{{id:guid}}"; // Usa constraint para garantir que o id é um GUID
        public const string GetAll = Base;
        public const string Update = Get;
        public const string Delete = Get;
    }

}
