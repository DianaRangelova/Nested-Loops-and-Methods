int n = int.Parse(Console.ReadLine());

for (int numb1 = 1; numb1 <= 9; numb1++)
{
    for (int numb2 = 0; numb2 <= 9; numb2++)
    {
        for (int numb3 = 0; numb3 <= 9; numb3++)
        {
            if (numb1 * numb2 * numb3 == n)
            {
                Console.Write($"{numb1}{numb2}{numb3} ");
            }
        }
    }
}
