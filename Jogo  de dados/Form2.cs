using MySql.Data.MySqlClient;
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

        string nickGL, nickGL2;
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

            Form1 = new Thread(newForm1); // instancia a janela atual
            Form1.SetApartmentState(ApartmentState.STA); // Indico que sera single thread 
            Form1.Start(); // e inicio
            this.Close(); // Fecha a janela atual 
        }


        private void newForm1()
        {
            Application.Run(new Form1(nickGL, nickGL2));
        }
        private void bt_salvarr_Click(object sender, EventArgs e)
        {
            nickGL = tx_box_nomej1.Text;
            nickGL2 = tx_box_nomej2.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server = mysql743.umbler.com;port=41890; Database =games;User= aluno10; Password = Uni9_aluno;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                string commandStr = "INSERT INTO alunodb (nome,nick,idade)" +
                            "VALUES('" + tx_box_nomej1.Text + "','" + tx_box_nickj1.Text + "','" + tx_box_idadej2.Text + "')";
                MessageBox.Show(commandStr);
                MySqlCommand command = new MySqlCommand(commandStr, cnn);

                int value = command.ExecuteNonQuery();
                Console.WriteLine("ExecuteNonQuery : " + value);
                commandStr = "INSERT INTO alunodb (nome,nick,idade)" +
                            "VALUES('" + tx_box_nomej2.Text + "','" + tx_box_nickj2.Text + "','" + tx_box_idadej2.Text + "')";
                MessageBox.Show(commandStr);
                MySqlCommand command2 = new MySqlCommand(commandStr, cnn);

                value = command2.ExecuteNonQuery();
                Console.WriteLine("ExecuteNonQuery : " + value);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


            Form1 = new Thread(newForm1);
            Form1.SetApartmentState(ApartmentState.STA);
            Form1.Start();
            this.Close();

            // String jogadores = "Nome Jogador 1: " + tx_box_nomej1.Text + "\n" + "Nick jogador 1: " + tx_box_nickj1.Text + "\n" + "Idade Jogador1: " +  tx_box_idadej1.Text + "\n" + "============================="+ "\n" + "Nome Jogador 2: " +  tx_box_nomej2.Text + "\n" + "Nick Jogador 2: " + tx_box_nickj2.Text + "\n" + "Idade Jogador 2: " + tx_box_idadej2.Text; 
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            //saveFileDialog1.Title = "Salvar um Arquivo Texto";
            //saveFileDialog1.FileName = "Log.txt";
            ////saveFileDialog1.ShowDialog();

            //if (saveFileDialog1.FileName != "")
            //{
            //System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

            //byte[] bytes = Encoding.ASCII.GetBytes(jogadores);
            //int Nbytes = Encoding.ASCII.GetCharCount(bytes);
            //fs.Write(bytes, 0, Nbytes);
            //Escrever o endereco do arquivo
            //jogadores = saveFileDialog1.FileName;
            //fs.Close();
            //}
        }


    }
}
