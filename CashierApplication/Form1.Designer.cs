namespace CashierApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            ItemNameTBox = new TextBox();
            DiscountTbox = new TextBox();
            pricelabel = new Label();
            quantext = new Label();
            quantibox = new TextBox();
            pricetBox = new TextBox();
            paymentBox = new TextBox();
            computeBtn = new Button();
            submitBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            amountLabel = new Label();
            changeLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logout = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(247, 42);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Discount (%)";
            // 
            // ItemNameTBox
            // 
            ItemNameTBox.Font = new Font("Segoe UI", 12F);
            ItemNameTBox.Location = new Point(12, 66);
            ItemNameTBox.Multiline = true;
            ItemNameTBox.Name = "ItemNameTBox";
            ItemNameTBox.Size = new Size(220, 24);
            ItemNameTBox.TabIndex = 2;
            // 
            // DiscountTbox
            // 
            DiscountTbox.Font = new Font("Segoe UI", 12F);
            DiscountTbox.Location = new Point(247, 66);
            DiscountTbox.Multiline = true;
            DiscountTbox.Name = "DiscountTbox";
            DiscountTbox.Size = new Size(122, 24);
            DiscountTbox.TabIndex = 3;
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Font = new Font("Segoe UI", 12F);
            pricelabel.Location = new Point(12, 105);
            pricelabel.Name = "pricelabel";
            pricelabel.Size = new Size(47, 21);
            pricelabel.TabIndex = 4;
            pricelabel.Text = "Price:";
            // 
            // quantext
            // 
            quantext.AutoSize = true;
            quantext.Font = new Font("Segoe UI", 12F);
            quantext.Location = new Point(215, 102);
            quantext.Name = "quantext";
            quantext.Size = new Size(73, 21);
            quantext.TabIndex = 5;
            quantext.Text = "Quantity:";
            // 
            // quantibox
            // 
            quantibox.Font = new Font("Segoe UI", 12F);
            quantibox.Location = new Point(294, 102);
            quantibox.Multiline = true;
            quantibox.Name = "quantibox";
            quantibox.Size = new Size(75, 24);
            quantibox.TabIndex = 6;
            // 
            // pricetBox
            // 
            pricetBox.Font = new Font("Segoe UI", 12F);
            pricetBox.Location = new Point(65, 102);
            pricetBox.Multiline = true;
            pricetBox.Name = "pricetBox";
            pricetBox.Size = new Size(144, 24);
            pricetBox.TabIndex = 7;
            // 
            // paymentBox
            // 
            paymentBox.Font = new Font("Segoe UI", 12F);
            paymentBox.Location = new Point(157, 212);
            paymentBox.Multiline = true;
            paymentBox.Name = "paymentBox";
            paymentBox.Size = new Size(120, 31);
            paymentBox.TabIndex = 8;
            // 
            // computeBtn
            // 
            computeBtn.BackColor = SystemColors.ControlLight;
            computeBtn.FlatStyle = FlatStyle.Flat;
            computeBtn.Font = new Font("Segoe UI", 12F);
            computeBtn.Location = new Point(157, 132);
            computeBtn.Name = "computeBtn";
            computeBtn.Size = new Size(93, 34);
            computeBtn.TabIndex = 9;
            computeBtn.Text = "Compute";
            computeBtn.UseVisualStyleBackColor = false;
            computeBtn.Click += computeBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = SystemColors.ControlLight;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI", 12F);
            submitBtn.Location = new Point(283, 212);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(86, 34);
            submitBtn.TabIndex = 10;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(46, 181);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 11;
            label5.Text = "Total Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 217);
            label6.Name = "label6";
            label6.Size = new Size(139, 21);
            label6.TabIndex = 12;
            label6.Text = "Payment Received:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(85, 258);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 13;
            label7.Text = "Change:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 12F);
            amountLabel.Location = new Point(157, 181);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(0, 21);
            amountLabel.TabIndex = 14;
            // 
            // changeLabel
            // 
            changeLabel.AutoSize = true;
            changeLabel.Font = new Font("Segoe UI", 12F);
            changeLabel.Location = new Point(157, 258);
            changeLabel.Name = "changeLabel";
            changeLabel.Size = new Size(0, 21);
            changeLabel.TabIndex = 15;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(380, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logout, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logout
            // 
            logout.Name = "logout";
            logout.Size = new Size(180, 22);
            logout.Text = "Logout";
            logout.Click += loginToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(180, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 304);
            Controls.Add(changeLabel);
            Controls.Add(amountLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(submitBtn);
            Controls.Add(computeBtn);
            Controls.Add(paymentBox);
            Controls.Add(pricetBox);
            Controls.Add(quantibox);
            Controls.Add(quantext);
            Controls.Add(pricelabel);
            Controls.Add(DiscountTbox);
            Controls.Add(ItemNameTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Purchase Discounted Item";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ItemNameTBox;
        private TextBox DiscountTbox;
        private Label pricelabel;
        private Label quantiBox;
        private TextBox textBox3;
        private TextBox pricetBox;
        private TextBox paymentBox;
        private Button computeBtn;
        private Button submitBtn;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label amountLabel;
        private Label changeLabel;
        private Label quantext;
        private TextBox quantibox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logout;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}
