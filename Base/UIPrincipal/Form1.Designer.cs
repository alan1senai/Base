
namespace UIPrincipal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.button1Salvar = new System.Windows.Forms.Button();
            this.button2Sair = new System.Windows.Forms.Button();
            this.button3CadastrarNovo = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            idLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Salvar
            // 
            this.button1Salvar.Location = new System.Drawing.Point(12, 634);
            this.button1Salvar.Name = "button1Salvar";
            this.button1Salvar.Size = new System.Drawing.Size(106, 46);
            this.button1Salvar.TabIndex = 0;
            this.button1Salvar.Text = "Sal&var";
            this.button1Salvar.UseVisualStyleBackColor = true;
            this.button1Salvar.Click += new System.EventHandler(this.button1Salvar_Click);
            // 
            // button2Sair
            // 
            this.button2Sair.Location = new System.Drawing.Point(996, 634);
            this.button2Sair.Name = "button2Sair";
            this.button2Sair.Size = new System.Drawing.Size(106, 46);
            this.button2Sair.TabIndex = 1;
            this.button2Sair.Text = "&Sair";
            this.button2Sair.UseVisualStyleBackColor = true;
            this.button2Sair.Click += new System.EventHandler(this.button2Sair_Click);
            // 
            // button3CadastrarNovo
            // 
            this.button3CadastrarNovo.Location = new System.Drawing.Point(159, 634);
            this.button3CadastrarNovo.Name = "button3CadastrarNovo";
            this.button3CadastrarNovo.Size = new System.Drawing.Size(166, 46);
            this.button3CadastrarNovo.TabIndex = 2;
            this.button3CadastrarNovo.Text = "Salvar e Cadastrar um N&ovo";
            this.button3CadastrarNovo.UseVisualStyleBackColor = true;
            this.button3CadastrarNovo.Click += new System.EventHandler(this.button3_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 147);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(64, 147);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 5;
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(228, 150);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(97, 16);
            nomeUsuarioLabel.TabIndex = 6;
            nomeUsuarioLabel.Text = "Nome Usuario:";
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(331, 147);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(367, 22);
            this.nomeUsuarioTextBox.TabIndex = 7;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(723, 150);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(49, 16);
            senhaLabel.TabIndex = 8;
            senhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(778, 144);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(100, 22);
            this.senhaTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1122, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(956, 146);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(59, 20);
            this.ativoCheckBox.TabIndex = 11;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button3CadastrarNovo);
            this.Controls.Add(this.button2Sair);
            this.Controls.Add(this.button1Salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Salvar;
        private System.Windows.Forms.Button button2Sair;
        private System.Windows.Forms.Button button3CadastrarNovo;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ativoCheckBox;
    }
}

