namespace VoiceRecordForm
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
            btnStartRecord = new Button();
            btnStopRecord = new Button();
            lblPath = new Label();
            SuspendLayout();
            // 
            // btnStartRecord
            // 
            btnStartRecord.Location = new Point(24, 23);
            btnStartRecord.Name = "btnStartRecord";
            btnStartRecord.Size = new Size(158, 29);
            btnStartRecord.TabIndex = 0;
            btnStartRecord.Text = "Kaydı Başlat";
            btnStartRecord.UseVisualStyleBackColor = true;
            btnStartRecord.Click += btnStartRecord_Click;
            // 
            // btnStopRecord
            // 
            btnStopRecord.Location = new Point(24, 104);
            btnStopRecord.Name = "btnStopRecord";
            btnStopRecord.Size = new Size(158, 29);
            btnStopRecord.TabIndex = 1;
            btnStopRecord.Text = "Kaydı Durdur";
            btnStopRecord.UseVisualStyleBackColor = true;
            btnStopRecord.Click += btnStopRecord_Click;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(388, 44);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(166, 20);
            lblPath.TabIndex = 2;
            lblPath.Text = "Kaydın Kaydedildiği Yer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPath);
            Controls.Add(btnStopRecord);
            Controls.Add(btnStartRecord);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartRecord;
        private Button btnStopRecord;
        private Label lblPath;
    }
}
