using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    public class Player : PictureBox
    {
        public int Velocidade { get; set; } = 10;
        private string nome;
        public string caminhoImagem { get; set; } = "";
        public Keys[] teclas = new Keys[4]; 



        public Player(int jogador)
        {



            if (jogador == 1)
            {
                this.teclas[0] = Keys.W;
                this.teclas[1] = Keys.A;
                this.teclas[2] = Keys.D;
                this.teclas[3] = Keys.S;
                this.caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "player.png"
                );
            }
            else
            {
                this.teclas[0] = Keys.Up;
                this.teclas[1] = Keys.Left;
                this.teclas[2] = Keys.Right;
                this.teclas[3] = Keys.Down;
                this.caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "player2.png"
                );
            }
            Bitmap imagem = new Bitmap(this.caminhoImagem);
            imagem.MakeTransparent(Color.White);

            this.Image = imagem;
            
            this.BackColor = Color.Transparent;
            this.Size = new Size(200, 200);
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            
            Image = Image.FromFile(this.caminhoImagem);
            this.DoubleBuffered = true;
            
        }
        public void Mover(Keys tecla, int larguraTela, int alturaTela)
        {
            if (tecla == this.teclas[0])
            {
                //Top = Top - Velocidade;
                Top -= Velocidade;
                Parent.Invalidate();
                Parent.Update();
                //verifica se saiu pela parte de cima da tela
                if (Top + Height < 0)
                {
                    Top = alturaTela; // posicao na parte de baixo da tela
                    Parent.Invalidate();
                    Parent.Update();
                }
            }
            if (tecla == this.teclas[1]) // mover pra esquerda
            {
                Left -= Velocidade;
                Parent.Invalidate();
                Parent.Update();
                //verifica se saiu pela parte esquerda da tela
                if (Left + Width < 0)
                {
                    Left = larguraTela;
                    Parent.Invalidate();
                    Parent.Update();// posicao na parte direita da tela
                }
            }
            if (tecla == this.teclas[2]) // mover pra direita
            {
                Left += Velocidade;
                Parent.Invalidate();
                Parent.Update();
                //verifica se saiu pela parte direita da tela
                if (Left > larguraTela)
                {
                    Left = -Width; // posicao na parte esquerda da tela
                    Parent.Invalidate();
                    Parent.Update();
                }

            }
            if (tecla == this.teclas[3]) // mover pra baixo
            {
                Top += Velocidade;
                Parent.Invalidate();
                Parent.Update();
                //verifica se saiu pela parte de baixo da tela
                if (Top > alturaTela)
                {
                    Top = -Height; // posicao na parte cima da tela
                    Parent.Invalidate();
                    Parent.Update();

                }
            }
        }


        private string secret(String nome) { 
            String nnome = "Loud " + nome;
            


            return nnome;
        }

        public void setNome(String nome) {
            this.nome = secret(nome);
        }

        public String Nomar() {
        
            return this.nome;
        }
    }
}