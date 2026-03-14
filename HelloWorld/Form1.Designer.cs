namespace HelloWorld
{
    partial class Form1
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
            kullanıcı_adı = new TextBox();
            sifre = new TextBox();
            sifre_tekrar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // kullanıcı_adı
            // 
            kullanıcı_adı.Location = new Point(280, 79);
            kullanıcı_adı.Name = "kullanıcı_adı";
            kullanıcı_adı.Size = new Size(152, 23);
            kullanıcı_adı.TabIndex = 2;
            // 
            // sifre
            // 
            sifre.Location = new Point(280, 119);
            sifre.Name = "sifre";
            sifre.PasswordChar = '*';
            sifre.Size = new Size(149, 23);
            sifre.TabIndex = 2;
            sifre.UseSystemPasswordChar = true;
            // 
            // sifre_tekrar
            // 
            sifre_tekrar.Location = new Point(280, 165);
            sifre_tekrar.Name = "sifre_tekrar";
            sifre_tekrar.PasswordChar = '*';
            sifre_tekrar.Size = new Size(149, 23);
            sifre_tekrar.TabIndex = 2;
            sifre_tekrar.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 82);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 127);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Sifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 168);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Sifre Tekrar";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(357, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_kaydet_click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(161, 218);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 5;
            label4.Text = "label4";
            label4.UseCompatibleTextRendering = true;
            label4.Visible = false;
            // 
            // Form1
            // 
            ClientSize = new Size(716, 460);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sifre_tekrar);
            Controls.Add(sifre);
            Controls.Add(kullanıcı_adı);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox kullanıcı_adı;
        private TextBox sifre;
        private TextBox sifre_tekrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}
