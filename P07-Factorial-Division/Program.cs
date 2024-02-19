int intNumb1 = int.Parse(Console.ReadLine());
int intNumb2 = int.Parse(Console.ReadLine());

int factIntNumb1 = CalculateFactorial(intNumb1);

int factIntNumb2 = CalculateFactorial(intNumb2);

Console.WriteLine(factIntNumb1 / factIntNumb2);

static int CalculateFactorial(int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
