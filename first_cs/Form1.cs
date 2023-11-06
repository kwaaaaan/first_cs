using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("안녕하세요!");

            textBox_print.Text = "나는\r\n피곤합니다.\r\n";
            //windows환경에서 줄바꿈은 \r\n임! c++과 c의 콘솔창은 DOS환경이라서 \n로 가능(옛날 mac은 \r임)
            //askdjaslkdjaklsjdalksjd
            textBox_print.Text = "나는\r\n피곤합니다2.\r\n";
            textBox_print.Text = "나는\r\n피곤합니다3.\r\n";
            textBox_print.Text = "나는\r\n피곤합니다4.\r\n";
            textBox_print.Text = "나는\r\n피곤합니다5.\r\n";
        }
    }
}