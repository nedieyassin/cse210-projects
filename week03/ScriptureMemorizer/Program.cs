// I exceeded requirements by making program work with a library of scriptures rather than a single one and choosing scriptures at random to present to the user.
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();


        List<Scripture> scriptures = [
new Scripture(new Reference("Hebrews", 11, 1), "Now faith is the substance of things hoped for, the evidence of things not seen."),
new Scripture(new Reference("1 Corinthians", 13, 4,7), "Love is patient, love is kind. It does not envy, it does not boast, it is not proud. It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. Love does not delight in evil but rejoices with the truth. It always protects, always trusts, always hopes, always perseveres."),
new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
new Scripture(new Reference("John", 14, 27), "Peace I leave with you; my peace I give you. I do not give to you as the world gives. Do not let your hearts be troubled and do not be afraid."),
new Scripture(new Reference("Proverbs", 3,5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
        ];

        Scripture scripture = scriptures[random.Next(0, scriptures.Count())];

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.Trim() == "" && !scripture.IsCompletelyHidden())
            {
                Console.Clear();
                scripture.HideRandomWords(3);
            }
            else if (scripture.IsCompletelyHidden())
            {
                break;
            }

            else if (input.Trim().ToLower() == "quit")
            {
                break;
            }






        }

    }
}