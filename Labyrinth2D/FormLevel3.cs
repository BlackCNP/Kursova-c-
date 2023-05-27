using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth2D
{
    public partial class FormLevel3 : Form
    {
        public FormLevel3()
        {
            InitializeComponent();
        }

        private void FormLevel3_Load(object sender, EventArgs e)
        {

        }
        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
             label_key.Visible = true;
            label8.Visible = true;
            Sound.play_start();
        }
        private void finish_game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Ви програли, чи хочете спробувати ще?", "Поразка",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            if (label_key.Visible)
                finish_game();
            else
                label8.Visible = false;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }
}
