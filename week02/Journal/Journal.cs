public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter($"{filename}.csv"))
        {

            outputFile.WriteLine("Date,PromptText,EntryText");
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }

        }
    }


    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines($"{filename}.csv");

        List<Entry> entries = new List<Entry>();

        for (int i = 0; i < lines.Length; i++)
        {


            // Skip headers
            if (i == 0)
            {
                continue;
            }
            string[] parts = lines[i].Split(",");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = promptText;
            entry._entryText = entryText;

            entries.Add(entry);
        }

        _entries = entries;
    }

}