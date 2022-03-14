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


namespace Linia
{
    public partial class Form1 : Form
    {
        static class Globals
        {
            public static bool loggedin = false;
            public static int timerpresencetime = 0;
            public static int timeralarmtime = 0;
            public static int timerlogouttime = 0;
            public static bool alarmon = false;
            public static float temeprature = 70;
            public static int linespeed = 5;
            public static bool additionalfan = false;
            public static bool boilertime = false;
            public static int boilertimeint = 0;
            public static String[] path = new string[2];
            public static Image[] myimage = new Image[2];
            public static int currentimage = 0;
        }

        public Form1()
        {
            InitializeComponent();
            textboxpassword.PasswordChar = '*';
            textboxpassword.MaxLength = 15;
            textboxlogin.MaxLength = 15;
            textboxtemperatura.Text = ("70");
            progressbarpotatoes.Minimum = 0;
            progressbarpotatoes.Maximum = 1000;
            progressbarpotatoes.Value = 1000;
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            
            Globals.path[0] = appPath + "\\foty\\fot1.png";
            Globals.path[1] = appPath + "\\foty\\fot2.png";
         

            Globals.myimage[0]= new Bitmap(Globals.path[0]);
            Globals.myimage[1] = new Bitmap(Globals.path[1]);
            pictureboxline.Image = Globals.myimage[0];

            timerapp.Start();
            timerline.Start();

        }
        
        private void onesecondtick(object sender, EventArgs e)
        {
            if (!Globals.alarmon)
            {
                if (Globals.loggedin)
                {
                    Globals.timerpresencetime++;
                    if (Globals.timerpresencetime == 30)
                    {
                        timerpresence.Stop();
                        Globals.timerpresencetime = 0;
                        timeralarm.Start();
                        checkpresence();    
                    }
                }
                
            }


        }

        private void turnonalarm(object sender, EventArgs e)
        {
            Globals.timeralarmtime++;
            if (Globals.timeralarmtime == 0)
            { 
            Globals.alarmon = true;
            }
            if (Globals.timeralarmtime == 30)
            {
                
                turnonalarm();
                
            }
          
              
            if (Globals.timeralarmtime % 2 == 1)
            {
                buttonpresencecheck.BackColor = Color.Red;
            }
            else
            {
                buttonpresencecheck.BackColor = SystemColors.Control;
            }
            if (Globals.timeralarmtime > 30)
            {
                Console.Beep(100, 400);
            }
            Console.WriteLine("alarm");
        }

        private void timertologout_Tick(object sender, EventArgs e)
        {
            Globals.timerlogouttime++;
            if (Globals.timerlogouttime == 10)
            {
                logout();
                Globals.timerlogouttime = 0;
                timertologout.Stop();
            }
            Console.WriteLine("logout");
        }

        private void timerapp_Tick(object sender, EventArgs e)
        {
            changetemp();
            if (progressbarpotatoes.Value >= Globals.linespeed)
                progressbarpotatoes.Value = progressbarpotatoes.Value - Globals.linespeed;
            else
                progressbarpotatoes.Value = 0;
            if (Globals.boilertime)
            {
                Globals.boilertimeint++;
                if (Globals.boilertimeint == 10)
                {
                    Globals.boilertime = false;
                    Globals.temeprature += 15;
                }
            }
            textboxtemperatura.Text = Globals.temeprature.ToString("R");
            textboxlinespeed.Text = Globals.linespeed.ToString();
        }

        private void timerline_Tick(object sender, EventArgs e)
        {
            if (!Globals.alarmon  && progressbarpotatoes.Value>0)
            {
                updateline();
                timerline.Interval = 1000 + 100 * (5 - Globals.linespeed);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // event holdery okna
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (!Globals.loggedin)
            {
                login();
            }
            else
            {
                logout();
            }
        }

        private void buttonpresencecheck_Click(object sender, EventArgs e)
        {
            if (Globals.loggedin)
            {
                turnoffalarm();
                Globals.timeralarmtime = 0;
                Globals.timerlogouttime = 0;
                Globals.timerpresencetime = 0;
                timerpresence.Start();
                timeralarm.Stop();
                buttonpresencecheck.BackColor = SystemColors.Control;
            }
        }

        private void buttonspeedown_Click(object sender, EventArgs e)
        {
            if(!Globals.alarmon && Globals.loggedin)
            {
                if (Globals.linespeed > 1)
                {
                    Globals.linespeed--;
                    textboxlinespeed.Text = Globals.linespeed.ToString();
                }
                timerapp.Stop();
                Globals.timerpresencetime = 0;
                Globals.temeprature -= 5;
                timerapp.Start();
                if (Globals.temeprature < 40 || Globals.temeprature > 110)
                {
                    if (Globals.temeprature < 40)
                    {
                        Globals.temeprature = 40;
                    }
                    if (Globals.temeprature > 110)
                    {
                        Globals.temeprature = 110;
                    }
                    textboxtemperatura.Text = Globals.temeprature.ToString("R");
                }
            }
        }

        private void buttonspeedup_Click(object sender, EventArgs e)
        {
            if (!Globals.alarmon && Globals.loggedin)
            {
                if (Globals.linespeed < 10)
                {
                    Globals.linespeed++;
                    textboxlinespeed.Text = Globals.linespeed.ToString();
                }
                timerapp.Stop();
                Globals.timerpresencetime = 0;
                Globals.temeprature += 5;
                timerapp.Start();
                if (Globals.temeprature < 40 || Globals.temeprature > 110)
                {
                    if (Globals.temeprature < 40)
                    {
                        Globals.temeprature = 40;
                    }
                    if (Globals.temeprature > 110)
                    {
                        Globals.temeprature = 110;
                    }
                    textboxtemperatura.Text = Globals.temeprature.ToString("R");
                }
            }
        }

        private void buttonadditionalfan_Click(object sender, EventArgs e)
        {
            if (!Globals.alarmon && Globals.loggedin)
            {

                Globals.timerpresencetime = 0;
                if (!Globals.additionalfan)
                {
                    Globals.additionalfan = true;
                    buttonadditionalfan.BackColor = Color.LawnGreen;
                }
                else
                {
                    Globals.additionalfan = false;
                    buttonadditionalfan.BackColor = Color.Red;
                }
           
            }
        }

        private void buttonboiler_Click(object sender, EventArgs e)
        {
            if (!Globals.alarmon && Globals.loggedin && ! Globals.boilertime)
            {
                Globals.timerpresencetime = 0;
                Globals.boilertime = true;
                if (Globals.temeprature < 40 || Globals.temeprature > 110)
                {
                    if (Globals.temeprature < 40)
                    {
                        Globals.temeprature = 40;
                    }
                    if (Globals.temeprature > 110)
                    {
                        Globals.temeprature = 110;
                    }
                    textboxtemperatura.Text = Globals.temeprature.ToString("R");
                }
            }
        }
        private void buttonpotatoes_Click(object sender, EventArgs e)
        {
            if (!Globals.alarmon && Globals.loggedin && progressbarpotatoes.Value<980)
            {
                progressbarpotatoes.Value += 20;
                Globals.timerpresencetime = 0;
            }
        }

        // funkcje
        private void login()
        {
            if(textboxlogin.Text=="admin" && textboxpassword.Text == "admin")
            {
                Globals.loggedin = true;
                buttonlogin.Text = "Log out";
                textboxlogin.Visible = false;
                textboxpassword.Visible = false;
                labelpassword.Visible = false;
                labellogin.Visible = false;
                timerpresence.Start();
            }
            else
            {
                string message = "Wrong credentials";
                string caption = "Cannot log you in";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void logout()
        {

            Globals.loggedin = false;
            buttonlogin.Text = "Log in";
            textboxlogin.Visible = true;
            textboxpassword.Visible = true;
            labelpassword.Visible = true;
            labellogin.Visible = true;
            textboxlogin.Text = "";
            textboxpassword.Text = "";
            Globals.timerpresencetime = 0;
            Globals.timerlogouttime = 0;
            timerpresence.Stop();
            timertologout.Stop();

        }

        private void checkpresence()
        {
            timeralarm.Start();
        }

        private void turnonalarm()
        {
            Console.WriteLine("alarm");
            timertologout.Start();
        }

        private void turnoffalarm()
        {
            Globals.alarmon = false;
            timeralarm.Stop();
            Globals.timeralarmtime = 0;
           

        }

        private void changetemp()
        {
            if (Globals.temeprature >= 40 && Globals.temeprature <= 110)
            {
                Random rnd = new Random();
                float value = rnd.Next(0, 21);
                float value2 = rnd.Next(1, 3);
                if (value == 10 || value == 0)
                {
                    if (value == 20)
                        Globals.temeprature += 20;
                    if (value == 0)
                        Globals.temeprature -= 20;
                }
                else
                {
                    if (value2 == 1)
                    {
                        Globals.temeprature += value / 10;
                    }
                    else
                    {
                        Globals.temeprature -= value / 10;
                    }
                }
                if (Globals.linespeed != 5)
                {
                    Globals.temeprature += (float)0.5 * (float)(Globals.linespeed - 5);
                }
                if (Globals.additionalfan)
                {
                    Globals.temeprature -= (float)0.5;
                }
                if (Globals.temeprature < 40)
                {
                    Globals.temeprature = 40;
                }
                if (Globals.temeprature > 110)
                {
                    Globals.temeprature = 110;
                }
            }
            Globals.temeprature = (float)Math.Round(Globals.temeprature, 1);
        }

        private int updateline()
        {
            if (Globals.currentimage == 0)
            {
                pictureboxline.Image = Globals.myimage[1];
                Globals.currentimage = 1;
                return 0;
            }
            if (Globals.currentimage == 1)
            {
                pictureboxline.Image = Globals.myimage[0];
                Globals.currentimage = 0;
                return 0;
            }
            return 0;
        }

    }
}
