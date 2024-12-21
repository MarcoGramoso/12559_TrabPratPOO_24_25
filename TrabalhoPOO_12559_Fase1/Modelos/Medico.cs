//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    /// <summary>
    /// Representa um médico, que é uma pessoa com a capacidade de ficar indisponível.
    /// </summary>
    public class Medico : Pessoa
    {
        #region Private Properties

        /// <summary>
        /// Define o médico com disponivel
        /// </summary>
        private bool _disponivel = true;
        #endregion

        #region Constructors

        /// <summary>
        /// Constrói uma instância de um médico com nome e data de nascimento.
        /// </summary>
        /// <param name="nome">Nome do médico.</param>
        /// <param name="dataNasc">Data de nascimento do médico.</param>
        public Medico(string nome, DateTime dataNasc) : base(nome, dataNasc) { }

        #endregion

        #region Methods

        /// <summary>
        /// Marca o médico como indisponível
        /// </summary>
        public override void Indisponivel()
        {
            // Lógica simples de marcação de indisponibilidade
            _disponivel = false;
        }

        #endregion
    }
}
