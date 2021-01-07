using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPassaro
{
    public partial class Form1 : Form
    {

        int tuboVelocidade = 8;
        int gravidade = 5;
        int pontuacao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tempoJogoEvent(object sender, EventArgs e)
        {
            passaro.Top += gravidade;
            tubobaixo.Left -= tuboVelocidade;
            tubocima.Left -=tuboVelocidade;
            lblpontos.Text = "Pontos: "+pontuacao.ToString();

            if(tubobaixo.Left < -50)
            {
                tubobaixo.Left = 600;
                pontuacao++;
            }
            if(tubocima.Left < -80)
            {
                tubocima.Left = 750;
                pontuacao++;
            }

            if (passaro.Bounds.IntersectsWith(tubobaixo.Bounds) || passaro.Bounds.IntersectsWith(tubocima.Bounds) || passaro.Bounds.IntersectsWith(terra.Bounds) || passaro.Top<-25)   
            {
                fimJogo();
            }

            if(pontuacao >5 )
            {
                tuboVelocidade = 15;
            }

     
        }

        private void jogochavebaixo(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravidade = -5;

            }
        }

        private void jogochavecima(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravidade = 5;

            }           

        }

        private void fimJogo()
        {
            tempoJogo.Stop();
            lblpontos.Text += " Fim do jogo!";
            
        }
    }
}
