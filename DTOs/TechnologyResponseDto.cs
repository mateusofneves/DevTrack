namespace DevTrack.DTOs;

public class TechnologyResponseDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string LearningStatus { get; set; } = string.Empty;

    public DateTime StartedAt { get; set; }
}