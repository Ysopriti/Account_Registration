namespace Account_Registration
{
    partial class FrmConfirm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            studentNum = new Label();
            program = new Label();
            lastName = new Label();
            firstName = new Label();
            middleName = new Label();
            age = new Label();
            contactNum = new Label();
            address = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 26);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "ACCOUNT REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 69);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Student No.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 103);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Program:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(77, 285);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 21;
            label9.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 253);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 20;
            label8.Text = "Contact No.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 222);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 19;
            label7.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 191);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 18;
            label6.Text = "Middle Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 160);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 17;
            label5.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 131);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 16;
            label4.Text = "Last Name:";
            // 
            // studentNum
            // 
            studentNum.AutoSize = true;
            studentNum.Location = new Point(238, 69);
            studentNum.Name = "studentNum";
            studentNum.Size = new Size(44, 15);
            studentNum.TabIndex = 22;
            studentNum.Text = "label10";
            // 
            // program
            // 
            program.AutoSize = true;
            program.Location = new Point(238, 103);
            program.Name = "program";
            program.Size = new Size(44, 15);
            program.TabIndex = 23;
            program.Text = "label11";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(238, 131);
            lastName.Name = "lastName";
            lastName.Size = new Size(44, 15);
            lastName.TabIndex = 24;
            lastName.Text = "label12";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(238, 160);
            firstName.Name = "firstName";
            firstName.Size = new Size(44, 15);
            firstName.TabIndex = 25;
            firstName.Text = "label13";
            // 
            // middleName
            // 
            middleName.AutoSize = true;
            middleName.Location = new Point(238, 191);
            middleName.Name = "middleName";
            middleName.Size = new Size(44, 15);
            middleName.TabIndex = 26;
            middleName.Text = "label14";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(238, 222);
            age.Name = "age";
            age.Size = new Size(44, 15);
            age.TabIndex = 27;
            age.Text = "label15";
            // 
            // contactNum
            // 
            contactNum.AutoSize = true;
            contactNum.Location = new Point(238, 253);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(44, 15);
            contactNum.TabIndex = 28;
            contactNum.Text = "label16";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(238, 285);
            address.Name = "address";
            address.Size = new Size(44, 15);
            address.TabIndex = 29;
            address.Text = "label17";
            // 
            // button1
            // 
            button1.Location = new Point(152, 333);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 385);
            Controls.Add(button1);
            Controls.Add(address);
            Controls.Add(contactNum);
            Controls.Add(age);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(program);
            Controls.Add(studentNum);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmConfirm";
            Text = "FrmConfirm";
            Load += FrmConfirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label studentNum;
        private Label program;
        private Label lastName;
        private Label firstName;
        private Label middleName;
        private Label age;
        private Label contactNum;
        private Label address;
        private Button button1;
    }
}