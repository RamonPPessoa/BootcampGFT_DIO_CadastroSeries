namespace DIO.Series
{
    public class Serie :EntidadeBase
    {
        private Genero Genero{get;set;}
        private string Titulo{get;set;}
        private string Descricao{get;set;}
        private int Ano{get;set;}


        public Serie(Genero Genero,string Titulo,string Descricao,int Ano)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano=Ano;
        }

        public override string ToString() 
        {
            string retorno = "";
            retorno += "Genero" + this.Genero;
            retorno += "Titulo" + this.Titulo;
            retorno += "Descrição: " + this.Descricao;
            retorno+= "Ano: " + this.Ano;

            return retorno;
         }
        

        public string retornaTitulo() 
        {
            return this.Titulo;
         }

         public int retornaId() 
        {
            return this.Id;
         }
    }
}