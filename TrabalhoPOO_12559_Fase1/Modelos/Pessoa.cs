//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    /// <summary>
    /// Representa uma pessoa com nome e data de nascimento.
    /// </summary>
    public abstract class Pessoa
    {
        #region Private Properties
        private string nome;
        private DateTime dataNasc;
        #endregion

        #region Public Properties
        /// <summary>
        /// Obtém o nome da pessoa.
        /// </summary>
        public string Nome
        {
            get => nome;
        }

        /// <summary>
        /// Define a data de nascimento da pessoa
        /// </summary>
        public DateTime DataNasc
        {
            get;
            private set;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Construtor para inicializar uma nova instância da pessoa fazendo validação de dados
        /// </summary>
        /// <param name="nome">Nome da pessoa.</param>
        /// <param name="dataNasc">Data de nascimento da pessoa.</param>
        public Pessoa(string nome, DateTime dataNasc)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser nulo ou vazio.", nameof(nome));
            }
            if (dataNasc >= DateTime.Now)
            {
                throw new ArgumentException("A data de nascimento não pode ser superior à data atual", nameof(dataNasc));
            }
            this.nome = nome;
            DataNasc = dataNasc;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Define a pessoa como indisponível. Este método deve ser implementado pelas subclasses.
        /// </summary>
        public abstract void Indisponivel();
        #endregion
    }
}