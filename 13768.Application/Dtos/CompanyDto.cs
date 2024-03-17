namespace _13768.Application.Dtos;

/// <summary>
/// Data transfer object for the company entity.
/// </summary>
public class CompanyDto
{
    /// <summary>
    /// Defines the name of the company dto.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Defines the website property of the company dto.
    /// </summary>
    public string? Website { get; set; }
}
