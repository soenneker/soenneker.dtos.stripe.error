using Soenneker.Stripe.Enums.DeclineCodes;
using Soenneker.Stripe.Enums.ErrorCodes;
using System.Text.Json.Serialization;
using Soenneker.Stripe.Enums.ErrorTypes;

namespace Soenneker.Dtos.Stripe.Error;

/// <summary>
/// A strong type for Stripe's common error response
/// </summary>
/// <summary>
/// A structured representation of a Stripe error response, using strongly-typed enums for reliable handling.
/// </summary>
public sealed class StripeErrorDto
{
    /// <summary>
    /// Gets or sets the human-readable message describing the error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the high-level type of the error (e.g., card_error, api_error).
    /// </summary>
    [JsonPropertyName("type")]
    public StripeErrorType? Type { get; set; }

    /// <summary>
    /// Gets or sets the specific Stripe error code (e.g., card_declined, expired_card).
    /// </summary>
    [JsonPropertyName("code")]
    public StripeErrorCode? Code { get; set; }

    /// <summary>
    /// Gets or sets the issuer-specific decline reason (e.g., insufficient_funds, do_not_honor). Only present if Code is card_declined.
    /// </summary>
    [JsonPropertyName("decline_code")]
    public StripeDeclineCode? DeclineCode { get; set; }

    /// <summary>
    /// Gets or sets the parameter related to the error, if applicable.
    /// </summary>
    [JsonPropertyName("param")]
    public string? Param { get; set; }

    /// <summary>
    /// Gets or sets the documentation URL for the error.
    /// </summary>
    [JsonPropertyName("doc_url")]
    public string? DocumentationUrl { get; set; }

    /// <summary>
    /// Gets or sets the HTTP status code returned by the API, if known.
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Gets or sets the charge ID associated with the error, if any.
    /// </summary>
    [JsonPropertyName("charge")]
    public string? Charge { get; set; }

    /// <summary>
    /// Gets or sets the payment intent ID, if relevant to the error.
    /// </summary>
    [JsonPropertyName("payment_intent")]
    public string? PaymentIntent { get; set; }

    /// <summary>
    /// Gets or sets the setup intent ID, if relevant to the error.
    /// </summary>
    [JsonPropertyName("setup_intent")]
    public string? SetupIntent { get; set; }

    /// <summary>
    /// Gets or sets the payment method ID, if relevant to the error.
    /// </summary>
    [JsonPropertyName("payment_method")]
    public string? PaymentMethod { get; set; }
}