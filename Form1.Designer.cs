
namespace RussianRGun
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadGunbtn = new System.Windows.Forms.Button();
            this.SpinRoulltebtn = new System.Windows.Forms.Button();
            this.Shootbtn = new System.Windows.Forms.Button();
            this.ShootAwaybtn = new System.Windows.Forms.Button();
            this.txtBullet = new System.Windows.Forms.TextBox();
            this.txtChances = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadGunbtn
            // 
            this.LoadGunbtn.BackColor = System.Drawing.Color.Gold;
            this.LoadGunbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGunbtn.Location = new System.Drawing.Point(33, 327);
            this.LoadGunbtn.Name = "LoadGunbtn";
            this.LoadGunbtn.Size = new System.Drawing.Size(141, 52);
            this.LoadGunbtn.TabIndex = 0;
            this.LoadGunbtn.Text = "Load Gun";
            this.LoadGunbtn.UseVisualStyleBackColor = false;
            this.LoadGunbtn.Click += new System.EventHandler(this.LoadGunbtn_Click);
            // 
            // SpinRoulltebtn
            // 
            this.SpinRoulltebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SpinRoulltebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinRoulltebtn.Location = new System.Drawing.Point(223, 331);
            this.SpinRoulltebtn.Name = "SpinRoulltebtn";
            this.SpinRoulltebtn.Size = new System.Drawing.Size(141, 50);
            this.SpinRoulltebtn.TabIndex = 1;
            this.SpinRoulltebtn.Text = "Chamber";
            this.SpinRoulltebtn.UseVisualStyleBackColor = false;
            this.SpinRoulltebtn.Click += new System.EventHandler(this.SpinRoulltebtn_Click);
            // 
            // Shootbtn
            // 
            this.Shootbtn.BackColor = System.Drawing.Color.Crimson;
            this.Shootbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shootbtn.Location = new System.Drawing.Point(441, 330);
            this.Shootbtn.Name = "Shootbtn";
            this.Shootbtn.Size = new System.Drawing.Size(139, 50);
            this.Shootbtn.TabIndex = 2;
            this.Shootbtn.Text = "Shoot";
            this.Shootbtn.UseVisualStyleBackColor = false;
            this.Shootbtn.Click += new System.EventHandler(this.Shootbtn_Click);
            // 
            // ShootAwaybtn
            // 
            this.ShootAwaybtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ShootAwaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAwaybtn.Location = new System.Drawing.Point(647, 331);
            this.ShootAwaybtn.Name = "ShootAwaybtn";
            this.ShootAwaybtn.Size = new System.Drawing.Size(141, 49);
            this.ShootAwaybtn.TabIndex = 3;
            this.ShootAwaybtn.Text = "Shoot Away";
            this.ShootAwaybtn.UseVisualStyleBackColor = false;
            this.ShootAwaybtn.Click += new System.EventHandler(this.ShootAwaybtn_Click);
            // 
            // txtBullet
            // 
            this.txtBullet.Location = new System.Drawing.Point(754, 369);
            this.txtBullet.Multiline = true;
            this.txtBullet.Name = "txtBullet";
            this.txtBullet.Size = new System.Drawing.Size(32, 23);
            this.txtBullet.TabIndex = 5;
            this.txtBullet.Visible = false;
            this.txtBullet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtChances
            // 
            this.txtChances.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChances.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtChances.Location = new System.Drawing.Point(712, 111);
            this.txtChances.Multiline = true;
            this.txtChances.Name = "txtChances";
            this.txtChances.Size = new System.Drawing.Size(76, 34);
            this.txtChances.TabIndex = 6;
            this.txtChances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Crimson;
            this.textBox.Location = new System.Drawing.Point(158, 405);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(408, 33);
            this.textBox.TabIndex = 7;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(33, 73);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(141, 49);
            this.Exitbtn.TabIndex = 8;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(721, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(721, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Points";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox1.Location = new System.Drawing.Point(571, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 34);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox2.Location = new System.Drawing.Point(571, 44);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 34);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox3.Location = new System.Drawing.Point(710, 44);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 34);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRGun.Properties.Resources.HE11_20111115_0076_open_rev;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.txtChances);
            this.Controls.Add(this.txtBullet);
            this.Controls.Add(this.ShootAwaybtn);
            this.Controls.Add(this.Shootbtn);
            this.Controls.Add(this.SpinRoulltebtn);
            this.Controls.Add(this.LoadGunbtn);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadGunbtn;
        private System.Windows.Forms.Button SpinRoulltebtn;
        private System.Windows.Forms.Button Shootbtn;
        private System.Windows.Forms.Button ShootAwaybtn;
        private System.Windows.Forms.TextBox txtBullet;
        private System.Windows.Forms.TextBox txtChances;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

