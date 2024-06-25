namespace Exercicio1
{
    public class VerificarParOuImpar{
        public static bool VerificarVerdadeiroOuFalso(int entrada)
        {
            int resto = entrada % 2;
            if (resto == 0){
                return true;
            }else{
                return false;
            }
        }
    }
}
