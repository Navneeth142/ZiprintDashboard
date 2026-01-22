namespace BlazorAssignment.Models
{
    public record PartStatus(
    string PartNo,
    int Count,
    int Target
);

    public class AndonState
    {
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Plant { get; set; } = "CDC-01";
        public string Shift { get; set; } = "S-01";

        public List<PartStatus> Parts { get; set; } = [];
        public Dictionary<string, int[]> ShiftCounts { get; set; } = [];
    }
}
