
namespace RepasoPersona.Core
{
    public class Cuenta
    {
        private static int _contador = 0;
        public int Cbu {get; private set;}
        public Cuenta()
        {
            Cbu = ++_contador;

        }

    }
}