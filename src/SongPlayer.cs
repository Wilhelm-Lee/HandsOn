namespace HandsOn;

public class SongPlayer : IPlayable
{
    private Playlist? playlist = null;
    private PlayMode playMode = PlayMode.STOP_AFTER_THIS;
    private int indexOfCurrentPlayingSong = 0;
    private bool isPlaying = false;

    
    /* Use the following two instead. */       
    public void Play(Song? song)
    {
        if (song == null)
        {
            // Implement ? error
            Console.WriteLine("no song in songPlayer");
            return;
        }

        if (playlist.CheckSongExist(song.GetIndentifier()))
        {
            Console.WriteLine($"~~Listening the song {song.GetSongName()} ~~");

            // 3min 
            return;
        }
       
        //throw new NotImplementedException();  // ?
    }


    // Todo Pause Song
}
