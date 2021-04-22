using System;

namespace Loja_Itens_Magicos
{
    class Program
    {
        static void Main(string[] args)
        {

            int alternativa = 0;
            Loja loja = new Loja();

            do
            {
                Console.WriteLine("1 - Irei comprar");
                Console.WriteLine("0 - Fechar \n");
                alternativa = Convert.ToInt16(Console.ReadLine());

                if (alternativa == 1)
                {
                   Personagem Heroi = new Personagem();
                    Heroi.Escolhaumaopcao(loja, Heroi);

                }              
                else if (alternativa != 0)
                {
                    Console.WriteLine("Entrada não permitida");
                }
            } while (alternativa != 0);
            
        }

        

    }
}
