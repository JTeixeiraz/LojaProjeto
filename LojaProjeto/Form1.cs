namespace LojaProjeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Connect bd = new Connect();

        private void Form1_Load(object sender, EventArgs e)
        {
            bd.ConectarBD();
        }
    }
}
