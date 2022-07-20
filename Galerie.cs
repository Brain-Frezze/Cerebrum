﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerebrum
{
    public partial class Galerie : Form
    {
        int nrimagine = 1;
        public Galerie()
        {
            InitializeComponent();
            schimbaimaginea(nrimagine);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Înapoi(object sender, EventArgs e)
        {
            nrimagine -= 1;
            if (nrimagine < 1)
            {
                nrimagine = 10;
            }
            schimbaimaginea(nrimagine);
        }

        private void Înainte(object sender, EventArgs e)
        {
            nrimagine += 1;
            if (nrimagine > 10)
            {
                nrimagine = 1;
            }
            schimbaimaginea(nrimagine);
        }
        private void schimbaimaginea(int nr)
        {
            switch (nr)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._01;
                    label1.Text = "Nervul olfactiv (I)";
                break;
                case 2:
                    pictureBox1.Image = Properties.Resources._02;
                    label1.Text = "Nervul optic (II) şi calea vizuală";
                break;
                case 3:
                    pictureBox1.Image = Properties.Resources._03;
                    label1.Text = "Nervii oculomotor(III), trohlear (IV) şi abducens (VI)";
                break;
                case 4:
                    pictureBox1.Image = Properties.Resources._04;
                    label1.Text = "Nervul trigemen (V)";
                break;
                case 5:
                    pictureBox1.Image = Properties.Resources._05;
                    label1.Text = "Nervul facial (VII)";
                break;
                case 6:
                    pictureBox1.Image = Properties.Resources._06;
                    label1.Text = "Nervul vestibulocohlear (VIII)";
                break;
                case 7:
                    pictureBox1.Image = Properties.Resources._07;
                    label1.Text = "Nervul glosofaringian (IX)";
                break;
                case 8:
                    pictureBox1.Image = Properties.Resources._08;
                    label1.Text = "Nervul vag (X)";
                break;
                case 9:
                    pictureBox1.Image = Properties.Resources._09;
                    label1.Text = "Nervul accesor (XI)";
                break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    label1.Text = "Nervul hipoglos (XII)";
                break;
            }
        }
    }
}
