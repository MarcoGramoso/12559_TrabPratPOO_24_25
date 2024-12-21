//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

using TrabalhoPOO_12559_Fase1.Modelos;
using TrabalhoPOO_12559_Fase2.Utilitarios;

/// <summary>
/// Formulário para gerir enfermeiros
/// </summary>
namespace TrabalhoPOO_12559_Fase2
{
    public partial class FormEnfermeiro : Form
    {
        #region Private Properties
        private List<Enfermeiro> enfermeiros;
        private INEM inem;
        private Enfermeiro enfermeiroSelecionado;

        /// <summary>
        /// Caminho do arquivo JSON para armazenamento dos enfermeiros.
        /// </summary>
        private const string filepath = "enfermeiros.json";
        #endregion

        #region Constructor
        public FormEnfermeiro(INEM inem)
        {
            InitializeComponent();
            this.inem = inem;

            try
            {
                enfermeiros = DataStorage.LoadData<List<Enfermeiro>>(filepath);
            }
            catch (FileNotFoundException)
            {
                enfermeiros = new List<Enfermeiro>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}");
                enfermeiros = new List<Enfermeiro>();
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar um enfermeiro.
        /// </summary>
        private void btnAdicionarEnfermeiro_Click(object sender, EventArgs e)
        {
            string nome = txtNomeEnfermeiro.Text;
            DateTime dataNasc = dtpDataNascEnfermeiro.Value;

            if (!string.IsNullOrEmpty(nome) && dataNasc <= DateTime.Now)
            {
                Enfermeiro novoEnfermeiro = new Enfermeiro(nome, dataNasc);
                enfermeiros.Add(novoEnfermeiro);
                MessageBox.Show("Enfermeiro adicionado com sucesso!");
                txtNomeEnfermeiro.Clear();
                AtualizarLista();
                DataStorage.SaveData(enfermeiros, filepath);
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para remover um enfermeiro.
        /// </summary>
        private void btnRemoverEnfermeiro_Click(object sender, EventArgs e)
        {
            if (listBoxEnfermeiros.SelectedIndex >= 0)
            {
                enfermeiros.RemoveAt(listBoxEnfermeiros.SelectedIndex);
                DataStorage.SaveData(enfermeiros, filepath);
                MessageBox.Show("Enfermeiro removido com sucesso!");
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um enfermeiro para remover.");
            }
        }

        /// <summary>
        /// Atualiza a lista de enfermeiros exibida no formulário.
        /// </summary>
        public void AtualizarLista()
        {
            listBoxEnfermeiros.Items.Clear();
            foreach (var enfermeiro in enfermeiros)
            {
                listBoxEnfermeiros.Items.Add($"{enfermeiro.Nome} - {enfermeiro.DataNasc:dd/MM/yyyy}");
            }
        }

        /// <summary>
        /// Evento executado quando o formulário é carregado.
        /// </summary>
        private void FormEnfermeiro_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        /// <summary>
        /// Evento executado ao clicar no botão para sair.
        /// </summary>
        private void Sair_Click(object sender, EventArgs e)
        {
            AtualizaFormularios.AtualizaTodosOsFormularios();
            DataStorage.SaveData(enfermeiros, filepath);
            this.Close();
        }

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar um enfermeiro ao INEM.
        /// </summary>
        private void btnAdicionarAoINEM_Click(object sender, EventArgs e)
        {
            if (listBoxEnfermeiros.SelectedIndex >= 0)
            {
                if (!inem.Enfermeiros.Contains(enfermeiroSelecionado))
                {
                    inem.Enfermeiros.Add(enfermeiroSelecionado);
                    MessageBox.Show("Enfermeiro adicionado ao INEM com sucesso!");
                }
                else
                {
                    MessageBox.Show("Este enfermeiro já foi adicionado ao INEM.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um enfermeiro para adicionar ao INEM.");
            }
        }

        #endregion
    }
}
