//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase1.Interfaces
{
    /// <summary>
    /// Define um contrato para objetos que possuem a capacidade de 
    /// se tornarem indisponíveis.
    /// </summary>
    internal interface IDisponibilidade
    {
        /// <summary>
        /// Marca o recurso como indisponível.
        /// </summary>
        void Indisponivel();

        /// <summary>
        /// Marca o recurso como disponível.
        /// </summary>
        void Disponivel();
    }
}
