﻿using System.Text.Json.Serialization;

namespace ChatGptNet.Models;

/// <summary>
/// Contains information about the error occurred while invoking the service.
/// </summary>
/// <remarks>
/// Refer to https://platform.openai.com/docs/guides/error-codes/api-errors for more information.
/// </remarks>
public class ChatGptError
{
    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    /// <remarks>
    /// Refer to https://platform.openai.com/docs/guides/error-codes/api-errors for more information.
    /// </remarks>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the error type.
    /// </summary>
    /// <remarks>
    /// Refer to https://platform.openai.com/docs/guides/error-codes/api-errors for more information.
    /// </remarks>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the parameter that caused the error.
    /// </summary>
    /// <remarks>
    /// Refer to https://platform.openai.com/docs/guides/error-codes/api-errors for more information.
    /// </remarks>
    [JsonPropertyName("param")]
    public string? Parameter { get; set; }

    /// <summary>
    /// Gets or sets the error code.
    /// </summary>
    /// <remarks>
    /// Refer to https://platform.openai.com/docs/guides/error-codes/api-errors for more information.
    /// </remarks>
    public string? Code { get; set; }
}