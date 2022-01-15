using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trenApplicationn
{
    public partial class Form1 : Form
    {
        public int sayi;
        public int kapasite;
        public int dolukoltuk;
        List<TrainInformations> trenList;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            trenList = new List<TrainInformations>()
            {
                new TrainInformations{numberOfPeople = 1},
                new TrainInformations{numberOfPeople = 2},
                new TrainInformations{numberOfPeople = 3},
                new TrainInformations{numberOfPeople = 4},
                new TrainInformations{numberOfPeople = 5}
            };
            foreach (var item in trenList)
            {

                comboBox3.Items.Add(item.numberOfPeople);
            }

            trenList = new List<TrainInformations>()
                {
                    new TrainInformations {trainName="İstanbultreni",wagonList = new Wagon[]{
                        new Wagon {wagonName = "vagon1", wagonFullSeat = 52, wagonCapacity =100 },
                        new Wagon {wagonName = "vagon2", wagonFullSeat = 68, wagonCapacity =100 },
                        new Wagon {wagonName = "vagon3", wagonFullSeat = 70, wagonCapacity =100 }} },

                    new TrainInformations {trainName="Baskenttreni",wagonList = new Wagon[]{
                        new Wagon {wagonName = "vagonn1", wagonFullSeat = 20, wagonCapacity =50 },
                        new Wagon {wagonName = "vagonn2", wagonFullSeat = 20, wagonCapacity =50 },
                        new Wagon {wagonName = "vagonn3", wagonFullSeat = 20, wagonCapacity =50 },
                        new Wagon {wagonName = "vagonn4", wagonFullSeat = 20, wagonCapacity =50 }

                    } }
                };

            foreach (var item in trenList)
            {
                comboBox1.Items.Add(item.trainName);

            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == "İstanbultreni")
            {


                foreach (var item in trenList)
                {
                    if (item.trainName == "İstanbultreni")
                    {
                        for (int i = 0; i < item.wagonList.Length; i++)
                        {
                            comboBox2.Text = "";
                            comboBox2.Items.Add(item.wagonList[i].wagonName);
                        }
                    }
                }

            }
            else
            {


                foreach (var item in trenList)
                {
                    if (item.trainName == "Baskenttreni")
                    {
                        for (int i = 0; i < item.wagonList.Length; i++)
                        {
                            comboBox2.Text = "";
                            comboBox2.Items.Add(item.wagonList[i].wagonName);
                        }
                    }
                }
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            foreach (var item in trenList)
            {
                if (comboBox1.SelectedItem == "İstanbultreni")
                {
                    if (comboBox2.SelectedItem == "vagon1" && item.trainName == "İstanbultreni")
                    {

                        kapasite = item.wagonList[0].wagonCapacity;
                        label4.Text = Convert.ToString(kapasite);
                        dolukoltuk = item.wagonList[0].wagonFullSeat;
                        dolukoltuk += sayi;
                        label7.Text = Convert.ToString(dolukoltuk);
                        comboBox3.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        button1.Visible = true;
                    }
                    else if (comboBox2.SelectedItem == "vagon2" && item.trainName == "İstanbultreni")
                    {

                        kapasite = item.wagonList[1].wagonCapacity;
                        label4.Text = Convert.ToString(kapasite);
                        dolukoltuk = item.wagonList[1].wagonFullSeat;
                        dolukoltuk += sayi;
                        label7.Text = Convert.ToString(dolukoltuk);
                        comboBox3.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        button1.Visible = true;



                    }
                    else
                    {

                        kapasite = item.wagonList[2].wagonCapacity;
                        label4.Text = Convert.ToString(kapasite);
                        dolukoltuk = item.wagonList[2].wagonFullSeat;
                        dolukoltuk += sayi;
                        label7.Text = Convert.ToString(dolukoltuk);
                        comboBox3.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        button1.Visible = true;
                    }

                }
                else if (comboBox1.SelectedItem == "Baskenttreni")
                {


                    if (comboBox2.SelectedItem == "vagonn1" && item.trainName == "Baskenttreni")
                    {

                        kapasite = item.wagonList[0].wagonCapacity;
                        label4.Text = Convert.ToString(kapasite);
                        dolukoltuk = item.wagonList[0].wagonFullSeat;
                        dolukoltuk += sayi;
                        label7.Text = Convert.ToString(dolukoltuk);
                        comboBox3.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        button1.Visible = true;

                    }
                    else if (comboBox2.SelectedItem == "vagonn2" && item.trainName == "Baskenttreni")
                    {

                        kapasite = item.wagonList[1].wagonCapacity;
                        label4.Text = Convert.ToString(kapasite);
                        dolukoltuk = item.wagonList[1].wagonFullSeat;
                        dolukoltuk += sayi;
                        label7.Text = Convert.ToString(dolukoltuk);
                        comboBox3.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        button1.Visible = true;


                    }
                    else if (comboBox2.SelectedItem == "vagonn3" && item.trainName == "Baskenttreni")
                    {

                        kapasite = item.wagonList[2].wagonCapacity;
                        label4.Text = Convert.ToString(kapasite);
                        dolukoltuk = item.wagonList[2].wagonFullSeat;
                        dolukoltuk += sayi;
                        label7.Text = Convert.ToString(dolukoltuk);
                        comboBox3.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        button1.Visible = true;
                    }
                    else
                    {
                        kapasite = item.wagonList[3].wagonCapacity;
                        label4.Text = Convert.ToString(kapasite);
                        dolukoltuk = item.wagonList[3].wagonFullSeat;
                        dolukoltuk += sayi;
                        label7.Text = Convert.ToString(dolukoltuk);
                        comboBox3.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        button1.Visible = true;
                    }
                    break;
                }
                return;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(comboBox3.SelectedItem);
            dolukoltuk += sayi;
            label7.Text = "";
            label7.Text += Convert.ToString(dolukoltuk);
            if (dolukoltuk > 70)
            {
                MessageBox.Show("Farklı Vagondan Seçim Yapınız");
                label7.Text = "";
                label7.Text += Convert.ToString(dolukoltuk - sayi);
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Seçtiğiniz Vagon Numarası  : " + comboBox2.SelectedItem + " Kişi Sayısı   :" + sayi, "" + comboBox1.SelectedItem, MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    // Buraya Kişi yaptığı seçimleri onayladığında seçtiği bilgileri başka alanda görüntülenecek.
                    listBox1.Items.Add(comboBox1.SelectedItem + " 'inden   " + "Seçtiğiniz Vagon Numarası : " + comboBox2.SelectedItem + " Kişi Sayısı : " + sayi);
                    listBox1.Visible = true;
                }
                else if (result1 == DialogResult.No)
                {
                    label7.Text = "";
                    label7.Text += Convert.ToString(dolukoltuk - sayi);
                }
            }

        }
    }
}