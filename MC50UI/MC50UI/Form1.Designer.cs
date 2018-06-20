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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDPortNum = new System.Windows.Forms.NumericUpDown();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.BtnBold = new System.Windows.Forms.Button();
            this.BtnSetContent = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RTBMainText = new MC50UI.NewRichBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPortNum)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(591, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
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
            this.label1.Location = new System.Drawing.Point(457, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "포트: COM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NUDPortNum
            // 
            this.NUDPortNum.Location = new System.Drawing.Point(529, 26);
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
            // BtnBold
            // 
            this.BtnBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnBold.Location = new System.Drawing.Point(13, 26);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(23, 23);
            this.BtnBold.TabIndex = 7;
            this.BtnBold.Text = "가";
            this.BtnBold.UseVisualStyleBackColor = true;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
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
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnItalic.Location = new System.Drawing.Point(42, 26);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 23);
            this.btnItalic.TabIndex = 7;
            this.btnItalic.Text = "가";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(71, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "가";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(31, 17);
            this.StatusLabel.Text = "준비";
            // 
            // RTBMainText
            // 
            this.RTBMainText.Location = new System.Drawing.Point(12, 55);
            this.RTBMainText.Name = "RTBMainText";
            this.RTBMainText.Size = new System.Drawing.Size(333, 311);
            this.RTBMainText.TabIndex = 0;
            this.RTBMainText.Text = "";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(503, 54);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 9;
            this.BtnConnect.Text = "연결";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 473);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnSetContent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.BtnBold);
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
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnSetContent;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnConnect;
    }
}

