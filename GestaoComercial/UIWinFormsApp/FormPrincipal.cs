namespace UIWinFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usu�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }
        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();

                if (!frm.Autenticou)
                    this.Close();
            }
        }
    }
}