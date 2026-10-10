using System.Collections;

namespace HandsOn;

public class Playlist
{
    // https://www.google.com/search?client=firefox-b-d&q=in+C%23%2C+which+container+has+the+redundancy+detection
    
    // storage struct using dictory?
    private HashSet<Song> songsStorage = new();

    public Playlist(Song[] songs)
    {
        this.Add(songs);
    }

    /* Copy the songs from another @Playlist. */
    public Playlist(Playlist playlist)
    {
        /* Implement this. */
        this.DeepCopy(playlist.GetStorage());
    }

    public HashSet<Song> GetStorage()
    {
        this.songsStorage();
    }

    private void DeepCopy(Playlist playlist)
    {
        HashSet<Song> 
        foreach (var songItem in playlist.GetStorage())
        {
        }
    }
    
    
    // ---------------------- Add & Remove method
    
    /* Returns true on successful operations; false otherwise. */
    public bool Add(Song? song)
    {
        if (songs == null)
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
            return this.Add(song);
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
            // song is not not null
            return this.Remove(song);
        }
        return true;
    }
    
    // ---------------------- Add & Remove method
}