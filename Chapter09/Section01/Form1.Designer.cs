namespace Section01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ofdOpen = new OpenFileDialog();
            btGet = new Button();
            dtpDate = new DateTimePicker();
            tbOut = new TextBox();
            nudDay = new NumericUpDown();
            label1 = new Label();
            dtpBirth = new DateTimePicker();
            btBirthCalc = new Button();
            label2 = new Label();
            label3 = new Label();
            tbOut2 = new TextBox();
            tbOut3 = new TextBox();
            label4 = new Label();
            tbOut4 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            // 
            // btGet
            // 
            btGet.Location = new Point(292, 50);
            btGet.Name = "btGet";
            btGet.Size = new Size(86, 39);
            btGet.TabIndex = 0;
            btGet.Text = "計算";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(30, 50);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 1;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(67, 236);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(311, 39);
            tbOut.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(110, 110);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 39);
            nudDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(236, 112);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpBirth
            // 
            dtpBirth.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirth.Location = new Point(30, 180);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 39);
            dtpBirth.TabIndex = 1;
            // 
            // btBirthCalc
            // 
            btBirthCalc.Location = new Point(292, 180);
            btBirthCalc.Name = "btBirthCalc";
            btBirthCalc.Size = new Size(86, 39);
            btBirthCalc.TabIndex = 5;
            btBirthCalc.Text = "計算";
            btBirthCalc.UseVisualStyleBackColor = true;
            btBirthCalc.Click += btBirthCalc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 253);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "年齢";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 298);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "経過日数";
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(67, 281);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(311, 39);
            tbOut2.TabIndex = 2;
            // 
            // tbOut3
            // 
            tbOut3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut3.Location = new Point(67, 326);
            tbOut3.Multiline = true;
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(311, 67);
            tbOut3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 326);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 7;
            label4.Text = "メモ";
            // 
            // tbOut4
            // 
            tbOut4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut4.Location = new Point(67, 413);
            tbOut4.Name = "tbOut4";
            tbOut4.Size = new Size(311, 39);
            tbOut4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 396);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 8;
            label5.Text = "誕生日までの日数";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 476);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btBirthCalc);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut3);
            Controls.Add(tbOut4);
            Controls.Add(tbOut2);
            Controls.Add(tbOut);
            Controls.Add(dtpBirth);
            Controls.Add(dtpDate);
            Controls.Add(btGet);
            Name = "Form1";
            Text = "Foom1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdOpen;
        private Button btGet;
        private DateTimePicker dtpDate;
        private TextBox tbOut;
        private NumericUpDown nudDay;
        private Label label1;
        private DateTimePicker dtpBirth;
        private Button btBirthCalc;
        private Label label2;
        private Label label3;
        private TextBox tbOut2;
        private TextBox tbOut3;
        private Label label4;
        private TextBox tbOut4;
        private Label label5;
    }
}
