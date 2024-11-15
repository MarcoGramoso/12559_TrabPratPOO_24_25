//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using TrabalhoPOO_12559_Fase1.Utilitários;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public class Corporacao
    {
        #region Private Properties
        private string nomeCorp { get; set; }
        private List<Viatura> viaturas = [];
        private List<Bombeiro> bombeiros = [];
        #endregion

        #region Public Properties
        public string NomeCorp
        {
            get => nomeCorp;
            set => nomeCorp = value;
        }
        public List<Viatura> Viaturas
        {
            get => viaturas;
            set => viaturas.AddRange(value);
        }
        public List<Bombeiro> Bombeiros
        {   get => bombeiros; 
            set => bombeiros.AddRange(value);
        }

        #endregion

        #region Constructors
        public Corporacao(string nomeCorp)
        {
            this.NomeCorp = nomeCorp;
        }
        #endregion

        #region Methods
        public void AddViatura(Viatura viaturas)
        {
            Viaturas.Add(viaturas);
            string tipoVeiculo = Utilitarios.tipoVeiculo(viaturas.tipoEquipamento);
            Console.WriteLine($"{tipoVeiculo} de matricula {viaturas.Matricula} adicionada à corporação {nomeCorp}.");
        }
        public void AddBombeiro(Bombeiro bombeiros)
        {
            Bombeiros.Add(bombeiros);
            Console.WriteLine($"{bombeiros.Nome} adicionado à corporação {nomeCorp}");
        }
        #endregion
    }
}
