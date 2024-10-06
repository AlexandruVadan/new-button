using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 1;
        int x = 1;
        int y = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            //int x=1, y = 1;
           // int buton1, buton2;
            
            //x = Convert.ToInt32(textBox1.Text);//numarul de linii
           // y = Convert.ToInt32(textBox2.Text);//numarul de coloane

            for (int i=1;i<=y;i++)
            {
                Button buton = new Button();
                buton.Text = count.ToString();
                buton.Name = count.ToString();
                buton.Size = new Size(35, 35);
                buton.Location = new Point(40 * x, 40 * (i+1));
                Controls.Add(buton);

            }
            if(y== int.Parse(textBox2.Text))
            {
                y = 0;
                x++;
            }

            //countul opreste butonul
            if(count == int.Parse(textBox1.Text)* int.Parse(textBox2.Text))
            {
                button1.Enabled = false;
            }    
            count++;
            y++;
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
