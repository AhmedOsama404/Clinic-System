namespace Osama
{
    partial class add_patient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AGE = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DIAGNOSIS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GENDER = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.PATIENT_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PHONE = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ADRESS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PATIENT_NAME = new System.Windows.Forms.TextBox();
            this.TYPE = new System.Windows.Forms.ComboBox();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // AGE
            // 
            this.AGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.AGE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.AGE.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AGE.Location = new System.Drawing.Point(269, 284);
            this.AGE.Name = "AGE";
            this.AGE.Size = new System.Drawing.Size(318, 26);
            this.AGE.TabIndex = 79;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(269, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 1);
            this.panel5.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Location = new System.Drawing.Point(139, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Date";
            // 
            // DIAGNOSIS
            // 
            this.DIAGNOSIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.DIAGNOSIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIAGNOSIS.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.DIAGNOSIS.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DIAGNOSIS.Location = new System.Drawing.Point(267, 329);
            this.DIAGNOSIS.Multiline = true;
            this.DIAGNOSIS.Name = "DIAGNOSIS";
            this.DIAGNOSIS.Size = new System.Drawing.Size(320, 23);
            this.DIAGNOSIS.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(138, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "AGE";
            // 
            // GENDER
            // 
            this.GENDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.GENDER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GENDER.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDER.ForeColor = System.Drawing.Color.White;
            this.GENDER.FormattingEnabled = true;
            this.GENDER.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GENDER.Location = new System.Drawing.Point(269, 225);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(318, 26);
            this.GENDER.TabIndex = 70;
            this.GENDER.SelectedIndexChanged += new System.EventHandler(this.GENDER_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label10.Location = new System.Drawing.Point(135, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "Patient ID";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(269, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(318, 1);
            this.panel10.TabIndex = 68;
            // 
            // PATIENT_ID
            // 
            this.PATIENT_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.PATIENT_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATIENT_ID.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.PATIENT_ID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PATIENT_ID.Location = new System.Drawing.Point(269, 21);
            this.PATIENT_ID.Name = "PATIENT_ID";
            this.PATIENT_ID.Size = new System.Drawing.Size(318, 26);
            this.PATIENT_ID.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label9.Location = new System.Drawing.Point(138, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 66;
            this.label9.Text = "Phone";
            // 
            // PHONE
            // 
            this.PHONE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.PHONE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHONE.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.PHONE.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PHONE.Location = new System.Drawing.Point(269, 173);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(318, 26);
            this.PHONE.TabIndex = 65;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Location = new System.Drawing.Point(269, 201);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(318, 1);
            this.panel9.TabIndex = 64;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 1);
            this.panel4.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(55)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(365, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 39);
            this.button2.TabIndex = 63;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label7.Location = new System.Drawing.Point(138, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(138, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(135, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Gender";
            // 
            // ADRESS
            // 
            this.ADRESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.ADRESS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADRESS.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.ADRESS.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ADRESS.Location = new System.Drawing.Point(269, 116);
            this.ADRESS.Name = "ADRESS";
            this.ADRESS.Size = new System.Drawing.Size(318, 26);
            this.ADRESS.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(130, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Patient Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(269, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 1);
            this.panel3.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(269, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 1);
            this.panel2.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(269, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 1);
            this.panel1.TabIndex = 54;
            // 
            // PATIENT_NAME
            // 
            this.PATIENT_NAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.PATIENT_NAME.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATIENT_NAME.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.PATIENT_NAME.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PATIENT_NAME.Location = new System.Drawing.Point(269, 65);
            this.PATIENT_NAME.Name = "PATIENT_NAME";
            this.PATIENT_NAME.Size = new System.Drawing.Size(318, 26);
            this.PATIENT_NAME.TabIndex = 53;
            // 
            // TYPE
            // 
            this.TYPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TYPE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TYPE.ForeColor = System.Drawing.Color.White;
            this.TYPE.FormattingEnabled = true;
            this.TYPE.Items.AddRange(new object[] {
            "Kobry El Kobba",
            "Not Kobry El Kobba",
            "Civil"});
            this.TYPE.Location = new System.Drawing.Point(267, 372);
            this.TYPE.Name = "TYPE";
            this.TYPE.Size = new System.Drawing.Size(323, 26);
            this.TYPE.TabIndex = 62;
            // 
            // add_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DIAGNOSIS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GENDER);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.PATIENT_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PHONE);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TYPE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ADRESS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PATIENT_NAME);
            this.Name = "add_patient";
            this.Size = new System.Drawing.Size(782, 967);
            this.Load += new System.EventHandler(this.add_patient_Load);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DIAGNOSIS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GENDER;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox PATIENT_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PHONE;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ADRESS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PATIENT_NAME;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox TYPE;
    }
}
