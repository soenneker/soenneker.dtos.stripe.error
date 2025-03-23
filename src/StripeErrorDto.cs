using System.Text.Json.Serialization;

namespace Soenneker.Dtos.Stripe.Error;

/// <summary>
/// A strong type for Stripe's common error response
/// </summary>
public class StripeErrorDto
{
    /// <summary>
    /// Gets or sets the error message describing what went wrong.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the type of error returned by Stripe (e.g., "card_error", "api_error").
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the specific error code provided by Stripe, if available (e.g., "card_declined").
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
