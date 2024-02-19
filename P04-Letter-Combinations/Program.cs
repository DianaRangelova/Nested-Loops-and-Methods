char startLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excludedLetter = char.Parse(Console.ReadLine());

int countOfLetters = 0;


for (char l1 = startLetter; l1 <= endLetter; l1++)
{
    for (char l2 = startLetter; l2 <= endLetter; l2++)
    {
        for (char l3 = startLetter; l3 <= endLetter; l3++)
        {
            if (l1 != excludedLetter && l2 != excludedLetter && l3 != excludedLetter)
            {
                Console.Write($"{l1}{l2}{l3} ");
                countOfLetters++;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine(countOfLetters);
