using Microsoft.AspNetCore.Mvc;
using TesteWhatsApp.Client;
using TesteWhatsApp.Models;

namespace TesteWhatsApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SenderController : ControllerBase
    {

        readonly ILogger<IWhatsAppClient> _Logger;
        readonly IWhatsAppClient _WhatsAppClient;

        public SenderController(ILogger<IWhatsAppClient> logger, IWhatsAppClient whatsAppClient)
        {
            _Logger = logger;
            _WhatsAppClient = whatsAppClient;
        }

        [HttpGet("/send/message/template")]
        public IActionResult SendMessage()
        {
            try
            {
                Language language = new Language("en_US");
                Template template = new Template("hello_world", language);

                MessageTemplate messageTemplate = new MessageTemplate("5511983709790", template);

                var send = _WhatsAppClient.SendMessagetemplate(messageTemplate);

                return Ok(send);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na solicitação: {ex.Message}");
            }
        }
    }
}