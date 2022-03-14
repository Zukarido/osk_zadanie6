namespace Linia
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
            this.components = new System.ComponentModel.Container();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.timerpresence = new System.Windows.Forms.Timer(this.components);
            this.labellogin = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textboxlogin = new System.Windows.Forms.TextBox();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.timeralarm = new System.Windows.Forms.Timer(this.components);
            this.buttonpresencecheck = new System.Windows.Forms.Button();
            this.timertologout = new System.Windows.Forms.Timer(this.components);
            this.labeltemperatura = new System.Windows.Forms.Label();
            this.textboxtemperatura = new System.Windows.Forms.TextBox();
            this.buttonspeedown = new System.Windows.Forms.Button();
            this.buttonspeedup = new System.Windows.Forms.Button();
            this.buttonadditionalfan = new System.Windows.Forms.Button();
            this.timerapp = new System.Windows.Forms.Timer(this.components);
            this.buttonboiler = new System.Windows.Forms.Button();
            this.textboxlinespeed = new System.Windows.Forms.TextBox();
            this.progressbarpotatoes = new System.Windows.Forms.ProgressBar();
            this.labellinespeed = new System.Windows.Forms.Label();
            this.buttonpotatoes = new System.Windows.Forms.Button();
            this.labelpotatoesstate = new System.Windows.Forms.Label();
            this.pictureboxline = new System.Windows.Forms.PictureBox();
            this.timerline = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxline)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(688, 12);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.TabStop = false;
            this.buttonlogin.Text = "Log in";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // timerpresence
            // 
            this.timerpresence.Interval = 1000;
            this.timerpresence.Tick += new System.EventHandler(this.onesecondtick);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(610, 39);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(29, 13);
            this.labellogin.TabIndex = 1;
            this.labellogin.Text = "login";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(610, 65);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(52, 13);
            this.labelpassword.TabIndex = 2;
            this.labelpassword.Text = "password";
            // 
            // textboxlogin
            // 
            this.textboxlogin.Location = new System.Drawing.Point(688, 39);
            this.textboxlogin.Name = "textboxlogin";
            this.textboxlogin.Size = new System.Drawing.Size(100, 20);
            this.textboxlogin.TabIndex = 3;
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(688, 65);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(100, 20);
            this.textboxpassword.TabIndex = 4;
            // 
            // timeralarm
            // 
            this.timeralarm.Interval = 1000;
            this.timeralarm.Tick += new System.EventHandler(this.turnonalarm);
            // 
            // buttonpresencecheck
            // 
            this.buttonpresencecheck.Location = new System.Drawing.Point(-3, 0);
            this.buttonpresencecheck.Name = "buttonpresencecheck";
            this.buttonpresencecheck.Size = new System.Drawing.Size(52, 46);
            this.buttonpresencecheck.TabIndex = 5;
            this.buttonpresencecheck.UseVisualStyleBackColor = true;
            this.buttonpresencecheck.Click += new System.EventHandler(this.buttonpresencecheck_Click);
            // 
            // timertologout
            // 
            this.timertologout.Interval = 1000;
            this.timertologout.Tick += new System.EventHandler(this.timertologout_Tick);
            // 
            // labeltemperatura
            // 
            this.labeltemperatura.AutoSize = true;
            this.labeltemperatura.Location = new System.Drawing.Point(24, 361);
            this.labeltemperatura.Name = "labeltemperatura";
            this.labeltemperatura.Size = new System.Drawing.Size(63, 13);
            this.labeltemperatura.TabIndex = 6;
            this.labeltemperatura.Text = "temperatura";
            // 
            // textboxtemperatura
            // 
            this.textboxtemperatura.Location = new System.Drawing.Point(12, 377);
            this.textboxtemperatura.Name = "textboxtemperatura";
            this.textboxtemperatura.Size = new System.Drawing.Size(100, 20);
            this.textboxtemperatura.TabIndex = 7;
            this.textboxtemperatura.Text = "70";
            // 
            // buttonspeedown
            // 
            this.buttonspeedown.Location = new System.Drawing.Point(12, 292);
            this.buttonspeedown.Name = "buttonspeedown";
            this.buttonspeedown.Size = new System.Drawing.Size(75, 39);
            this.buttonspeedown.TabIndex = 8;
            this.buttonspeedown.Text = "speed down";
            this.buttonspeedown.UseVisualStyleBackColor = true;
            this.buttonspeedown.Click += new System.EventHandler(this.buttonspeedown_Click);
            // 
            // buttonspeedup
            // 
            this.buttonspeedup.Location = new System.Drawing.Point(119, 293);
            this.buttonspeedup.Name = "buttonspeedup";
            this.buttonspeedup.Size = new System.Drawing.Size(75, 38);
            this.buttonspeedup.TabIndex = 9;
            this.buttonspeedup.Text = "speed up";
            this.buttonspeedup.UseVisualStyleBackColor = true;
            this.buttonspeedup.Click += new System.EventHandler(this.buttonspeedup_Click);
            // 
            // buttonadditionalfan
            // 
            this.buttonadditionalfan.BackColor = System.Drawing.Color.Red;
            this.buttonadditionalfan.Location = new System.Drawing.Point(231, 293);
            this.buttonadditionalfan.Name = "buttonadditionalfan";
            this.buttonadditionalfan.Size = new System.Drawing.Size(75, 38);
            this.buttonadditionalfan.TabIndex = 10;
            this.buttonadditionalfan.Text = "additional fan";
            this.buttonadditionalfan.UseVisualStyleBackColor = false;
            this.buttonadditionalfan.Click += new System.EventHandler(this.buttonadditionalfan_Click);
            // 
            // timerapp
            // 
            this.timerapp.Interval = 1000;
            this.timerapp.Tick += new System.EventHandler(this.timerapp_Tick);
            // 
            // buttonboiler
            // 
            this.buttonboiler.Location = new System.Drawing.Point(231, 361);
            this.buttonboiler.Name = "buttonboiler";
            this.buttonboiler.Size = new System.Drawing.Size(75, 36);
            this.buttonboiler.TabIndex = 11;
            this.buttonboiler.Text = "boiler room check";
            this.buttonboiler.UseVisualStyleBackColor = true;
            this.buttonboiler.Click += new System.EventHandler(this.buttonboiler_Click);
            // 
            // textboxlinespeed
            // 
            this.textboxlinespeed.Location = new System.Drawing.Point(118, 377);
            this.textboxlinespeed.Name = "textboxlinespeed";
            this.textboxlinespeed.Size = new System.Drawing.Size(100, 20);
            this.textboxlinespeed.TabIndex = 12;
            this.textboxlinespeed.Text = "5";
            // 
            // progressbarpotatoes
            // 
            this.progressbarpotatoes.Location = new System.Drawing.Point(336, 374);
            this.progressbarpotatoes.Name = "progressbarpotatoes";
            this.progressbarpotatoes.Size = new System.Drawing.Size(100, 23);
            this.progressbarpotatoes.TabIndex = 13;
            // 
            // labellinespeed
            // 
            this.labellinespeed.AutoSize = true;
            this.labellinespeed.Location = new System.Drawing.Point(138, 361);
            this.labellinespeed.Name = "labellinespeed";
            this.labellinespeed.Size = new System.Drawing.Size(55, 13);
            this.labellinespeed.TabIndex = 14;
            this.labellinespeed.Text = "line speed";
            // 
            // buttonpotatoes
            // 
            this.buttonpotatoes.Location = new System.Drawing.Point(336, 308);
            this.buttonpotatoes.Name = "buttonpotatoes";
            this.buttonpotatoes.Size = new System.Drawing.Size(100, 23);
            this.buttonpotatoes.TabIndex = 15;
            this.buttonpotatoes.Text = "add potatoes";
            this.buttonpotatoes.UseVisualStyleBackColor = true;
            this.buttonpotatoes.Click += new System.EventHandler(this.buttonpotatoes_Click);
            // 
            // labelpotatoesstate
            // 
            this.labelpotatoesstate.AutoSize = true;
            this.labelpotatoesstate.Location = new System.Drawing.Point(336, 355);
            this.labelpotatoesstate.Name = "labelpotatoesstate";
            this.labelpotatoesstate.Size = new System.Drawing.Size(74, 13);
            this.labelpotatoesstate.TabIndex = 16;
            this.labelpotatoesstate.Text = "potatoes state";
            // 
            // pictureboxline
            // 
            this.pictureboxline.Location = new System.Drawing.Point(480, 223);
            this.pictureboxline.Name = "pictureboxline";
            this.pictureboxline.Size = new System.Drawing.Size(325, 200);
            this.pictureboxline.TabIndex = 17;
            this.pictureboxline.TabStop = false;
            // 
            // timerline
            // 
            this.timerline.Interval = 1000;
            this.timerline.Tick += new System.EventHandler(this.timerline_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 504);
            this.Controls.Add(this.pictureboxline);
            this.Controls.Add(this.labelpotatoesstate);
            this.Controls.Add(this.buttonpotatoes);
            this.Controls.Add(this.labellinespeed);
            this.Controls.Add(this.progressbarpotatoes);
            this.Controls.Add(this.textboxlinespeed);
            this.Controls.Add(this.buttonboiler);
            this.Controls.Add(this.buttonadditionalfan);
            this.Controls.Add(this.buttonspeedup);
            this.Controls.Add(this.buttonspeedown);
            this.Controls.Add(this.textboxtemperatura);
            this.Controls.Add(this.labeltemperatura);
            this.Controls.Add(this.buttonpresencecheck);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.textboxlogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.buttonlogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Timer timerpresence;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textboxlogin;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.Timer timeralarm;
        private System.Windows.Forms.Button buttonpresencecheck;
        private System.Windows.Forms.Timer timertologout;
        private System.Windows.Forms.Label labeltemperatura;
        private System.Windows.Forms.TextBox textboxtemperatura;
        private System.Windows.Forms.Button buttonspeedown;
        private System.Windows.Forms.Button buttonspeedup;
        private System.Windows.Forms.Button buttonadditionalfan;
        private System.Windows.Forms.Timer timerapp;
        private System.Windows.Forms.Button buttonboiler;
        private System.Windows.Forms.TextBox textboxlinespeed;
        private System.Windows.Forms.ProgressBar progressbarpotatoes;
        private System.Windows.Forms.Label labellinespeed;
        private System.Windows.Forms.Button buttonpotatoes;
        private System.Windows.Forms.Label labelpotatoesstate;
        private System.Windows.Forms.PictureBox pictureboxline;
        private System.Windows.Forms.Timer timerline;
    }
}

