//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------
using TrabalhoPOO_12559_Fase1.Enums;
using TrabalhoPOO_12559_Fase1.Modelos;
using TrabalhoPOO_12559_Fase2.Utilitarios;

namespace TrabalhoPOO_12559_Fase2
{
    /// <summary>
    /// Formulário para gerir ocorrências.
    /// </summary>
    public partial class FormOcorrencia : Form
    {
        #region Private Properties

        /// <summary>
        /// Lista de ocorrências.
        /// </summary>
        private List<Ocorrencia> ocorrencias;

        /// <summary>
        /// Instância do INEM.
        /// </summary>
        private INEM inem;

        /// <summary>
        /// Instância da Corporação.
        /// </summary>
        private Corporacao corporacao;

        /// <summary>
        /// Caminho do arquivo JSON para armazenamento de ocorrências.
        /// </summary>
        private const string ocorrenciasFilepath = "ocorrencias.json";

        #endregion

        #region Constructors

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="FormOcorrencia"/>.
        /// </summary>
        public FormOcorrencia()
        {
            InitializeComponent();
            ocorrencias = LoadOcorrencias();
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusOcorrencia));
            corporacao = new Corporacao();
            inem = new INEM();
        }

        /// <summary>
        /// Carrega a lista de ocorrências a partir de um arquivo JSON.
        /// </summary>
        private List<Ocorrencia> LoadOcorrencias()
        {
            try
            {
                return DataStorage.LoadData<List<Ocorrencia>>(ocorrenciasFilepath);
            }
            catch (FileNotFoundException)
            {
                return new List<Ocorrencia>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar ocorrências: {ex.Message}");
                return new List<Ocorrencia>();
            }
        }
        #endregion

        #region Event Handlers

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar uma ocorrência.
        /// </summary>
        private void btnAdicionarOcorrencia_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            string local = txtLocal.Text;

            if (!string.IsNullOrEmpty(descricao) && !string.IsNullOrEmpty(local))
            {
                Ocorrencia novaOcorrencia = new Ocorrencia(descricao, local);
                ocorrencias.Add(novaOcorrencia);
                SaveOcorrencias(); // Salvando as ocorrências após adicionar
                MessageBox.Show($"Ocorrência '{descricao}' adicionada com sucesso!");
                txtDescricao.Clear();
                txtLocal.Clear();
                AtualizarListaOcorrencias();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para atualizar o status de uma ocorrência.
        /// </summary>
        private void btnAtualizarStatus_Click(object sender, EventArgs e)
        {
            if (listBoxOcorrencias.SelectedIndex >= 0)
            {
                Ocorrencia ocorrenciaSelecionada = ocorrencias[listBoxOcorrencias.SelectedIndex];
                StatusOcorrencia novoStatus = (StatusOcorrencia)comboBoxStatus.SelectedItem;
                ocorrenciaSelecionada.AtualizarStatus(novoStatus);
                SaveOcorrencias();
                MessageBox.Show($"Status da ocorrência '{ocorrenciaSelecionada.Descricao}' atualizado para '{novoStatus}'.");
                AtualizarListaOcorrencias();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma ocorrência para atualizar o status.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para listar todas as ocorrências.
        /// </summary>
        private void btnListarOcorrencias_Click(object sender, EventArgs e)
        {
            AtualizarListaOcorrencias();
        }

        /// <summary>
        /// Atualiza a lista de ocorrências exibida no formulário.
        /// </summary>
        private void AtualizarListaOcorrencias()
        {
            listBoxOcorrencias.Items.Clear();
            foreach (var ocorrencia in ocorrencias)
            {
                listBoxOcorrencias.Items.Add(ocorrencia.ToString());
            }
        }


        /// <summary>
        /// Evento executado ao clicar no botão para adicionar meios do INEM a uma ocorrência.
        /// </summary>
        private void btnAdicionarMeiosINEM_Click(object sender, EventArgs e)
        {
            FormINEM formINEM = new FormINEM();
            formINEM.ShowDialog();
        }


        /// <summary>
        /// Evento executado ao clicar no botão para adicionar meios da Corporação a uma ocorrência.
        /// </summary>
        private void btnCorporacao_Click(object sender, EventArgs e)
        {
            FormCorporacao formCorporacao = new FormCorporacao();
            formCorporacao.ShowDialog();
        }




        #endregion

        #region Methods

        /// <summary>
        /// Evento disparado quando o formulário é carregado.
        /// </summary>
        private void FormOcorrencia_Load(object sender, EventArgs e)
        {
            AtualizarListaOcorrencias();
        }

        /// <summary>
        /// Salva a lista de ocorrências em um arquivo JSON.
        /// </summary>
        private void SaveOcorrencias()
        {
            DataStorage.SaveData(ocorrencias, ocorrenciasFilepath);
        }
        #endregion
    }
}
