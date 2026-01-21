public class StudyTask {
    public string? Name { get; set; }
    public double TargetHours { get; set; }
    public double SecondsSpent { get; set; }
    public DateTime? LastStarted { get; set; }
    
    // Logic for the UI
    public double Progress => (SecondsSpent / 3600) / TargetHours;
    public string TimeRemaining => $"{Math.Max(0, TargetHours - (SecondsSpent / 3600)):F1} hrs left";
}