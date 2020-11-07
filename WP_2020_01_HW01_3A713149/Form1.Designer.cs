namespace WP_2020_01_HW01_3A713149
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtboutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbinput
            // 
            this.tbinput.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbinput.Location = new System.Drawing.Point(225, 79);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(284, 31);
            this.tbinput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(225, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 124);
            this.button1.TabIndex = 1;
            this.button1.Text = "MD5加密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtboutput
            // 
            this.rtboutput.Location = new System.Drawing.Point(225, 294);
            this.rtboutput.Name = "rtboutput";
            this.rtboutput.Size = new System.Drawing.Size(284, 96);
            this.rtboutput.TabIndex = 2;
            this.rtboutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtboutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtboutput;
    }
}

