using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace prova_interrogazione
{
    public partial class Form1 : Form
    {
        int righe = 5;
        int colonne = 5;

        public Form1()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Button[] btns = new Button[righe * colonne];
            int k = 0;

            /*
            this.Width = 150 * righe;
            this.Height = 150 * colonne;
            */

            for (int j=0; j < righe; j++)
            {
                for (int i = 0; i < colonne; i++)
                {
                    btns[k]= new Button();
                    btns[k].Size = new Size(100, 100);
                    btns[k].Location = new Point(i * 100, j * 100);

                    // Imposta le proprietà del pulsante
                    /*
                    btn.Text = $"Pulsante {i + 1}";
                    btn.Width = 100;
                    btn.Height = 50;
                    btn.Top = 20 + i * 60;
                    btn.Left = 50;
                    */




                    // Aggiunge il pulsante al form
                    this.Controls.Add(btns[k]);
                    /*
                    //creare il thread 
                    Thread colore = new Thread(colora);
                    //avviare il thread 
                    colore.Start(btn);
                    */

                    k++;

                }
            }
            
            Object oggetto = (Object)btns;

            //colora(btns);
            //creare il thread 
            Thread colore = new Thread(colora);
            //avviare il thread 
            colore.Start(btns);
            this.ClientSize = new Size(righe * 100, colonne * 100);

        }
            
        private void colora(Object obj)
        {
            for (int j = 0; j < righe*righe; j++)
            {
                Thread.Sleep(1000);
                Button[] arg = (Button[])obj;
                Random casuale = new Random();

                arg[casuale.Next(righe * colonne)].BackColor = Color.Blue;
            }
        }

    }

}
