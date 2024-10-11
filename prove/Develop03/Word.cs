//class representing word in the scripture

public class Word
{
    public string Text{get; set;}
    public bool IsHidden{get; set;}

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        //Hide the word if it is marked
        return IsHidden ? "____" : Text;
    }
}