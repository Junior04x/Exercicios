namespace Exercicio1
{
    internal class Program
    {
        static void Main()
        {
            int numero = InteracaoUsuario.PegarRespostaUsuario();
            bool ehPar = VerificarParOuImpar.VerificarVerdadeiroOuFalso(numero);
            InteracaoUsuario.RetornarSaida(ehPar);
        }
    }
}
