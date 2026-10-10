namespace HandsOn;

public class Song
{
    private string absolute_path = "/";
    private string song_name = "";
    private long song_length = 0;
    
    /* Write a constructor for all of these three members. */

    public Song(string absolutePath, string song_name, long song_length)
    {
        this.absolute_path = absolutePath;
        this.song_name = song_name;
        this.song_length = song_length;
    }
    
    // Getter
    public string GetAbsolutePath()
    {
        return (string)this.absolute_path.Clone();
    }
    public string GetSongName()
    {
        return (string)this.song_name.Clone();
    } 
    public long GetSongLength()
    {
        return this.song_length;
    }

    // Setter
    public void SetAbsolutePath(string absolutePath)
    {
        this.absolute_path = (string)absolutePath.Clone();
    }
    public void SetSongName(string songName)
    {
        this.song_name = (string)songName.Clone();
    } 
    public void SetSongLength(long songLength)
    {
        this.song_length = songLength;
    }
 
    /* Direct-Reference-Modification safe Getters & Setters for all of these three members. */
}
