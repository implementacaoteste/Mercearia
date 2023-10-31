using BLL;

namespace UIWinFormsApp
{
    public partial class FormLogin : Form
    {
        public bool Autenticou;
        public FormLogin()
        {
            InitializeComponent();
            Autenticou = false;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().Autenticar(textBox1.Text, textBox2.Text);
                Autenticou = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
