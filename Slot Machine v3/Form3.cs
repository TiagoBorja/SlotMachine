using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Slot_Machine_v3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        double saldo = 0, aposta = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            
            double morecoins;

            try
            { 
                morecoins = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Quanto deseja acrescentar?"));

                if (morecoins > 5000)
                {
                    MessageBox.Show("Você não pode acrescentar mais que 5000 coins de uma vez.");
                    return;
                }

                MessageBox.Show("Foi acrescentado mais " + morecoins + " coins a sua carteira.");
                label1.Text = "O seu saldo atual é de: " + (saldo + morecoins) + " coins.";
                saldo = saldo + morecoins;
            }
            catch
            {
                MessageBox.Show("Não será possivél prosseguir sem um valor.");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (saldo <= 49)
                {
                    MessageBox.Show("Não será possível realizar está ação, você não tem o saldo mínimo", "Você deve inserir mais moedas.");
                    return;
                }

                aposta = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Quanto deseja apostar?"));
                DialogResult result = MessageBox.Show("Deseja apostar o valor de " + aposta + " coins?", "!VALOR DESCONTADO SOMENTE APÓS AO SPIN!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("", "!VALOR DESCONTADO SOMENTE APÓS AO SPIN!");
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Tudo bem, refaça sua aposta");
                }

                button1.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Não será possivél prosseguir sem um valor.");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "O seu saldo atual é de: " + saldo.ToString() + " coins.";

            string currentDirName = System.IO.Directory.GetCurrentDirectory() + @"\ImgSlot\";

            int[] numero = new int[4];


            if (saldo >= aposta)
            {
                saldo = saldo - aposta;

                Random random = new Random();
                numero[0] = random.Next(1, 8);
                numero[1] = random.Next(1, 8);
                numero[2] = random.Next(1, 8);
                numero[3] = random.Next(1, 8);

                pictureBox1.ImageLocation = string.Format(currentDirName + numero[0] + ".png");
                pictureBox2.ImageLocation = string.Format(currentDirName + numero[1] + ".png");
                pictureBox3.ImageLocation = string.Format(currentDirName + numero[2] + ".png");
                pictureBox4.ImageLocation = string.Format(currentDirName + numero[3] + ".png");

                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();

                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();

                var duplicados = numero.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => new { Item = y.Key, Count = y.Count() })
                .ToList();

                if (duplicados.Count() != 0)
                {
                    foreach (var item in duplicados)
                    {
                        if (item.Item == 1)
                        {
                            if (item.Count == 1)
                            {

                            }
                            else if (item.Count == 2)
                            {

                                saldo = saldo + (aposta * 0.50);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 3)
                            {

                                saldo = saldo + (aposta * 1);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 4)
                            {
                                saldo = saldo + (aposta * 2);
                                label1.Text = saldo.ToString();
                            }
                        }

                        if (item.Item == 2)
                        {
                            if (item.Count == 1)
                            {

                            }
                            else if (item.Count == 2)
                            {

                                saldo = saldo + (aposta * 0.75);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 3)
                            {

                                saldo = saldo + (aposta * 1.25);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 4)
                            {
                                saldo = saldo + (aposta * 2.25);
                                label1.Text = saldo.ToString();
                            }
                        }

                        if (item.Item == 3)

                        {
                            if (item.Count == 1)
                            {

                            }
                            else if (item.Count == 2)
                            {

                                saldo = saldo + (aposta * 0.80);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 3)
                            {

                                saldo = saldo + (aposta * 1.5);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 4)
                            {
                                saldo = saldo + (aposta * 2.5);
                                label1.Text = saldo.ToString();
                            }
                        }

                        if (item.Item == 4)

                        {
                            if (item.Count == 1)
                            {

                            }
                            else if (item.Count == 2)
                            {

                                saldo = saldo + (aposta * 0.85);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 3)
                            {

                                saldo = saldo + (aposta * 1.5);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 4)
                            {
                                saldo = saldo + (aposta * 2.5);
                                label1.Text = saldo.ToString();
                            }
                        }

                        if (item.Item == 5)

                        {

                            if (item.Count == 1)
                            {

                            }
                            else if (item.Count == 2)
                            {

                                saldo = saldo + (aposta * 1);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 3)
                            {

                                saldo = saldo + (aposta * 1.5);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 4)
                            {
                                saldo = saldo + (aposta * 2.5);
                                label1.Text = saldo.ToString();
                            }
                        }

                        if (item.Item == 6)

                        {

                            if (item.Count == 1)
                            {

                            }
                            else if (item.Count == 2)
                            {

                                saldo = saldo + (aposta * 1.25);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 3)
                            {

                                saldo = saldo + (aposta * 2);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 4)
                            {
                                saldo = saldo + (aposta * 4);
                                label1.Text = saldo.ToString();
                            }
                        }

                        if (item.Item == 7)

                        {

                            if (item.Count == 1)
                            {

                            }
                            else if (item.Count == 2)
                            {

                                saldo = saldo + (aposta * 2);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 3)
                            {

                                saldo = saldo + (aposta * 2.5);
                                label1.Text = saldo.ToString();

                            }
                            else if (item.Count == 4)
                            {
                                saldo = saldo + (aposta * 10);
                                label1.Text = saldo.ToString();
                            }
                        }                      
                    }                  
                    
                }
                label1.Text = "O seu saldo atual é de: " + (saldo.ToString()) + " coins.";
            }
            else MessageBox.Show("Você está tentando apostar mais do que possui!", "INSIRA MAIS COINS.");                     
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 novoForm = new Form1();
            novoForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 novoForm = new Form2();
            novoForm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            try
            {
                do
                {
                    saldo = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Qual será o seu saldo inicial?", "MÁXIMO DE 500 COINS!"));
                    if (saldo > 500)
                    {
                        MessageBox.Show("Você está tentando inserir mais que o valor máximo.");
                    }
                }
                while (saldo < 0 || saldo > 500);

                MessageBox.Show("Bem vindo!");
                label1.Text = "O seu saldo atual é de: " + saldo + " coins.";

            }
            catch
            {
                MessageBox.Show("Não será possivél prosseguir sem um valor.", "Reinicie a aplicação");
                Application.Exit();
            }
           
            
            
            
        }
    }
}
