//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    /// <summary>
    /// Representa um meio de transporte, que pode ter uma matrícula
    /// e um estado de disponibilidade.
    /// </summary>
    public abstract class Meio
    {
        #region Private Properties
        private string matricula;
        private bool disponivel = true;
        #endregion

        #region Public Properties
        /// <summary>
        /// Obtém ou define a matrícula do meio de transporte fazendo a validação de dados
        /// </summary>
        public string Matricula
        {
            get => matricula;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0)
                    throw new ArgumentException("Matricula inválida");
                matricula = value;
            }
        }

        /// <summary>
        /// Obtém ou define o meio com disponivel
        /// </summary>
        public bool Disponivel
        {
            get => disponivel;
            set => disponivel = value;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Construtor para inicializar o meio com uma matrícula.
        /// </summary>
        /// <param name="matricula">Matrícula do meio de transporte.</param>
        public Meio(string matricula)
        {
            this.matricula = matricula;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Retorna uma representação em string do meio de transporte.
        /// </summary>
        /// <returns>String contendo a matrícula do meio.</returns>
        public override string ToString()
        {
            return $"Matricula: {matricula}";
        }

        /// <summary>
        /// Define o meio como indisponível. Este método deve ser implementado nas subclasses.
        /// </summary>
        public abstract void Indisponivel();
        #endregion
    }
}
