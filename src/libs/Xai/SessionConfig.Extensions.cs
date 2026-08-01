using System.Text.Json;

namespace Xai.Realtime;

public sealed partial class SessionConfig
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

    private static JsonElement JsonNull
    {
        get
        {
            using var document = JsonDocument.Parse("null");
            return document.RootElement.Clone();
        }
    }
}
