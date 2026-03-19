#nullable enable

namespace Xai
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Generate speech<br/>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Xai.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(

            global::Xai.CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate speech<br/>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="model">
        /// The model to use for text-to-speech.
        /// </param>
        /// <param name="input">
        /// The text to generate audio for.
        /// </param>
        /// <param name="voice">
        /// The voice to use for synthesis.
        /// </param>
        /// <param name="responseFormat">
        /// The audio format of the output.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio (0.25-4.0).<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            string model,
            string input,
            global::Xai.CreateSpeechRequestVoice voice,
            global::Xai.CreateSpeechRequestResponseFormat? responseFormat = default,
            double? speed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}