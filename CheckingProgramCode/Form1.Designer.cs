namespace CheckingProgramCode
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.lbxKeyWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(732, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(139, 41);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(705, 22);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // rtbCode
            // 
            this.rtbCode.Location = new System.Drawing.Point(13, 63);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(694, 626);
            this.rtbCode.TabIndex = 2;
            this.rtbCode.Text = "";
            // 
            // lbxKeyWords
            // 
            this.lbxKeyWords.FormattingEnabled = true;
            this.lbxKeyWords.ItemHeight = 16;
            this.lbxKeyWords.Location = new System.Drawing.Point(732, 93);
            this.lbxKeyWords.Name = "lbxKeyWords";
            this.lbxKeyWords.Size = new System.Drawing.Size(139, 596);
            this.lbxKeyWords.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key words";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxKeyWords);
            this.Controls.Add(this.rtbCode);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.ListBox lbxKeyWords;
        private System.Windows.Forms.Label label1;
    }
}

