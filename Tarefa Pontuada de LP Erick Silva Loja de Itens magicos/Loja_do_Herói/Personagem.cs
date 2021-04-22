using System;
using System.Collections.Generic;


namespace Loja_Itens_Magicos
{
    public class Personagem
    {
        public string Nome;
        public Int32 Prata;
        public List<Item> Inventario = new List<Item>();

        public Personagem()
        {
           Console.Clear();
           Console.WriteLine("Herói:Mercante deixe-me apresentar, meu nome é: ");
           Console.WriteLine("Herói:Estou em uma jornada e preciso de novos itens. Estou em uma jornada para salvar a Mercia "); 
           this.Nome = Console.ReadLine();
           Console.WriteLine("Vendedor:Tens Prata contigo Nobre Herói ?");
           this.Prata = int.Parse(Console.ReadLine());
        }



        public void Escolhaumaopcao(Loja loja, Personagem Heroi)
        {
            Console.Clear();
            int alternativa;
            
            do
            {
                Console.WriteLine("1 - Mostre-me o que tens.");
                Console.WriteLine("2 - Irei levar esse."); 
                Console.WriteLine("3 - Meus itens");
                Console.WriteLine("0 - voltar");
                alternativa = Convert.ToInt16(Console.ReadLine());
                if (alternativa == 1)
                {
                    loja.ApresentarCatalogo();
                }
                else if (alternativa == 2 && loja.VerificarEstoque() == true)
                {
                    Console.Clear();
                    loja.ApresentarCatalogo();
                    loja.Vender(Heroi.Comprar(), Heroi);
                }else if(alternativa == 3)
                {
                    Console.Clear();
                    if(Heroi.Inventario.Count == 0)
                    {
                        Console.WriteLine("\nMinha Prata: " + Heroi.Prata + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nMinha Prata: " + Heroi.Prata);
                        foreach (var inventario in Heroi.Inventario)
                        {
                            Console.WriteLine("\nNome: " + inventario.Nome);
                            Console.WriteLine("Descrição: " + inventario.Descricao);
                            Console.WriteLine("Quantidade: " + inventario.Quantidade + "\n");
                        }
                    }
                }
                else if (loja.VerificarEstoque() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nVendedor: Estou em Falta de itens no momento Herói, volte novamente em outro momento e irei adorar te vender meus preciosos itens.");
                }
                else if (alternativa != 0)
                {
                    Console.WriteLine("Entrada Invalida");
                }

            } while (alternativa != 0);
            Console.Clear();
        }
    }
}
