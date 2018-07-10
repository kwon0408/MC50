namespace MC50UI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDPortNum = new System.Windows.Forms.NumericUpDown();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.BtnSetContent = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbNewFile = new System.Windows.Forms.ToolStripButton();
            this.BtnTest = new System.Windows.Forms.Button();
            this.TsbOpen = new System.Windows.Forms.ToolStripButton();
            this.TsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbBold = new System.Windows.Forms.ToolStripButton();
            this.TsbWideChar = new System.Windows.Forms.ToolStripButton();
            this.RTBMainText = new MC50UI.NewRichBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPortNum)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 546);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(591, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(31, 17);
            this.StatusLabel.Text = "준비";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보AToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 정보AToolStripMenuItem
            // 
            this.정보AToolStripMenuItem.Name = "정보AToolStripMenuItem";
            this.정보AToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.정보AToolStripMenuItem.Text = "정보(&A)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "포트: COM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NUDPortNum
            // 
            this.NUDPortNum.Location = new System.Drawing.Point(529, 57);
            this.NUDPortNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDPortNum.Name = "NUDPortNum";
            this.NUDPortNum.Size = new System.Drawing.Size(50, 21);
            this.NUDPortNum.TabIndex = 5;
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(352, 55);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(75, 23);
            this.PreviewButton.TabIndex = 6;
            this.PreviewButton.Text = "코드 보기";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // BtnSetContent
            // 
            this.BtnSetContent.Location = new System.Drawing.Point(352, 85);
            this.BtnSetContent.Name = "BtnSetContent";
            this.BtnSetContent.Size = new System.Drawing.Size(75, 23);
            this.BtnSetContent.TabIndex = 8;
            this.BtnSetContent.Text = "button1";
            this.BtnSetContent.UseVisualStyleBackColor = true;
            this.BtnSetContent.Click += new System.EventHandler(this.BtnSetContent_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(503, 85);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 9;
            this.BtnConnect.Text = "연결";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNewFile,
            this.TsbOpen,
            this.TsbSave,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.TsbBold,
            this.TsbWideChar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbNewFile
            // 
            this.TsbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbNewFile.Image = ((System.Drawing.Image)(resources.GetObject("TsbNewFile.Image")));
            this.TsbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNewFile.Name = "TsbNewFile";
            this.TsbNewFile.Size = new System.Drawing.Size(23, 22);
            this.TsbNewFile.Text = "toolStripButton1";
            this.TsbNewFile.ToolTipText = "새 파일";
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(352, 115);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 11;
            this.BtnTest.Text = "test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // TsbOpen
            // 
            this.TsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("TsbOpen.Image")));
            this.TsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbOpen.Name = "TsbOpen";
            this.TsbOpen.Size = new System.Drawing.Size(23, 22);
            this.TsbOpen.Text = "toolStripButton1";
            this.TsbOpen.ToolTipText = "열기";
            // 
            // TsbSave
            // 
            this.TsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSave.Image = ((System.Drawing.Image)(resources.GetObject("TsbSave.Image")));
            this.TsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(23, 22);
            this.TsbSave.Text = "toolStripButton2";
            this.TsbSave.ToolTipText = "저장";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbBold
            // 
            this.TsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbBold.Image = ((System.Drawing.Image)(resources.GetObject("TsbBold.Image")));
            this.TsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBold.Name = "TsbBold";
            this.TsbBold.Size = new System.Drawing.Size(23, 22);
            this.TsbBold.Text = "toolStripButton1";
            this.TsbBold.ToolTipText = "굵게";
            this.TsbBold.Click += new System.EventHandler(this.TsbBold_Click);
            // 
            // TsbWideChar
            // 
            this.TsbWideChar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbWideChar.Image = ((System.Drawing.Image)(resources.GetObject("TsbWideChar.Image")));
            this.TsbWideChar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbWideChar.Name = "TsbWideChar";
            this.TsbWideChar.Size = new System.Drawing.Size(23, 22);
            this.TsbWideChar.Text = "toolStripButton1";
            this.TsbWideChar.ToolTipText = "2배 폭";
            this.TsbWideChar.Click += new System.EventHandler(this.TsbWideChar_Click);
            // 
            // RTBMainText
            // 
            this.RTBMainText.Font = new System.Drawing.Font("D2Coding", 12F);
            this.RTBMainText.Location = new System.Drawing.Point(12, 55);
            this.RTBMainText.Name = "RTBMainText";
            this.RTBMainText.Size = new System.Drawing.Size(333, 485);
            this.RTBMainText.TabIndex = 0;
            this.RTBMainText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 592);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnSetContent);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.NUDPortNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RTBMainText);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPortNum)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NewRichBox RTBMainText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보AToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDPortNum;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.Button BtnSetContent;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNewFile;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.ToolStripButton TsbOpen;
        private System.Windows.Forms.ToolStripButton TsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbBold;
        private System.Windows.Forms.ToolStripButton TsbWideChar;
    }
}

