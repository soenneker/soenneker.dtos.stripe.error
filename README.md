[![](https://img.shields.io/nuget/v/soenneker.dtos.stripe.error.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.stripe.error/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.stripe.error/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.stripe.error/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.stripe.error.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.stripe.error/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.stripe.error/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.stripe.error/actions/workflows/codeql.yml)

# Soenneker.Dtos.Stripe.Error

A `System.Text.Json` DTO for the inner Stripe error object, with strongly typed error type, error code, and decline code values.

## Install

```bash
dotnet add package Soenneker.Dtos.Stripe.Error
```

## Deserialize an error response

Stripe responses commonly place the error object under an `error` property. This DTO represents that inner object, not the outer envelope:

```csharp
using System.Text.Json;
using Soenneker.Dtos.Stripe.Error;

using JsonDocument document = JsonDocument.Parse(responseJson);
StripeErrorDto? error = document.RootElement
    .GetProperty("error")
    .Deserialize<StripeErrorDto>();

Console.WriteLine(error?.Message);
Console.WriteLine(error?.Code);
```

For an already-extracted error object:

```csharp
StripeErrorDto? error = JsonSerializer.Deserialize<StripeErrorDto>(errorJson);
```

## Fields

- `Type` identifies the broad error category.
- `Code` identifies the Stripe error condition.
- `DeclineCode` contains the issuer decline reason when one is supplied.
- `Param` identifies the request parameter associated with the failure.
- `DocumentationUrl` maps from `doc_url`.
- `Charge`, `PaymentIntent`, `SetupIntent`, and `PaymentMethod` carry related object identifiers when present.
- `Status` carries a status value from the JSON body when present; it does not infer or set the HTTP response status.

All fields are optional because Stripe error shapes vary by failure. Preserve the actual HTTP status and request identifier separately from this DTO, and do not expose raw decline details to end users without applying your application's messaging policy.
