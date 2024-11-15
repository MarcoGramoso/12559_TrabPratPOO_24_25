//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using TrabalhoPOO_12559_Fase1.Interfaces;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public abstract class Pessoa : IDisponibilidade
    {
        #region Private Properties
        private string nome { get; set; }
        private DateTime dataNasc { get; set; }
        #endregion

        #region Public Properties
        public string Nome
        {
            get => nome;
        }
        public DateTime DataNasc
        {
            get => dataNasc;
            set => dataNasc = value;
        }
        #endregion

        #region Constructors
        public Pessoa(string nome, DateTime dataNasc)
        {
            this.nome = nome;
            this.DataNasc = dataNasc;
        }
        #endregion

        #region Methods
        public abstract void Indisponivel();
        #endregion
    }
}

