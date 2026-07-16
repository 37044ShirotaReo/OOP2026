namespace CarReportSystem {
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
            label1 = new Label();
            dtpDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbHonda = new RadioButton();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            cbCarName = new ComboBox();
            cbAuthor = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tbReport = new TextBox();
            label6 = new Label();
            dgvRecords = new DataGridView();
            label7 = new Label();
            btDeletePicture = new Button();
            btOpenPicture = new Button();
            btAddRecord = new Button();
            btDeleteRecord = new Button();
            bt = new Button();
            pbPicture = new PictureBox();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            btNewInput = new Button();
            statusStrip1 = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            ofdPicFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(55, 54);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(135, 49);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(237, 39);
            dtpDate.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox1.Location = new Point(135, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 49);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbHonda.Location = new Point(140, 12);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(66, 25);
            rbHonda.TabIndex = 0;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbOther.Location = new Point(366, 12);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(69, 25);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbImport.Location = new Point(284, 12);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(76, 25);
            rbImport.TabIndex = 0;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbSubaru.Location = new Point(212, 12);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(66, 25);
            rbSubaru.TabIndex = 0;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbNissan.Location = new Point(74, 12);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(60, 25);
            rbNissan.TabIndex = 0;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbToyota.Location = new Point(6, 12);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(62, 25);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(38, 185);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(31, 117);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(135, 245);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(237, 40);
            cbCarName.TabIndex = 3;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(135, 114);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(312, 40);
            cbAuthor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(55, 248);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(55, 461);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 0;
            label5.Text = "一覧";
            // 
            // tbReport
            // 
            tbReport.Location = new Point(135, 310);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(461, 139);
            tbReport.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(34, 310);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 0;
            label6.Text = "レポート";
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(135, 461);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(869, 242);
            dgvRecords.TabIndex = 5;
            dgvRecords.Click += dgvRecords_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(643, 49);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // btDeletePicture
            // 
            btDeletePicture.FlatStyle = FlatStyle.Flat;
            btDeletePicture.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeletePicture.Location = new Point(886, 49);
            btDeletePicture.Name = "btDeletePicture";
            btDeletePicture.Size = new Size(107, 39);
            btDeletePicture.TabIndex = 6;
            btDeletePicture.Text = "削除";
            btDeletePicture.UseVisualStyleBackColor = true;
            // 
            // btOpenPicture
            // 
            btOpenPicture.FlatStyle = FlatStyle.Flat;
            btOpenPicture.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btOpenPicture.Location = new Point(759, 47);
            btOpenPicture.Name = "btOpenPicture";
            btOpenPicture.Size = new Size(107, 39);
            btOpenPicture.TabIndex = 6;
            btOpenPicture.Text = "開く...";
            btOpenPicture.UseVisualStyleBackColor = true;
            btOpenPicture.Click += btOpenPicture_Click;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = Color.FromArgb(192, 192, 255);
            btAddRecord.FlatStyle = FlatStyle.Flat;
            btAddRecord.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddRecord.Location = new Point(643, 384);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(92, 65);
            btAddRecord.TabIndex = 6;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.FromArgb(255, 128, 128);
            btDeleteRecord.FlatStyle = FlatStyle.Flat;
            btDeleteRecord.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteRecord.Location = new Point(898, 385);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(95, 66);
            btDeleteRecord.TabIndex = 6;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            // 
            // bt
            // 
            bt.BackColor = Color.FromArgb(192, 255, 255);
            bt.FlatStyle = FlatStyle.Flat;
            bt.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bt.Location = new Point(770, 384);
            bt.Name = "bt";
            bt.Size = new Size(96, 67);
            bt.TabIndex = 6;
            bt.Text = "修正";
            bt.UseVisualStyleBackColor = false;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(643, 104);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(350, 274);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 7;
            pbPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1018, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "ファイル";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, 色設定ToolStripMenuItem, 終了ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(155, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(155, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(155, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(155, 22);
            終了ToolStripMenuItem.Text = "終了(&X)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(164, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて...";
            // 
            // btNewInput
            // 
            btNewInput.FlatStyle = FlatStyle.Flat;
            btNewInput.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btNewInput.Location = new Point(455, 47);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(141, 40);
            btNewInput.TabIndex = 9;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = true;
            btNewInput.Click += btNewInput_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            statusStrip1.Location = new Point(0, 713);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1018, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 735);
            Controls.Add(statusStrip1);
            Controls.Add(btNewInput);
            Controls.Add(pbPicture);
            Controls.Add(bt);
            Controls.Add(btDeleteRecord);
            Controls.Add(btAddRecord);
            Controls.Add(btOpenPicture);
            Controls.Add(btDeletePicture);
            Controls.Add(dgvRecords);
            Controls.Add(tbReport);
            Controls.Add(cbAuthor);
            Controls.Add(cbCarName);
            Controls.Add(groupBox1);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private GroupBox groupBox1;
        private RadioButton rbToyota;
        private Label label2;
        private Label label3;
        private RadioButton rbHonda;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbNissan;
        private ComboBox cbCarName;
        private ComboBox cbAuthor;
        private Label label4;
        private Label label5;
        private TextBox tbReport;
        private Label label6;
        private DataGridView dgvRecords;
        private Label label7;
        private Button btDeletePicture;
        private Button btOpenPicture;
        private Button btAddRecord;
        private Button btDeleteRecord;
        private Button bt;
        private PictureBox pbPicture;
        private MenuStrip menuStrip1;
        private Button btNewInput;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslbMessage;
        private OpenFileDialog ofdPicFileOpen;
    }
}
