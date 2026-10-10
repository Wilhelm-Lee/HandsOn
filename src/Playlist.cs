namespace HandsOn;

using System.Collections;


public class Playlist
{
    
    // storage struct using dictory?
    private List<string> songList = new();
    private BackSongs backSongs;

    //private Dictionary<int, string> playList = new();
    // How to deal with list method record order


    public Playlist(string[] indentifiers, BackSongs backSongs)
    {
        this.Add(indentifiers);
        this.backSongs = backSongs;
    }

    /* Copy the songs from another @Playlist. */
    public Playlist(Playlist playlist, BackSongs backSongs)
    {
        this.backSongs = backSongs;
        this.songList = playlist.GetSongList();
    }


    // + DeepCopy
    public List<string> GetSongList()
    {
        List<string> copyList = new();
        foreach (var indentifier in this.songList)
        {
            copyList.Add((string)indentifier.Clone());
        }
        return copyList;
    }

    
     
    // ---------------------- Add & Remove & Show method
    
    /* Returns true on successful operations; false otherwise. */
    public bool Add(string indentifier)
    {
        if (indentifier == null || indentifier == "")
        {
            return false;
        }
        if ( !backSongs.CheckIndentifierExist(indentifier) || songList.Contains(indentifier) )
        {
            return false;
        }
        // If have a repeat key in dict no throw error , return false in silence
        songList.Add(indentifier);
        return  true;
    }

    /* Returns true on successful operations; false otherwise. */
    public bool Add(string[] indentifiers)
    {
        if (indentifiers == null)
        {
            return false;
        }

        foreach (var indentifier in indentifiers)
        {
            if (!this.Add(indentifier))
            {
                Console.WriteLine($"Insert Failed after {indentifier}");
                return false;
            }
        }
        return true;
    }

    /* Returns true on successful operations; false otherwise. */
    public bool Remove(string indentifier)
    {
        if (indentifier == null || indentifier == "")
        {
            return false;
        }
        if ( !backSongs.CheckIndentifierExist(indentifier) || !songList.Contains(indentifier) )
        {
            return false;
        }
        // If return true dele successful, return false key not exist
        songList.Remove(indentifier);
        return true;
    }
    
    /* Returns true on successful operations; false otherwise. */
    public bool Remove(string[] indentifiers)
    {
        if (indentifiers == null)
        {
            return false;
        }
        
        foreach (var indentifier in indentifiers)
        {
            if (!this.Remove(indentifier))
            {
                Console.WriteLine($"Remove Failed after {indentifier}");
                return false;
            }
        }
        return true;
    }

    public void show()
    {
        foreach (var indentifier in this.songList)
        {
            Console.WriteLine(indentifier);
        }
    }

    // exist return true, else return false
    public bool CheckSongExist(String indentifier)
    {
        return songList.Contains(indentifier);
    }

    // ---------------------- Add & Remove & Show method
}
