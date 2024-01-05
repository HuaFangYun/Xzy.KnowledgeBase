namespace SemanticKernel.AIAgent.Web.Data.Application.Kms.Dto
{
    public class KmsDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ChatModel { get; set; }
        public string EmbeddingModel { get; set; }

        public bool IsChecked { get; set; }
        public bool IsCompleted { get; set; }
        [Required]
        public List<string> Tag { get; set; } = new List<string>();
    }
}
