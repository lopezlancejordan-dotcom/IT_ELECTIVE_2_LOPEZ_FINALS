namespace IT_ELECTIVE_2_LOPEZ_FINALS.Models
{
    public class QATaskModel
    {
        public int IssueId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string DirectUrl { get; set; } = string.Empty;
    }
}