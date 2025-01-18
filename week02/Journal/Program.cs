using System;

class Program
{
    static void Main(string[] args)
    {

        // I exceeded requirements by adding ability to save .csv file which can be opened with Excel.
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one if the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            Console.Write("What would you like to do?: ");
            int input = int.Parse(Console.ReadLine());



            if (input == 1)
            {

                PromptGenerator promptGenerator = new PromptGenerator();
                Entry entry = new Entry();

                string promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine(promptText);
                string entryText = Console.ReadLine();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = promptText;
                entry._entryText = entryText;

                journal.AddEntry(entry);

            }
            else if (input == 2)
            {
                journal.DisplayAll();
            }
            else if (input == 3)
            {
                Console.WriteLine("What is the filename? (ignore the file extension)");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (input == 4)
            {
                Console.WriteLine("What is the filename? (ignore the file extension)");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (input == 5)
            {
                Console.WriteLine("Goodbye, have a blessed day.");
                break;
            }

        }
    }
}