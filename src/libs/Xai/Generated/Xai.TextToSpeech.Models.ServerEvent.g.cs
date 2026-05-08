#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Xai.TextToSpeech
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Xai.TextToSpeech.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A base64-encoded audio chunk in the codec specified at connection time.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.TextToSpeech.AudioDeltaEvent? AudioDelta { get; init; }
#else
        public global::Xai.TextToSpeech.AudioDeltaEvent? AudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDelta))]
#endif
        public bool IsAudioDelta => AudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.TextToSpeech.AudioDeltaEvent? value)
        {
            value = AudioDelta;
            return IsAudioDelta;
        }

        /// <summary>
        /// All audio for the current utterance has been sent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.TextToSpeech.AudioDoneEvent? AudioDone { get; init; }
#else
        public global::Xai.TextToSpeech.AudioDoneEvent? AudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDone))]
#endif
        public bool IsAudioDone => AudioDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.TextToSpeech.AudioDoneEvent? value)
        {
            value = AudioDone;
            return IsAudioDone;
        }

        /// <summary>
        /// An error occurred.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Xai.TextToSpeech.ErrorEvent? Error { get; init; }
#else
        public global::Xai.TextToSpeech.ErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Xai.TextToSpeech.ErrorEvent? value)
        {
            value = Error;
            return IsError;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.TextToSpeech.AudioDeltaEvent value) => new ServerEvent((global::Xai.TextToSpeech.AudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.TextToSpeech.AudioDeltaEvent?(ServerEvent @this) => @this.AudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.TextToSpeech.AudioDeltaEvent? value)
        {
            AudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.TextToSpeech.AudioDoneEvent value) => new ServerEvent((global::Xai.TextToSpeech.AudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.TextToSpeech.AudioDoneEvent?(ServerEvent @this) => @this.AudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.TextToSpeech.AudioDoneEvent? value)
        {
            AudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Xai.TextToSpeech.ErrorEvent value) => new ServerEvent((global::Xai.TextToSpeech.ErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Xai.TextToSpeech.ErrorEvent?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Xai.TextToSpeech.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::Xai.TextToSpeech.ServerEventDiscriminatorType? type,
            global::Xai.TextToSpeech.AudioDeltaEvent? audioDelta,
            global::Xai.TextToSpeech.AudioDoneEvent? audioDone,
            global::Xai.TextToSpeech.ErrorEvent? error
            )
        {
            Type = type;

            AudioDelta = audioDelta;
            AudioDone = audioDone;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            AudioDone as object ??
            AudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AudioDelta?.ToString() ??
            AudioDone?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioDelta && !IsAudioDone && !IsError || !IsAudioDelta && IsAudioDone && !IsError || !IsAudioDelta && !IsAudioDone && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Xai.TextToSpeech.AudioDeltaEvent, TResult>? audioDelta = null,
            global::System.Func<global::Xai.TextToSpeech.AudioDoneEvent, TResult>? audioDone = null,
            global::System.Func<global::Xai.TextToSpeech.ErrorEvent, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta && audioDelta != null)
            {
                return audioDelta(AudioDelta!);
            }
            else if (IsAudioDone && audioDone != null)
            {
                return audioDone(AudioDone!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Xai.TextToSpeech.AudioDeltaEvent>? audioDelta = null,

            global::System.Action<global::Xai.TextToSpeech.AudioDoneEvent>? audioDone = null,

            global::System.Action<global::Xai.TextToSpeech.ErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta)
            {
                audioDelta?.Invoke(AudioDelta!);
            }
            else if (IsAudioDone)
            {
                audioDone?.Invoke(AudioDone!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Xai.TextToSpeech.AudioDeltaEvent>? audioDelta = null,
            global::System.Action<global::Xai.TextToSpeech.AudioDoneEvent>? audioDone = null,
            global::System.Action<global::Xai.TextToSpeech.ErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta)
            {
                audioDelta?.Invoke(AudioDelta!);
            }
            else if (IsAudioDone)
            {
                audioDone?.Invoke(AudioDone!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioDelta,
                typeof(global::Xai.TextToSpeech.AudioDeltaEvent),
                AudioDone,
                typeof(global::Xai.TextToSpeech.AudioDoneEvent),
                Error,
                typeof(global::Xai.TextToSpeech.ErrorEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Xai.TextToSpeech.AudioDeltaEvent?>.Default.Equals(AudioDelta, other.AudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.TextToSpeech.AudioDoneEvent?>.Default.Equals(AudioDone, other.AudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Xai.TextToSpeech.ErrorEvent?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
