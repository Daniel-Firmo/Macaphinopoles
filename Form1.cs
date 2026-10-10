namespace Jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        public void button1_Click(object sender, EventArgs e)
        {

            Nomeaar nomear = new Nomeaar();
            nomear.Show();
            this.Hide();
        }
    }
}
