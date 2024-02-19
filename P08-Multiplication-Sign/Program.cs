int numb1 = int.Parse(Console.ReadLine());
int numb2 = int.Parse(Console.ReadLine());
int numb3 = int.Parse(Console.ReadLine());

PrintResult(numb1, numb2, numb3);


static void PrintResult(int n1, int n2, int n3)
{
    if (n1 == 0 || n2 == 0 || n3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if (n1 > 0 && n2 > 0 && n3 > 0)
    {
        Console.WriteLine("positive");
    }
    else 
    {
        Console.WriteLine("negative");
    }
}
