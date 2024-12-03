namespace jogo_da_velha.view
{
    partial class Inicial
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.Label labelTitulo;

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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 128, 255);
            this.labelTitulo.Location = new System.Drawing.Point(50, 30);  // Ajustar a posição conforme necessário
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(300, 46);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Bem-vindo ao Jogo";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(100, 100);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(200, 50);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.Logim);
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Location = new System.Drawing.Point(100, 180);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(200, 50);
            this.buttonCadastro.TabIndex = 2;
            this.buttonCadastro.Text = "Cadastrar";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.criarconta);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCadastro);
            this.Name = "Inicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
