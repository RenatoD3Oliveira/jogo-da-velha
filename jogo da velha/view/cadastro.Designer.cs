namespace jogo_da_velha.view
{
    partial class Cadastro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonCadastrar;
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
            this.labelNick = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.LightSkyBlue;  // Define a cor de fundo
            this.panelFundo.Controls.Add(this.labelTitulo);
            this.panelFundo.Controls.Add(this.labelNome);
            this.panelFundo.Controls.Add(this.textBoxNome);
            this.panelFundo.Controls.Add(this.labelNick);
            this.panelFundo.Controls.Add(this.textBoxNick);
            this.panelFundo.Controls.Add(this.labelSenha);
            this.panelFundo.Controls.Add(this.textBoxSenha);
            this.panelFundo.Controls.Add(this.buttonCadastrar);
            this.panelFundo.Controls.Add(this.buttonCancelar);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(400, 400);
            this.panelFundo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(60, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(280, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Cadastro de Usuário";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 10F);
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(60, 100);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(60, 130);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(280, 22);
            this.textBoxNome.TabIndex = 2;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Arial", 10F);
            this.labelNick.ForeColor = System.Drawing.Color.White;
            this.labelNick.Location = new System.Drawing.Point(60, 170);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(42, 20);
            this.labelNick.TabIndex = 3;
            this.labelNick.Text = "Nick:";
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(60, 200);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(280, 22);
            this.textBoxNick.TabIndex = 4;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 10F);
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(60, 240);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(58, 20);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(60, 270);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(280, 22);
            this.textBoxSenha.TabIndex = 6;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(60, 320);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(120, 40);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.Verificar);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(220, 320);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 40);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // Cadastro
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panelFundo);
            this.Name = "Cadastro";
            this.Text = "Cadastro de Usuário";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
