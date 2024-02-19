string text = Console.ReadLine();

int countVowels = GetVowelsCount(text);
Console.WriteLine(countVowels);

static int GetVowelsCount(string text)
{
    int count = 0;

    for (int c = 0; c <= text.Length - 1; c++)
    {
        char vowel = text[c];

        if  (vowel == 'A' || vowel == 'a'
            || vowel == 'E' || vowel == 'e'
            || vowel == 'I' || vowel == 'i'
            || vowel == 'O' || vowel == 'o'
            || vowel == 'U' || vowel == 'u')
        {
            count++;
        }
    }
    return count;
}
