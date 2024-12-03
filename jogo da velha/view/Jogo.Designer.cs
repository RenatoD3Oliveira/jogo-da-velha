namespace jogo_da_velha.view
{
    partial class Jogo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelPontos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFundo = new System.Windows.Forms.Panel();
            this.buttonClick = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelPontos = new System.Windows.Forms.Label();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.LightGreen;  // Define a cor de fundo
            this.panelFundo.Controls.Add(this.buttonClick);
            this.panelFundo.Controls.Add(this.buttonSair);
            this.panelFundo.Controls.Add(this.buttonExcluir);
            this.panelFundo.Controls.Add(this.labelPontos);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(400, 400);
            this.panelFundo.TabIndex = 0;
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(100, 100);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(200, 50);
            this.buttonClick.TabIndex = 0;
            this.buttonClick.Text = "Clique aqui";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Click += new System.EventHandler(this.click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(100, 170);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(200, 50);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.sair);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(100, 240);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(200, 50);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir Usuário";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.excluir);
            // 
            // labelPontos
            // 
            this.labelPontos.AutoSize = true;
            this.labelPontos.Font = new System.Drawing.Font("Arial", 14F);
            this.labelPontos.Location = new System.Drawing.Point(100, 50);
            this.labelPontos.Name = "labelPontos";
            this.labelPontos.Size = new System.Drawing.Size(78, 22);
            this.labelPontos.TabIndex = 3;
            this.labelPontos.Text = "Pontos: 0";
            // 
            // Jogo
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panelFundo);
            this.Name = "Jogo";
            this.Text = "Tela de Jogo";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
