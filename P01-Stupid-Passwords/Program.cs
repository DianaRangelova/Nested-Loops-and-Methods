int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i += 2)
{
    // i will always be an even number 
    // For each one iteration
    for (int j = 1; j <= n; j += 2)
    {
        // j will always be an odd number
        // For each one iteration of j (for each combination i-j)
        int product = i * j;

        Console.Write($"{i}{j}{product} ");
    }
}
