using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_1400_Cake
{
    public partial class Form1 : Form
    {

        static int money = 100;
        static string input = "";
        static int inputInt = 0;
        static int mal = 0;
        int randomNumber = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Visible == true)
            {
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                mal = 2;
                RandomNumber();
            }
            else if (checkBox2.Visible == false)
            {
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Visible == true)
            {
                checkBox3.Visible = false;
                checkBox1.Visible = false;
                mal = 3;
                RandomNumber();
            }

            else if (checkBox3.Visible == false)
            {
                checkBox3.Visible = true;
                checkBox1.Visible = true;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Visible == true)
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                mal = 4;
                RandomNumber();
            }

            else if (checkBox2.Visible == false)
            {
                checkBox2.Visible = true;
                checkBox1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Visible == false && checkBox2.Visible == false)
            {
                RandomNumber();
                CheckCup(1);
            }
            else if (checkBox1.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(1);
            }
            else if (checkBox2.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(1);
            }
            else
            {
                MessageBox.Show("Es muss eine Verdoppelung ausgewählt werden.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Visible == false && checkBox2.Visible == false)
            {
                RandomNumber();
                CheckCup(2);
            }
            else if (checkBox1.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(2);
            }
            else if (checkBox2.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(2);
            }
            else
            {
                MessageBox.Show("Es muss eine Verdoppelung ausgewählt werden.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Visible == false && checkBox2.Visible == false)
            {
                RandomNumber();
                CheckCup(3);
            }
            else if (checkBox1.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(3);
            }
            else if (checkBox2.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(3);
            }
            else
            {
                MessageBox.Show("Es muss eine Verdppelung ausgewählt werden.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Visible == false && checkBox2.Visible == false)
            {
                RandomNumber();
                CheckCup(4);
            }
            else if (checkBox1.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(4);
            }
            else if (checkBox2.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(4);
            }
            else
            {
                MessageBox.Show("Es muss eine Verdoppelung ausgewählt werden.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (checkBox1.Visible == false && checkBox2.Visible == false)
            {
                RandomNumber();
                CheckCup(5);
            }
            else if (checkBox1.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(5);
            }
            else if (checkBox2.Visible == false && checkBox3.Visible == false)
            {
                RandomNumber();
                CheckCup(5);
            }
            else
            {
                MessageBox.Show("Es muss eine Verdoppelung ausgewählt werden.");
            }
        }

        private void RandomNumber()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;


            if (checkBox1.Visible == true)
            {
                Random random = new Random();
                randomNumber = random.Next(1, 3);

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else if (checkBox2.Visible == true)
            {
                Random random = new Random();
                randomNumber = random.Next(1, 4);
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            else if (checkBox3.Visible == true)
            {
                Random random = new Random();
                randomNumber = random.Next(1, 5);
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Verdoppelung");
            }
        }

        private int CheckCup(int selectedCup)
        {

            if (selectedCup == randomNumber)
            {


                input = textBox1.Text;
                try
                {
                    inputInt = Convert.ToInt32(input);

                    if (money == 0)
                    {
                        MessageBox.Show("Game over");
                        Environment.Exit(-1);
                    }
                    else if (inputInt <= 0 || inputInt > money)
                    {
                        throw new Exception();
                    }

                    money = money + inputInt * mal;
                    label2.Text = money.ToString();
                    MessageBox.Show("Du hast gewonnen.");
                    return 1;
                }
                catch
                {
                    MessageBox.Show("Versuchen Sie es mit einer gültigen Zahl.");
                    return 1;
                }
            }
            else
            {
                input = textBox1.Text;
                try
                {
                    inputInt = Convert.ToInt32(input);

                    if (money == 0)
                    {
                        MessageBox.Show("Game over");
                        Environment.Exit(-1);
                    }
                    else if (inputInt <= 0 || inputInt > money)
                    {
                        throw new Exception();
                    }



                    money = money - inputInt;
                    label2.Text = money.ToString();
                    MessageBox.Show("Du hast verloren.");
                    return 1;
                }
                catch
                {
                    MessageBox.Show("Versuchen Sie es mit einer gültigen Zahl.");
                    return 1;
                }
            }
        }

    }
}
