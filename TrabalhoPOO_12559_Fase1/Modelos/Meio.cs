//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public abstract class Meio : Interfaces.IDisponibilidade
    {

        #region Private Properties
        /// <summary>
        /// 
        /// </summary>
        protected string matricula { get; set; }
        #endregion

        #region Public Properties
        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }
        #endregion

        #region Constructors
        public Meio(string matricula)
        {
            this.matricula = matricula;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Matricula: {matricula}";
        }
        public abstract void Indisponivel();

        #endregion
    }
}

