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
    /// Formulario que gere viaturas
    /// </summary>
    public partial class FormViatura : Form
    {
        #region Private Properties
        private List<Viatura> viaturas;

        /// <summary>
        /// Caminho do arquivo JSON para armazenamento das viaturas.
        /// </summary>
        private const string filepath = "viaturas.json";
        #endregion

        #region Constructors
        public FormViatura()
        {
            InitializeComponent();

            comboBoxTipoEquipamento.DataSource = Enum.GetValues(typeof(TipoEquipamento));

            // Carregar as viaturas do arquivo JSON
            try
            {
                viaturas = DataStorage.LoadData<List<Viatura>>(filepath);
            }
            catch (FileNotFoundException)
            {
                viaturas = new List<Viatura>();  // Caso o arquivo não seja encontrado, cria uma lista vazia
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}");
                viaturas = new List<Viatura>();  // Em caso de erro, também cria uma lista vazia
            }
        }
        #endregion

        #region Event Handlers

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar uma viatura.
        /// </summary>
        private void btnAdicionarViatura_Click(object sender, EventArgs e)
        {
            TipoEquipamento tipo = (TipoEquipamento)comboBoxTipoEquipamento.SelectedItem;
            string matricula = txtMatricula.Text;

            if (!string.IsNullOrEmpty(matricula))
            {
                Viatura novaViatura = new Viatura(tipo, matricula);
                viaturas.Add(novaViatura);
                MessageBox.Show("Viatura adicionada com sucesso!");
                comboBoxTipoEquipamento.Refresh();
                txtMatricula.Clear();
                AtualizarListaViatura();
                DataStorage.SaveData(viaturas, filepath);  // Salva os dados após adicionar a viatura
            }
            else
            {
                MessageBox.Show("Por favor, insira todos os dados da viatura.");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão para remover uma viatura.
        /// </summary>
        private void btnRemoverViatura_Click(object sender, EventArgs e)
        {
            if (listBoxViaturas.SelectedIndex >= 0)
            {
                viaturas.RemoveAt(listBoxViaturas.SelectedIndex);  // Remove a viatura selecionada
                DataStorage.SaveData(viaturas, filepath);  // Salva os dados após a remoção
                MessageBox.Show("Viatura removida com sucesso!");
                AtualizarListaViatura();  // Atualiza a lista exibida
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma viatura para remover.");
            }
        }

        /// <summary>
        /// Atualiza a lista de viaturas exibidas no formulário.
        /// </summary>
        public void AtualizarListaViatura()
        {
            listBoxViaturas.Items.Clear();  // Limpa a lista antes de adicionar novos itens
            foreach (var viatura in viaturas)
            {
                listBoxViaturas.Items.Add($"{viatura.TipoEquipamentoDescricao} - {viatura.Matricula}");
            }
        }

        /// <summary>
        /// Evento executado quando o formulário é carregado.
        /// </summary>
        private void FormViatura_Load(object sender, EventArgs e)
        {
            AtualizarListaViatura();  // Atualiza a lista ao carregar o formulário
        }

        /// <summary>
        /// Evento executado ao clicar no botão para sair.
        /// </summary>
        private void Sair_Click(object sender, EventArgs e)
        {
            DataStorage.SaveData(viaturas, filepath);
            this.Close();  // Fecha o formulário
        }

        /// <summary>
        /// Evento executado ao clicar no botão para adicionar uma viatura ao INEM.
        /// </summary>
        private void btnAdicionarAoINEM_Click(object sender, EventArgs e)
        {
            if (listBoxViaturas.SelectedIndex >= 0)
            {
                Viatura viaturaSelecionada = viaturas[listBoxViaturas.SelectedIndex];  // Pega a viatura selecionada
                INEM.Instance.AddViatura(viaturaSelecionada);  // Adiciona ao INEM
                MessageBox.Show("Viatura adicionada ao INEM com sucesso!");
                AtualizaFormularios.AtualizaTodosOsFormularios();  // Atualiza outros formulários
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma viatura para adicionar ao INEM.");
            }
        }

        private void btnAdicionarAoCorporacao_Click(object sender, EventArgs e)
        {
            if (listBoxViaturas.SelectedIndex >= 0)
            {
                Viatura viaturaSelecionada = viaturas[listBoxViaturas.SelectedIndex];
                Corporacao.Instance.AddViatura(viaturaSelecionada);
                MessageBox.Show("Viatura adicionada à coorporação com sucesso");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma viatura para adicionar à corporação");
            }
        }

        #endregion
    }
}
