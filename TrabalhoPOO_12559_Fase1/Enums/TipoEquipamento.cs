//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

using System.ComponentModel;

namespace TrabalhoPOO_12559_Fase1.Enums
{
    /// <summary>
    /// Representa os diferentes tipos de equipamentos utilizados nas ocorrências.
    /// </summary>
    public enum TipoEquipamento
    {
        /// <summary>
        /// Ambulância para transporte de vítimas.
        /// </summary>
        [Description("Ambulância")]
        Ambulancia,

        /// <summary>
        /// Veículo auto de combate a incêndios.
        /// </summary>
        [Description("Veículo Auto de Combate a Incêndios")]
        ViaturaIncendio,

        /// <summary>
        /// Veículo auto de desencarceramento.
        /// </summary>
        [Description("Veículo Auto de Desencarceramento")]
        ViaturaDesencarceramento,

        /// <summary>
        /// Helicóptero de combate a incêndios.
        /// </summary>
        [Description("Helicóptero de combate a incêndios")]
        HeliInc,

        /// <summary>
        /// Helicóptero de socorro.
        /// </summary>
        [Description("Helicóptero de socorro")]
        HeliSoc,

        /// <summary>
        /// Barco de salvamento de vidas.
        /// </summary>
        [Description("Barco Salva vidas")]
        Barco,

        /// <summary>
        /// Moto utilizada para resgates rápidos.
        /// </summary>
        [Description("Moto")]
        Moto,

        /// <summary>
        /// Mota de água para resgates em áreas aquáticas.
        /// </summary>
        [Description("Mota de água")]
        MotaDeAgua,

        /// <summary>
        /// Viatura médica para atendimento e transporte de pacientes.
        /// </summary>
        [Description("Viatura Médica")]
        ViaturaMedica,

        /// <summary>
        /// Outros tipos de veículos não especificados.
        /// </summary>
        [Description("Outro veículo")]
        Outros
    }
}
