// class representing the scripture

public class Scripture
{
    public Reference Reference {get; set;}
    public List<Word> Words {get; set;}

    public Scripture(string referenceText, string scriptureText)
    {
        Reference = new Reference(referenceText);
        Words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool HideRandomWord()
    {
        // Get words that are not hidden
        var hiddenWords = Words.Where(word => !word.IsHidden).ToList();
    

        //no more words to hide
        if (!hiddenWords.Any()) return false; 
        
        // Select a random word to hide
        Random random = new Random();
        var wordToHide = hiddenWords[random.Next(hiddenWords.Count)];
        
        // Hide the selected word
        wordToHide.Hide();
        return true;
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n {string.Join(" ", Words)}";
    }
}
