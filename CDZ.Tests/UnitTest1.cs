namespace CDZ.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SimularBatalha_Test()
    {
        var cavaleiro1 = new Class1.CavaleiroDePegasus();
        var cavaleiro2 = new Class1.CavaleiroDeFenix();

        Batalha.SimularBatalha(cavaleiro1, cavaleiro2);
    }
}
    public class Batalha
    {
        public static void SimularBatalha(Class1.ICavaleiro cavaleiro1, Class1.ICavaleiro cavaleiro2)
        {
            Console.WriteLine($"A batalha começou {cavaleiro1.GetType().Name} {cavaleiro2.GetType().Name}");

            Console.WriteLine($"{cavaleiro1.GetType().Name} está atacando");
            cavaleiro1.Atacar();

            Console.WriteLine($"{cavaleiro2.GetType().Name} está defendendo");
            cavaleiro2.Defender();

            Console.WriteLine($"{cavaleiro2.GetType().Name} está atacando");
            cavaleiro2.Atacar();

            Console.WriteLine($"{cavaleiro1.GetType().Name} está defendendo");
            cavaleiro1.Defender();

            Console.WriteLine($"{cavaleiro1.GetType().Name} usou o golpe especial");
            cavaleiro1.HabilidadeEspecial();

            Console.WriteLine($"{cavaleiro2.GetType().Name} usou o golpe especial");
            cavaleiro2.HabilidadeEspecial();

            Console.WriteLine("Batalha concluída");
        }
    }
