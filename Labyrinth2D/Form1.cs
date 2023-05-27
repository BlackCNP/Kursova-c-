namespace Labyrinth2D
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        
        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (box_sound.Checked)
            {
                Sound.sound_on();
                box_sound.Text = "Звук вкл";
                Sound.play_youwin();
            }
            else
            {
                Sound.sound_off();
                box_sound.Text = "Звук вимк";
            }
              

            
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void  start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.OK)
                start_level2();
            
        }
        private void start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr2 = level2.ShowDialog();
            if (dr2 == DialogResult.OK)
                start_level3();


        }
        private void start_level3()
        {
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr3 = level3.ShowDialog();
            if (dr3 == DialogResult.OK)
                start_level4();
        }
        private void start_level4()
        {
            FormLevel4 level4 = new FormLevel4();
            DialogResult dr4 = level4.ShowDialog();
            //if (dr3 == DialogResult.OK)
              //  start_level4();
        }

    }
}