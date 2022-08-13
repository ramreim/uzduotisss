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


using System.Data.SqlClient;



namespace threaddsss
{
    public partial class Form1 : Form
    {

        #region labels_create


        Thread trd00 = new Thread(new ThreadStart(ThreadTask00));
        Thread trd01 = new Thread(new ThreadStart(ThreadTask01));
        Thread trd02 = new Thread(new ThreadStart(ThreadTask02));        
        Thread trd03 = new Thread(new ThreadStart(ThreadTask03));
        Thread trd04 = new Thread(new ThreadStart(ThreadTask04));
        Thread trd05 = new Thread(new ThreadStart(ThreadTask05));
        Thread trd06 = new Thread(new ThreadStart(ThreadTask06));
        Thread trd07 = new Thread(new ThreadStart(ThreadTask07));
        Thread trd08 = new Thread(new ThreadStart(ThreadTask08));
        Thread trd09 = new Thread(new ThreadStart(ThreadTask09));
        Thread trd10 = new Thread(new ThreadStart(ThreadTask10));
        Thread trd11 = new Thread(new ThreadStart(ThreadTask11));
        Thread trd12 = new Thread(new ThreadStart(ThreadTask12));
        Thread trd13 = new Thread(new ThreadStart(ThreadTask13));
        Thread trd14 = new Thread(new ThreadStart(ThreadTask14));
        Thread trd15 = new Thread(new ThreadStart(ThreadTask15));


        public static ListView atsakymusarasas = new ListView();



        public static char[] letters = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa".ToCharArray();

        //string pirmas = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";




        public static Label lbl001 = new Label();
        public static Label lbl002 = new Label();
        public static Label lbl003 = new Label();
        public static Label lbl004 = new Label();
        public static Label lbl005 = new Label();

        public static TextBox tboxmin = new TextBox();
        //public static TextBox tboxmax = new TextBox();





        public static int skaicius2 = 0;
        public static int skaicius03 = 0;
        public static int skaicius04 = 0;
        public static int skaicius05 = 0;

        public static int ivestasSakuSk = 0;

        // private Thread trd;
        #endregion labels_create

        public Form1()
        {

            #region labels_kordinates

            InitializeComponent();


            lbl001.Left = 50;
            lbl001.Top = 50;
            lbl001.Height = 20;
            lbl001.Width = 150;
            lbl001.Text = "tim01";
            this.Controls.Add(lbl001);


            lbl002.Left = 50;
            lbl002.Top = 90;
            lbl002.Height = 20;
            lbl002.Width = 150;
            lbl002.Text = "tim02";
            this.Controls.Add(lbl002);


            lbl003.Left = 50;
            lbl003.Top = 130;
            lbl003.Height = 20;
            lbl003.Width = 50;
            lbl003.Text = "tim03";
            this.Controls.Add(lbl003);


            lbl004.Left = 50;
            lbl004.Top = 170;
            lbl004.Height = 20;
            lbl004.Width = 50;
            lbl004.Text = "tim04";
            this.Controls.Add(lbl004);


            lbl005.Left = 50;
            lbl005.Top = 210;
            lbl005.Height = 20;
            lbl005.Width = 50;
            lbl005.Text = "tim05";
            this.Controls.Add(lbl005);


            tboxmin.Left = 200;
            tboxmin.Top = 50;
            tboxmin.Height = 20;
            tboxmin.Width = 50;
            tboxmin.Text = "2";
            this.Controls.Add(tboxmin);




            ColumnHeader trIdCol = new ColumnHeader();
            trIdCol.Text = "ID";
            trIdCol.Width = 50;
            trIdCol.TextAlign = HorizontalAlignment.Left;

            ColumnHeader eiluteCol = new ColumnHeader();
            eiluteCol.Text = "Eilute";
            eiluteCol.Width = 200;
            eiluteCol.TextAlign = HorizontalAlignment.Left;


            atsakymusarasas.View = View.Details;
            atsakymusarasas.LabelEdit = true;
            atsakymusarasas.CheckBoxes = false;
            atsakymusarasas.FullRowSelect = true;
            atsakymusarasas.GridLines = true;
            atsakymusarasas.Sorting = System.Windows.Forms.SortOrder.None;


            atsakymusarasas.Left = 850;
            atsakymusarasas.Top = 20;
            atsakymusarasas.Height = 500;
            atsakymusarasas.Width = 250;


            atsakymusarasas.Columns.Add(trIdCol);
            atsakymusarasas.Columns.Add(eiluteCol);
            this.Controls.Add(atsakymusarasas);






            /*

            tboxmax.Left = 280;
            tboxmax.Top = 50;
            tboxmax.Height = 20;
            tboxmax.Width = 50;
            tboxmax.Text = "15";
            this.Controls.Add(tboxmax);

            */


            #endregion labels_kordinates

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This is the main thread");

            try
            {
                ivestasSakuSk = Convert.ToInt16(tboxmin.Text);
            }
            catch (Exception ee){
                MessageBox.Show("klaida, neteisingas saku skaicius\nturi buti nuo 2 iki 15  \n\n\n" + ee.ToString());
                tboxmin.Text = "2";
            }


            if (ivestasSakuSk < 2 || ivestasSakuSk > 15)
            {
                ivestasSakuSk = 0;
                MessageBox.Show("klaida, neteisingas saku skaicius\nturi buti nuo 2 iki 15  \n\n\n");
                tboxmin.Text = "2";
            }




            #region saku_startas



            if (ivestasSakuSk > 0)
            {

                btnStart.Enabled = false;
                btnStop.Enabled = true;
                btnResume.Enabled = false;
                tboxmin.Enabled = false;


                trd00.IsBackground = true;
                trd00.Start();
            }


            if (ivestasSakuSk > 1)
            {
                trd01.IsBackground = true;
                trd01.Start();
            }

            if (ivestasSakuSk > 2)
            {
                trd02.IsBackground = true;
                trd02.Start();
            }

            if (ivestasSakuSk > 3)
            {
                trd03.IsBackground = true;
                trd03.Start();
            }

            if (ivestasSakuSk > 4)
            {
                trd04.IsBackground = true;
                trd04.Start();
            }

            if (ivestasSakuSk > 5)
            {
                trd05.IsBackground = true;
                trd05.Start();
            }

            if (ivestasSakuSk > 6)
            {
                trd06.IsBackground = true;
                trd06.Start();
            }

            if (ivestasSakuSk > 7)
            {
                trd07.IsBackground = true;
                trd07.Start();
            }

            if (ivestasSakuSk > 8)
            {
                trd08.IsBackground = true;
                trd08.Start();
            }

            if (ivestasSakuSk > 9)
            {
                trd09.IsBackground = true;
                trd09.Start();
            }

            if (ivestasSakuSk > 10)
            {
                trd10.IsBackground = true;
                trd10.Start();
            }

            if (ivestasSakuSk > 11)
            {
                trd11.IsBackground = true;
                trd11.Start();
            }

            if (ivestasSakuSk > 12)
            {
                trd12.IsBackground = true;
                trd12.Start();
            }

            if (ivestasSakuSk > 13)
            {
                trd13.IsBackground = true;
                trd13.Start();
            }

            if (ivestasSakuSk > 14)
            {
                trd14.IsBackground = true;
                trd14.Start();
            }


            if (ivestasSakuSk > 15)
            {
                trd15.IsBackground = true;
                trd15.Start();
            }


            /*



            //Thread trd02 = new Thread(new ThreadStart(this.ThreadTask2));
            trd02.IsBackground = true;
            trd02.Start();


            //Thread trd03 = new Thread(new ThreadStart(this.ThreadTask03));
            trd03.IsBackground = true;
            trd03.Start();


            //Thread trd04 = new Thread(new ThreadStart(this.ThreadTask04));
            trd04.IsBackground = true;
            trd04.Start();


            //Thread trd05 = new Thread(new ThreadStart(this.ThreadTask05));
            trd05.IsBackground = true;
            trd05.Start();

            trd06.IsBackground = true;
            trd06.Start();

            trd07.IsBackground = true;
            trd07.Start();

            trd08.IsBackground = true;
            trd08.Start();


            trd09.IsBackground = true;
            trd09.Start();

            trd10.IsBackground = true;
            trd10.Start();

            trd11.IsBackground = true;
            trd11.Start();

            trd12.IsBackground = true;
            trd12.Start();


            trd13.IsBackground = true;
            trd13.Start();


            trd14.IsBackground = true;
            trd14.Start();

            trd15.IsBackground = true;
            trd15.Start();
            */


            #endregion saku_startas

        }


        public static void ThreadTask00()
        {

            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "00", randstring });
                    atsakymusarasas.Items.Add(item);

                  

               

                    irasymasDB(0, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }

                });
            }


        }


        public static void ThreadTask01()
        {

            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();



                

                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] {  "01", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(1, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }
                });
            }



        }





        public static void ThreadTask02()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "02", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(2, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }

                });
            }
        }





        public static void ThreadTask03()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "03", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(3, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }

                });
            }
        }


        public static void ThreadTask04()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "04", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(4, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }

                });
            }
        }




        public static void ThreadTask05()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "05", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(5, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }

        public static void ThreadTask06()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "06", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(6, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }

                });
            }
        }

        public static void ThreadTask07()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "07", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(7, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }

        public static void ThreadTask08()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "08", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(8, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }

        public static void ThreadTask09()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "09", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(9, DateTime.Now.ToString("HH:mm:ss"), randstring);
                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }

        public static void ThreadTask10()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "10", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(10, DateTime.Now.ToString("HH:mm:ss"), randstring);
                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }

        }

        public static void ThreadTask11()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "11", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(11, DateTime.Now.ToString("HH:mm:ss"), randstring);
                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }

        public static void ThreadTask12()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "12", randstring });
                    atsakymusarasas.Items.Add(item);
                    irasymasDB(12, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }

        public static void ThreadTask13()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "13", randstring });
                    atsakymusarasas.Items.Add(item);
                    irasymasDB(13, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }

        public static void ThreadTask14()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "14", randstring });
                    atsakymusarasas.Items.Add(item);

                    irasymasDB(14, DateTime.Now.ToString("HH:mm:ss"), randstring);

                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }
        public static void ThreadTask15()
        {
            while (true)
            {
                string randstring = "";

                Random rndEilutesIlgis = new Random();
                Random rndSleepLaikasMS = new Random();

                Random RandomStringNumber = new Random();

                Random rnd = new Random();





                for (int i = 0; i <= rnd.Next(5, 10); i++)
                {
                    randstring += (char)RandomStringNumber.Next(48, 125);
                }
                Thread.Sleep(rnd.Next(500, 2000));

                lbl001.Invoke((MethodInvoker)delegate ()
                {
                    lbl001.Text = randstring.ToString();

                    ListViewItem item = new ListViewItem();
                    item = new ListViewItem(new string[] { "15", randstring });
                    atsakymusarasas.Items.Add(item);
                    irasymasDB(15, DateTime.Now.ToString("HH:mm:ss"), randstring);


                    if (atsakymusarasas.Items.Count > 20)
                    {
                        atsakymusarasas.Items.RemoveAt(0);
                    }


                });
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //trd01.Abort();

            btnStart.Enabled = false;
            btnStop.Enabled = false;
            btnResume.Enabled = true;
            tboxmin.Enabled = false;



            if (ivestasSakuSk > 0)
            {
                trd00.Suspend();
            }

            if (ivestasSakuSk > 1)
            {
                trd01.Suspend();
            }



            if (ivestasSakuSk > 2)
            {
                trd02.Suspend();
            }


            if (ivestasSakuSk > 3)
            {
                trd03.Suspend();
            }


            if (ivestasSakuSk > 4)
            {
                trd04.Suspend();
            }


            if (ivestasSakuSk > 5)
            {
                trd05.Suspend();
            }


            if (ivestasSakuSk > 6)
            {
                trd06.Suspend();
            }


            if (ivestasSakuSk > 7)
            {
                trd07.Suspend();
            }

            if (ivestasSakuSk > 8)
            {
                trd08.Suspend();
            }

            if (ivestasSakuSk > 9)
            {
                trd09.Suspend();
            }


            if (ivestasSakuSk > 10)
            {
                trd10.Suspend();
            }


            if (ivestasSakuSk > 11)
            {
                trd11.Suspend();
            }

            if (ivestasSakuSk > 12)
            {
                trd12.Suspend();
            }

            if (ivestasSakuSk > 13)
            {
                trd13.Suspend();
            }



            if (ivestasSakuSk > 14)
            {
                trd14.Suspend();
            }


            if (ivestasSakuSk > 15)
            {
                trd15.Suspend();
            }



       




        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnResume.Enabled = false;
            tboxmin.Enabled = false;


            

            if (ivestasSakuSk > 0)
            {
                trd00.Resume();
            }


            if (ivestasSakuSk > 1)
            {
                trd01.Resume();
            }



            if (ivestasSakuSk > 2)
            {
                trd02.Resume();
            }



            if (ivestasSakuSk > 3)
            {
                trd03.Resume();
            }



            if (ivestasSakuSk > 4)
            {
                trd04.Resume();
            }



            if (ivestasSakuSk > 5)
            {
                trd05.Resume();
            }



            if (ivestasSakuSk > 6)
            {
                trd06.Resume();
            }



            if (ivestasSakuSk > 7)
            {
                trd07.Resume();
            }



            if (ivestasSakuSk > 8)
            {
                trd08.Resume();
            }




            if (ivestasSakuSk > 9)
            {
                trd09.Resume();
            }



            if (ivestasSakuSk > 10)
            {
                trd10.Resume();
            }



            if (ivestasSakuSk > 11)
            {
                trd11.Resume();
            }



            if (ivestasSakuSk > 12)
            {
                trd12.Resume();
            }



            if (ivestasSakuSk > 13)
            {
                trd13.Resume();
            }



            if (ivestasSakuSk > 14)
            {
                trd14.Resume();
            }



            if (ivestasSakuSk > 15)
            {
                trd15.Resume();
            }







            //atsakymusarasas.Update();
        }



       static void irasymasDB(int gautasid, string gautas_laikas, string gauta_eilute)
        {


            SqlConnection conn = new SqlConnection("Server=192.168.0.105;Database=uvsDB;Integrated Security=True;");


            conn.Open();


            //INSERT PRADZIA

            //INSERT INTO table_name(column1, column2, column3, ...) VALUES(value1, value2, value3, ...);
            //sakinys = "INSERT INTO salestable(ThreadID, Timee, Data) VALUES('VARDAS0" + "hjk" + "')";

            string sakinys = "";
                sakinys = "INSERT INTO sakosTable(ThreadID, Timee, Data) VALUES(" + gautasid +", '" + gautas_laikas + "', '" + gauta_eilute + "')";


                SqlCommand cmd = new SqlCommand(sakinys, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
           

            conn.Close();
            //INSERT PABAIGA



        }
    }
}
