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
    public partial class FormLevel5 : Form
    {
        int left_boxes;
        public FormLevel5()
        {
            InitializeComponent();
        }
        private void start_game()
        {
            
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            left_boxes = 4;
            label_box.Visible= true;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormLevel5_Load(object sender, EventArgs e)
        {
            start_game();

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if(left_boxes==0)
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label_box2_MouseEnter(object sender, EventArgs e)
        {
            left_boxes--;
            ((Label)sender).Visible = false;
 
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }
}
