namespace module3
{
    partial class BookingConfirmForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFromOutbound = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbToOutbound = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCabintypeOutbound = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDateOutbound = new System.Windows.Forms.Label();
            this.lbFlightnumberOutbound = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbFromReturn = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbToReturn = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbCabintypeReturn = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbDateReturn = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbFlightReturn = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cbPassportCountry = new System.Windows.Forms.ComboBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnAddpassenger = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvPassenger = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outbound flight details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbFromOutbound
            // 
            this.lbFromOutbound.AutoSize = true;
            this.lbFromOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromOutbound.Location = new System.Drawing.Point(66, 46);
            this.lbFromOutbound.Name = "lbFromOutbound";
            this.lbFromOutbound.Size = new System.Drawing.Size(27, 13);
            this.lbFromOutbound.TabIndex = 2;
            this.lbFromOutbound.Text = "CAI";
            this.lbFromOutbound.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbToOutbound
            // 
            this.lbToOutbound.AutoSize = true;
            this.lbToOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToOutbound.Location = new System.Drawing.Point(160, 46);
            this.lbToOutbound.Name = "lbToOutbound";
            this.lbToOutbound.Size = new System.Drawing.Size(33, 13);
            this.lbToOutbound.TabIndex = 4;
            this.lbToOutbound.Text = "AUH";
            this.lbToOutbound.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cabin Type:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbCabintypeOutbound
            // 
            this.lbCabintypeOutbound.AutoSize = true;
            this.lbCabintypeOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabintypeOutbound.Location = new System.Drawing.Point(295, 46);
            this.lbCabintypeOutbound.Name = "lbCabintypeOutbound";
            this.lbCabintypeOutbound.Size = new System.Drawing.Size(68, 13);
            this.lbCabintypeOutbound.TabIndex = 6;
            this.lbCabintypeOutbound.Text = "ECONOMY";
            this.lbCabintypeOutbound.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbDateOutbound
            // 
            this.lbDateOutbound.AutoSize = true;
            this.lbDateOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOutbound.Location = new System.Drawing.Point(424, 46);
            this.lbDateOutbound.Name = "lbDateOutbound";
            this.lbDateOutbound.Size = new System.Drawing.Size(75, 13);
            this.lbDateOutbound.TabIndex = 8;
            this.lbDateOutbound.Text = "06/10/2020";
            this.lbDateOutbound.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbFlightnumberOutbound
            // 
            this.lbFlightnumberOutbound.AutoSize = true;
            this.lbFlightnumberOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightnumberOutbound.Location = new System.Drawing.Point(611, 46);
            this.lbFlightnumberOutbound.Name = "lbFlightnumberOutbound";
            this.lbFlightnumberOutbound.Size = new System.Drawing.Size(75, 13);
            this.lbFlightnumberOutbound.TabIndex = 10;
            this.lbFlightnumberOutbound.Text = "06/10/2020";
            this.lbFlightnumberOutbound.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Flight number:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Return flight details";
            // 
            // lbFromReturn
            // 
            this.lbFromReturn.AutoSize = true;
            this.lbFromReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromReturn.Location = new System.Drawing.Point(66, 119);
            this.lbFromReturn.Name = "lbFromReturn";
            this.lbFromReturn.Size = new System.Drawing.Size(27, 13);
            this.lbFromReturn.TabIndex = 13;
            this.lbFromReturn.Text = "CAI";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "From:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(134, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "To:";
            // 
            // lbToReturn
            // 
            this.lbToReturn.AutoSize = true;
            this.lbToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToReturn.Location = new System.Drawing.Point(160, 119);
            this.lbToReturn.Name = "lbToReturn";
            this.lbToReturn.Size = new System.Drawing.Size(33, 13);
            this.lbToReturn.TabIndex = 15;
            this.lbToReturn.Text = "AUH";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(228, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Cabin Type:";
            // 
            // lbCabintypeReturn
            // 
            this.lbCabintypeReturn.AutoSize = true;
            this.lbCabintypeReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabintypeReturn.Location = new System.Drawing.Point(298, 119);
            this.lbCabintypeReturn.Name = "lbCabintypeReturn";
            this.lbCabintypeReturn.Size = new System.Drawing.Size(68, 13);
            this.lbCabintypeReturn.TabIndex = 17;
            this.lbCabintypeReturn.Text = "ECONOMY";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(394, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Date:";
            // 
            // lbDateReturn
            // 
            this.lbDateReturn.AutoSize = true;
            this.lbDateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateReturn.Location = new System.Drawing.Point(424, 119);
            this.lbDateReturn.Name = "lbDateReturn";
            this.lbDateReturn.Size = new System.Drawing.Size(75, 13);
            this.lbDateReturn.TabIndex = 19;
            this.lbDateReturn.Text = "06/10/2020";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(535, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Flight number:";
            // 
            // lbFlightReturn
            // 
            this.lbFlightReturn.AutoSize = true;
            this.lbFlightReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightReturn.Location = new System.Drawing.Point(614, 119);
            this.lbFlightReturn.Name = "lbFlightReturn";
            this.lbFlightReturn.Size = new System.Drawing.Size(75, 13);
            this.lbFlightReturn.TabIndex = 21;
            this.lbFlightReturn.Text = "06/10/2020";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(30, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Passenger details";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(52, 196);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Firstname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(137, 193);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(131, 20);
            this.txtFirstname.TabIndex = 24;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(368, 193);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(131, 20);
            this.txtLastname.TabIndex = 26;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(313, 196);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 25;
            this.label25.Text = "Lastname";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(163, 240);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(105, 20);
            this.txtPassportNumber.TabIndex = 28;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(52, 243);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "Passport number";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(313, 247);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 13);
            this.label27.TabIndex = 29;
            this.label27.Text = "Passport country";
            // 
            // cbPassportCountry
            // 
            this.cbPassportCountry.FormattingEnabled = true;
            this.cbPassportCountry.Location = new System.Drawing.Point(405, 243);
            this.cbPassportCountry.Name = "cbPassportCountry";
            this.cbPassportCountry.Size = new System.Drawing.Size(112, 21);
            this.cbPassportCountry.TabIndex = 30;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(622, 196);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(131, 20);
            this.txtBirthday.TabIndex = 32;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(540, 196);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Birthday";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(622, 243);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(131, 20);
            this.txtPhonenumber.TabIndex = 34;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(540, 247);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "Phone number";
            // 
            // btnAddpassenger
            // 
            this.btnAddpassenger.Location = new System.Drawing.Point(640, 283);
            this.btnAddpassenger.Name = "btnAddpassenger";
            this.btnAddpassenger.Size = new System.Drawing.Size(101, 23);
            this.btnAddpassenger.TabIndex = 35;
            this.btnAddpassenger.Text = "Add passenger";
            this.btnAddpassenger.UseVisualStyleBackColor = true;
            this.btnAddpassenger.Click += new System.EventHandler(this.btnAddpassenger_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(37, 283);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 13);
            this.label30.TabIndex = 36;
            this.label30.Text = "Passenger list";
            // 
            // dgvPassenger
            // 
            this.dgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dgvPassenger.Location = new System.Drawing.Point(44, 322);
            this.dgvPassenger.Name = "dgvPassenger";
            this.dgvPassenger.Size = new System.Drawing.Size(708, 125);
            this.dgvPassenger.TabIndex = 37;
            this.dgvPassenger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassenger_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(163, 481);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 23);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back to search for flight";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(342, 481);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 23);
            this.btnConfirm.TabIndex = 39;
            this.btnConfirm.Text = "Confirm booking";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(652, 453);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 23);
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "Remove passenger";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Firstname";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lastname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Birthday";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Passport number";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Passport country";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone";
            this.Column7.Name = "Column7";
            // 
            // BookingConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPassenger);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnAddpassenger);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cbPassportCountry);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lbFlightReturn);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbDateReturn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbCabintypeReturn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbToReturn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbFromReturn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbFlightnumberOutbound);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbDateOutbound);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbCabintypeOutbound);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbToOutbound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbFromOutbound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingConfirmForm";
            this.Text = "Booking Confirmation";
            this.Load += new System.EventHandler(this.BookingConfirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFromOutbound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbToOutbound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCabintypeOutbound;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDateOutbound;
        private System.Windows.Forms.Label lbFlightnumberOutbound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbFromReturn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbToReturn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbCabintypeReturn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbDateReturn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbFlightReturn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbPassportCountry;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnAddpassenger;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dgvPassenger;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}