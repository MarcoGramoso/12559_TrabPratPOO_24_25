//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using TrabalhoPOO_12559_Fase1.Enums;


namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public class Viatura : Meio
    {
        #region Private Properties
        private TipoEquipamento tipo;
        #endregion

        #region Public Properties
        public TipoEquipamento tipoEquipamento
        {
            get => tipo;
            set => tipo = value;
        }
        #endregion

        #region Constructors
        public Viatura(TipoEquipamento tipo, string matricula) : base(matricula)
        {
            this.tipo = tipo;
            this.matricula = matricula;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Equipamento: {tipo}, Matricula: {matricula}";
        }

        public override void Indisponivel()
        {
            Console.WriteLine($"Viatura {matricula} está indisponivel.");
        }
        #endregion
    }
}

