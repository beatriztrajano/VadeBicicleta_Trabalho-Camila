using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LoginComInterface.Context
{
    /*
     * =========================================================================================
     * GUIA DE CONFIGURAÇÃO PARA COLABORADORES (SUPABASE STORAGE):
     * 
     * 1. Crie uma cópia deste arquivo nesta mesma pasta com o nome: SupabaseStorageService.cs
     * 2. No arquivo criado, altere o nome da classe para "SupabaseStorageService"
     * 3. Preencha a propriedade "SupabaseKey" com a chave fornecida pela equipe (anon ou service_role)
     * 4. O arquivo "SupabaseStorageService.cs" está protegido no .gitignore e nunca deve ser commitado!
     * =========================================================================================
     */
    public static class SupabaseStorageServiceExample
    {
        public static string SupabaseUrl { get; set; } = "https://bxlcvlwmqeyaodlnimje.supabase.co";

        // Substitua pela sua chave obtida no painel: Project Settings -> API
        public static string SupabaseKey { get; set; } = "SUA_API_KEY_DO_SUPABASE_AQUI";

        public static string BucketName { get; set; } = "documentos-privados";

        public static async Task<string> UploadArquivoAsync(byte[] arquivoBytes, string extensao, string usuario)
        {
            if (string.IsNullOrEmpty(SupabaseKey))
            {
                throw new InvalidOperationException("Configure a sua chave do Supabase (SupabaseKey) no arquivo SupabaseStorageService.cs antes de fazer o envio.");
            }

            string nomeArquivo = $"{usuario}_{Guid.NewGuid()}{extensao}";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("apikey", SupabaseKey);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {SupabaseKey}");

                using (var content = new ByteArrayContent(arquivoBytes))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    string endpoint = $"{SupabaseUrl}/storage/v1/object/{BucketName}/{nomeArquivo}";
                    var response = await client.PostAsync(endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        return nomeArquivo;
                    }
                    else
                    {
                        string erro = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Erro no upload para o Supabase Storage ({response.StatusCode}): {erro}");
                    }
                }
            }
        }
    }
}

