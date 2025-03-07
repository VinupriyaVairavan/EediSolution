using System.Text.Json;

namespace API.Dtos;

public class ErrorDetailsDto
{
    public int StatusCode { get; set; }
    public string? Message { get; set; }
    public override string ToString() => JsonSerializer.Serialize(this);
}