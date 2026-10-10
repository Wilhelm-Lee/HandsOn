using NAudio;
using NAudio.Wave;

namespace HandsOn;

public interface IPlayable
{
    void Play(Song? song)
    {
        if (song is null)
        {
            return;
        }
        
        using var audioFile = new AudioFileReader(song.GetAbsolutePath());
        using var player = new WasapiPlayerBuilder().Build();
        player.Init(audioFile);
        player.Play();
        while (player.PlaybackState == PlaybackState.Playing)
        {
            Thread.Sleep(500);
        }
    }
}

