namespace TesteWhatsApp.Models
{
    public class MessageTemplate
    {
        public string messaging_product { get; set; }
        public string to { get; set; }
        public string type { get; set; }
        public Template template { get; set; }

        public MessageTemplate(string to, Template template)
        {
            this.messaging_product = "whatsapp";
            this.to = to;
            this.type = "template";
            this.template = template;
        }
    }
}
