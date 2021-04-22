using System;
using System.Collections.Generic;

namespace Loja_Itens_Magicos
{
    public class Item
    {
        public string Nome;
        public Int32 Preco;
        public string Categoria;
        public string Descricao;
        public int Quantidade;

        public Item(string Nome,Int32 Preco, string Categoria, string Descricao, int Quantidade)
        {
            this.Nome = Nome
            this.Preco = Preco
            this.Categoria = Categoria
            this.Descricao = Descricao
            this.Quantidade = Quantidade

        }
        public static Dictionary<string,Item> adicionaritem()
        {

            Dictionary<string,Item> Listadeitem = new Dictionary<string,Item>();
            Item I1 = new Item("Espada",10,"Arma","Uma lamina cortante", 15);
            Listadeitem.Add(I1.Nome,I1);

             Item I2 = new Item("Orbe de Vida",15,"Item de Vida","Uma pedra esferica que concede vida", 15);
            Listadeitem.Add(I2.Nome,I2);

             Item I3 = new Item("Arco Curto",20,"Arma","Um Arco para iniciantes", 15);
            Listadeitem.Add(I3.Nome,I3);

             Item I4 = new Item("Arco Longa",30,"Arma","Um Arco para experientes", 15);
            Listadeitem.Add(I4.Nome,I4);

             Item I5 = new Item("Flechas",2,"Munição","Flecha de boa qualidade", 15);
            Listadeitem.Add(I5.Nome,I5);

             Item I6 = new Item("Capa de Pele de Cervo",5,"Capas","Capa que concede proteção contra itens magicos", 15);
            Listadeitem.Add(I6.Nome,I6);

             Item I7 = new Item("Escudo de Madeira",15,"Defesa Pessoal","Escudo de baixa qualidade feito de madeira", 15);
            Listadeitem.Add(I7.Nome,I7);

             Item I8 = new Item("Escudo de Ferro",25,"Defesa Pessoal","Escudo de Qualidade boa feito de ferro", 15);
            Listadeitem.Add(I8.Nome,I8);

             Item I9 = new Item("Poção de Veneno",10,"Item de Veneno","Um Frasco contendo um veneno poderoso capaz de matar um leão em segundos", 15);
            Listadeitem.Add(I9.Nome,I9);

             Item I10 = new Item("Doce de Força",50,"Consumivel","Um doce misterioso que concede aumento instantanêo de força", 15);
            Listadeitem.Add(I10.Nome,I10);

        }

        public static Item CopiaItem(Item itemCopia, int quantidade)
        {
            Item itemVendido = new Item();
            itemVendido.Nome = itemCopia.Nome;
            itemVendido.Preco = itemCopia.Preco;
            itemVendido.Categoria = itemCopia.Categoria;
            itemVendido.Descricao = itemCopia.Descricao;
            itemVendido.Quantidade = quantidade;

            return itemVendido;
        }
    }
}
