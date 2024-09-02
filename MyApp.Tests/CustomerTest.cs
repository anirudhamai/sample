using MyApp;

namespace MyApp.Tests
{
    public class CustomerTest
    {
        [Test]
        public void AddTest()
        {
            Calculator c = new Calculator();
            int result= c.add(1,2);
            Console.WriteLine("Result is : "+ result.ToString());
            Assert.AreEqual(3, result);
        }
    }
}