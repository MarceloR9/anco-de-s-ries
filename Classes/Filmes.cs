namespace DIO.Series.Classes
{
    public class Filmes : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}
    

        public Filmes(int id, Genero Genero, string Titulo, string Descricao, int Ano)
        {
        this.id = id;
        this.Genero = Genero;
        this.Titulo = Titulo;
        this.Descricao = Descricao;   
        this.Ano = Ano;
        this.Excluido = false;
        }

      public override string ToString()
      {
        string retorno = " ";
        retorno += "Gênero: " + this.Genero + Environment.NewLine;
        retorno += "Título: " + this.Titulo + Environment.NewLine;
        retorno += "Descrição: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
        retorno += "Excluído " + this.Excluido;
        return retorno;
        }  

      public string retornaTitulo()
       {
        return this.Titulo;
       }

     public int retornaId()
       {
        return this.id;
       }

     public void Excluir()
       {
        this.Excluido = true;
       } 
    }
}