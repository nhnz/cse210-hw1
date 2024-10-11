//class representing the reference

public class Reference
{
    private string _book;
    private string _chapterVerse;
    

    public Reference(string referenceText)
    {
        var parts = referenceText.Split(' ');
        _book = parts[0];
        _chapterVerse = parts[1];    
    }

    // Format: Book Chapter:Verse
    
    public override string ToString()
    {
        return $"{_book} {_chapterVerse}";
    }
}