namespace TimeTracker.Models;

public class TimeEntry
{
    public string TaskName { get; set; } = string.Empty;
    public string PhaseNumber { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public TimeSpan Duration => EndTime - StartTime;
}