//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using TrabalhoPOO_12559_Fase1.Utilitários;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public class INEM
    {
        #region Private Properties

        /// <summary>
        /// Aplicação do Singleton
        /// </summary>
        private static INEM? _instance;
        private static readonly object _lock = new object();

        #endregion

        #region Public Properties

        public List<Viatura> Viaturas { get; set; }
        public List<Medico> Medicos { get; set; }
        public List<Enfermeiro> Enfermeiros { get; set; }

        /// <summary>
        /// Singleton
        /// </summary>
        public static INEM Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new INEM();
                        }
                    }
                }
                return _instance;
            }

        }


        #endregion

        #region Constructors
        /// <summary>
        /// Construtor de INEM
        /// </summary>
        public INEM()
        {
            Viaturas = new List<Viatura>();
            Medicos = new List<Medico>();
            Enfermeiros = new List<Enfermeiro>();
        }
        #endregion

        #region Methods
        public void AddViatura(Viatura viaturas)
        {
            if (!Viaturas.Exists(v => v.Matricula == viaturas.Matricula))
            {
                Viaturas.Add(viaturas);
                string tipoVeiculo = Utilitarios.tipoVeiculo(viaturas.TipoEquipamento);
            }

        }
        public void AddMedico(Medico medicos)
        {
            if (!Medicos.Exists(m => m.Nome == medicos.Nome))
            {
                if (!Medicos.Exists(d => d.DataNasc == medicos.DataNasc))
                {
                    Medicos.Add(medicos);
                }
            }
        }

        public void AddEnfermeiro(Enfermeiro enfermeiros)
        {
            if (!Enfermeiros.Exists(m => m.Nome == enfermeiros.Nome))
            {
                if (!Enfermeiros.Exists(d => d.DataNasc == enfermeiros.DataNasc))
                {
                    Enfermeiros.Add(enfermeiros);
                }
            }
        }
        #endregion
    }
}