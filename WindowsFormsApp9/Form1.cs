using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        public string[,] FnB = new string[40, 2];
        public int counter = 5;
        public int counter1 = 4;
        public int Check=0;
        private void Form1_Load(object sender, EventArgs e)
        {

            listBoxpertama.Items.Add(FnB[0, 0] = "Mi Instan");
            listBoxpertama.Items.Add(FnB[1, 0] = "Telor");
            listBoxpertama.Items.Add(FnB[0, 1] = "Susu Sapi");
            listBoxpertama.Items.Add(FnB[1, 1] = "Kopi");
           listBoxpertama.Items.Add(FnB[2, 0] = "Roti");
            listBoxpertama.Items.Add(FnB[3, 0] = "Keju");
            listBoxpertama.Items.Add(FnB[4, 0] = "Daging Giling");
            listBoxpertama.Items.Add(FnB[2, 1] = "Teh");
            listBoxpertama.Items.Add(FnB[3, 1] = "Bir");
        }
 
        private void buttoninput_Click(object sender, EventArgs e)
        {
            Check = 2;
            for (int i = 0; i < counter1; i++)
            {
                if (FnB[i, 1] == textBoxinput.Text)
                {
                    Check--;
                }
            }
            for (int i = 0; i < counter; i++)
            {
                if (FnB[i, 0] ==textBoxinput.Text)
                {
                    Check--;
                }
            }

           
            if (Check ==1 && radioButtonmakan.Checked == true || Check > 0 && radioButtonminum.Checked == true)
            {
                MessageBox.Show("Makannya Dibaca ListBoxnya","error!");
            }
            else if (textBoxinput.Text != "" && radioButtonmakan.Checked == true)
            {
                listBoxpertama.Items.Add(FnB[counter, 0] = textBoxinput.Text);
                counter++;
            }
            else if (textBoxinput.Text != "" && radioButtonminum.Checked == true)
            {
                listBoxpertama.Items.Add(FnB[counter, 0] = textBoxinput.Text);
                counter1++;
            }
            else
            {
                MessageBox.Show("tulis dong!");
            }
            radioButtonmakan.Checked = false;
            radioButtonminum.Checked = false;
            textBoxinput.Text = "";

        }

        

        private void buttonpindah_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBoxpertama.SelectedIndices.Count - 1; i++)
            {
                if (listBoxkedua.Items.Contains(listBoxpertama.SelectedItems[i]))
                {

                }
                else
                {
                    listBoxkedua.Items.Add(listBoxpertama.SelectedItem);
                }
            }
            listBoxpertama.ClearSelected();
            cBoxMakanan.Checked = false;
            cBoxMinuman.Checked = false;
        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            if (listBoxkedua.SelectedItems.Count == 0)
            {
                listBoxkedua.Items.Clear();
            }
            else
            {
                for (int i = listBoxkedua.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBoxkedua.Items.Remove(listBoxkedua.SelectedItems[i]);
                }
            }
            listBoxkedua.ClearSelected();
        }



        private void cBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {

   
        }
        private void cBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {

    
        }

        private void listBoxpertama_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
