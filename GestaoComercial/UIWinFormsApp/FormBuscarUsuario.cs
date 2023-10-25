﻿using BLL;

namespace UIWinFormsApp
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarPorNomeUsuario(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
