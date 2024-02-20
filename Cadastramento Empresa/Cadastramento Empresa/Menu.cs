namespace Cadastramento_Empresa
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.ShowDialog();
        }
    }
}