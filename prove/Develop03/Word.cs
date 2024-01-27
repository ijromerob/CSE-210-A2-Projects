using System.Net;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        int length = _text.Length;
        string newText ="";

        for(int c = 0; c < length; c++)
        {
            newText += "_";
        } 
        _text = newText;
        _isHidden = true;
        
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        bool status = _isHidden;
        return status;
    }
    public string GetDisplayText()
    {
        string text_word;
        text_word = _text;
        return text_word;
    }
}