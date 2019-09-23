namespace WindowsFormsApp15
{
    partial class SaveFunc
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
            this.CancelCmd = new System.Windows.Forms.Button();
            this.openFileCmd = new System.Windows.Forms.Button();
            this.SaveFileCmd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelCmd
            // 
            this.CancelCmd.Location = new System.Drawing.Point(713, 415);
            this.CancelCmd.Name = "CancelCmd";
            this.CancelCmd.Size = new System.Drawing.Size(75, 23);
            this.CancelCmd.TabIndex = 0;
            this.CancelCmd.Text = "Cancel";
            this.CancelCmd.UseVisualStyleBackColor = true;
            // 
            // openFileCmd
            // 
            this.openFileCmd.Location = new System.Drawing.Point(12, 22);
            this.openFileCmd.Name = "openFileCmd";
            this.openFileCmd.Size = new System.Drawing.Size(75, 23);
            this.openFileCmd.TabIndex = 2;
            this.openFileCmd.Text = "Open File";
            this.openFileCmd.UseVisualStyleBackColor = true;
            this.openFileCmd.Click += new System.EventHandler(this.openFileCmd_Click);
            // 
            // SaveFileCmd
            // 
            this.SaveFileCmd.Location = new System.Drawing.Point(12, 77);
            this.SaveFileCmd.Name = "SaveFileCmd";
            this.SaveFileCmd.Size = new System.Drawing.Size(75, 23);
            this.SaveFileCmd.TabIndex = 3;
            this.SaveFileCmd.Text = "Save File";
            this.SaveFileCmd.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // SaveFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveFileCmd);
            this.Controls.Add(this.openFileCmd);
            this.Controls.Add(this.CancelCmd);
            this.Name = "SaveFunc";
            this.Text = "SaveFunc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelCmd;
        private System.Windows.Forms.Button openFileCmd;
        private System.Windows.Forms.Button SaveFileCmd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}