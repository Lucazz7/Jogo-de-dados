using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo__de_dados
{
   
    public partial class Form1 : Form
    {
        Thread Form2;
        private Random rdnDado = new Random();
        bool flagJoga1;
        bool flagJoga2;

        int valor_dado1;
        int valor_dado2;
        public Form1()
        {
            InitializeComponent();
            ValorPartida.Text = "5";
            
            flagJoga1 = true;
            flagJoga2 = true;
        }

        private void comparaDados()
        {

            int Pontos1Int = Convert.ToInt32(pontos1.Text);
            int Pontos2Int = Convert.ToInt32(pontos2.Text);

            ValorPartida.ReadOnly = true;
            if (!flagJoga1 && !flagJoga2)
            {
                if (valor_dado1 < valor_dado2)
                {
                    Pontos1Int = Pontos1Int - 1;
                    pontos1.Text = Convert.ToString(Pontos1Int);
                }
                if (valor_dado2 < valor_dado1)
                {
                    Pontos2Int = Pontos2Int - 1;
                    pontos2.Text = Convert.ToString(Pontos2Int); 
                }
            if ((Pontos1Int == 0) || (Pontos2Int == 0))
                        {

                    if(Pontos1Int == 0)
                    {
                        venc.Text = "Jogador 2";
                    }
                    else
                    {
                        venc.Text = "Jogador 1";
                    }
                    bt_joga1.Text = "FIM";
                    btjoga2.Text = "FIM";

                }
                else
            {
                flagJoga1 = true;
                flagJoga2 = true;
                bt_joga1.Text = "JOGAR!";
                btjoga2.Text = "JOGAR!";
                }


            }
        }

        internal static void Start()
        {
            throw new NotImplementedException();
        }

        internal static void SetApartmentState(ApartmentState sTA)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_joga1_Click(object sender, EventArgs e)
        {
            //Gerar numeros aleatorios dado1

            

            if (flagJoga1)
            {

                //Definindo que o numero de numeros aleatorios é de 1 a 6
                valor_dado1 = rdnDado.Next(1, 7);

                //Condição para que as imagens são geradas conforme os numero com Switch e case
                switch (valor_dado1)
                {
                    case 1:
                        dado1.Image = Properties.Resources.dado1;
                        break;
                    case 2:
                        dado1.Image = Properties.Resources.dado2;
                        break;
                    case 3:
                        dado1.Image = Properties.Resources.dado3;
                        break;
                    case 4:
                        dado1.Image = Properties.Resources.dado4;
                        break;
                    case 5:
                        dado1.Image = Properties.Resources.dado5;
                        break;
                    case 6:
                        dado1.Image = Properties.Resources.dado6;
                        break;
                }
                flagJoga1 = false;
                bt_joga1.Text = "OK";

                comparaDados();
            }

        }

        private void btjoga2_Click(object sender, EventArgs e)
        {
            //variavel do dado2
            
            

            if(flagJoga2) { 

            //Definindo que o numero de numeros aleatorios é de 1 a 6
            valor_dado2 = rdnDado.Next(1, 7);

            //Condição para que as imagens são geradas conforme os numero com IF
            if (valor_dado2 == 1)
            {
                dado2.Image = Properties.Resources.dado1;
            }
            if (valor_dado2 == 2)
            {
                dado2.Image = Properties.Resources.dado2;
            }
            if (valor_dado2 == 3)
            {
                dado2.Image = Properties.Resources.dado3;
            }
            if (valor_dado2 == 4)
            {
                dado2.Image = Properties.Resources.dado4;
            }
            if (valor_dado2 == 5)
            {
                dado2.Image = Properties.Resources.dado5;
            }
            if (valor_dado2 == 6)
            {
                dado2.Image = Properties.Resources.dado6;
            }
                flagJoga2 = false;
                btjoga2.Text = "OK";
                comparaDados();
            }

        }

        private void dado2_Click(object sender, EventArgs e)
        {

        }

        private void btreiniciar_Click(object sender, EventArgs e)
        {
            dado1.Image = Properties.Resources.dado0;
            dado2.Image = Properties.Resources.dado0;
            flagJoga1 = true;
            flagJoga2 = true;
            ValorPartida.ReadOnly = false;
            pontos1.Text = ValorPartida.Text;
            pontos2.Text = ValorPartida.Text;

            
        }

        private void ValorPartida_TextChanged(object sender, EventArgs e)
        {
            pontos1.Text = ValorPartida.Text;
            pontos2.Text = ValorPartida.Text;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            //this.Close(); // Fecha a janela atual 
            Form2 = new Thread(newForm2); // instancia a janela atual
            //Form2.SetApartmentState(ApartmentState.STA); // Indico que sera single thread 
            Form2.Start(); // e inicio
        }

        private void newForm2()
        {
            Application.Run(new Form2());
        }

        private void bt_resultado_Click(object sender, EventArgs e)
        {
            String log = "Jogador 1: " + n_jogador1.Text + " --" + "Pontos : " + pontos1.Text + "\n" + "Jogador 2: " + n_jogador2.Text + " --" + "Pontos: " + pontos2.Text + "\n" + "Valor da partida: " + ValorPartida.Text + "\n" + "Vencedor da partida: " + venc.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            saveFileDialog1.Title = "Salvar um Arquivo Texto";
            saveFileDialog1.FileName = "Cadastro.txt";
            //saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                byte[] bytes = Encoding.ASCII.GetBytes(log);
                int Nbytes = Encoding.ASCII.GetCharCount(bytes);
                fs.Write(bytes, 0, Nbytes);
                //Escrever o endereco do arquivo
                log = saveFileDialog1.FileName;
                fs.Close();

            }

            

        }

       
    }
}
