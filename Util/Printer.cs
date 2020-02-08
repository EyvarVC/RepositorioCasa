using static System.Console;
namespace IntentoCasa.Util
{
    public static class Printer
    {
        public static void DibujaLinea(int tamaño=10)
        {
            WriteLine("".PadLeft(tamaño,'='));
        }

        public static void Titulo(string titulo)
        {
            DibujaLinea(titulo.Length);
            WriteLine(titulo);
            DibujaLinea(titulo.Length);
        }
        
    }
}