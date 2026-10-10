namespace HandsOn;

using System.Collections;


/*
 *
 *  Field
 *  private List<string> songList
 *
 *  Function
 *
 *  public bool Add(string indentifier);
 *  public bool Add(string[] indentifiers);
 *  public bool Remove(string indentifier);
 *  public bool Remove(string[] indentifiers);
 *  public bool CheckSongExist(String indentifier);
 *
 */



public class Playlist
{
    
    private List<string> songList = new();

    // How to reference backSongs ?  Instead of load
    private BackSongs backSongs;


    // indentifier in playlist, but backSongs remove, Todo handle it --- need retrun resourse not found and remove it from list



    // Constructor
    public Playlist(string[] indentifiers, BackSongs backSongs)
    {
        this.backSongs = backSongs;
        this.Add(indentifiers);
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

    
    // public bool Add(string indentifier);
    // public bool Add(string[] indentifiers);
    // public bool Remove(string indentifier);
    // public bool Remove(string[] indentifiers);
    // public void show();
    // public bool CheckSongExist(String indentifier);
     
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
        // remove not need resource in backend
        //if ( !backSongs.CheckIndentifierExist(indentifier) || !songList.Contains(indentifier) )
        // if ( !songList.Contains(indentifier) )
        // {
        //     return false;
        // }

        // If return true dele successful, return false  not exist in list
        return songList.Remove(indentifier);
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
            // class method
            if (!this.Remove(indentifier))
            {
                Console.WriteLine($"Remove Failed after {indentifier}");
                return false;
            }
        }
        return true;
    }


    // exist return true, else return false
    public bool CheckSongExist(String indentifier)
    {
        return songList.Contains(indentifier);
    }

    // Test
    public void show()
    {
        foreach (var indentifier in this.songList)
        {
            Console.WriteLine(indentifier);
        }
    }

}
