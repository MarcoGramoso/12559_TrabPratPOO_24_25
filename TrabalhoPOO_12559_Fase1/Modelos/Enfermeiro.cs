//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public class Enfermeiro : Pessoa
    {
        #region Constructors
        public Enfermeiro(string nome, DateTime dataNasc) : base(nome, dataNasc) { }
        #endregion

        #region Methods
        public override void Indisponivel()
        {
            Console.WriteLine($"Enfermeiro {Nome} está indisponivel.");
        }
        #endregion
    }
}

