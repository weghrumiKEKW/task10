using System.Media;

namespace plane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
        }
        bool c = false;

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                button8.Text = "ON";
                pictureBox2.Visible = false;
                splights.Play();
            }
            else
            {
                c = false;
                button8.Text = "OFF";
                pictureBox2.Visible = true;
                splights.Play();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);
            if (pictureBox1.Location.Y == 0)
            {
                timer1.Stop();
                MessageBox.Show("You reached to the end", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        SoundPlayer splights = new SoundPlayer("C:\\Users\\User\\Downloads\\isiq.wav");
        SoundPlayer sp1 = new SoundPlayer("C:\\Users\\User\\Downloads\\enis.wav");
        SoundPlayer sp2 = new SoundPlayer("C:\\Users\\User\\Downloads\\turbulans.wav");
        SoundPlayer sp3 = new SoundPlayer("C:\\Users\\User\\Downloads\\kemerler.wav");
        SoundPlayer sp4 = new SoundPlayer("C:\\Users\\User\\Downloads\\tesekkurler.wav");
        SoundPlayer sp5 = new SoundPlayer("C:\\Users\\User\\Downloads\\beep.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            sp1.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp2.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp3.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sp4.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sp5.Play();
        }
    }
}
