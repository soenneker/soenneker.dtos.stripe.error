[![](https://img.shields.io/nuget/v/soenneker.dtos.stripe.error.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.stripe.error/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.stripe.error/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.stripe.error/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.stripe.error.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.stripe.error/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.stripe.error/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.stripe.error/actions/workflows/codeql.yml)

# Soenneker.Dtos.Stripe.Error

A strong type for Stripe's common error response.

## Install

```bash
dotnet add package Soenneker.Dtos.Stripe.Error
```

## What you get

- `StripeErrorDto` — A strong type for Stripe's common error response.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `StripeErrorDto.Message` | Gets or sets the human-readable message describing the error. | Gets or sets the human-readable message describing the error. |
| `StripeErrorDto.Type` | Gets or sets the high-level type of the error (e.g., card_error, api_error). | Gets or sets the high-level type of the error (e.g., card_error, api_error). |
| `StripeErrorDto.Code` | Gets or sets the specific Stripe error code (e.g., card_declined, expired_card). | Gets or sets the specific Stripe error code (e.g., card_declined, expired_card). |
| `StripeErrorDto.DeclineCode` | Gets or sets the issuer-specific decline reason (e.g., insufficient_funds, do_not_honor). Only present if Code is card_declined. | Gets or sets the issuer-specific decline reason (e.g., insufficient_funds, do_not_honor). Only present if Code is card_declined. |
| `StripeErrorDto.Param` | Gets or sets the parameter related to the error, if applicable. | Gets or sets the parameter related to the error, if applicable. |
| `StripeErrorDto.DocumentationUrl` | Gets or sets the documentation URL for the error. | Gets or sets the documentation URL for the error. |
| `StripeErrorDto.Status` | Gets or sets the HTTP status code returned by the API, if known. | Gets or sets the HTTP status code returned by the API, if known. |
| `StripeErrorDto.Charge` | Gets or sets the charge ID associated with the error, if any. | Gets or sets the charge ID associated with the error, if any. |
| `StripeErrorDto.PaymentIntent` | Gets or sets the payment intent ID, if relevant to the error. | Gets or sets the payment intent ID, if relevant to the error. |
| `StripeErrorDto.SetupIntent` | Gets or sets the setup intent ID, if relevant to the error. | Gets or sets the setup intent ID, if relevant to the error. |
| `StripeErrorDto.PaymentMethod` | Gets or sets the payment method ID, if relevant to the error. | Gets or sets the payment method ID, if relevant to the error. |
