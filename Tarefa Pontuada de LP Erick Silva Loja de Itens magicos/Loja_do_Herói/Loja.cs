using System;
using System.Collections.Generic;

namespace Loja_Itens_Magicos
{
    public class Loja
    {
        public Dictionary<string, Item> Catalogo = Item.adicionaritem();
      

        public bool VerificarEstoque()
        {
            bool estoque = false;
            if (Catalogo.Count == 0)
            {
                estoque = false;
            }
            else if (Catalogo.Count > 0)
            {
                estoque = true;

            }
            return estoque;
        }

        public static int VerificarQuantidade()
        {
            Console.WriteLine("Vendedor:Quantos deseja, nobre herói ?");
            return int.Parse(Console.ReadLine());
        }


        public void ApresentarCatalogo()
        {
            Console.Clear();
            if (VerificarEstoque() == false)
            {
                Console.WriteLine("Vendedor: Estou em Falta destes itens herói. Passe aqui novamente mais tarde.\n");
            }else if(VerificarEstoque() == true)
            {
                Console.WriteLine("Bem vindo Herói! O que desejas: ");
                foreach(KeyValuePair<string, Item> item in Catalogo)
                {
                    Console.WriteLine("\nNome: " + item.Value.Nome);
                    Console.WriteLine("Preço: " + item.Value.Preco);
                    Console.WriteLine("Categoria: " + item.Value.Categoria);
                    Console.WriteLine("Descrição: " + item.Value.Descricao);
                    Console.WriteLine("Quantidade: " + item.Value.Quantidade + "\n");
                }
            }          
        }

        public void Vender(string carrinho, Personagem Heroi)
        {     
            if(Catalogo.TryGetValue(carrinho, out Item item))
            {
                int quantidade; 
                if (item.Quantidade <= 1)
                {
                    Console.WriteLine("Vendedor:Ja vendemos demais desse herói,passe novamente quando o esque estiver cheio!\n");
                    Catalogo.Remove(carrinho);
                }
                else if(item.Quantidade > 0)
                {
                    quantidade = VerificarQuantidade();
                    List<Item> listaTemp = new List<Item>();
                    if (quantidade > item.Quantidade)
                    {
                        Console.WriteLine("está me pedindo mais do que eu tenho, volte que terei mais em breve herói.\n");
                    }
                    else
                    {
                        item.Quantidade = item.Quantidade - quantidade;
                        if (Heroi.Inventario.Count == 0 && item.Preco < Heroi.Prata)
                        {
                            Heroi.Inventario.Add(Item.CopiaItem(item, quantidade));
                            Console.WriteLine("Compra Realizada!\n");
                           Heroi.Prata -= item.Preco * quantidade;
                        }
                        else if (Heroi.Inventario.Count != 0 && item.Preco > Heroi.Prata)
                        {
                            Console.WriteLine("Esta faltando prata aqui, herói!\n");
                        }
                        else if (Heroi.Inventario.Count != 0 && item.Preco < Heroi.Prata)
                        {
                            foreach (var inventario in Heroi.Inventario)
                            {
                                if (inventario.Nome == item.Nome)
                                {
                                    inventario.Quantidade += 1*quantidade;
                                }
                                else
                                {
                                    listaTemp.Add(Item.CopiaItem(item, quantidade));

                                }
                            }
                            foreach (var itemTemp in listaTemp)
                            {
                                Heroi.Inventario.Add(itemTemp);
                            }
                            Heroi.Prata -= item.Preco*quantidade;
                            Console.WriteLine("Compra Realizada\n");
                        }

                    } 
                                   
                }
            }
        
            
        }
    }
}
