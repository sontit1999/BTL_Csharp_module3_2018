namespace module3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCabintype = new System.Windows.Forms.ComboBox();
            this.rbReturn = new System.Windows.Forms.RadioButton();
            this.rbOneWay = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutbound = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxOutbound = new System.Windows.Forms.CheckBox();
            this.dgvOutbound = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.checkboxReturn = new System.Windows.Forms.CheckBox();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumberPassenger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search parameters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(72, 42);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(276, 42);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cabin Type";
            // 
            // cbCabintype
            // 
            this.cbCabintype.FormattingEnabled = true;
            this.cbCabintype.Location = new System.Drawing.Point(554, 42);
            this.cbCabintype.Name = "cbCabintype";
            this.cbCabintype.Size = new System.Drawing.Size(121, 21);
            this.cbCabintype.TabIndex = 7;
            // 
            // rbReturn
            // 
            this.rbReturn.AutoSize = true;
            this.rbReturn.Location = new System.Drawing.Point(29, 79);
            this.rbReturn.Name = "rbReturn";
            this.rbReturn.Size = new System.Drawing.Size(57, 17);
            this.rbReturn.TabIndex = 8;
            this.rbReturn.TabStop = true;
            this.rbReturn.Text = "Return";
            this.rbReturn.UseVisualStyleBackColor = true;
            this.rbReturn.CheckedChanged += new System.EventHandler(this.rbReturn_CheckedChanged);
            // 
            // rbOneWay
            // 
            this.rbOneWay.AutoSize = true;
            this.rbOneWay.Location = new System.Drawing.Point(108, 79);
            this.rbOneWay.Name = "rbOneWay";
            this.rbOneWay.Size = new System.Drawing.Size(67, 17);
            this.rbOneWay.TabIndex = 9;
            this.rbOneWay.TabStop = true;
            this.rbOneWay.Text = "One way";
            this.rbOneWay.UseVisualStyleBackColor = true;
            this.rbOneWay.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Outbound";
            // 
            // txtOutbound
            // 
            this.txtOutbound.Location = new System.Drawing.Point(276, 80);
            this.txtOutbound.Name = "txtOutbound";
            this.txtOutbound.Size = new System.Drawing.Size(124, 20);
            this.txtOutbound.TabIndex = 11;
            this.txtOutbound.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Return";
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(554, 80);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(124, 20);
            this.txtReturn.TabIndex = 13;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(701, 77);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Outbound flight details";
            // 
            // checkBoxOutbound
            // 
            this.checkBoxOutbound.AutoSize = true;
            this.checkBoxOutbound.Location = new System.Drawing.Point(595, 117);
            this.checkBoxOutbound.Name = "checkBoxOutbound";
            this.checkBoxOutbound.Size = new System.Drawing.Size(193, 17);
            this.checkBoxOutbound.TabIndex = 16;
            this.checkBoxOutbound.Text = " Display three days before and after";
            this.checkBoxOutbound.UseVisualStyleBackColor = true;
            this.checkBoxOutbound.CheckedChanged += new System.EventHandler(this.checkBoxDisplayOutbound_CheckedChanged);
            // 
            // dgvOutbound
            // 
            this.dgvOutbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutbound.Location = new System.Drawing.Point(31, 146);
            this.dgvOutbound.Name = "dgvOutbound";
            this.dgvOutbound.Size = new System.Drawing.Size(756, 141);
            this.dgvOutbound.TabIndex = 17;
            this.dgvOutbound.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutbound_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Return flight details";
            // 
            // checkboxReturn
            // 
            this.checkboxReturn.AutoSize = true;
            this.checkboxReturn.Location = new System.Drawing.Point(594, 304);
            this.checkboxReturn.Name = "checkboxReturn";
            this.checkboxReturn.Size = new System.Drawing.Size(193, 17);
            this.checkboxReturn.TabIndex = 19;
            this.checkboxReturn.Text = " Display three days before and after";
            this.checkboxReturn.UseVisualStyleBackColor = true;
            this.checkboxReturn.CheckedChanged += new System.EventHandler(this.checkboxReturn_CheckedChanged);
            // 
            // dgvReturn
            // 
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(41, 327);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.Size = new System.Drawing.Size(756, 141);
            this.dgvReturn.TabIndex = 20;
            this.dgvReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturn_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Confirm booking for";
            // 
            // txtNumberPassenger
            // 
            this.txtNumberPassenger.Location = new System.Drawing.Point(242, 510);
            this.txtNumberPassenger.Name = "txtNumberPassenger";
            this.txtNumberPassenger.Size = new System.Drawing.Size(44, 20);
            this.txtNumberPassenger.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Passengers";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(522, 508);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 24;
            this.btnBook.Text = "BookFilght";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(649, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumberPassenger);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvReturn);
            this.Controls.Add(this.checkboxReturn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvOutbound);
            this.Controls.Add(this.checkBoxOutbound);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOutbound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbOneWay);
            this.Controls.Add(this.rbReturn);
            this.Controls.Add(this.cbCabintype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Search for Flight";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCabintype;
        private System.Windows.Forms.RadioButton rbReturn;
        private System.Windows.Forms.RadioButton rbOneWay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutbound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxOutbound;
        private System.Windows.Forms.DataGridView dgvOutbound;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkboxReturn;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumberPassenger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnExit;
    }
}

