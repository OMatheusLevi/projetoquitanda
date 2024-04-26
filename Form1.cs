using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string fruta;
        private float preco;
        private string mtdpagamento;
        private string title = "--------------BOLETO QUITANDA-------------";
        private string linha = "--------------------------------------------";
        private string vrf = "f";
        private bool entrega;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fruta = "Morango";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mtdpagamento = "Dinheiro";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            mtdpagamento = "Debito";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mtdpagamento = "Credito";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float Kilos;
            if (float.TryParse(textBox1.Text, out Kilos))
            {   
                if (fruta == "Morango")   //------------------------- PREÇO MORANGO
                {
                    if(Kilos <= 5)
                    {
                        preco = (Kilos * 5);
                    }
                    if (Kilos > 5 && Kilos <= 10)
                    {
                        preco = (Kilos * (350/100));
                    }
                    if(Kilos > 10)
                    {
                        preco = (Kilos * (200 / 100));
                    }

                    //Descontos

                    if (mtdpagamento == "Dinheiro")
                    {
                        preco = preco - 10 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Debito")
                    {
                        preco = preco - 5 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Credito")
                    {
                        preco = preco / 2;
                        vrf = "t";
                    }
                    
                    // GERAÇÂO DO BOLETO

                    if(entrega = true)
                    {
                        preco = preco + 10;
                        MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Taxa de Entrega:R$10,00" + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha , "Boleto Gerado!");
                    }
                    else
                    {
                          MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha, "Boleto Gerado!" );
                    }

                }
                if (fruta == "Banana")
                {
                    if (Kilos <= 5)
                    {
                        preco = (Kilos * 10);
                    }
                    if (Kilos > 5 && Kilos <= 10)
                    {
                        preco = (Kilos * (750 / 100));
                    }
                    if (Kilos > 10)
                    {
                        preco = (Kilos * (680 / 100));
                    }

                    //Descontos

                    if (mtdpagamento == "Dinheiro")
                    {
                        preco = preco - 10 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Debito")
                    {
                        preco = preco - 5 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Credito")
                    {
                        preco = preco / 2;
                        vrf = "t";
                    }

                    // GERAÇÂO DO BOLETO

                    if (entrega = true)
                    {
                        preco = preco + 10;
                        MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Taxa de Entrega:R$10,00" + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha, "Boleto Gerado!");
                    }
                    else
                    {
                        MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha, "Boleto Gerado!");
                    }
                }
                if (fruta == "Pera")
                {
                    if (Kilos <= 5)
                    {
                        preco = (Kilos * (850 / 100));
                    }
                    if (Kilos > 5 && Kilos <= 10)
                    {
                        preco = (Kilos * 7);
                    }
                    if (Kilos > 10)
                    {
                        preco = (Kilos * (550 / 100));
                    }

                    //Descontos

                    if (mtdpagamento == "Dinheiro")
                    {
                        preco = preco - 10 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Debito")
                    {
                        preco = preco - 5 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Credito")
                    {
                        preco = preco / 2;
                        vrf = "t";
                    }

                    // GERAÇÂO DO BOLETO

                    if (entrega = true)
                    {
                        preco = preco + 10;
                        MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Taxa de Entrega:R$10,00" + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha, "Boleto Gerado!");
                    }
                    else
                    {
                        MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha, "Boleto Gerado!");
                    }
                }
                if (fruta == "Maca")
                {
                    if (Kilos <= 5)
                    {
                        preco = (Kilos * (650 / 100));
                    }
                    if (Kilos > 5 && Kilos <= 10)
                    {
                        preco = (Kilos * 5);
                    }
                    if (Kilos > 10)
                    {
                        preco = (Kilos * (375 / 100));
                    }

                    //Descontos

                    if (mtdpagamento == "Dinheiro")
                    {
                        preco = preco - 10 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Debito")
                    {
                        preco = preco - 5 / 100;
                        vrf = "t";
                    }
                    if (mtdpagamento == "Credito")
                    {
                        preco = preco / 2;
                        vrf = "t";
                    }

                    // GERAÇÂO DO BOLETO

                    if (entrega = true)
                    {
                        preco = preco + 10;
                        MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Taxa de Entrega:R$10,00" + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha, "Boleto Gerado!");
                    }
                    else
                    {
                        MessageBox.Show(title + Environment.NewLine + "Fruta:" + fruta + Environment.NewLine + linha + Environment.NewLine + "Kilos:" + Kilos + Environment.NewLine + linha + Environment.NewLine + "Preço: R$" + preco + Environment.NewLine + linha + Environment.NewLine + "Metodo de Pagamento:" + mtdpagamento + Environment.NewLine + linha, "Boleto Gerado!");
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Digite o Kilo em Numeros por favor");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fruta = "Banana";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fruta = "Pera";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fruta = "Maca";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
