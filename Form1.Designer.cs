namespace PR_6 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.move_button = new System.Windows.Forms.Button();
            this.set_sails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shipName = new System.Windows.Forms.TextBox();
            this.steamName = new System.Windows.Forms.TextBox();
            this.corvetteName = new System.Windows.Forms.TextBox();
            this.sailableName = new System.Windows.Forms.TextBox();
            this.shipEn = new System.Windows.Forms.Label();
            this.steamEn = new System.Windows.Forms.Label();
            this.corvEn = new System.Windows.Forms.Label();
            this.sailEn = new System.Windows.Forms.Label();
            this.healthShip = new System.Windows.Forms.Label();
            this.healthSteam = new System.Windows.Forms.Label();
            this.healthCorv = new System.Windows.Forms.Label();
            this.healthWind = new System.Windows.Forms.Label();
            this.fuelShip = new System.Windows.Forms.Label();
            this.fuelSteam = new System.Windows.Forms.Label();
            this.fuelCorv = new System.Windows.Forms.Label();
            this.fuelWind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // move_button
            // 
            this.move_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.move_button.Location = new System.Drawing.Point(37, 390);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(216, 48);
            this.move_button.TabIndex = 0;
            this.move_button.Text = "Плити";
            this.move_button.UseVisualStyleBackColor = true;
            this.move_button.Click += new System.EventHandler(this.move_button_Click);
            // 
            // set_sails
            // 
            this.set_sails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_sails.Location = new System.Drawing.Point(37, 336);
            this.set_sails.Name = "set_sails";
            this.set_sails.Size = new System.Drawing.Size(216, 48);
            this.set_sails.TabIndex = 0;
            this.set_sails.Text = "Set sails!";
            this.set_sails.UseVisualStyleBackColor = true;
            this.set_sails.Click += new System.EventHandler(this.set_sails_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(523, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Корвет";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(225, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Корабель";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(703, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Вітрильник";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(371, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пароплав";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ім\'я";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Двигун запущено";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "Справність";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "Топливо";
            // 
            // shipName
            // 
            this.shipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shipName.Location = new System.Drawing.Point(208, 70);
            this.shipName.Name = "shipName";
            this.shipName.Size = new System.Drawing.Size(139, 31);
            this.shipName.TabIndex = 2;
            this.shipName.Text = "Кораблик";
            // 
            // steamName
            // 
            this.steamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steamName.Location = new System.Drawing.Point(371, 70);
            this.steamName.Name = "steamName";
            this.steamName.Size = new System.Drawing.Size(139, 31);
            this.steamName.TabIndex = 2;
            this.steamName.Text = "Пароплавчик";
            // 
            // corvetteName
            // 
            this.corvetteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corvetteName.Location = new System.Drawing.Point(532, 70);
            this.corvetteName.Name = "corvetteName";
            this.corvetteName.Size = new System.Drawing.Size(139, 31);
            this.corvetteName.TabIndex = 2;
            this.corvetteName.Text = "Корвет";
            // 
            // sailableName
            // 
            this.sailableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sailableName.Location = new System.Drawing.Point(703, 70);
            this.sailableName.Name = "sailableName";
            this.sailableName.Size = new System.Drawing.Size(139, 31);
            this.sailableName.TabIndex = 2;
            this.sailableName.Text = "Вітрильничик";
            // 
            // shipEn
            // 
            this.shipEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shipEn.Location = new System.Drawing.Point(225, 118);
            this.shipEn.Name = "shipEn";
            this.shipEn.Size = new System.Drawing.Size(101, 35);
            this.shipEn.TabIndex = 1;
            // 
            // steamEn
            // 
            this.steamEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steamEn.Location = new System.Drawing.Point(383, 118);
            this.steamEn.Name = "steamEn";
            this.steamEn.Size = new System.Drawing.Size(101, 35);
            this.steamEn.TabIndex = 1;
            // 
            // corvEn
            // 
            this.corvEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corvEn.Location = new System.Drawing.Point(543, 118);
            this.corvEn.Name = "corvEn";
            this.corvEn.Size = new System.Drawing.Size(101, 35);
            this.corvEn.TabIndex = 1;
            // 
            // sailEn
            // 
            this.sailEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sailEn.Location = new System.Drawing.Point(703, 118);
            this.sailEn.Name = "sailEn";
            this.sailEn.Size = new System.Drawing.Size(101, 35);
            this.sailEn.TabIndex = 1;
            // 
            // healthShip
            // 
            this.healthShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthShip.Location = new System.Drawing.Point(225, 165);
            this.healthShip.Name = "healthShip";
            this.healthShip.Size = new System.Drawing.Size(101, 35);
            this.healthShip.TabIndex = 1;
            // 
            // healthSteam
            // 
            this.healthSteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthSteam.Location = new System.Drawing.Point(383, 165);
            this.healthSteam.Name = "healthSteam";
            this.healthSteam.Size = new System.Drawing.Size(101, 35);
            this.healthSteam.TabIndex = 1;
            // 
            // healthCorv
            // 
            this.healthCorv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthCorv.Location = new System.Drawing.Point(543, 165);
            this.healthCorv.Name = "healthCorv";
            this.healthCorv.Size = new System.Drawing.Size(101, 35);
            this.healthCorv.TabIndex = 1;
            // 
            // healthWind
            // 
            this.healthWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthWind.Location = new System.Drawing.Point(703, 165);
            this.healthWind.Name = "healthWind";
            this.healthWind.Size = new System.Drawing.Size(101, 35);
            this.healthWind.TabIndex = 1;
            // 
            // fuelShip
            // 
            this.fuelShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelShip.Location = new System.Drawing.Point(225, 219);
            this.fuelShip.Name = "fuelShip";
            this.fuelShip.Size = new System.Drawing.Size(101, 35);
            this.fuelShip.TabIndex = 1;
            // 
            // fuelSteam
            // 
            this.fuelSteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelSteam.Location = new System.Drawing.Point(383, 219);
            this.fuelSteam.Name = "fuelSteam";
            this.fuelSteam.Size = new System.Drawing.Size(101, 35);
            this.fuelSteam.TabIndex = 1;
            // 
            // fuelCorv
            // 
            this.fuelCorv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelCorv.Location = new System.Drawing.Point(543, 219);
            this.fuelCorv.Name = "fuelCorv";
            this.fuelCorv.Size = new System.Drawing.Size(101, 35);
            this.fuelCorv.TabIndex = 1;
            // 
            // fuelWind
            // 
            this.fuelWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelWind.Location = new System.Drawing.Point(730, 219);
            this.fuelWind.Name = "fuelWind";
            this.fuelWind.Size = new System.Drawing.Size(101, 35);
            this.fuelWind.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 457);
            this.Controls.Add(this.sailableName);
            this.Controls.Add(this.corvetteName);
            this.Controls.Add(this.steamName);
            this.Controls.Add(this.shipName);
            this.Controls.Add(this.sailEn);
            this.Controls.Add(this.corvEn);
            this.Controls.Add(this.steamEn);
            this.Controls.Add(this.healthWind);
            this.Controls.Add(this.healthCorv);
            this.Controls.Add(this.healthSteam);
            this.Controls.Add(this.fuelWind);
            this.Controls.Add(this.fuelCorv);
            this.Controls.Add(this.fuelSteam);
            this.Controls.Add(this.fuelShip);
            this.Controls.Add(this.healthShip);
            this.Controls.Add(this.shipEn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.set_sails);
            this.Controls.Add(this.move_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label fuelShip;
        private System.Windows.Forms.Label fuelSteam;
        private System.Windows.Forms.Label fuelCorv;
        private System.Windows.Forms.Label fuelWind;

        private System.Windows.Forms.Label healthShip;
        private System.Windows.Forms.Label healthSteam;
        private System.Windows.Forms.Label healthCorv;
        private System.Windows.Forms.Label healthWind;

        private System.Windows.Forms.Label shipEn;
        private System.Windows.Forms.Label steamEn;
        private System.Windows.Forms.Label corvEn;
        private System.Windows.Forms.Label sailEn;

        private System.Windows.Forms.TextBox steamName;
        private System.Windows.Forms.TextBox corvetteName;
        private System.Windows.Forms.TextBox sailableName;

        private System.Windows.Forms.TextBox shipName;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button move_button;
        private System.Windows.Forms.Button set_sails;

        #endregion
    }
}