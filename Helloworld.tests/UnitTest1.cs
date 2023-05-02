namespace Helloworld.tests;
using Helloworld;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string retorno = Program.GetGreeting();
        Assert.AreEqual("Ola, mundo!", retorno);

    }
}