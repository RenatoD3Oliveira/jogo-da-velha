using jogo_da_velha.model;
using jogo_da_velha.controller;
using System;
using System.Windows.Forms;

namespace jogo_da_velha.view
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Verificar(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string nick = textBoxNick.Text;
            string senha = textBoxSenha.Text;

            Usuario usuario = new Usuario(nome, nick, senha);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            try
            {
                usuarioDAO.AdicionarUsuario(usuario);
                MessageBox.Show("Usuário cadastrado com sucesso!");

                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário de cadastro
        }
    }
}
