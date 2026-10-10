

namespace Jogo
{
    public partial class Game : Form
    {
        private Player jogador;
        private Player jogador2;
        public Game(string nome1, string nome2)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            IniciarJogo(nome1, nome2);

        }

        private void IniciarJogo(string nome1, string nome2)
        {
            // Instanciar um objeto Player
            jogador = new Player(1);
            jogador2 = new Player(2);
            // Definir uma posição para o jogador
            jogador.Location = new Point(50, 340);
            jogador2.Location = new Point(290, 340);
            jogador.setNome(nome1);
            jogador2.setNome(nome2);
            label1.Text = jogador.Nomar();
            label8.Text = jogador2.Nomar();
            //Adicionar o Player no formulário
            Controls.Add(jogador);
            Controls.Add(jogador2);
            KeyPreview = true;
            
            KeyDown += Game_KeyDown;

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            jogador.Mover(e.KeyCode, ClientSize.Width, ClientSize.Height);
            jogador2.Mover(e.KeyCode, ClientSize.Width, ClientSize.Height);
            label1.Location = new Point(jogador.Left, jogador.Top -20);
            label8.Location = new Point(jogador2.Left, jogador2.Top -20);
        }
    }
}
