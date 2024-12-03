namespace jogo_da_velha.view
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonTogglePassword;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelSenha;
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonTogglePassword = new System.Windows.Forms.Button();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 1;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(120, 210);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(100, 30);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.entrar);
            // 
            // buttonTogglePassword
            // 
            this.buttonTogglePassword.Location = new System.Drawing.Point(330, 150);
            this.buttonTogglePassword.Name = "buttonTogglePassword";
            this.buttonTogglePassword.Size = new System.Drawing.Size(75, 22);
            this.buttonTogglePassword.TabIndex = 3;
            this.buttonTogglePassword.Text = "Mostrar";
            this.buttonTogglePassword.UseVisualStyleBackColor = true;
            this.buttonTogglePassword.Click += new System.EventHandler(this.togglePasswordVisibility);
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Arial", 10F);
            this.labelNick.Location = new System.Drawing.Point(120, 70);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(41, 19);
            this.labelNick.TabIndex = 4;
            this.labelNick.Text = "Nick";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 10F);
            this.labelSenha.Location = new System.Drawing.Point(120, 130);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(56, 19);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTitulo.Location = new System.Drawing.Point(120, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(192, 40);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Bem-vindo";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.buttonTogglePassword);
            this.Name = "Login";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
