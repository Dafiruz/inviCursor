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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int xLimite, yLimite;
        Random randomGenerator = new Random();
        int start = 0;

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

        int loss = 1;
        int score = 0;

        private void Form3_Leave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void picTarget_Click_1(object sender, EventArgs e)
        {
            xLimite = this.Width - picTarget.Width;
            yLimite = this.Height - picTarget.Height;
            MoverBotao();
            start = 1;
            if (progressBar1.Value > 0)
            {
                time.Start();
            }
            else
            {
                time.Stop();
            }
            //System.Media.SoundPlayer Break = new System.Media.SoundPlayer(@"F:\Daniel\Escola\PSI\InvisibleCursor\Invisible Cursor\Invisible Cursor\Resources\Break.wav");
            //Break.Play();
            if (loss != 0)
            {
                score += 10;
            }
            textBox1.Text = score.ToString();
            if (loss == 0)
            {
                start = 0;
                time.Stop();
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 1;
            if (progressBar1.Value <= 0)
            {
                Cursor.Show();
                loss = 0;
                time.Stop();
                MessageBox.Show("Acabou o Tempo, a sua pontuação foi " + score, "Pontuação Final");
            }
        }

        private void picTarget_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            loss = 0;
            Cursor.Show();
            time.Stop();
            //System.Media.SoundPlayer Hit = new System.Media.SoundPlayer(@"F:\Daniel\Escola\PSI\InvisibleCursor\Invisible Cursor\Invisible Cursor\Resources\Hit.wav");
            //Hit.Play();
            MessageBox.Show("Falhou o Alvo, a sua pontuação foi " + score + " Tempo que não usou: " + progressBar1.Value, "Pontuação Final", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            if (loss == 0 && start == 0)
            {
                Cursor.Show();
            }
            else
            {
                Cursor.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (loss == 1)
            {
                score += 1;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loss = 1;
            score = 0;
        }
    }
}
