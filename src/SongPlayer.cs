namespace HandsOn;

public class SongPlayer : IPlayable
{
    private Playlist playlist = null;
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
            // return
            return;
        }

       
        throw new NotImplementedException();  // ?
    }
}

//public void Play(string path)
//{
    ///* Implement this. */
    //foreach (var song in  this.playlist )
    //{
        //paths  =  song.GetAbsolutePath()
        //Console.WriteLine("play the song" + $"{path}");
    //}
    //throw new NotImplementedException();
//}

//public void Play(string[]? path)
//{
    ///* Implement this. */
        //
    //throw new NotImplementedException();
//}
