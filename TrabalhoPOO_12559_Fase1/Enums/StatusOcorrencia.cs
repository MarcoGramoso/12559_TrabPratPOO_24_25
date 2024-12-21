//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

using System.ComponentModel;

namespace TrabalhoPOO_12559_Fase1.Enums
{
    /// <summary>
    /// Representa os diferentes estados possíveis de uma ocorrência.
    /// </summary>
    public enum StatusOcorrencia
    {
        /// <summary>
        /// Ocorrência com meios despachados.
        /// </summary>
        [Description("Despacho de Meios")]
        DespachoDeMeios,

        /// <summary>
        /// Ocorrência ainda não resolvida.
        /// </summary>
        [Description("Em aberto")]
        Aberta,

        /// <summary>
        /// Ocorrência em andamento.
        /// </summary>
        [Description("Em curso")]
        EmCurso,

        /// <summary>
        /// Ocorrência encerrada.
        /// </summary>
        [Description("Fechada")]
        Fechada
    }
}
