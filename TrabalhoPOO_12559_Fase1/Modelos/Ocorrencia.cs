//-----------------------------------------------------------------​
//    <version>0.1</version>​
//    <author>Marco Gramoso</author>​
//-----------------------------------------------------------------

using System.ComponentModel;
using System.Reflection;
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
            get=>status; set => status = value;
        }

        #endregion

        #region Constructors
        public Ocorrencia(string descricao, string local)
        {
            idOcorrencia = contadorID++;
            this.descricao = descricao;
            status = StatusOcorrencia.Aberta;
            equipa = new List<Pessoa>();
            viaturas = new List<Viatura>();
            this.local = local;
        }
        #endregion

        #region Methods
        public void AdicionarPessoa(Pessoa pessoa)
        {
            equipa.Add(pessoa);
            Console.WriteLine($"{pessoa.Nome} adicionado à ocorrência");
        }

        public void AdicionarMeio(Viatura viatura)
        {
            viaturas.Add(viatura);
            string tipoVeiculo = Utilitarios.tipoVeiculo(viatura.tipoEquipamento);
            Console.WriteLine($"{tipoVeiculo} matricula {viatura.Matricula} adicionado à ocorrência");
        }

        public void AtualizarStatus(StatusOcorrencia novoStatus)
        {
            status = novoStatus;
            string descricao = Utilitarios.statusOcorrencia(status);
            Console.WriteLine($"Estado atualizado para: {descricao}");
        }

        public override string ToString()
        {
            return $"ID: {idOcorrencia},\nDescrição: {descricao}, Local: {local} , Estado da ocorrência: {status}";
        }

        public void SalvarOcorrencia()
        {
            string filePath = "ocorrencias.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(ToString());
            }
        }
        #endregion
    }
}

