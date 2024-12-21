using TrabalhoPOO_12559_Fase1.Utilitários;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    /// <summary>
    /// Representa uma corporação de bombeiros.
    /// </summary>
    public class Corporacao
    {
        #region Private Properties
        private static Corporacao _instance;
        private static readonly object _lock = new object();
        #endregion

        #region Public Properties

        public static Corporacao Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Corporacao();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Lista de viaturas da corporação.
        /// </summary>
        public List<Viatura> Viaturas { get; private set; }

        /// <summary>
        /// Lista de bombeiros da corporação.
        /// </summary>
        public List<Bombeiro> Bombeiros { get; private set; }

        #endregion

        #region Constructors


        public Corporacao()
        {
            Viaturas = new List<Viatura>();
            Bombeiros = new List<Bombeiro>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adiciona uma viatura à corporação.
        /// </summary>
        /// <param name="viatura">A viatura a ser adicionada.</param>
        /// <exception cref="ArgumentNullException">Se a viatura for nula.</exception>
        public void AddViatura(Viatura viatura)
        {
            if (viatura == null)
            {
                throw new ArgumentNullException(nameof(viatura), "A viatura não pode ser nula.");
            }

            // Verificar se a viatura já foi adicionada com a mesma matrícula
            if (Viaturas.Exists(v => v.Matricula == viatura.Matricula))
            {
                return;
            }

            Viaturas.Add(viatura);
            string tipoVeiculo = Utilitarios.tipoVeiculo(viatura.TipoEquipamento);
        }

        /// <summary>
        /// Adiciona um bombeiro à corporação.
        /// </summary>
        /// <param name="bombeiro">O bombeiro a ser adicionado.</param>
        /// <exception cref="ArgumentNullException">Se o bombeiro for nulo.</exception>
        public void AddBombeiro(Bombeiro bombeiro)
        {
            if (bombeiro == null)
            {
                throw new ArgumentNullException(nameof(bombeiro), "O bombeiro não pode ser nulo.");
            }

            // Verificar se o bombeiro já foi adicionado com o mesmo nome
            if (Bombeiros.Exists(b => b.Nome == bombeiro.Nome))
            {
                return;
            }

            Bombeiros.Add(bombeiro);
        }

        /// <summary>
        /// Exibe as informações sobre as viaturas e bombeiros da corporação.
        /// </summary>
        public void ExibirInformacoes()
        {
            foreach (var viatura in Viaturas)
            {
                Console.WriteLine(viatura.ToString());
            }

            foreach (var bombeiro in Bombeiros)
            {
                Console.WriteLine(bombeiro.Nome);
            }
        }

        #endregion
    }
}
