
namespace MLNET_ObjectDetection_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileWatcher = new System.IO.FileSystemWatcher();
            this.picPrediction = new System.Windows.Forms.PictureBox();
            this.btnNewPrediction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrediction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(335, 177);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(96, 26);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "file";
            // 
            // fileWatcher
            // 
            this.fileWatcher.EnableRaisingEvents = true;
            this.fileWatcher.SynchronizingObject = this;
            // 
            // picPrediction
            // 
            this.picPrediction.Location = new System.Drawing.Point(93, 177);
            this.picPrediction.Name = "picPrediction";
            this.picPrediction.Size = new System.Drawing.Size(729, 406);
            this.picPrediction.TabIndex = 1;
            this.picPrediction.TabStop = false;
            // 
            // btnNewPrediction
            // 
            this.btnNewPrediction.BackColor = System.Drawing.Color.LightGreen;
            this.btnNewPrediction.Location = new System.Drawing.Point(383, 106);
            this.btnNewPrediction.Name = "btnNewPrediction";
            this.btnNewPrediction.Size = new System.Drawing.Size(108, 37);
            this.btnNewPrediction.TabIndex = 2;
            this.btnNewPrediction.Text = "chọn ảnh";
            this.btnNewPrediction.UseVisualStyleBackColor = false;
            this.btnNewPrediction.Click += new System.EventHandler(this.btnNewPrediction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(902, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nghiên cứu ML.Net - Nhận dạng màu rượu vang";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewPrediction);
            this.Controls.Add(this.picPrediction);
            this.Controls.Add(this.btnSelectImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrediction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.IO.FileSystemWatcher fileWatcher;
        private System.Windows.Forms.PictureBox picPrediction;
        private System.Windows.Forms.Button btnNewPrediction;
        private System.Windows.Forms.Label label1;
    }
}

