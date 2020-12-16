using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace RussianRGun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     //   RussianRGame RRGClass = new RussianRGame();
        int bullet;
        int chance = 2;
        int num;
        int point;

         int  points;
        int num1, num2, add;

        SoundPlayer load = new SoundPlayer(RussianRGun.Properties.Resources.loadp);
        SoundPlayer fire = new SoundPlayer(RussianRGun.Properties.Resources.Firep);

        string message;

        int[] chamber = { 0, 0, 0, 0, 0, 0, };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadGunbtn_Click(object sender, EventArgs e)
        {
            bullet = 1;
            chance = 2;
            
            txtBullet.Text = bullet.ToString();
            txtChances.Text = chance.ToString();
            message = "Bullet is loaded ..Spin Chamber";
            textBox.Text = Convert.ToString(message);
            load.Play();
            ShootAwaybtn.Enabled = false;
            Shootbtn.Enabled = false;
            SpinRoulltebtn.Enabled = true;
            LoadGunbtn.Enabled = false;

        }

        private void SpinRoulltebtn_Click(object sender, EventArgs e)
        {
            Random myfun = new Random();
            int random = myfun.Next(1, 7);
            txtBullet.Text = random.ToString();
            message = "Chamber is run ... Fire ";
            textBox.Text = Convert.ToString(message);
            load.Play();
            LoadGunbtn.Enabled = true;
            SpinRoulltebtn.Enabled = false;
           
            Shootbtn.Enabled = true;
            ShootAwaybtn.Enabled = true;




            num = random;

        }

        private void Shootbtn_Click(object sender, EventArgs e)
        {
            point +=10;

            points += 5;

            fire.Play();
            num--;
            txtBullet.Text = num.ToString();
            message = "Fire....Fire ... Fire ";
            textBox1.Text = point.ToString();
            textBox.Text = Convert.ToString(message);
            textBox3.Text = add.ToString();

            if (num == 0) 
            {
                message = "You Loose";
                textBox.Text = Convert.ToString(message);
               

                Shootbtn.Enabled = false;
            }
            else
            {
                
            }


        }

        private void ShootAwaybtn_Click(object sender, EventArgs e)
        {
           
            point +=  10;

            points += 5;

            load.Play();
            chance--;
            num--;
            txtBullet.Text = num.ToString();
            textBox3.Text = add.ToString();
            if (num == 1)


            {
                message = "You Win";
                textBox.Text = Convert.ToString(message);
                textBox1.Text = point.ToString();
                load.Play();
                ShootAwaybtn.Enabled = false;
                Shootbtn.Enabled = false;
            }
            else if (chance == 0)
            {
                message = " You Loose";
                ShootAwaybtn.Enabled = false;
                textBox2.Text = points.ToString();
                load.Play();

            }

           textBox.Text =Convert.ToString(message);

                txtChances.Text = chance.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Are you sure to Exit the Game ", "Notice", MessageBoxButtons.YesNo);
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
            num1 = Convert.ToInt32(Convert.ToString(textBox1.Text));
            num2 = Convert.ToInt32(Convert.ToString(textBox2.Text));
            add = num1 - num2;
            

        }
    }
}

