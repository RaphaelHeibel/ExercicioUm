
namespace ExercicioUm
{
    public class Program
    {
        static void Main(string[] args)
        {

            double nlampadas;
            double tamanho;
            comodo comodo = new comodo();

            Console.WriteLine("\n\nDigite o tipo de comodo (0 ate 4):");
            comodo.tipo = Convert.ToInt16(Console.ReadLine());

            while (comodo.tipo != -1)
            {
                Console.WriteLine("\n\nDigite a largura do comodo:");
                comodo.larg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n\nDigite o comprimento do comodo:");
                comodo.comp = Convert.ToDouble(Console.ReadLine()); 

                tamanho = Program.CalculaArea(comodo.larg, comodo.comp);
                nlampadas = Program.Lampada(comodo.tipo, tamanho);
                Console.WriteLine($"\n\n Pela metragem de seu comodo voce ira precisar de {Math.Ceiling(nlampadas)} lampadas");
                Console.WriteLine("\n\nDigite o tipo de comodo (0 ate 4):");
                comodo.tipo = Convert.ToInt16(Console.ReadLine());
            }           
        }

        struct comodo
        {
            public int tipo;
            public double larg, comp;
        }

        public static double CalculaArea(double largura, double comprimento)
        {
            return largura * comprimento;
        }

        public static double Lampada(int tipo, double metragem)
        {
            double quantidade;
            int potencia;
            switch (tipo)
            {
                case 0:
                    potencia = 12;
                    break;
                case 1:
                    potencia = 15;
                    break;
                case 2:
                    potencia = 18;
                    break;
                case 3:
                    potencia = 20;
                    break;
                case 4:
                    potencia = 22;
                    break;
                default:
                    potencia = 0;  // Tipo inválido
                    break;
            }
            quantidade = (metragem * potencia) / 60;
            return quantidade;
        }
    }
}


