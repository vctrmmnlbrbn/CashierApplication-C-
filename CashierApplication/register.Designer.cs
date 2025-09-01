namespace CashierApplication
{
    partial class register
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
            firstBox = new TextBox();
            malerbttn = new RadioButton();
            monthBox = new ComboBox();
            label2 = new Label();
            lastBox = new TextBox();
            label3 = new Label();
            dayBox = new ComboBox();
            yearBox = new ComboBox();
            label4 = new Label();
            femalerbttn = new RadioButton();
            label5 = new Label();
            jobBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            userbox = new TextBox();
            registerbttn = new Button();
            passBox = new MaskedTextBox();
            repassBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // firstBox
            // 
            firstBox.Font = new Font("Segoe UI", 12F);
            firstBox.Location = new Point(12, 33);
            firstBox.Name = "firstBox";
            firstBox.Size = new Size(183, 29);
            firstBox.TabIndex = 1;
            // 
            // malerbttn
            // 
            malerbttn.AutoSize = true;
            malerbttn.Font = new Font("Segoe UI", 12F);
            malerbttn.Location = new Point(272, 93);
            malerbttn.Name = "malerbttn";
            malerbttn.Size = new Size(62, 25);
            malerbttn.TabIndex = 2;
            malerbttn.TabStop = true;
            malerbttn.Text = "Male";
            malerbttn.UseVisualStyleBackColor = true;
            // 
            // monthBox
            // 
            monthBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthBox.FormattingEnabled = true;
            monthBox.Location = new Point(12, 89);
            monthBox.Name = "monthBox";
            monthBox.Size = new Size(89, 25);
            monthBox.TabIndex = 3;
            monthBox.Text = "-Month-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(200, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // lastBox
            // 
            lastBox.Font = new Font("Segoe UI", 12F);
            lastBox.Location = new Point(201, 33);
            lastBox.Name = "lastBox";
            lastBox.Size = new Size(183, 29);
            lastBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 6;
            label3.Text = "Birthday:";
            // 
            // dayBox
            // 
            dayBox.Font = new Font("Segoe UI", 9.75F);
            dayBox.FormattingEnabled = true;
            dayBox.Location = new Point(107, 89);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(71, 25);
            dayBox.TabIndex = 7;
            dayBox.Text = "-Day-";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Segoe UI", 9.75F);
            yearBox.FormattingEnabled = true;
            yearBox.Location = new Point(184, 89);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(76, 25);
            yearBox.TabIndex = 8;
            yearBox.Text = "-Year-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(272, 65);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 9;
            label4.Text = "Gender:";
            // 
            // femalerbttn
            // 
            femalerbttn.AutoSize = true;
            femalerbttn.Font = new Font("Segoe UI", 12F);
            femalerbttn.Location = new Point(274, 124);
            femalerbttn.Name = "femalerbttn";
            femalerbttn.Size = new Size(78, 25);
            femalerbttn.TabIndex = 10;
            femalerbttn.TabStop = true;
            femalerbttn.Text = "Female";
            femalerbttn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 11;
            label5.Text = "Job Title:";
            // 
            // jobBox
            // 
            jobBox.Font = new Font("Segoe UI", 12F);
            jobBox.Location = new Point(88, 160);
            jobBox.Name = "jobBox";
            jobBox.Size = new Size(183, 29);
            jobBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 13;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 254);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 14;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 310);
            label8.Name = "label8";
            label8.Size = new Size(144, 21);
            label8.TabIndex = 15;
            label8.Text = "Re-enter password:";
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 12F);
            userbox.Location = new Point(12, 222);
            userbox.Name = "userbox";
            userbox.Size = new Size(259, 29);
            userbox.TabIndex = 16;
            // 
            // registerbttn
            // 
            registerbttn.BackColor = Color.Crimson;
            registerbttn.FlatStyle = FlatStyle.Flat;
            registerbttn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerbttn.ForeColor = SystemColors.ButtonHighlight;
            registerbttn.Location = new Point(242, 396);
            registerbttn.Name = "registerbttn";
            registerbttn.Size = new Size(142, 42);
            registerbttn.TabIndex = 19;
            registerbttn.Text = "Register";
            registerbttn.UseVisualStyleBackColor = false;
            registerbttn.Click += button1_Click;
            // 
            // passBox
            // 
            passBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passBox.Location = new Point(12, 278);
            passBox.Name = "passBox";
            passBox.Size = new Size(259, 29);
            passBox.TabIndex = 20;
            // 
            // repassBox
            // 
            repassBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repassBox.Location = new Point(12, 334);
            repassBox.Name = "repassBox";
            repassBox.Size = new Size(259, 29);
            repassBox.TabIndex = 21;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 445);
            Controls.Add(repassBox);
            Controls.Add(passBox);
            Controls.Add(registerbttn);
            Controls.Add(userbox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(jobBox);
            Controls.Add(label5);
            Controls.Add(femalerbttn);
            Controls.Add(label4);
            Controls.Add(yearBox);
            Controls.Add(dayBox);
            Controls.Add(label3);
            Controls.Add(lastBox);
            Controls.Add(label2);
            Controls.Add(monthBox);
            Controls.Add(malerbttn);
            Controls.Add(firstBox);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstBox;
        private RadioButton malerbttn;
        private ComboBox monthBox;
        private Label label2;
        private TextBox lastBox;
        private Label label3;
        private ComboBox dayBox;
        private ComboBox yearBox;
        private Label label4;
        private RadioButton femalerbttn;
        private Label label5;
        private TextBox jobBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox userbox;
        private TextBox passbox;
        private TextBox textBox6;
        private Button registerbttn;
        private MaskedTextBox passBox;
        private MaskedTextBox repassBox;
    }
}