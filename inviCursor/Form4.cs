using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inviCursor
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int xLimite, yLimite;
        Random randomGenerator = new Random();
        private void picTarget_Click(object sender, EventArgs e)
        {
            xLimite = this.Width - picTarget.Width;
            yLimite = this.Height - picTarget.Height;
            MoverBotao();
            if (progressBar1.Value > 0)
            {
                time.Start();
            }
            else
            {
                time.Stop();
            }
            System.Media.SoundPlayer Break = new System.Media.SoundPlayer(@"F:\Daniel\Escola\PSI\InvisibleCursor\Invisible Cursor\Invisible Cursor\Resources\Break.wav");
            Break.Play();
            if (loss != 0)
            {
                score += 10;
            }
            //txtScore.Text = score.ToString();
        }
        private void MoverBotao()
        {
            int[] num = NumRandom();
            picTarget.Location = new Point(num[0], num[1]);
        }
        private int[] NumRandom() // Melhorar Isto <------------------------------------------------
        {
            int[] RandomNum = new int[2];
            RandomNum[0] = randomGenerator.Next(0, xLimite);
            RandomNum[1] = randomGenerator.Next(0, yLimite);
            if (RandomNum[0] >= 10 && RandomNum[0] <= 430 && RandomNum[1] >= 10 && RandomNum[1] <= 260)
            {
                return RandomNum;
            }
            else
            {
                NumRandom();
            }
            return RandomNum;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 1;
            if (progressBar1.Value <= 0)
            {
                //Cursor.Show();
                loss = 0;
                time.Stop();
                MessageBox.Show("Acabou o Tempo, a sua pontuação foi " + score, "Pontuação Final");
            }
        }

        private void picTarget_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Show();
        }

        int loss = 1;
        int score = 0;
        int start = 0;

        private void Form4_Load(object sender, EventArgs e)
        {
            loss = 1;
            //Cursor.Hide();
            score = 0;
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            loss = 0;
            //Cursor.Show();
            time.Stop();
            System.Media.SoundPlayer Hit = new System.Media.SoundPlayer(@"F:\Daniel\Escola\PSI\InvisibleCursor\Invisible Cursor\Invisible Cursor\Resources\Hit.wav");
            Hit.Play();
            MessageBox.Show("Falhou o Alvo, a sua pontuação foi " + score + " Tempo que não usou: " + progressBar1.Value, "Pontuação Final", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Form4_MouseEnter(object sender, EventArgs e)
        {
            if (loss == 0)
            {
                //Cursor.Show();
            }
            else
            {
                //Cursor.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (loss != 0)
            {
                score += 1;
            }
        }

        private void picTarget2_Click(object sender, EventArgs e)
        {
            xLimite = this.Width - picTarget2.Width;
            yLimite = this.Height - picTarget2.Height;
            MoverBotao2();
            if (progressBar1.Value > 0)
            {
                time.Start();
            }
            else
            {
                time.Stop();
            }
            System.Media.SoundPlayer Break = new System.Media.SoundPlayer(@"F:\Daniel\Escola\PSI\InvisibleCursor\Invisible Cursor\Invisible Cursor\Resources\Break.wav");
            Break.Play();
            if (loss != 0)
            {
                score += 10;
            }
            //txtScore.Text = score.ToString();
        }

        private void picTarget2_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Show();
        }

        private void MoverBotao2()
        {
            int[] num = NumRandom();
            picTarget2.Location = new Point(num[0], num[1]);
        }

        private void picTarget3_Click(object sender, EventArgs e)
        {
            xLimite = this.Width - picTarget3.Width;
            yLimite = this.Height - picTarget3.Height;
            MoverBotao3();
            if (progressBar1.Value > 0)
            {
                time.Start();
            }
            else
            {
                time.Stop();
            }
            System.Media.SoundPlayer Break = new System.Media.SoundPlayer(@"F:\Daniel\Escola\PSI\InvisibleCursor\Invisible Cursor\Invisible Cursor\Resources\Break.wav");
            Break.Play();
            if (loss != 0)
            {
                score += 10;
            }
            //txtScore.Text = score.ToString();
        }
        private void MoverBotao3()
        {
            int[] num = NumRandom();
            picTarget3.Location = new Point(num[0], num[1]);
        }

        private void picTarget3_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Show();
        }

        private void Form4_Leave(object sender, EventArgs e)
        {
            //Cursor.Show();
        }
    }
}
