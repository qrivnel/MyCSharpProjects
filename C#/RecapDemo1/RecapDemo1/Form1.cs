﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateBoard();

        }

        private void GenerateBoard()
        {
            Button[,] buttons = new Button[8, 8];
            int left = 0, top = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();

                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.Black;
                    else
                        buttons[i, j].BackColor = Color.White;

                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    left += 50;
                    buttons[i, j].Top = top;
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}
