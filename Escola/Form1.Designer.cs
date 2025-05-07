namespace Escola
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
            btnConexao = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtId = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(713, 27);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(75, 23);
            btnConexao.TabIndex = 0;
            btnConexao.Text = "connection";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 90);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(133, 108);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 70);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 108);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 140);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 179);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 1;
            label5.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(133, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(133, 176);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(78, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 70);
            txtId.Name = "txtId";
            txtId.Size = new Size(78, 23);
            txtId.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(133, 241);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnConexao);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConexao;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtId;
        private Button btnCadastrar;
    }
}
