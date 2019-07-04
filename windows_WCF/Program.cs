using System;

namespace windows_WCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var wcf_validaEmail = new Wcf_Exemplo.Service1Client();

            Console.WriteLine($"Este email éh: {wcf_validaEmail.ValidarEmail("gabi@teste.com.br")}");
            Console.WriteLine($"Este email éh: {wcf_validaEmail.ValidarEmail("teste_teste.com.br")}");

            Console.ReadKey();

        }
    }
}
