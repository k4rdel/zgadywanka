using System.Runtime.InteropServices;

namespace zgadywanka
{
    public partial class Form1 : Form
    {
        int liczbaWpisana, liczbaWylosowana, numerProby, dzialaCzyNie;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                dzialaCzyNie = 1;
                if (liczbaWylosowana > liczbaWpisana)
                {
                    label1.Text = "Wylosowana liczba jest wiêksza";
                }
                else if (liczbaWylosowana < liczbaWpisana)
                {
                    label1.Text = "Wylosowana liczba jest mniejsza";
                }
            }
            else
            {
                dzialaCzyNie = 0;
                label1.Text = "BRAK";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out _) == false)
            {
                MessageBox.Show("Wartoœæ nie mo¿e byæ tekstem oraz nie mo¿e byæ pusta!", "Komunikat");
                textBox2.Clear();
            }
            else
            {
                liczbaWpisana = Convert.ToInt32(textBox2.Text);
                if (liczbaWylosowana == liczbaWpisana)
                {
                    numerProby++;
                    textBox1.Text = Convert.ToString(numerProby);
                    label3.Text = "Iloœæ prób " + numerProby;
                    label1.Text = "Trafi³eœ";
                    button2.Enabled = false;
                    button1.Enabled = false;
                    textBox2.Enabled = false;
                    checkBox1.Enabled = false;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    panel2.BackColor = Color.Yellow;

                }
                else
                {
                    numerProby++;
                    textBox1.Text = Convert.ToString(numerProby);
                    if (dzialaCzyNie == 1)
                    {
                        if (liczbaWylosowana > liczbaWpisana)
                        {
                            label1.Text = "Wylosowana liczba jest wiêksza";
                        }
                        else if (liczbaWylosowana < liczbaWpisana)
                        {
                            label1.Text = "Wylosowana liczba jest mniejsza";
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (radioButton1.Checked == true)
            {
                liczbaWylosowana = rnd.Next(0, 1000);
            }
            else if (radioButton2.Checked == true)
            {
                liczbaWylosowana = rnd.Next(0, 100);
            }
            else if (radioButton3.Checked == true)
            {
                liczbaWylosowana = rnd.Next(0, 10);
            }
            numerProby = 0;
            textBox1.Text = Convert.ToString(numerProby);
        }
    }
}