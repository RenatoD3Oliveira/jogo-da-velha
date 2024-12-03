using jogo_da_velha.controller;
using jogo_da_velha.model;
using System;
using System.Windows.Forms;

namespace jogo_da_velha.view
{
    public partial class Jogo : Form
    {
        private int pontos;
        private UsuarioDAO usuarioDAO;
        private string usuarioNick;

        public Jogo(string nick)
        {
            InitializeComponent();
            usuarioNick = nick;
            usuarioDAO = new UsuarioDAO();
            pontos = usuarioDAO.ObterPontos(usuarioNick);
            labelPontos.Text = "Pontos: " + pontos;
        }

        private void click(object sender, EventArgs e)
        {
            pontos++;
            labelPontos.Text = "Pontos: " + pontos;
            usuarioDAO.AtualizarPontos(usuarioNick, pontos);
        }

        private void sair(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo inteiro
        }

        private void excluir(object sender, EventArgs e)
        {
            Excluir confirmForm = new Excluir(usuarioNick, this);
            confirmForm.ShowDialog();
        }
    }
}
