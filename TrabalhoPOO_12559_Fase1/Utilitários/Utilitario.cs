//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO_12559_Fase1.Enums;

namespace TrabalhoPOO_12559_Fase1.Utilitários
{
    // Classe onde o método 'ObterDescricao' está definido
    public class Utilitarios
    {
        #region Methods

        // Método estático para obter a descrição do enum
        public static string tipoVeiculo(TipoEquipamento tipoEquipamento)
        {
            // Obtendo o campo do enum e seu atributo Description
            var field = tipoEquipamento.GetType().GetField(tipoEquipamento.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            // Se o atributo Description não existir, retorna o nome do valor do enum
            return attribute == null ? tipoEquipamento.ToString() : attribute.Description;
        }
        public static string statusOcorrencia(StatusOcorrencia status)
        {
            // Obtendo o campo do enum e seu atributo Description
            var field = status.GetType().GetField(status.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            // Se o atributo Description não existir, retorna o nome do valor do enum
            return attribute == null ? status.ToString() : attribute.Description;
        }

        #endregion
    }
}
