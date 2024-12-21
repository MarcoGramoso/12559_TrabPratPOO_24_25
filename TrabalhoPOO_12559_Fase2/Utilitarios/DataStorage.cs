//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

using System.Text.Json;

namespace TrabalhoPOO_12559_Fase2.Utilitarios
{
    public static class DataStorage
    {
        /// <summary>
        /// Salva os dados em um arquivo.
        /// </summary>
        /// <typeparam name="T">O tipo de dados a serem salvos.</typeparam>
        /// <param name="data">Os dados a serem salvos.</param>
        /// <param name="filePath">O caminho do arquivo onde os dados serão salvos.</param>
        public static void SaveData<T>(T data, string filePath)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Os dados a serem salvos não podem ser nulos.");
            }

            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("O caminho do arquivo não pode ser nulo ou vazio.", nameof(filePath));
            }

            try
            {
                var jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                throw new IOException("Erro ao salvar os dados no arquivo.", ex);
            }
        }

        /// <summary>
        /// Carrega os dados de um arquivo.
        /// </summary>
        /// <typeparam name="T">O tipo de dados a serem carregados.</typeparam>
        /// <param name="filePath">O caminho do arquivo de onde os dados serão carregados.</param>
        /// <returns>Os dados carregados.</returns>
        public static T LoadData<T>(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("O caminho do arquivo não pode ser nulo ou vazio.", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("O arquivo especificado não foi encontrado.", filePath);
            }

            try
            {
                var jsonData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    AllowTrailingCommas = true,
                    ReadCommentHandling = JsonCommentHandling.Skip
                });
            }
            catch (JsonException jsonEx)
            {
                throw new InvalidOperationException("Erro ao desserializar o JSON.", jsonEx);
            }
            catch (Exception ex)
            {
                throw new IOException("Erro inesperado ao carregar os dados.", ex);
            }
        }
    }
}
