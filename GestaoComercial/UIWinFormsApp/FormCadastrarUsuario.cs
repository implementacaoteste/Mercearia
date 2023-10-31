﻿using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormCadastrarUsuario : Form
    {
        private int id;
        public FormCadastrarUsuario(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id == 0)
                bindingSourceCadastro.AddNew();
            else
                bindingSourceCadastro.DataSource = new UsuarioBLL().BuscarPorId(id);
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.EndEdit();
                Usuario usuario = (Usuario)bindingSourceCadastro.Current;

                if (id == 0)
                    new UsuarioBLL().Inserir(usuario, textBoxConfirmacaoSenha.Text);
                else
                    new UsuarioBLL().Alterar(usuario, textBoxConfirmacaoSenha.Text);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}