namespace HandsOn;

public class BackSongs
{
    // https://www.google.com/search?client=firefox-b-d&q=in+C%23%2C+which+container+has+the+redundancy+detection
    private HashSet<Song> backSongs = new ();


    public BackSongs(Song[] songs)
    {
        this.Add(songs);
    }

    // /* Copy the songs from another @Playlist. */
    // public BackSongs(Playlist playlist)
    // {
    //     this.backSongs = this.GetStorage();
    // }


    // For obtain metadata information
    public HashSet<Song> GeetStorage()
    {
        //? this.backSongs = DeepCopy();
        return this.backSongs;
    }


    // return different hashset
    private HashSet<Song> DeepCopy()
    {
        HashSet<Song> copySongStorage = new();
        foreach (var song in this.backSongs)
        {
            var copySong = new Song(
                    song.GetIndentifier(),
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
        return  this.backSongs.Add(song);
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
        return this.backSongs.Remove(song);
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
        foreach (var song in this.backSongs)
        {
            Console.WriteLine(song.GetSongName());
        }
    }

    public void showHash()
    {
        foreach (var song in this.backSongs)
        {
            Console.WriteLine(song.GetHashCode());
        }
    }


    // return true is exist; else return false
    public bool CheckIndentifierExist(string Indentifier)
    {
        foreach (var song in this.backSongs)
        {
             if (song.GetIndentifier() == Indentifier)
             {
                 return true;
             }
        }
        return false;
    }
    // ---------------------- Add & Remove  method
}
