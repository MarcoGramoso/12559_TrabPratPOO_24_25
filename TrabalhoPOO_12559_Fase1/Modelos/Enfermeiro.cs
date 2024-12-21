//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    /// <summary>
    /// Representa um enfermeiro, que é uma pessoa com a capacidade de ficar indisponível.
    /// </summary>
    public class Enfermeiro : Pessoa
    {
        #region Constructors

        /// <summary>
        /// Constrói uma instância de um enfermeiro com nome e data de nascimento.
        /// </summary>
        /// <param name="nome">Nome do enfermeiro.</param>
        /// <param name="dataNasc">Data de nascimento do enfermeiro.</param>
        public Enfermeiro(string nome, DateTime dataNasc) : base(nome, dataNasc) { }

        #endregion

        #region Methods

        /// <summary>
        /// Marca o enfermeiro como indisponível e exibe uma mensagem no console.
        /// </summary>
        public override void Indisponivel()
        {
            Console.WriteLine($"Enfermeiro {Nome} está indisponível.");
        }

        #endregion
    }
}
