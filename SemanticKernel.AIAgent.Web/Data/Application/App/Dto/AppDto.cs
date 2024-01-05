namespace SemanticKernel.AIAgent.Web.Data.Application.App.Dto
{
    public class AppDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Describe { get; set; }

        public bool IsChecked { get; set; }
        public bool IsCompleted { get; set; }
        [Required]
        public List<string> Tag { get; set; } = new List<string>();

    }
}
