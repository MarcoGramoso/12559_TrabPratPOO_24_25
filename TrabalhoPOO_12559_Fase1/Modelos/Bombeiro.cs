//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using TrabalhoPOO_12559_Fase1.Interfaces;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public class Bombeiro : Pessoa
    {
        #region Private Properties
        #endregion

        #region Constructors
        public Bombeiro(string nome, DateTime dataNasc) : base(nome, dataNasc) { }
        #endregion

        #region Methods
        public override void Indisponivel()
        {
            Console.WriteLine($"Bombeiro {Nome} está indisponível.");
        }
        #endregion
    }
}