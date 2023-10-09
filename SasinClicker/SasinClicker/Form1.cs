using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SasinClicker
{

    public partial class Form1 : Form
    {
        public int  balance = 0;
        public double multiplier = 1;
        public int[] minst;

        public bool fsb = false;
        public bool mosad = false;

        public int yearruling = 1;

        public string infobar;

        public string info = "W tym roku od koronawirusa LGBT dostało jebanego pierdolca, a do chuja są kurwa ważniejsze problemy.";

        public Form1()
        {
            minst = new int[5];
            InitializeComponent();
            this.DoubleBuffered = true;
            Update();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            pictureBox1.Enabled = false;
            try
            {
                info = File.ReadAllText("TVP-BAR.txt");
            }
            catch
            {
                info = "Rusza Bitwa o Respiratory. MEN podaruje respiratory klasom o najwyższej frekwencji. W każdym województwie klasa do 30 uczniów z największa frekwencją we wrześniu otrzyma respirator – zapowiedzieli na wspólnej konferencji szefowie resortów zdrowia i edukacji. Rząd chce tym samym zachęcić uczniów, by bez obaw uczęszczali do szkół po 1 września. Dla klas, które ze składek na fundusz klasowy nie będą mogły wygospodarować środków na zakup własnego respiratora, rząd ma ciekawą propozycję. O profrekwencyjnej inicjatywie poinformowali ministrowie edukacji Dariusz Piontkowski i zdrowia Adam Niedzielski. - Klasa, która okaże się najbardziej pilna i sumienna, otrzyma od MEN i MZ środki na sfinansowanie w całości jednego z szesnastu profesjonalnych respiratorów moblinych o wartości 50 tys. złotych – zapowiedział Dariusz Piontkowski. Podstawą rozliczenia będą listy obecności, które dyrekcja szkół będzie musiała dostarczyć do kuratorium. Minister edukacji przypomniał, że do średniej będzie liczona obecność na lekcji religii (Podwójnie).                           PiS ukarał Jacka Sasina. Musi wydrukować Nie będę robił wyborów bez ustawy 30 milionów razy  Jacek Sasin zapamięta tę lekcję na całe życie. Minister ma 30 milionów razy wydrukować zdanie Nie będę robił wyborów bez podstawy prawnej.To kara od Jarosława Kaczyńskiego za wydrukowanie 30 milionów razy pakietów wyborczych bez podstawy prawnej.Nie od dziś wiadomo, że Jarosław Kaczyński to bardzo wymagający prezes. Kara, jaką nałożył na Jacka Sasina, wydaje się surowa, ale adekwatna do czynów niesfornego ministra.Jak udało się nam dowiedzieć, w grę wchodził zakaz uczestnictwa w wycieczkach do Torunia do końca roku, upomnienie przy Zgromadzeniu Narodowym, a nawet przeniesienie do ławy poselskiej przy Marku Suskim.Prezes nie był jednak aż tak okrutny.Stanęło na tym, że Jacek Sasin musi 30 milionów razy wydrukować Nie będę robił wyborów bez ustawy. - Jest dopiero przy sześćdziesiątej ósmej kartce, a w drukarce powoli zaczyna brakować papieru - przyznaje osoba z biura poselskiego Jacka Sasina. -Jak tak dalej pójdzie, skończy nam się budżet na materiały biurowe.Gdy doliczyć do tego koszt kopert, atramentu, a także znaczków do wysyłki na ul.Nowogrodzką w Warszawie do kontroli, biuro poselskie Jacka Sasina mogłoby się nie podnieść. Dlatego minister wpadł na genialny pomysł: zleci wydrukowanie 30 milionów kopii Polskiej Wytwórni Papierów Wartościowych. Mateusz Morawiecki zapewnił, że pieniądze na zlecenie do PWPW w budżecie na pewno się znajdą i Jacek Sasin będzie mógł spokojnie wrócić do pracy na rzecz kraju.                                    Szumowski: Gdyby nie Śląsk, byłoby po pandemii.Przekazanie Śląska Niemcom jeszcze dziś.Łukasz Szumowski powiedział w niedzielę, że jedynym powodem, dla którego w Polsce przebieg epidemii nie ma jeszcze tendencji spadkowej, są ogniska zakażeń na Śląsku.Dlatego jeszcze dziś rząd przekaże Śląsk Niemcom.- Jeżeli byśmy oddzielili Śląsk i zakażenia koronawirusem w kopalniach od przebiegu epidemii w Polsce, to mielibyśmy już tendencje spadkową - ocenił minister zdrowia Łukasz Szumowski. Testy na koronawirusa wśród górników przyniosły wiele wyników dodatnich.W tej chwili z pięciu głównych śląskich kopalni, w dwóch praca jest całkowicie wstrzymana.Wniosek, co rząd powinien teraz zrobić, nasunął się sam. - Pertraktacje nie były łatwe, ale miło mi poinformować, że dzisiaj o 18:00 podpiszemy umowę o przekazaniu Górnego Śląska Republice Federalnej Niemiec - mówi Mateusz Morawiecki. Podkreśla, że to ogromny sukces polskiego rządu. Sytuację skomentowali sami Ślązacy. Niestety nikt nie zrozumiał ich śmiesznej gwary.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddBalance(Convert.ToInt32(Math.Ceiling(1 * multiplier)));
                Update();
            }
            catch (OverflowException ex)
            {
                Win();
            }
        }

        void AddBalance(int val)
        {
            balance += val;
            Update();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sasin_norma;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sasin_wkurw;
        }

        //szumi
        private void button4_Click(object sender, EventArgs e)
        {
            if (balance >= 100)
            {
                panel1.Show();
                minst[0] += 1;
                label6.Text = minst[0].ToString()+"ŻYDA";
                balance -= 100;
                multiplier *= 1.1;
                Update();
            }
        }

        //premir
        private void button3_Click(object sender, EventArgs e)
        {
            if (balance >= 1000)
            {
                panel2.Show();
                minst[1] += 1;
                label7.Text = minst[1].ToString() + "ŻYDA";
                balance -= 1000;
                multiplier *= 1.3;
                Update();
            }
        }

        //prezid
        private void button2_Click(object sender, EventArgs e)
        {
            if (balance >= 10000)
            {
                panel3.Show();
                minst[2] += 1;
                label3.Text = minst[2].ToString() + "ŻYDA";
                balance -= 10000;
                multiplier *= 1.5;
                Update();
            }
        }

        void Update()
        {
            label4.Text = balance.ToString() + "S";
            label5.Text = "Obecna Korupcja (około) " + multiplier.ToString() + " Narciarzy";
            label2.Text = "Aktywni Agenci " + (minst[4] + minst[3]).ToString();
            label6.Text = minst[0].ToString() + "ŻYDA";
            label7.Text = minst[1].ToString() + "ŻYDA";
            label3.Text = minst[2].ToString() + "ŻYDA";
            if (yearruling > 1)
            {
                label8.Text = "U władzy już od " + yearruling + " lat";
            }
            if (balance < 0)
            {
                Win();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (balance >= 100000)
            {
                balance -= 100000;
                minst[3] += 1;
                fsb = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (balance >= 1000000)
            {
                balance -= 1000000;
                minst[4] += 1;
                mosad = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (fsb)
                {
                    AddBalance(Convert.ToInt32(minst[3] * multiplier));
                }
                if (mosad)
                {
                    AddBalance(Convert.ToInt32(10 * minst[4] * multiplier));
                }
                Update();
            }
            catch (OverflowException ex)
            {
                Win();
            }
        }
        void Win()
        {
            timer1.Enabled = false;
            balance = 0;
            Array.Clear(minst, 0, minst.Length);
            yearruling += 1;
            multiplier = 1;
            Update();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            MessageBox.Show("Z ostatniej chwili:\nW tym roku udało się utrzymać reżimową telewizje!\nMamy 51% poparcia.\nNa koronawirusa zmarł twój stary.\nGratulacje towarzyszu!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                infobar = info.Substring(0,42);
                info = info.Substring(1);
                label10.Text = infobar;
            }
            catch
            {
                timer2.Enabled = false;
                label10.Text = "TVP blisko upadku";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddBalance(100000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] save = File.ReadAllLines("save.txt");
                balance = Convert.ToInt32(save[0]);
                multiplier = Convert.ToDouble(save[1]);
                yearruling = Convert.ToInt32(save[2]);
                minst[0] = Convert.ToInt32(save[3]);
                minst[1] = Convert.ToInt32(save[4]);
                minst[2] = Convert.ToInt32(save[5]);
                minst[3] = Convert.ToInt32(save[6]);
                minst[4] = Convert.ToInt32(save[7]);
                if (minst[0] > 0)
                {
                    panel1.Show();
                }
                if (minst[1] > 0)
                {
                    panel2.Show();
                }
                if (minst[2] > 0)
                {
                    panel3.Show();
                }
                setParts(yearruling);
                Update();
                label11.Hide();
            }
            catch(Exception x)
            {
                label11.Hide();
                MessageBox.Show("Nowego gracza wita\n0cbe4e7a3a4ac6df2460b63fa69d59cc");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] save = new string[8];
            save[0] = balance.ToString();
            save[1] = multiplier.ToString();
            save[2] = yearruling.ToString();
            save[3] = minst[0].ToString();
            save[4] = minst[1].ToString();
            save[5] = minst[2].ToString();
            save[6] = minst[3].ToString();
            save[7] = minst[4].ToString();
            File.WriteAllLines("save.txt",save);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Hide();
            button8.Hide();
            label12.Hide();
            pictureBox1.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            button8.Hide();
            label12.Text = "BEZ DRUKARKI";
        }

        public void setParts(int year)
        {
            pictureBox1.Hide();
            label12.Hide();
            button8.Hide();
            button9.Hide();
            if (year >= 2) { 
                    pictureBox1.Show();
                    label12.Show();
                    button9.Show();
                    button8.Show();
            }
        }
    }
}
