using System;
using System.Windows.Forms;

namespace jogo_da_velha.view
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void criarconta(object sender, EventArgs e)
        {
            this.Hide();  // Esconde a tela principal
            Cadastro cadastro = new Cadastro();
            cadastro.FormClosed += (s, args) => this.Show();  // Mostra a tela inicial novamente apenas quando o formulário de cadastro é fechado
            cadastro.Show();
        }

        private void Logim(object sender, EventArgs e)
        {
            this.Hide();  // Esconde a tela principal
            Login logim = new Login();
            logim.FormClosed += (s, args) => this.Show();  // Mostra a tela inicial novamente apenas quando o formulário de login é fechado
            logim.Show();
        }
    }
}
