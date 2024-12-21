using TrabalhoPOO_12559_Fase1.Enums;
using TrabalhoPOO_12559_Fase1.Utilitários;

namespace TrabalhoPOO_12559_Fase1.Modelos
{
    public class Ocorrencia
    {
        #region Private Properties
        private static int contadorID = 1;
        private int idOcorrencia;
        private string descricao;
        private string local;
        private StatusOcorrencia status;
        private List<Pessoa> equipa;
        private List<Viatura> viaturas;
        #endregion

        #region Public Properties
        public StatusOcorrencia Status
        {
            get => status;
            set => status = value;
        }

        public string Descricao
        {
            get => descricao;
            set => descricao = value ?? throw new ArgumentNullException(nameof(descricao), "A descrição não pode ser nula.");
        }

        public string Local
        {
            get => local;
            set => local = value ?? throw new ArgumentNullException(nameof(local), "O local não pode ser nulo.");
        }

        #endregion

        #region Constructors
        public Ocorrencia(string descricao, string local)
        {
            idOcorrencia = contadorID++;
            Descricao = descricao;
            Local = local;
            status = StatusOcorrencia.Aberta;
            equipa = new List<Pessoa>();
            viaturas = new List<Viatura>();
        }
        #endregion

        #region Methods

        public void AdicionarPessoa(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new ArgumentNullException(nameof(pessoa), "A pessoa não pode ser nula.");
            }

            equipa.Add(pessoa);
        }

        public void AdicionarViatura(Viatura viatura)
        {
            if (viatura == null)
            {
                throw new ArgumentNullException(nameof(viatura), "A viatura não pode ser nula.");
            }

            viaturas.Add(viatura);
            string tipoVeiculo = Utilitarios.tipoVeiculo(viatura.TipoEquipamento);
        }

        public void AtualizarStatus(StatusOcorrencia novoStatus)
        {
            status = novoStatus;
            string descricaoStatus = Utilitarios.statusOcorrencia(status);
        }

        public override string ToString()
        {
            return $"ID: {idOcorrencia}, Descrição: {descricao}, Local: {local}, Status: {status}";
        }

        public void SalvarOcorrencia()
        {
            try
            {
                string filePath = "ocorrencias.txt";
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(ToString());
                }
                Console.WriteLine("Ocorrência salva com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar ocorrência: {ex.Message}");
            }
        }

        public void AdicionarMeio(object meio)
        {
            if (meio is Viatura viatura)
            {
                AdicionarViatura(viatura);
            }
            else if (meio is Pessoa pessoa)
            {
                AdicionarPessoa(pessoa);
            }
            else
            {
                throw new ArgumentException("Tipo de meio inválido.", nameof(meio));
            }
        }

        #endregion
    }
}
