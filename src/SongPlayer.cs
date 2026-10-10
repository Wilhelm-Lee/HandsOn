namespace HandsOn;


/*
 *  
 *
 *  public void Pause();
 *  public void Next();
 *  public void Previous();
 *  public void Offset(long time);
 *
 *
 *
 *
 *
 *
 */


public class SongPlayer : IPlayable
{
    private Playlist playlist;

    private PlayMode playMode = PlayMode.STOP_AFTER_THIS;
    // If in order play
    private int indexOfCurrentPlayingSong = 0;
    private bool isPlaying = false;
    private long offsetSong = 0;
    private string currentSong = "";


    public SongPlayer(Playlist playlist)
    {
        this.playlist = playlist;
    }
    
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
            isPlaying = true;
            Console.WriteLine($"~~Listening the song {song.GetSongName()} ~~");

            // 3min 
            return;
        }
       
        //throw new NotImplementedException();  // ?
    }

    // Todo Pause Song
    public void Pause()
    {
        isPlaying = false;
    }

    public void Next()
    {
        var index = playlist.GetSongList().IndexOf(currentSong);
        currentSong = playlist.GetSongList()[index + 1];
        //this.Play(song);
    }


    public void Previous()
    {
        var index = playlist.GetSongList().IndexOf(currentSong);
        currentSong = playlist.GetSongList()[index - 1];
        //this.Play(song);
    }


    public void Offset(long time)
    {

    }
}
