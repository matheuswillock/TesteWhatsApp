using TesteWhatsApp.Models;

namespace TesteWhatsApp.Client
{
    public interface IWhatsAppClient
    {
        public Task<string> SendMessagetemplate(MessageTemplate messageTemplate);
    }
}
