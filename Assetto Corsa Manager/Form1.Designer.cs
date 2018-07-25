namespace Assetto_Corsa_Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.speed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crpm = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.fuel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable1.Location = new System.Drawing.Point(9, 33);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(48, 20);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "RPM:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fuel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.crpm);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speed.Location = new System.Drawing.Point(124, 100);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(36, 20);
            this.speed.TabIndex = 6;
            this.speed.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Speed (km/h):";
            // 
            // gear
            // 
            this.gear.AutoSize = true;
            this.gear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gear.Location = new System.Drawing.Point(63, 67);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(18, 20);
            this.gear.TabIndex = 4;
            this.gear.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gear:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // crpm
            // 
            this.crpm.AutoSize = true;
            this.crpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.crpm.Location = new System.Drawing.Point(63, 33);
            this.crpm.Name = "crpm";
            this.crpm.Size = new System.Drawing.Size(45, 20);
            this.crpm.TabIndex = 2;
            this.crpm.Text = "8756";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboPorts);
            this.groupBox2.Location = new System.Drawing.Point(232, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect to Arduino";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ports:";
            // 
            // comboPorts
            // 
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(46, 35);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(121, 21);
            this.comboPorts.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fuel:";
            // 
            // fuel
            // 
            this.fuel.AutoSize = true;
            this.fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fuel.Location = new System.Drawing.Point(60, 134);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(27, 20);
            this.fuel.TabIndex = 8;
            this.fuel.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label crpm;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label fuel;
        private System.Windows.Forms.Label label2;
    }
}

