public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splittedText = text.Split(" ");
        
        foreach(string w in splittedText)
        {
            _words.Add(new Word(text = w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
        {
            text += w.GetDisplayText() + " ";
        }
        return text;
    }
    public bool IsCompletelyHidden()
    {
        bool CompletelyHidden =true;
        foreach (Word w in _words)
        {
            if ( w.IsHidden() == false)
            {
                CompletelyHidden = false;
            }
        }
        return CompletelyHidden;
    }
    public int WordCount()
    {
        int listCount = _words.Count;
        return listCount;
    }
}