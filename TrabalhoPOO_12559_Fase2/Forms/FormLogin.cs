//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------
using System.Security.Cryptography;
using System.Text;

namespace TrabalhoPOO_12559_Fase2
{
    /// <summary>
    /// formulário de login.
    /// </summary>
    public partial class FormLogin : Form
    {
        #region Private Properties

        private const string FilePath = "utilizadores.txt";

        #endregion

        #region Constructor
        /// <summary>
        /// Inicia o Formulário Login
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers
        /// <summary>
        /// Evento executado ao clicar no botão de entrada.
        /// </summary>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string utilizador = txtUtilizador.Text.Trim();
            string senha = txtSenha.Text.Trim();

            try
            {
                // Lógica para autenticação do utilizador
                if (AutenticarUtilizador(utilizador, senha))
                {
                    MessageBox.Show("Login com sucesso!");
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Utilizador ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar login: {ex.Message}");
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão de registo.
        /// </summary>
        private void btnRegisto_Click(object sender, EventArgs e)
        {
            string utilizador = txtUtilizador.Text.Trim();
            string senha = txtSenha.Text.Trim();

            try
            {
                // Lógica para registar o utilizador
                if (RegistarUtilizador(utilizador, senha))
                {
                    MessageBox.Show("Utilizador registado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao registar utilizador.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar registar utilizador: {ex.Message}");
            }
        }

        /// <summary>
        /// Autentica o utilizador e verifica se as credenciais estão corretas.
        /// </summary>
        private bool AutenticarUtilizador(string utilizador, string senha)
        {
            if (string.IsNullOrWhiteSpace(utilizador) || string.IsNullOrWhiteSpace(senha))
                return false;

            if (!File.Exists(FilePath))
                return false;

            var utilizadores = File.ReadAllLines(FilePath)
                .Select(line => line.Split(','))
                .ToDictionary(parts => parts[0], parts => parts[1]);

            // Gerar o hash da senha para comparar com o armazenado
            string senhaHash = GerarHashSenha(senha);

            return utilizadores.ContainsKey(utilizador) && utilizadores[utilizador] == senhaHash;
        }

        /// <summary>
        /// Regista um novo utilizador armazenando as suas credenciais.
        /// </summary>
        private bool RegistarUtilizador(string utilizador, string senha)
        {
            if (string.IsNullOrWhiteSpace(utilizador) || string.IsNullOrWhiteSpace(senha))
                return false;

            var utilizadores = new Dictionary<string, string>();

            if (File.Exists(FilePath))
            {
                utilizadores = File.ReadAllLines(FilePath)
                    .Select(line => line.Split(','))
                    .ToDictionary(parts => parts[0], parts => parts[1]);

                if (utilizadores.ContainsKey(utilizador))
                    return false; // Utilizador já existe
            }

            // Gerar o hash da senha para armazenar de forma segura
            string senhaHash = GerarHashSenha(senha);

            try
            {
                using (var sw = new StreamWriter(FilePath, true))
                {
                    sw.WriteLine($"{utilizador},{senhaHash}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gera o hash da senha para armazenamento seguro.
        /// </summary>
        private string GerarHashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Evento executado ao carregar o formulário.
        /// </summary>
        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
    }
    #endregion
}
