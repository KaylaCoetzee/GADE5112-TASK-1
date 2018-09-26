using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadeAssignment
{
    public partial class Form1 : Form
    {
        Map map = new Map();

        public int tick;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //map.updateMap();
            map.initialiseMap();
            map.generateUnits();
           lblMap.Text = map.redraw();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            lblTimer.Text = tick.ToString();
            //map.updateMap();
            lblMap.Text = map.redraw();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
 
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

    }
}
