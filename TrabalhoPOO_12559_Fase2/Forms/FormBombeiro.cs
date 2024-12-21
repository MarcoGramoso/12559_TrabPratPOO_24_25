//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------
using TrabalhoPOO_12559_Fase1.Modelos;
using TrabalhoPOO_12559_Fase2.Utilitarios;

namespace TrabalhoPOO_12559_Fase2
{
    /// <summary>
    /// Formulário para gerir bombeiros
    /// </summary>
    public partial class FormBombeiro : Form
    {
        #region Private Properties

        /// <summary>
        /// Lista de bombeiros.
        /// </summary>
        private List<Bombeiro> bombeiros;

        /// <summary>
        /// Instância da corporação.
        /// </summary>
        private Corporacao corporacao;

        /// <summary>
        /// Caminho do arquivo JSON para armazenamento dos bombeiros.
        /// </summary>
        private const string filepath = "bombeiros.json";

        #endregion

        #region Constructors

        /// <summary>
        /// Inicia uma nova instância da classe <see cref="FormBombeiro"/> com uma corporação.
        /// </summary>
        /// <param name="corp">Instância da corporação.</param>
        public FormBombeiro(Corporacao corp)
        {
            InitializeComponent();
            corporacao = corp;

            try
            {
                bombeiros = DataStorage.LoadData<List<Bombeiro>>(filepath);
            }
            catch (FileNotFoundException)
            {
                bombeiros = new List<Bombeiro>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}");
                bombeiros = new List<Bombeiro>();
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar um bombeiro.
        /// </summary>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateTime dataNasc = dtpDataNasc.Value;

            if (!string.IsNullOrEmpty(nome) && dataNasc <= DateTime.Now)
            {
                Bombeiro novoBombeiro = new Bombeiro(nome, dataNasc);
                bombeiros.Add(novoBombeiro);
                MessageBox.Show("Bombeiro adicionado com sucesso!");
                txtNome.Clear();
                AtualizarListaBombeiros();
                DataStorage.SaveData(bombeiros, filepath);
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome e uma data de nascimento válidas.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para remover um bombeiro.
        /// </summary>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxBombeiros.SelectedIndex >= 0)
            {
                bombeiros.RemoveAt(listBoxBombeiros.SelectedIndex);
                MessageBox.Show("Bombeiro removido com sucesso!");
                AtualizarListaBombeiros();
                DataStorage.SaveData(bombeiros, filepath);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um bombeiro para remover.");
            }
        }

        /// <summary>
        /// Atualiza a lista de bombeiros exibida no formulário.
        /// </summary>
        public void AtualizarListaBombeiros()
        {
            listBoxBombeiros.Items.Clear();
            foreach (var bombeiro in bombeiros)
            {
                listBoxBombeiros.Items.Add($"{bombeiro.Nome} - {bombeiro.DataNasc:dd/MM/yyyy}");
            }
        }

        /// <summary>
        /// Evento executado quando o formulário é carregado.
        /// </summary>
        private void FormBombeiro_Load(object sender, EventArgs e)
        {
            AtualizarListaBombeiros();
        }

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar um bombeiro à corporação.
        /// </summary>
        private void btnAdicionarACorpBomb_Click(object sender, EventArgs e)
        {
            if (listBoxBombeiros.SelectedIndex >= 0)
            {
                Bombeiro bombeiroSelecionado = bombeiros[listBoxBombeiros.SelectedIndex];

                if (!corporacao.Bombeiros.Contains(bombeiroSelecionado))
                {
                    corporacao.AddBombeiro(bombeiroSelecionado);
                    MessageBox.Show("Bombeiro adicionado à corporação com sucesso!");
                }
                else
                {
                    MessageBox.Show("Este bombeiro já está na corporação.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um bombeiro para adicionar à corporação.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para sair.
        /// </summary>
        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            DataStorage.SaveData(bombeiros, filepath);
            AtualizaFormularios.AtualizaTodosOsFormularios();
        }

        /// <summary>
        /// Salva as alterações quando o formulário é fechado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBombeiro_FormClosing(Object sender, FormClosingEventArgs e)
        {
            DataStorage.SaveData(bombeiros, filepath);
            AtualizaFormularios.AtualizaTodosOsFormularios();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Evento executado ao alterar o conteúdo do campo de nome para ativar o botão de adicionar.
        /// </summary>
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = !string.IsNullOrEmpty(txtNome.Text);
        }
        #endregion
    }
}
