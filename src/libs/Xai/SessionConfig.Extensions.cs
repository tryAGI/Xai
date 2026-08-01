using System.Text.Json;
using System.Text.Json.Serialization;

namespace Xai.Realtime;

public sealed partial class SessionConfig : IJsonOnSerializing
{
    private const string TurnDetectionPropertyName = "turn_detection";

    /// <summary>
    /// Disables server turn detection by serializing <c>turn_detection</c> as an explicit JSON null.
    /// </summary>
    /// <returns>This session configuration, for fluent configuration.</returns>
    public SessionConfig UseManualTurnDetection()
    {
        TurnDetection = null;
        AdditionalProperties[TurnDetectionPropertyName] = JsonNull;

        return this;
    }

    /// <summary>
    /// Enables server turn detection with the supplied configuration.
    /// </summary>
    /// <param name="turnDetection">The server turn detection configuration.</param>
    /// <returns>This session configuration, for fluent configuration.</returns>
    public SessionConfig UseServerTurnDetection(TurnDetection turnDetection)
    {
        ArgumentNullException.ThrowIfNull(turnDetection);

        AdditionalProperties.Remove(TurnDetectionPropertyName);
        TurnDetection = turnDetection;

        return this;
    }

    /// <summary>
    /// Returns validation errors for documented xAI Realtime session limits.
    /// </summary>
    /// <returns>An empty list when the configuration is valid.</returns>
    public IReadOnlyList<string> GetValidationErrors()
    {
        var errors = new List<string>();

        if (TurnDetection is { } turnDetection)
        {
            ValidateFiniteRange(
                turnDetection.Threshold,
                minimum: 0.1,
                maximum: 0.9,
                "turn_detection.threshold",
                errors);
            ValidateIntegerRange(
                turnDetection.SilenceDurationMs,
                minimum: 0,
                maximum: 10_000,
                "turn_detection.silence_duration_ms",
                errors);
            ValidateIntegerRange(
                turnDetection.PrefixPaddingMs,
                minimum: 0,
                maximum: 10_000,
                "turn_detection.prefix_padding_ms",
                errors);

            if (turnDetection.IdleTimeoutMs is < 0)
            {
                errors.Add("turn_detection.idle_timeout_ms must be greater than or equal to 0.");
            }
        }

        if (Audio?.Input is { } input)
        {
            if (input.Speed is not null)
            {
                errors.Add("audio.input.speed is not supported; configure speed on audio.output.");
            }

            ValidateTranscription(input.Transcription, errors);
        }

        if (Audio?.Output is { } output)
        {
            if (output.Transcription is not null)
            {
                errors.Add("audio.output.transcription is not supported; configure transcription on audio.input.");
            }

            ValidateFiniteRange(
                output.Speed,
                minimum: 0.7,
                maximum: 1.5,
                "audio.output.speed",
                errors);
        }

        return errors;
    }

    /// <summary>
    /// Validates documented xAI Realtime session limits.
    /// </summary>
    /// <exception cref="ArgumentException">The session contains one or more invalid values.</exception>
    public void Validate()
    {
        var errors = GetValidationErrors();
        if (errors.Count == 0)
        {
            return;
        }

        throw new ArgumentException(
            $"Invalid xAI Realtime session configuration: {string.Join(" ", errors)}",
            "session");
    }

    void IJsonOnSerializing.OnSerializing()
    {
        Validate();
    }

    private static JsonElement JsonNull
    {
        get
        {
            using var document = JsonDocument.Parse("null");
            return document.RootElement.Clone();
        }
    }

    private static void ValidateTranscription(
        AudioTranscriptionConfig? transcription,
        List<string> errors)
    {
        if (transcription?.Keyterms is not { } keyterms)
        {
            return;
        }

        if (keyterms.Count > 100)
        {
            errors.Add("audio.input.transcription.keyterms cannot contain more than 100 terms.");
        }

        for (var index = 0; index < keyterms.Count; index++)
        {
            var keyterm = keyterms[index];
            if (keyterm is null)
            {
                errors.Add($"audio.input.transcription.keyterms[{index}] cannot be null.");
            }
            else if (keyterm.Length > 50)
            {
                errors.Add($"audio.input.transcription.keyterms[{index}] cannot exceed 50 characters.");
            }
        }
    }

    private static void ValidateFiniteRange(
        double? value,
        double minimum,
        double maximum,
        string propertyName,
        List<string> errors)
    {
        if (value is { } actualValue &&
            (!double.IsFinite(actualValue) || actualValue < minimum || actualValue > maximum))
        {
            errors.Add($"{propertyName} must be between {minimum} and {maximum}, inclusive.");
        }
    }

    private static void ValidateIntegerRange(
        int? value,
        int minimum,
        int maximum,
        string propertyName,
        List<string> errors)
    {
        if (value is { } actualValue && (actualValue < minimum || actualValue > maximum))
        {
            errors.Add($"{propertyName} must be between {minimum} and {maximum}, inclusive.");
        }
    }
}
