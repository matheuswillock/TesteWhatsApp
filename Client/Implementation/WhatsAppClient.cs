using Newtonsoft.Json.Linq;
using System.Text.Json;
using TesteWhatsApp.Models;

namespace TesteWhatsApp.Client.Implementation
{
    public class WhatsAppClient : IWhatsAppClient
    {

        public async Task<string> SendMessagetemplate(MessageTemplate messageTemplate)
        {
            string apiUrl = "https://graph.facebook.com/v17.0/188906824306227/messages";

            var requestBody = "{ \"messaging_product\": \"whatsapp\", \"to\": \"5511983709790\", \"type\": \"template\", \"template\": { \"name\": \"hello_world\", \"language\": { \"code\": \"en_US\" } } }";

            string token = "EAAKEAhg4844BO9fJ74G9QoYQH8PET6AjktGBNb8awQTyrXzWRif9o1HOhMWnkHlkf2gQlqOZBKF82EY41GGJtX10n7SQTarO7uRKPIK8FpaKLNF0edLbh1ZC93OraC7nZCtymUT5nbUJnBoZAUf4FsocduGZC6TRIopwKVdYRd3jjgDZC499Mmqz0t2ZAe0dlimWrujSgaOjgBaF6BTdZBXC33bC16MZD";

            using (HttpClient client = new HttpClient())
            {
                //string messageTemplateJson = JsonSerializer.Serialize(messageTemplate);

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var content = new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                //var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return $"Mensagem enviada com sucesso! ";
                }
                else
                {
                    return $"Erro na solicitação";
                }
            }
        }

    }
}
