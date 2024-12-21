//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

using System.Text.Json.Serialization;
using TrabalhoPOO_12559_Fase1.Enums;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    /// <summary>
    /// Representa uma viatura, um tipo específico de meio.
    /// </summary>
    public class Viatura : Meio
    {
        #region Private Properties

        /// <summary>
        /// Tipo de equipamento associado à viatura.
        /// </summary>
        private TipoEquipamento tipo;

        private bool disponivel = true;

        #endregion

        #region Public Properties

        /// <summary>
        /// Obtém ou define o tipo de equipamento da viatura.
        /// </summary>
        [JsonIgnore] // Ignora a propriedade durante a serialização JSON
        public TipoEquipamento TipoEquipamento
        {
            get => tipo;
            set => tipo = value;
        }

        /// <summary>
        /// Apenas para fins de exibição, para evitar conflitos de nome de propriedades.
        /// </summary>
        public string TipoEquipamentoDescricao => tipo.ToString();

        /// <summary>
        /// Indica se a viatura está disponível.
        /// </summary>
        public bool _disponivel = true;

        #endregion

        #region Constructors

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Viatura"/> com o tipo de equipamento e matrícula especificados.
        /// </summary>
        /// <param name="tipo">O tipo de equipamento da viatura.</param>
        /// <param name="matricula">A matrícula da viatura.</param>
        public Viatura(TipoEquipamento tipo, string matricula) : base(matricula)
        {
            this.tipo = tipo;
            this.Matricula = Matricula;
        }

        /// <summary>
        /// Construtor padrão necessário para a desserialização.
        /// </summary>
        public Viatura() : base(string.Empty)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retorna uma string que representa a viatura.
        /// </summary>
        /// <returns>Uma string que representa a viatura.</returns>
        public override string ToString()
        {
            return $"Equipamento: {TipoEquipamentoDescricao}, Matrícula: {Matricula}, Disponível: {disponivel}";
        }

        /// <summary>
        /// Marca a viatura como indisponível
        /// </summary>
        public override void Indisponivel()
        {
            _disponivel = false;
        }

        #endregion
    }
}
