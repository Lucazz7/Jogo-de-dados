using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo__de_dados
{

    public partial class Form2 : Form
    {
        
        Thread Form1;
        public Form2()
        {
            InitializeComponent();
        }

        internal static void SetApartmentState(ApartmentState sTA)
        {
            throw new NotImplementedException();
        }

        internal static void Start()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a janela atual 
            Form1 = new Thread(newForm1); // instancia a janela atual
            Form1.SetApartmentState(ApartmentState.STA); // Indico que sera single thread 
            //Form1.Start(); // e inicio
        }

        private void newForm1()
        {
            Application.Run(new Form1());
        }

        private void bt_salvarr_Click(object sender, EventArgs e)
        {
            String jogadores = "Nome Jogador 1: " + tx_box_nomej1.Text + "\n" + "Nick jogador 1: " + tx_box_nickj1.Text + "\n" + "Idade Jogador1: " +  tx_box_idadej1.Text + "\n" + "============================="+ "\n" + "Nome Jogador 2: " +  tx_box_nomej2.Text + "\n" + "Nick Jogador 2: " + tx_box_nickj2.Text + "\n" + "Idade Jogador 2: " + tx_box_idadej2.Text; 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            saveFileDialog1.Title = "Salvar um Arquivo Texto";
            saveFileDialog1.FileName = "Log.txt";
            //saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                byte[] bytes = Encoding.ASCII.GetBytes(jogadores);
                int Nbytes = Encoding.ASCII.GetCharCount(bytes);
                fs.Write(bytes, 0, Nbytes);
                //Escrever o endereco do arquivo
                jogadores = saveFileDialog1.FileName;
                fs.Close();
            }
        }

        
    }
}
