using MyApp;
class mainCLass
{ 
    public static void Main (String[] Args)
    {
        var calci = new Calculator();
        Console.WriteLine($"Sum is: {calci.add(1, 2)}");
    }
}
