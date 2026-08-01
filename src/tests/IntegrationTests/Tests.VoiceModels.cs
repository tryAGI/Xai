using Xai.Realtime;

namespace Xai.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void VoiceModels_HaveExpectedWireValues()
    {
        VoiceModel.GrokVoiceLatest.ToValueString().Should().Be("grok-voice-latest");
        VoiceModel.GrokVoiceThinkFast20.ToValueString().Should().Be("grok-voice-think-fast-2.0");
        VoiceModel.GrokVoiceThinkFast10.ToValueString().Should().Be("grok-voice-think-fast-1.0");
        VoiceReasoningEffort.High.ToValueString().Should().Be("high");
        VoiceReasoningEffort.None.ToValueString().Should().Be("none");
    }
}
