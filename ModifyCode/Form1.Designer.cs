namespace ModifyCode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.AddStrOnFileHead = new System.Windows.Forms.TextBox();
            this.AddToFileHead = new System.Windows.Forms.Button();
            this.AddStrOnFileEnd = new System.Windows.Forms.TextBox();
            this.AddToFileEnd = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileFilterCS = new System.Windows.Forms.CheckBox();
            this.FileFilterTXT = new System.Windows.Forms.CheckBox();
            this.FileFilterShader = new System.Windows.Forms.CheckBox();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(325, 24);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(115, 23);
            this.ChooseBtn.TabIndex = 0;
            this.ChooseBtn.Text = "选择文件或文件夹";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += ChooseBtn_Click;
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(13, 25);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(290, 21);
            this.FilePathBox.TabIndex = 1;
            // 
            // AddStrOnFileHead
            // 
            this.AddStrOnFileHead.Location = new System.Drawing.Point(13, 114);
            this.AddStrOnFileHead.Name = "AddStrOnFileHead";
            this.AddStrOnFileHead.Size = new System.Drawing.Size(100, 21);
            this.AddStrOnFileHead.TabIndex = 2;
            // 
            // AddToFileHead
            // 
            this.AddToFileHead.Location = new System.Drawing.Point(144, 114);
            this.AddToFileHead.Name = "AddToFileHead";
            this.AddToFileHead.Size = new System.Drawing.Size(75, 23);
            this.AddToFileHead.TabIndex = 3;
            this.AddToFileHead.Text = "文件首添加";
            this.AddToFileHead.UseVisualStyleBackColor = true;
            // 
            // AddStrOnFileEnd
            // 
            this.AddStrOnFileEnd.Location = new System.Drawing.Point(13, 159);
            this.AddStrOnFileEnd.Name = "AddStrOnFileEnd";
            this.AddStrOnFileEnd.Size = new System.Drawing.Size(100, 21);
            this.AddStrOnFileEnd.TabIndex = 4;
            // 
            // AddToFileEnd
            // 
            this.AddToFileEnd.Location = new System.Drawing.Point(144, 159);
            this.AddToFileEnd.Name = "AddToFileEnd";
            this.AddToFileEnd.Size = new System.Drawing.Size(75, 23);
            this.AddToFileEnd.TabIndex = 5;
            this.AddToFileEnd.Text = "文件尾添加";
            this.AddToFileEnd.UseVisualStyleBackColor = true;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel1,
            this.StatusBarLabel2});
            this.StatusBar.Location = new System.Drawing.Point(0, 310);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(572, 22);
            this.StatusBar.TabIndex = 6;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel1
            // 
            this.StatusBarLabel1.Name = "StatusBarLabel1";
            this.StatusBarLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusBarLabel2
            // 
            this.StatusBarLabel2.Name = "StatusBarLabel2";
            this.StatusBarLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // FileFilterCS
            // 
            this.FileFilterCS.AutoSize = true;
            this.FileFilterCS.Checked = true;
            this.FileFilterCS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FileFilterCS.Location = new System.Drawing.Point(325, 62);
            this.FileFilterCS.Name = "FileFilterCS";
            this.FileFilterCS.Size = new System.Drawing.Size(48, 16);
            this.FileFilterCS.TabIndex = 7;
            this.FileFilterCS.Text = "*.cs";
            this.FileFilterCS.UseVisualStyleBackColor = true;
            // 
            // FileFilterTXT
            // 
            this.FileFilterTXT.AutoSize = true;
            this.FileFilterTXT.Location = new System.Drawing.Point(386, 62);
            this.FileFilterTXT.Name = "FileFilterTXT";
            this.FileFilterTXT.Size = new System.Drawing.Size(54, 16);
            this.FileFilterTXT.TabIndex = 8;
            this.FileFilterTXT.Text = "*.txt";
            this.FileFilterTXT.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.FileFilterShader.AutoSize = true;
            this.FileFilterShader.Location = new System.Drawing.Point(446, 62);
            this.FileFilterShader.Name = "FileFilterShader";
            this.FileFilterShader.Size = new System.Drawing.Size(78, 16);
            this.FileFilterShader.TabIndex = 9;
            this.FileFilterShader.Text = "*.shader";
            this.FileFilterShader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 332);
            this.Controls.Add(this.FileFilterShader);
            this.Controls.Add(this.FileFilterTXT);
            this.Controls.Add(this.FileFilterCS);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.AddToFileEnd);
            this.Controls.Add(this.AddStrOnFileEnd);
            this.Controls.Add(this.AddToFileHead);
            this.Controls.Add(this.AddStrOnFileHead);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.ChooseBtn);
            this.Name = "Form1";
            this.Text = "代码批量修改";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddStrOnFileHead_Click(object sender, System.EventArgs e)
        {
            FileToolManager.AddToFirstLine(AddStrOnFileHead.Text);
        }

        private void AddStrOnFileEnd_Click(object sender, System.EventArgs e)
        {
            FileToolManager.AddToLastLine(AddStrOnFileEnd.Text);
        //    AddStrOnFileEnd.Text
        }

        private void ChooseBtn_Click(object sender, System.EventArgs e)
        {
            FileToolManager.ClearFiles();
            this.folderBrowserDialog.ShowDialog();
            if (!string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {                 
                FilePathBox.Text = folderBrowserDialog.SelectedPath;
                int fileNum = 0;
                string filterStr = "";
                if (FileFilterCS.Checked)
                {
                    filterStr = FileFilterCS.Text;
                    fileNum = FileToolManager.FindFiles(folderBrowserDialog.SelectedPath, filterStr);
                }
                if (FileFilterTXT.Checked)
                {
                    filterStr = FileFilterTXT.Text;
                    fileNum = FileToolManager.FindFiles(folderBrowserDialog.SelectedPath, filterStr);
                }
                if (FileFilterShader.Checked)
                {
                    filterStr = FileFilterTXT.Text;
                    fileNum = FileToolManager.FindFiles(folderBrowserDialog.SelectedPath, filterStr);
                }
                int lineNum = FileToolManager.GetLineCountOfAllFiles();
                StatusBarLabel1.Text = "一共选中了" + fileNum + "个文件,总共行数:"+lineNum.ToString();
            }
        }


        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.TextBox AddStrOnFileHead;
        private System.Windows.Forms.Button AddToFileHead;
        private System.Windows.Forms.TextBox AddStrOnFileEnd;
        private System.Windows.Forms.Button AddToFileEnd;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.CheckBox FileFilterCS;
        private System.Windows.Forms.CheckBox FileFilterTXT;
        private System.Windows.Forms.CheckBox FileFilterShader;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel2;
        
    }
}

