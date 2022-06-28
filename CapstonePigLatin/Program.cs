//Prompt user for a word

bool tryAgain = true;

while (tryAgain)
{
    Console.WriteLine("Please enter a word: ");
    string word = Console.ReadLine().ToLower();

    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    int spotOfFirstVowel = word.IndexOfAny(vowels);

    if (spotOfFirstVowel == 0)
    {
        Console.WriteLine(word + "way");
    }
    else
    {
        string newWord = word.Substring(spotOfFirstVowel, word.Length - spotOfFirstVowel) + word.Substring(0, spotOfFirstVowel) + "ay";

        Console.WriteLine(newWord); 
    }

    while (true)
    {
        Console.WriteLine("Would you like to go another round, buddy? y/n");
        string answer = Console.ReadLine();
        if (answer.ToLower().Trim() == "y")
        {
            break;
        }
        else if (answer.ToLower().Trim() == "n")
        {
            tryAgain = false;
            break;
        }
    }
}

