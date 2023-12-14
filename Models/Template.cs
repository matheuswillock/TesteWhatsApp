namespace TesteWhatsApp.Models
{
    public class Template
    {
        public string name { get; set; }
        public Language language { get; set; }

        public Template(string name, Language language)
        {
            this.name = name;
            this.language = language;
        }
    }
}
