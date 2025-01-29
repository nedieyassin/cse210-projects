public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {

        List<Word> words = new List<Word>();

        foreach (var word in text.Split(" "))
        {
            words.Add(new Word(word));
        }

        _words = words;
        _reference = reference;


    }


    public void HideRandomWords(int numberToHide)
    {

        Random random = new Random();


        if (numberToHide > _words.Count())
        {
            numberToHide = _words.Count();
        }

        var wordsToHide = _words.OrderBy(_ => random.Next())
                                .Where(word => !word.IsHidden())
                                .Take(numberToHide);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }



    }

    public string GetDisplayText()
    {
        string scriptureString = "";

        foreach (var word in _words)
        {
            scriptureString += $" {word.GetDisplayText()}";
        }

        return $"{_reference.GetDisplayText()} {scriptureString.Trim()}";
    }


    public bool IsCompletelyHidden()
    {


        bool isHidden = true;

        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                isHidden = false;
                break;
            }
        }

        return isHidden;
    }
}