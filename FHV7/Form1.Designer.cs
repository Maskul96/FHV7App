namespace FHV7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CPUTypeComboBox = new ComboBox();
            IPAddressTextBox = new TextBox();
            RacknumericUpDown = new NumericUpDown();
            SlotnumericUpDown = new NumericUpDown();
            ConnectToPLCButton = new Button();
            DisconnectPLCButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            StatusPLCTextBox = new TextBox();
            ReadDBButton = new Button();
            DBValue = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)RacknumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SlotnumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Cpu Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 63);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "IP Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 96);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Rack";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 131);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "Slot";
            // 
            // CPUTypeComboBox
            // 
            CPUTypeComboBox.FormattingEnabled = true;
            CPUTypeComboBox.Items.AddRange(new object[] { "S7200", "S7300", "S7400", "S71200", "S71500" });
            CPUTypeComboBox.Location = new Point(117, 32);
            CPUTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            CPUTypeComboBox.Name = "CPUTypeComboBox";
            CPUTypeComboBox.Size = new Size(133, 23);
            CPUTypeComboBox.TabIndex = 4;
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Location = new Point(116, 64);
            IPAddressTextBox.Margin = new Padding(3, 2, 3, 2);
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.Size = new Size(131, 23);
            IPAddressTextBox.TabIndex = 5;
            // 
            // RacknumericUpDown
            // 
            RacknumericUpDown.Location = new Point(116, 94);
            RacknumericUpDown.Margin = new Padding(3, 2, 3, 2);
            RacknumericUpDown.Name = "RacknumericUpDown";
            RacknumericUpDown.Size = new Size(131, 23);
            RacknumericUpDown.TabIndex = 6;
            // 
            // SlotnumericUpDown
            // 
            SlotnumericUpDown.Location = new Point(116, 126);
            SlotnumericUpDown.Margin = new Padding(3, 2, 3, 2);
            SlotnumericUpDown.Name = "SlotnumericUpDown";
            SlotnumericUpDown.Size = new Size(131, 23);
            SlotnumericUpDown.TabIndex = 7;
            // 
            // ConnectToPLCButton
            // 
            ConnectToPLCButton.Location = new Point(37, 170);
            ConnectToPLCButton.Margin = new Padding(3, 2, 3, 2);
            ConnectToPLCButton.Name = "ConnectToPLCButton";
            ConnectToPLCButton.Size = new Size(82, 22);
            ConnectToPLCButton.TabIndex = 8;
            ConnectToPLCButton.Text = "Połącz";
            ConnectToPLCButton.UseVisualStyleBackColor = true;
            // 
            // DisconnectPLCButton
            // 
            DisconnectPLCButton.Location = new Point(167, 170);
            DisconnectPLCButton.Margin = new Padding(3, 2, 3, 2);
            DisconnectPLCButton.Name = "DisconnectPLCButton";
            DisconnectPLCButton.Size = new Size(82, 22);
            DisconnectPLCButton.TabIndex = 9;
            DisconnectPLCButton.Text = "Rozłącz";
            DisconnectPLCButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 214);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(167, 285);
            label6.Name = "label6";
            label6.Size = new Size(114, 44);
            label6.TabIndex = 12;
            label6.Text = "Sygnał RUN";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(247, 287);
            label7.Name = "label7";
            label7.Size = new Size(34, 42);
            label7.TabIndex = 13;
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatusPLCTextBox
            // 
            StatusPLCTextBox.Location = new Point(47, 211);
            StatusPLCTextBox.Margin = new Padding(3, 2, 3, 2);
            StatusPLCTextBox.Name = "StatusPLCTextBox";
            StatusPLCTextBox.Size = new Size(236, 23);
            StatusPLCTextBox.TabIndex = 14;
            // 
            // ReadDBButton
            // 
            ReadDBButton.Location = new Point(32, 250);
            ReadDBButton.Margin = new Padding(3, 2, 3, 2);
            ReadDBButton.Name = "ReadDBButton";
            ReadDBButton.Size = new Size(82, 22);
            ReadDBButton.TabIndex = 15;
            ReadDBButton.Text = "Odczytaj";
            ReadDBButton.UseVisualStyleBackColor = true;
            ReadDBButton.Click += ReadDBButton_Click;
            // 
            // DBValue
            // 
            DBValue.AutoSize = true;
            DBValue.Location = new Point(32, 286);
            DBValue.Name = "DBValue";
            DBValue.Size = new Size(38, 15);
            DBValue.TabIndex = 16;
            DBValue.Text = "label8";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 338);
            Controls.Add(DBValue);
            Controls.Add(ReadDBButton);
            Controls.Add(StatusPLCTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DisconnectPLCButton);
            Controls.Add(ConnectToPLCButton);
            Controls.Add(SlotnumericUpDown);
            Controls.Add(RacknumericUpDown);
            Controls.Add(IPAddressTextBox);
            Controls.Add(CPUTypeComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)RacknumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SlotnumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox CPUTypeComboBox;
        private TextBox IPAddressTextBox;
        private NumericUpDown RacknumericUpDown;
        private NumericUpDown SlotnumericUpDown;
        private Button ConnectToPLCButton;
        private Button DisconnectPLCButton;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox StatusPLCTextBox;
        private Button ReadDBButton;
        private Label DBValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}