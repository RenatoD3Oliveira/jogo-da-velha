namespace jogo_da_velha.view
{
    partial class Excluir
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;

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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.LightCoral;  // Define a cor de fundo
            this.panelFundo.Controls.Add(this.labelTitulo);
            this.panelFundo.Controls.Add(this.labelNome);
            this.panelFundo.Controls.Add(this.labelSenha);
            this.panelFundo.Controls.Add(this.textBoxSenha);
            this.panelFundo.Controls.Add(this.buttonConfirmar);
            this.panelFundo.Controls.Add(this.buttonCancelar);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(350, 250);
            this.panelFundo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(20, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(310, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Confirmar Exclusão";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(20, 80);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(200, 24);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Usuário: {usuarioNick}";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 10F);
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(20, 130);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(58, 20);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(20, 160);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(280, 22);
            this.textBoxSenha.TabIndex = 3;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(20, 200);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(100, 30);
            this.buttonConfirmar.TabIndex = 4;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.ExcluirUsuario);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(200, 200);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 30);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // Excluir
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.panelFundo);
            this.Name = "Excluir";
            this.Text = "Confirmar Exclusão";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
