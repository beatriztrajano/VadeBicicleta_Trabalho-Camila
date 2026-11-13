using System;

namespace LoginComInterface.Context
{
    /*
     * =========================================================================================
     * EXEMPLO BASE DE CONFIGURAÇÃO DE BANCO (DbConfig)
     * =========================================================================================
     * Instruções para colaboradores:
     * 1. Crie um arquivo chamado "DbConfig.cs" nesta mesma pasta (LoginComInterface/Context).
     * 2. Use a estrutura abaixo para a classe "DbConfig":
     * 
     *    namespace LoginComInterface.Context
     *    {
     *        public static class DbConfig
     *        {
     *            public static string ConnectionString =>
     *                "Host=aws-0-us-east-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.bxlcvlwmqeyaodlnimje;Password=SUA_SENHA_AQUI;SSL Mode=Require;Trust Server Certificate=true";
     *        }
     *    }
     * 
     * 3. Substitua "SUA_SENHA_AQUI" pela senha fornecida pela equipe.
     * 4. O arquivo "DbConfig.cs" real já está listado no .gitignore e nunca será commitado.
     * =========================================================================================
     */
    public static class DatabaseConfigExample
    {
        public static string ConnectionString =>
            "Host=aws-0-us-east-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.bxlcvlwmqeyaodlnimje;Password=[SUA_SENHA_AQUI];SSL Mode=Require;Trust Server Certificate=true";
    }
}

