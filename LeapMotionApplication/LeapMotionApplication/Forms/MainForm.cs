using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeapMotionApplication.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            Frames frames = new Frames();
            frames.Show();
            
        }

        private void butFE_Click(object sender, EventArgs e)
        {
            FirstExperiment firstExperiment = new FirstExperiment();
            firstExperiment.Show();
        }

        private void butSE_Click(object sender, EventArgs e)
        {
            SecondExperiment secondExperiment = new SecondExperiment();
            secondExperiment.Show();
        }
    }
}
