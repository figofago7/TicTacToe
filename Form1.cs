using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        char p1, p2, p3, p4, p5, p6, p7, p8, p9;    //kolejne pola planszy ('n' - nic, 'o' - kolko, 'x' - krzyzyk)
        char ruch;  //kto wykonuje ruch ('o' - kolko, 'x' - krzyzyk)
        int ilosc = 9; //ilosc ruchow pozostala do konca gry

        void sprawdz() //funkcja sprawdzajaca, czy nastapila wygrana
        {
            if ((p1 == p2 && p2 == p3 && p1 != 'n') ||
               (p4 == p5 && p5 == p6 && p4 != 'n') ||
               (p7 == p8 && p8 == p9 && p7 != 'n') ||
               (p1 == p4 && p4 == p7 && p1 != 'n') ||
               (p2 == p5 && p5 == p8 && p2 != 'n') ||
               (p3 == p6 && p6 == p9 && p3 != 'n') ||
               (p1 == p5 && p5 == p9 && p1 != 'n') ||
               (p3 == p5 && p5 == p7 && p3 != 'n'))
            {
                string wiadomosc;
                if (ruch == 'o')
                    wiadomosc = "Wygrywa krzyżyk.";
                else
                    wiadomosc = "Wygrywa kółko.";

                if (pole1.Enabled == true)
                    pole1.Enabled = false;
                if (pole2.Enabled == true)
                    pole2.Enabled = false;
                if (pole3.Enabled == true)
                    pole3.Enabled = false;
                if (pole4.Enabled == true)
                    pole4.Enabled = false;
                if (pole5.Enabled == true)
                    pole5.Enabled = false;
                if (pole6.Enabled == true)
                    pole6.Enabled = false;
                if (pole7.Enabled == true)
                    pole7.Enabled = false;
                if (pole8.Enabled == true)
                    pole8.Enabled = false;
                if (pole9.Enabled == true)
                    pole9.Enabled = false;
                MessageBox.Show(wiadomosc, "Koniec Gry.");
            }
            else if (ilosc == 0)
            {
                pole10.Image = TicTacToe.Properties.Resources.nic;
                MessageBox.Show("Remis", "Koniec Gry.");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //inicjalizacja warstwy graficznej
            pole1.Image = TicTacToe.Properties.Resources.nic;
            pole2.Image = TicTacToe.Properties.Resources.nic;
            pole3.Image = TicTacToe.Properties.Resources.nic;
            pole4.Image = TicTacToe.Properties.Resources.nic;
            pole5.Image = TicTacToe.Properties.Resources.nic;
            pole6.Image = TicTacToe.Properties.Resources.nic;
            pole7.Image = TicTacToe.Properties.Resources.nic;
            pole8.Image = TicTacToe.Properties.Resources.nic;
            pole9.Image = TicTacToe.Properties.Resources.nic;
            pole10.Image = TicTacToe.Properties.Resources.ooo;

            //inicjalizacja logiki gry
            p1 = 'n'; p2 = 'n'; p3 = 'n';
            p4 = 'n'; p5 = 'n'; p6 = 'n';
            p7 = 'n'; p8 = 'n'; p9 = 'n';
            ruch = 'o';

            //czyszczenie pola gry (dopisane do buttona Wyczysc - button1)
            pole1.Enabled = true;
            pole2.Enabled = true;
            pole3.Enabled = true;
            pole4.Enabled = true;
            pole5.Enabled = true;
            pole6.Enabled = true;
            pole7.Enabled = true;
            pole8.Enabled = true;
            pole9.Enabled = true;

            ilosc = 9;
        }

        private void pole1_Click(object sender, System.EventArgs e)
        {
            if (p1 == 'n')
            {
                if (ruch == 'o')
                {
                    p1 = 'o';
                    pole1.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p1 = 'x';
                    pole1.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole1.Enabled = false;
                ilosc--;
                sprawdz();
           }
        }

        private void pole2_Click(object sender, System.EventArgs e)
        {
            if (p2 == 'n')
            {
                if (ruch == 'o')
                {
                    p2 = 'o';
                    pole2.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p2 = 'x';
                    pole2.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole2.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }

        private void pole3_Click(object sender, System.EventArgs e)
        {
            if (p3 == 'n')
            {
                if (ruch == 'o')
                {
                    p3 = 'o';
                    pole3.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p3 = 'x';
                    pole3.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole3.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }

        private void pole4_Click(object sender, System.EventArgs e)
        {
            if (p4 == 'n')
            {
                if (ruch == 'o')
                {
                    p4 = 'o';
                    pole4.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p4 = 'x';
                    pole4.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole4.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }

        private void pole5_Click(object sender, System.EventArgs e)
        {
            if (p5 == 'n')
            {
                if (ruch == 'o')
                {
                    p5 = 'o';
                    pole5.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p5 = 'x';
                    pole5.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole5.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }

        private void pole6_Click(object sender, System.EventArgs e)
        {
            if (p6 == 'n')
            {
                if (ruch == 'o')
                {
                    p6 = 'o';
                    pole6.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p6 = 'x';
                    pole6.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole6.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }

        private void pole7_Click(object sender, System.EventArgs e)
        {
            if (p7 == 'n')
            {
                if (ruch == 'o')
                {
                    p7 = 'o';
                    pole7.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p7 = 'x';
                    pole7.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole7.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }

        private void pole8_Click(object sender, System.EventArgs e)
        {
            if (p8 == 'n')
            {
                if (ruch == 'o')
                {
                    p8 = 'o';
                    pole8.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p8 = 'x';
                    pole8.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole8.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }

        private void pole9_Click(object sender, System.EventArgs e)
        {
            if (p9 == 'n')
            {
                if (ruch == 'o')
                {
                    p9 = 'o';
                    pole9.Image = TicTacToe.Properties.Resources.ooo;
                    pole10.Image = TicTacToe.Properties.Resources.xxx;
                    ruch = 'x';
                }
                else
                {
                    p9 = 'x';
                    pole9.Image = TicTacToe.Properties.Resources.xxx;
                    pole10.Image = TicTacToe.Properties.Resources.ooo;
                    ruch = 'o';
                }
                pole9.Enabled = false;
                ilosc--;
                sprawdz();
            }
        }
    }

        
    }

