using jogo_da_velha.model;
using jogo_da_velha.controller;
using System;
using System.Windows.Forms;

namespace jogo_da_velha.view
{
    public partial class Login : Form
    {
        private bool isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
        }

        private void usuario(object sender, EventArgs e)
        {
            // Adicione lógica aqui, se necessário
        }

        private void password(object sender, EventArgs e)
        {
            // Adicione lógica aqui, se necessário
        }

        private void entrar(object sender, EventArgs e)
        {
            VerificarLogin();
        }

        private void VerificarLogin()
        {
            string nick = textBox1.Text;  // Usar .Text para obter o valor do TextBox
            string senha = textBox2.Text; // Usar .Text para obter o valor do TextBox

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            try
            {
                bool isValidUser = usuarioDAO.VerificarUsuario(nick, senha);

                if (isValidUser)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    // Abrir a tela de Jogo
                    Jogo jogoForm = new Jogo(nick); // Passar o nick do usuário para a tela de Jogo
                    jogoForm.Show();
                    this.Hide(); // Esconde a tela de Login
                }
                else
                {
                    MessageBox.Show("Nick ou senha incorretos. Tente novamente.");
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Erro ao verificar login: " + ex.Message);
            }
        }

        private void togglePasswordVisibility(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                textBox2.PasswordChar = '*';
                isPasswordVisible = false;
            }
            else
            {
                textBox2.PasswordChar = '\0';
                isPasswordVisible = true;
            }
        }
    }
}
