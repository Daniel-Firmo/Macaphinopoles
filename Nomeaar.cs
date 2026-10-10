using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jogo
{
    public partial class Nomeaar : Form
    {
        public Nomeaar()
        {
            InitializeComponent();
        }
        string nomePlayer1;
        string nomePlayer2;

        public void button1_Click(object sender, EventArgs e)
        {
            nomePlayer1 = textBox1.Text;
            nomePlayer2 = textBox2.Text;
            Game game = new Game(nomePlayer1, nomePlayer2);
            game.Show();
            this.Hide();
        }

    }
}
