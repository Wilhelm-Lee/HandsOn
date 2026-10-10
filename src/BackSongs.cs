namespace HandsOn;

/*
 *  Field
 *  private Dictionary<string, Song> backSongs = new ();
 *  
 *  Function
 *  public bool Add(Song? song);
 *  public bool Add(Song[]? songs);
 *  public bool Remove(Song? song);
 *  public bool Remove(Song[]? songs)
 *  public bool CheckIndentifierExist(string Indentifier);
 */

public class BackSongs
{


    // https://www.google.com/search?client=firefox-b-d&q=in+C%23%2C+which+container+has+the+redundancy+detection
    private Dictionary<string, Song> backSongs = new ();




    // Constructot
    public BackSongs(Song song)
    {
        this.Add(song);
    }
    public BackSongs(Song[] songs)
    {
        // Implemented Method
        this.Add(songs);
    }
    // Constructot




    // For obtain metadata information
    public Dictionary<string, Song> GeetStorage()
    {
        //? this.backSongs = DeepCopy();
        return this.backSongs;
    }


    // return different Dictionary
    // future need backup?
    private Dictionary<string, Song> DeepCopy()
    {
        Dictionary<string, Song> copySongStorage = new();
        foreach (var song in this.backSongs)
        {
            var copySong = new Song(
                    song.Value.GetIndentifier(),
                    song.Value.GetAbsolutePath(),
                    song.Value.GetSongName(),
                    song.Value.GetSongLength()
                    );

            copySongStorage.Add(song.Key, copySong);
        }
        return copySongStorage;
    }



    // public bool Add(Song? song);
    // public bool Add(Song[]? songs);
    // public bool Remove(Song? song);
    // public bool Remove(Song[]? songs)
    // public bool CheckIndentifierExist(string Indentifier);

    // ----------------------
    

    /* Returns true on successful operations; false otherwise. */
    public bool Add(Song? song)
    {
        if (song == null)
        {
            return false;
        }
        // If have a repeat key in dict no throw error , return false in silence
        return  this.backSongs.TryAdd(song.GetIndentifier(), song);
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
                // Interupt once fail
                // repeat insert problem is ban
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
        return this.backSongs.Remove(song.GetIndentifier());
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


    // return true is exist; else return false
    public bool CheckIndentifierExist(string Indentifier)
    {
        return this.backSongs.ContainsKey(Indentifier);
    }


    // Test method

    public void show()
    {
        foreach (var item in this.backSongs)
        {
            Console.WriteLine(item.Value.GetSongName());
        }
    }

    public void showHash()
    {
        foreach (var item in this.backSongs)
        {
            Console.WriteLine(item.Value.GetHashCode());
        }
    }

}
