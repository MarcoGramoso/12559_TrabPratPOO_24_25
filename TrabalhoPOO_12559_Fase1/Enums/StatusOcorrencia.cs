//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using System.ComponentModel;

namespace TrabalhoPOO_12559_Fase1.Enums
{
    public enum StatusOcorrencia
    {
        [Description ("Despacho de Meios")]
        Despachodemeios,
        [Description ("Em aberto")]
        Aberta,
        [Description ("Em curso")]
        EmCurso,
        [Description ("Fechada")]
        Fechada
    }
}

