//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------
using TrabalhoPOO_12559_Fase1.Modelos;
using TrabalhoPOO_12559_Fase2.Utilitarios;

namespace TrabalhoPOO_12559_Fase2
{
    /// <summary>
    /// Formulário para gerir a corporação.
    /// </summary>
    public partial class FormCorporacao : Form
    {
        #region Private Properties

        /// <summary>
        /// Representa a corporação de bombeiros.
        /// </summary>
        private Corporacao corporacao;
        private Ocorrencia ocorrencia;

        /// <summary>
        /// Caminho do arquivo JSON para armazenamento da corporação.
        /// </summary>
        private const string filepath = "corporacao.json";

        public List<Bombeiro> BombeirosSelecionados { get; private set; } = new List<Bombeiro>();
        public List<Viatura> ViaturasSelecionadas { get; private set; } = new List<Viatura>();

        public IEnumerable<object> MeiosSelecionados { get; internal set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="FormCorporacao"/> e carrega os dados.
        /// </summary>
        public FormCorporacao()
        {
            InitializeComponent();

            // Carregar os dados da corporação a partir do arquivo JSON, se existir.
            try
            {
                corporacao = DataStorage.LoadData<Corporacao>(filepath);
            }
            catch (FileNotFoundException)
            {
                corporacao = new Corporacao(); // Caso o arquivo não exista, cria uma nova corporação.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}");
                corporacao = new Corporacao();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Atualiza a lista de viaturas e bombeiros exibida no formulário.
        /// </summary>
        public void AtualizarLista()
        {
            listBoxCorpViaturas.Items.Clear();
            listBoxCorpBombeiros.Items.Clear();

            // Atualiza a lista de viaturas.
            foreach (var viatura in corporacao.Viaturas)
            {
                listBoxCorpViaturas.Items.Add($"Viatura: {viatura.Matricula}, Tipo: {viatura.TipoEquipamento}");
            }

            // Atualiza a lista de bombeiros.
            foreach (var bombeiro in corporacao.Bombeiros)
            {
                listBoxCorpBombeiros.Items.Add($"Bombeiro: {bombeiro.Nome}, Data Nascimento: {bombeiro.DataNasc.ToShortDateString()}");
            }
        }

        /// <summary>
        /// Evento executado quando o formulário é carregado.
        /// </summary>
        private void FormCorporacao_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        /// <summary>
        /// Salva as alterações quando o formulário é fechado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBombeiro_FormClosing(Object sender, FormClosingEventArgs e)
        {
            DataStorage.SaveData(corporacao, filepath);
            AtualizaFormularios.AtualizaTodosOsFormularios();
        }

        /// <summary>
        /// Método para remover itens usado em vários botões
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <param name="listBox"></param>
        /// <param name="atualizarLista"></param>
        /// <param name="filepath"></param>
        private void RemoverItem<T>(List<T> lista, ListBox listBox, Action atualizarLista, string filepath)
        {
            if (listBox.SelectedIndex >= 0)
            {
                lista.RemoveAt(listBox.SelectedIndex);  // Remove o item selecionado da lista
                MessageBox.Show($"{listBox.SelectedItem} removido com sucesso!");  // Exibe a mensagem de sucesso
                atualizarLista();  // Atualiza a lista exibida
                DataStorage.SaveData(corporacao, filepath);  // Salva os dados no arquivo
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item para remover.");  // Caso não haja item selecionado
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Evento executado ao clicar em "Adicionar Viatura".
        /// </summary>
        private void btnAdicionarViatura_Click(object sender, EventArgs e)
        {
            // Passa de corporação para o formulário de viaturas.
            FormViatura formViatura = new FormViatura();
            formViatura.ShowDialog();
        }

        /// <summary>
        /// Evento gerado ao clicar em "Adicionar Bombeiro".
        /// </summary>
        private void btnAdicionarBombeiro_Click(object sender, EventArgs e)
        {
            // Passa de corporação para o formulário de bombeiros.
            FormBombeiro formBombeiro = new FormBombeiro(corporacao);
            formBombeiro.ShowDialog();
        }

        /// <summary>
        /// Evento executado ao clicar em "Remover Bombeiro".
        /// </summary>
        private void btnRemoverBombeiro_Click(object sender, EventArgs e)
        {
            RemoverItem(corporacao.Bombeiros, listBoxCorpBombeiros, AtualizarLista, filepath);
        }

        /// <summary>
        /// Evento disparado ao clicar em "Remover Viatura".
        /// </summary>
        private void btnRemViatCorp_Click(object sender, EventArgs e)
        {
            RemoverItem(corporacao.Viaturas, listBoxCorpViaturas, AtualizarLista, filepath);
        }


        /// <summary>
        /// Evento executado ao clicar no botão de Adicionar à Ocorrência
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBomOcorr_Click(object sender, EventArgs e)
        {
            if (listBoxCorpBombeiros.SelectedIndex >= 0)
            {
                var bombeiroSelecionado = corporacao.Bombeiros[listBoxCorpBombeiros.SelectedIndex];
                if (!BombeirosSelecionados.Contains(bombeiroSelecionado))
                {
                    BombeirosSelecionados.Add(bombeiroSelecionado);
                    MessageBox.Show("Bombeiro adicionado à ocorrência com sucesso!");
                }
                else
                {
                    MessageBox.Show("Este bombeiro já foi adicionado à ocorrência.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um bombeiro para adicionar à ocorrência.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão Adicionar à ocorrência
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddViatOcor_Click(object sender, EventArgs e)
        {
            if (listBoxCorpViaturas.SelectedIndex >= 0)
            {
                var viaturaSelecionada = corporacao.Viaturas[listBoxCorpBombeiros.SelectedIndex];
                if (!ViaturasSelecionadas.Contains(viaturaSelecionada))
                {
                    ViaturasSelecionadas.Add(viaturaSelecionada);
                    MessageBox.Show("Viatura adicionada à ocorrência com sucesso!");
                }
                else
                {
                    MessageBox.Show("Esta viatura já foi adicionado à ocorrência.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma viatura para adicionar à ocorrência.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para sair.
        /// </summary>
        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            DataStorage.SaveData(corporacao, filepath);
            AtualizaFormularios.AtualizaTodosOsFormularios();
        }

        #endregion
    }

}
