using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundButtonSubClass
{
    public partial class Form1 : Form
    {
        NewButton testButton = new NewButton();

        public Form1()
        {
            InitializeComponent();
            
            makeButton(testButton,50,50);

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            roundButton1.Text = "XXX";
            changeButtonColor(testButton, Color.Red);
        }

        private void makeButton(NewButton myButton,int x, int y)
        {

            

            myButton.Location = new Point(x, y);
            this.Controls.Add(myButton);


        }

        private void changeButtonColor(NewButton myButton, Color myColor)
        {
            myButton.BackColor =Color.Red;
            Application.DoEvents();
        }
    }
}
