﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crossword
{
    public partial class Clues : Form
    {

        public Clues()
        {
            InitializeComponent();
        }

        private void Clues_LocationChanged(object sender, EventArgs e)
        {

        }

        private void clue_board_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Clues_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void Clues_Load(object sender, EventArgs e)
        {

        }

        private void Clues_Resize(object sender, EventArgs e)
        {
            
        }

        private void Clues_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
