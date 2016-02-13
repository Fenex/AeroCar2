namespace AeroCar2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_aero = new System.Windows.Forms.Button();
            this.cmb_filelist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown0 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmb_aero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.btn_car = new System.Windows.Forms.Button();
            this.lbl_FolderPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown0)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(281, 137);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(67, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_aero
            // 
            this.btn_aero.Location = new System.Drawing.Point(207, 137);
            this.btn_aero.Name = "btn_aero";
            this.btn_aero.Size = new System.Drawing.Size(68, 23);
            this.btn_aero.TabIndex = 2;
            this.btn_aero.Text = "Aero...";
            this.btn_aero.UseVisualStyleBackColor = true;
            this.btn_aero.Click += new System.EventHandler(this.btn_aero_Click);
            // 
            // cmb_filelist
            // 
            this.cmb_filelist.Enabled = false;
            this.cmb_filelist.Location = new System.Drawing.Point(12, 83);
            this.cmb_filelist.Name = "cmb_filelist";
            this.cmb_filelist.Size = new System.Drawing.Size(185, 21);
            this.cmb_filelist.TabIndex = 3;
            this.cmb_filelist.SelectedIndexChanged += new System.EventHandler(this.cmb_filelist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car (file):";
            // 
            // numericUpDown0
            // 
            this.numericUpDown0.Location = new System.Drawing.Point(6, 23);
            this.numericUpDown0.Name = "numericUpDown0";
            this.numericUpDown0.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown0.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown0);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Tuning";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(129, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 52);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // cmb_aero
            // 
            this.cmb_aero.Items.AddRange(new object[] {
            "Aero 1",
            "Aero 2",
            "Aero 3",
            "Aero 4",
            "Aero 5",
            "Aero 6",
            "Aero 7",
            "Aero 8"});
            this.cmb_aero.Location = new System.Drawing.Point(205, 83);
            this.cmb_aero.Name = "cmb_aero";
            this.cmb_aero.Size = new System.Drawing.Size(143, 21);
            this.cmb_aero.TabIndex = 7;
            this.cmb_aero.Text = "Aero 1";
            this.cmb_aero.SelectedValueChanged += new System.EventHandler(this.cmb_aero_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(242, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aero:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(246, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 52);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.BackgroundImageChanged += new System.EventHandler(this.pictureBox3_BackgroundImageChanged);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(127, 121);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(0, 13);
            this.lbl_FileName.TabIndex = 10;
            // 
            // btn_car
            // 
            this.btn_car.Location = new System.Drawing.Point(134, 137);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(67, 23);
            this.btn_car.TabIndex = 11;
            this.btn_car.Text = "Car...";
            this.btn_car.UseVisualStyleBackColor = true;
            this.btn_car.Visible = false;
            this.btn_car.Click += new System.EventHandler(this.btn_car_Click);
            // 
            // lbl_FolderPath
            // 
            this.lbl_FolderPath.AutoSize = true;
            this.lbl_FolderPath.Location = new System.Drawing.Point(127, 108);
            this.lbl_FolderPath.Name = "lbl_FolderPath";
            this.lbl_FolderPath.Size = new System.Drawing.Size(0, 13);
            this.lbl_FolderPath.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "version 2.1.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(295, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fenex, 2012";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Не показывать на панели задач";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(134, 189);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Поверх всех окон";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(360, 231);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_aero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_FolderPath);
            this.Controls.Add(this.btn_car);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_filelist);
            this.Controls.Add(this.btn_aero);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AeroCar2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown0)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_aero;
        private System.Windows.Forms.ComboBox cmb_filelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmb_aero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.Label lbl_FolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

