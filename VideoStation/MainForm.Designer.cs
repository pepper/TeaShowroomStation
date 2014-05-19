namespace VideoStation
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenSingleVideoForm = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenSingleVideoForm
            // 
            this.OpenSingleVideoForm.Location = new System.Drawing.Point(162, 161);
            this.OpenSingleVideoForm.Name = "OpenSingleVideoForm";
            this.OpenSingleVideoForm.Size = new System.Drawing.Size(231, 58);
            this.OpenSingleVideoForm.TabIndex = 0;
            this.OpenSingleVideoForm.Text = "Open Single Video Form";
            this.OpenSingleVideoForm.UseVisualStyleBackColor = true;
            this.OpenSingleVideoForm.Click += new System.EventHandler(this.OpenSingleVideoForm_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.Location = new System.Drawing.Point(162, 245);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(231, 58);
            this.Shutdown.TabIndex = 1;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 367);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.OpenSingleVideoForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenSingleVideoForm;
        private System.Windows.Forms.Button Shutdown;
    }
}

