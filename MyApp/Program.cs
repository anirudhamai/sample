class Calculator
{
    public int add(int a, int b)
    {
        return a + b;
    }
}

class mainCLass
{ 
    public static void Main (String[] Args)
    {
        var calci = new Calculator();
        Console.WriteLine($"Sum: {calci.add(1, 2)}");
    }
}
