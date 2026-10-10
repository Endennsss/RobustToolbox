using System;

namespace Robust.Shared.Audio.Sources;

// Orbitra-Edit: интерфейс доступен контенту для непрерывного голоса.
public interface IBufferedAudioSource : IAudioSource
{
    int SampleRate { get; set; }
    int GetNumberOfBuffersProcessed();
    void GetBuffersProcessed(Span<int> handles);
    void WriteBuffer(int handle, ReadOnlySpan<ushort> data);
    void WriteBuffer(int handle, ReadOnlySpan<float> data);
    void QueueBuffers(ReadOnlySpan<int> handles);
    void EmptyBuffers();
}
