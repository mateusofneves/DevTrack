namespace DevTrack.DTOs;

public class TechnologyCreateDto
{
    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string LearningStatus { get; set; } = "Learning";

    public int UserId { get; set; }
}