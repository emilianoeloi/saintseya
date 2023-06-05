namespace CDZ;
public class Class1
{
    public static void Main(string[] args)
    {}
    public interface ICavaleiro
    {
        void Atacar();
        void Defender();
        void HabilidadeEspecial();
    }
    public class CavaleiroDePegasus : ICavaleiro
    {
        public void Atacar()
        {
            Console.WriteLine("meteoro de pegasus");
        }
        
        public void Defender()
        {
            Console.WriteLine("escudo de pégaso");
        }

        public void HabilidadeEspecial()
        {
            Console.WriteLine("cometa de pegasus");
        }
    }
    public class CavaleiroDeCisne : ICavaleiro
    {
        public void Atacar()
        {
            Console.WriteLine("pó de diamante");
        }

        public void Defender()
        {
            Console.WriteLine("escudo de gelo");
        }

        public void HabilidadeEspecial()
        {
            Console.WriteLine("execução aurora");
        }
    }
    public class CavaleiroDeDragão : ICavaleiro
    {
        public void Atacar()
        {
            Console.WriteLine("colera do dragão");
        }

        public void Defender()
        {
            Console.WriteLine("escudo do dragão");
        }

        public void HabilidadeEspecial()
        {
            Console.WriteLine("colera do cem dragões");
        }
    }
    public class CavaleiroDeAndromeda : ICavaleiro
    {
        public void Atacar()
        {
            Console.WriteLine("corrente de andromeda");
        }

        public void Defender()
        {
            Console.WriteLine("corrente circular");
        }

        public void HabilidadeEspecial()
        {
            Console.WriteLine("tempestade nebulosa");
        }
    }
    public class CavaleiroDeFenix : ICavaleiro
    {
        public void Atacar()
        {
            Console.WriteLine("ave fenix");
        }

        public void Defender()
        {
            Console.WriteLine("escudo da fenix");
        }

        public void HabilidadeEspecial()
        {
            Console.WriteLine("golpe de fantasma de fenix");
        }    
    }
    public class Batalha
    {
        ICavaleiro cavaleiro1 = new CavaleiroDePegasus();
        ICavaleiro cavaleiro2 = new CavaleiroDeFenix();
    }  

}
