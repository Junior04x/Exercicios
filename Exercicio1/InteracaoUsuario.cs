namespace Exercicio1
{
    public class InteracaoUsuario{
        public static int PegarRespostaUsuario()
        {
            Console.WriteLine("Digite um número");
            string entrada = Console.ReadLine();
            int numero = ConverterStringEmInteiro(entrada);
            return numero;
        }

        public static int ConverterStringEmInteiro(string numero)
        {
            return int.Parse(numero);
        }

        public static void RetornarSaida(bool ehPar)
        {
            if (ehPar)
            {
                Console.WriteLine("O número é Par");
            }
            else
            {
                Console.WriteLine("O número é Impar");
            }
        }
    }
}
