namespace HandsOn;

using System.Collections;


public class Playlist
{
    // https://www.google.com/search?client=firefox-b-d&q=in+C%23%2C+which+container+has+the+redundancy+detection
    
    // storage struct using dictory?
    private HashSet<Song> songsStorage = new ();

    //private Dictionary<int, string> playList = new();
    // How to deal with list method record order


    public Playlist(Song[] songs)
    {
        this.Add(songs);
    }

    /* Copy the songs from another @Playlist. */
    public Playlist(Playlist playlist)
    {
        this.songsStorage = this.GetStorage();
    }


    public HashSet<Song> GetStorage()
    {
        this.songsStorage = DeepCopy();
        return this.songsStorage;
    }


    private HashSet<Song> DeepCopy()
    {
        HashSet<Song> copySongStorage = new();
        foreach (var song in this.songsStorage)
        {
            var copySong = new Song(
                    song.GetAbsolutePath(),
                    song.GetSongName(),
                    song.GetSongLength()
                    );

            copySongStorage.Add(copySong);
        }
        return copySongStorage;
    }
    
     
    // ---------------------- Add & Remove  method
    
    /* Returns true on successful operations; false otherwise. */
    public bool Add(Song? song)
    {
        if (song == null)
        {
            return false;
        }
        // If have a repeat key in dict no throw error , return false in silence
        return  this.songsStorage.Add(song);
    }

    /* Returns true on successful operations; false otherwise. */
    public bool Add(Song[]? songs)
    {
        if (songs == null)
        {
            return false;
        }

        foreach (var song in songs)
        {
            if (!this.Add(song))
            {
                Console.WriteLine($"Insert Failed after {song.GetSongName}");
                return false;
            }
        }
        return true;
    }

    /* Returns true on successful operations; false otherwise. */
    public bool Remove(Song? song)
    {
        if (song == null)
        {
            return false;
        }
        // If return true dele successful, return false key not exist
        return this.songsStorage.Remove(song);
    }
    
    /* Returns true on successful operations; false otherwise. */
    public bool Remove(Song[]? songs)
    {
        if (songs == null)
        {
            return false;
        }
        
        foreach (var song in songs)
        {
            if (!this.Remove(song))
            {
                Console.WriteLine($"Remove Failed after {song.GetSongName}");
                return false;
            }
        }
        return true;
    }

    public void show()
    {
        foreach (var song in this.songsStorage)
        {
            Console.WriteLine(song.GetSongName());
        }
    }
    
    // ---------------------- Add & Remove  method
}
