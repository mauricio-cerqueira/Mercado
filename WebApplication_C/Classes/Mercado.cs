
using System.Collections.Generic;

public static class Mercado
{
    public static List<Produto> Produtos = new List<Produto>();


    public static List<Produto> GetProdutoNome(string nome)
    {
        List<Produto> busca = new List<Produto>();
        foreach (Produto produto in Produtos)
        {
            if (produto.Nome.Contains(nome))
            {
                busca.Add(produto);
            }
        }
        return busca;
    }
}