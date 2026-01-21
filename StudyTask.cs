namespace StudyTracker;

public class StudyTask
{
    // 'required' ensures the name is never null
    public required string Name { get; set; } 
    public double TargetHours { get; set; }
    public double SecondsSpent { get; set; }

    // Calculates 0.0 to 1.0 for the progress bar
    public double Progress => TargetHours > 0 ? (SecondsSpent / 3600) / TargetHours : 0;

    // Formats the text display for the card
    public string TimeRemaining 
    {
        get 
        {
            double remaining = TargetHours - (SecondsSpent / 3600);
            return remaining > 0 ? $"{remaining:F1} hrs left" : "Goal Reached!";
        }
    }
}