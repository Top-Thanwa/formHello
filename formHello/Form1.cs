using System.Security.Cryptography.Xml;

namespace formHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Window Forms", "Hello");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye", "Exit");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Brown;
            button1.ForeColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            label2.Text = textBox1.Text.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.BackColor == SystemColors.Control)
            {
                label3.BackColor = Color.OrangeRed;
            }
            else label3.BackColor = SystemColors.Control;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double radius;
            double area = 0.00;
            double circ = 0.00;
            if (double.TryParse(txtRedius.Text, out radius) && radius >= 0)
            {
                area = Math.PI * Math.Pow(radius, 2);
                circ = 2 * Math.PI * radius;
                lblResult.Text = string.Format("พื้นที่วงกลม = {0:F2} \nเส้นรอบวง = {1:F2}", area, circ);
            }
            else
            {
                MessageBox.Show("กรอกรัศมีวงกรม : ", "ข้อมูลผิดพลาด");
            }
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {

        }
    }
}
