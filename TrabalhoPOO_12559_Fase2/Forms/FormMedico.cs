//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------
using TrabalhoPOO_12559_Fase1.Modelos;
using TrabalhoPOO_12559_Fase2.Utilitarios;

namespace TrabalhoPOO_12559_Fase2
{
    /// <summary>
    /// Formulário para gerir médicos.
    /// </summary>
    public partial class FormMedico : Form
    {
        #region Private Properties

        /// <summary>
        /// Lista de médicos.
        /// </summary>
        private List<Medico> medicos;
        private INEM inem;

        /// <summary>
        /// Caminho do arquivo JSON para armazenamento dos médicos.
        /// </summary>
        private const string filepath = "medicos.json";

        #endregion

        #region Constructors

        /// <summary>
        /// Inicia uma nova instância
        /// </summary>
        public FormMedico(INEM inem)
        {
            InitializeComponent();
            this.inem = inem;

            try
            {
                medicos = DataStorage.LoadData<List<Medico>>(filepath);
            }
            catch (FileNotFoundException)
            {
                medicos = new List<Medico>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}");
                medicos = new List<Medico>();
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar um médico.
        /// </summary>
        private void btnAdicionarMedico_Click(object sender, EventArgs e)
        {
            string nome = txtNomeMedico.Text;
            DateTime dataNasc = dtpDataNascMedico.Value;

            if (!string.IsNullOrEmpty(nome))
            {
                Medico novoMedico = new Medico(nome, dataNasc);
                medicos.Add(novoMedico);
                MessageBox.Show("Médico adicionado com sucesso!");
                txtNomeMedico.Clear();
                AtualizarListaMedicos();
                DataStorage.SaveData(medicos, filepath);
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar um médico ao INEM.
        /// </summary>
        private void btnAdicionarAoINEM_Click(object sender, EventArgs e)
        {

            if (listBoxMedicos.SelectedIndex >= 0)
            {
                Medico medicoSelecionado = medicos[listBoxMedicos.SelectedIndex];
                if (!INEM.Instance.Medicos.Contains(medicoSelecionado))
                {
                    INEM.Instance.Medicos.Add(medicoSelecionado);
                    MessageBox.Show("Médico adicionado ao INEM com sucesso!");
                    AtualizaFormularios.AtualizaTodosOsFormularios(); // Atualiza outros formulários
                }
                else
                {
                    MessageBox.Show("Este médico já foi adicionado ao INEM.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um médico para adicionar ao INEM.");
            }
        }

        /// <summary>
        /// Atualiza a lista de médicos exibida no formulário.
        /// </summary>
        public void AtualizarListaMedicos()
        {
            listBoxMedicos.Items.Clear();
            foreach (var medico in medicos)
            {
                listBoxMedicos.Items.Add($"Dr. {medico.Nome} - {medico.DataNasc:dd/MM/yyyy}");
            }
        }

        /// <summary>
        /// Evento executado quando o formulário é carregado.
        /// </summary>
        private void FormMedico_Load(object sender, EventArgs e)
        {
            AtualizarListaMedicos();
        }

        /// <summary>
        /// Evento executado ao clicar no botão para sair.
        /// </summary>
        private void Sair_Click(object sender, EventArgs e)
        {
            AtualizaFormularios.AtualizaTodosOsFormularios();
            this.Close();
        }

        /// <summary>
        /// Evento executado ao clicar no botão para remover um médico.
        /// </summary>
        private void btnRemoverMedico_Click(object sender, EventArgs e)
        {
            if (listBoxMedicos.SelectedIndex >= 0)
            {
                var resposta = MessageBox.Show("Tem certeza que deseja remover este médico?", "Confirmar remoção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    medicos.RemoveAt(listBoxMedicos.SelectedIndex);
                    AtualizarListaMedicos();
                    DataStorage.SaveData(medicos, filepath);
                    MessageBox.Show("Médico removido com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um médico para remover.");
            }
        }


        #endregion
    }
}
