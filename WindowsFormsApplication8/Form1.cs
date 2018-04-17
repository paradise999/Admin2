using System;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Random rnd = new Random();
        public iden[] mass = new iden[5];
        public iden[] sec = new iden[3];
        public class iden
        {
            public string s;
            public int i;         

        }       
        public Form1()
        {
            InitializeComponent();            
            mass[0] = new iden();
            mass[0].s = "Admin";
            mass[0].i = 0;
            for(int i = 1; i < 5; i++)
            {
                mass[i] = new iden();
                mass[i].s = "User" + i;
                mass[i].i = rnd.Next(0, 2);
            }
            for (int i = 0; i < 3; i++)
            {
                sec[i] = new iden();
                sec[i].s = "Security" + i;
                sec[i].i = i;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           form2 = new Form2(this);
            for (int i = 0; i < 5; i++)
            {
                label1.Text += "\n" + mass[i].s + " - " + mass[i].i;
            }
            for (int i = 0; i < 3; i++)
            {
                label2.Text += "\n" + sec[i].s + " - " + sec[i].i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            bool f = false;
            for (int i = 0; i < 5; i++)
                if (textBox1.Text == mass[i].s)
                {
                    f = true;
                    form2.p = mass[i].i;
                    if (!form2.Visible)
                    {
                        form2.Show();
                        Hide();
                    }
                }
            if (!f)
                MessageBox.Show("Неверный идентификатор");
        }
    }
}
