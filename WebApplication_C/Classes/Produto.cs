//Bibliotecas utilizadas pela classe produtos
using System;

// Classe para cadastro de produtos
public class Produto
{
    //Atributos da classe Produtos
    public long Cod_Barras { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set;}
    public float Preco { get; set;}
    public string Marca { get; set;}
    public DateTime Fabricacao { get; set; }
    public DateTime Validade { get; set;}
    public int Quantidade { get; set;}
    
    //Construtor básico para a classe Produto
    public Produto(long Cod_Barras, float Preco, int Quantidade)
    {
        this.Cod_Barras = Cod_Barras;
        this.Preco = Preco;
        this.Quantidade = Quantidade;
    }

    //Construtor completo para a classe Produto
    public Produto(long Cod_Barras, string Nome, string Descricao, float Preco, string Marca, DateTime Fabricacao, DateTime Validade, int Quantidade) {
        this.Cod_Barras=Cod_Barras;
        this.Nome = Nome;
        this.Descricao = Descricao;
        this.Preco = Preco;
        this.Marca = Marca;
        this.Fabricacao = Fabricacao;
        this.Validade = Validade;
        this.Quantidade = Quantidade;
    }

}








