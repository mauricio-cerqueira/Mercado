//Classe Pessoa com os dados referentes as pessoas

using System;

//Definição da classe pessoa
public class Pessoa
{
    //Variáveis públicas da classe pessoa
    // o código {get; set;} serve para permitir a leitua e escrita dos valores das variáveis fora da classe.
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public long Tel { get; set; }
    public DateTime Aniversario { get; set; }

    //Contrutor da classe Pessoa
    public Pessoa()
    {
    }



    //Metodo para retornar a idade da pessoa
    public int GetIdade()
    {
        int idade = DateTime.Now.Year - Aniversario.Year;
        if(DateTime.Now.DayOfYear < Aniversario.DayOfYear)
        {
            idade--;
        }
        
        return idade;
    }

    /*
    //Abaixo temos um construtor com um número de parametros diferentes

    public Pessoa(string Nome, string Endereco, long Tel, DateTime Aniversario)
    {
        this.Nome = Nome;
        this.Endereco = Endereco;  
        this.Tel = Tel;
        this.Aniversario = Aniversario;
    }
    */
}