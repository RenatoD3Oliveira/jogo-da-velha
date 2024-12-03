using jogo_da_velha.controller;
using System;
using System.Windows.Forms;

namespace jogo_da_velha.view
{
    public partial class Excluir : Form
    {
        private string usuarioNick;
        private Form telaJogo;

        public Excluir(string nick, Form jogoForm)
        {
            InitializeComponent();
            usuarioNick = nick;
            telaJogo = jogoForm;
            labelNome.Text = $"Usuário: {usuarioNick}";
        }

        private void ExcluirUsuario(object sender, EventArgs e)
        {
            string senha = textBoxSenha.Text;

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            bool isDeleted = usuarioDAO.ExcluirUsuario(usuarioNick, senha);

            if (isDeleted)
            {
                MessageBox.Show("Usuário excluído com sucesso!");

                // Fecha a tela de jogo e abre a tela inicial
                telaJogo.Close();
                this.Close();

                // Abre a tela inicial
                Inicial telaInicial = new Inicial();
                telaInicial.Show();
            }
            else
            {
                MessageBox.Show("Senha incorreta. Tente novamente.");
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário de confirmação
        }
    }
}
