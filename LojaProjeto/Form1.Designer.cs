namespace LojaProjeto
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label3 = new Label();
            btn_cadastro = new Button();
            btn_login = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_Senha = new TextBox();
            txt_Usuario = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_cadastro);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_Senha);
            panel1.Controls.Add(txt_Usuario);
            panel1.Location = new Point(170, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 710);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(92, 175);
            label3.Name = "label3";
            label3.Size = new Size(103, 43);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // btn_cadastro
            // 
            btn_cadastro.Cursor = Cursors.Hand;
            btn_cadastro.Location = new Point(92, 514);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(103, 37);
            btn_cadastro.TabIndex = 5;
            btn_cadastro.Text = "Cadastrar";
            btn_cadastro.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(92, 455);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(103, 37);
            btn_login.TabIndex = 4;
            btn_login.Text = "LogIn";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(62, 290);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(62, 370);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Senha";
            // 
            // txt_Senha
            // 
            txt_Senha.BorderStyle = BorderStyle.None;
            txt_Senha.Cursor = Cursors.IBeam;
            txt_Senha.Location = new Point(62, 388);
            txt_Senha.Multiline = true;
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(169, 23);
            txt_Senha.TabIndex = 1;
            // 
            // txt_Usuario
            // 
            txt_Usuario.BorderStyle = BorderStyle.None;
            txt_Usuario.Cursor = Cursors.IBeam;
            txt_Usuario.Location = new Point(62, 308);
            txt_Usuario.Multiline = true;
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(169, 23);
            txt_Usuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Captura_de_tela_2025_01_28_075322;
            pictureBox1.Location = new Point(-53, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 178);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(448, 702);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_Senha;
        private TextBox txt_Usuario;
        private Button btn_login;
        private Label label2;
        private Label label1;
        private Button btn_cadastro;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
