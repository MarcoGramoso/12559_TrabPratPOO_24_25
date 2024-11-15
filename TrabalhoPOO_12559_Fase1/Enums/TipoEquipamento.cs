//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using System.ComponentModel;

namespace TrabalhoPOO_12559_Fase1.Enums
{
    public enum TipoEquipamento
    {
        [Description ("Ambulância")]
        Ambulancia,
        [Description ("Veículo Auto de Combate a Incêndios")]
        ViaturaIncendio,
        [Description ("Veículo Auto de Desencarceramento")]
        ViaturaDesencarceramento,
        [Description ("Helicoptero de combate a incêndios")]
        HeliInc,
        [Description ("Helicoptero de socorro")]
        HeliSoc,
        [Description ("Barco Salva vidas")]
        Barco,
        [Description ("Moto")]
        Moto,
        [Description ("Mota de água")] 
        MotodeAgua,
        [Description ("Viatura Médica")]
        ViaturaMedica,
        [Description ("Outro veículo")]
        Outros
    }
}

