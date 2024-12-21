//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

using System.ComponentModel;
using TrabalhoPOO_12559_Fase1.Enums;

namespace TrabalhoPOO_12559_Fase1.Utilitários
{
    public class Utilitarios
    {
        #region Methods

        // Método genérico para obter a descrição de um enum com atributo Description
        public static string ObterDescricaoEnum(Enum valorEnum)
        {
            if (valorEnum == null)
            {
                throw new ArgumentNullException(nameof(valorEnum), "O valor do enum não pode ser nulo.");
            }

            try
            {
                var field = valorEnum.GetType().GetField(valorEnum.ToString());
                var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
                return attribute == null ? valorEnum.ToString() : attribute.Description;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao obter a descrição do enum.", ex);
            }

        }


        // Método específico para tipo de equipamento, usando o genérico
        public static string tipoVeiculo(TipoEquipamento tipoEquipamento)
        {
            return ObterDescricaoEnum(tipoEquipamento);
        }

        // Método específico para status de ocorrência, usando o genérico
        public static string statusOcorrencia(StatusOcorrencia status)
        {
            return ObterDescricaoEnum(status);
        }

        #endregion
    }
}
