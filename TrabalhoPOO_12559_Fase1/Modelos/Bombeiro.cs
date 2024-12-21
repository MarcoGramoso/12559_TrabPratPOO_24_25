//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    /// <summary>
    /// Representa um bombeiro, que é uma pessoa com a capacidade de ficar indisponível.
    /// </summary>
    public class Bombeiro : Pessoa
    {
        #region Private Properties

        /// <summary>
        /// Define o bombeiro como disponivel
        /// </summary>
        private bool _disponivel = true;
        #endregion 

        #region Constructors
        /// <summary>
        /// Constrói uma instância de um Bombeiro com nome e data de nascimento.
        /// </summary>
        /// <param name="nome">Nome do bombeiro.</param>
        /// <param name="dataNasc">Data de nascimento do bombeiro.</param>
        public Bombeiro(string nome, DateTime dataNasc) : base(nome, dataNasc) { }
        #endregion

        #region Methods
        /// <summary>
        /// Marca o bombeiro como indisponível
        /// </summary>
        public override void Indisponivel()
        {
            // Exemplo de lógica simples de indisponibilidade
            _disponivel = false;
        }
        #endregion
    }
}
