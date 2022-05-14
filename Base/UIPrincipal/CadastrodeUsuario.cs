using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show(" Cadastro Relizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocorreu um erro" + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new   UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo =ativoCheckBox.Checked;
           
            usuarioBLL.Inserir(usuario);
                
                }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
