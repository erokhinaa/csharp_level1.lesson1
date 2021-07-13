
namespace Lesson7
{
    partial class Form2
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
            this.boxNum = new System.Windows.Forms.TextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxNum
            // 
            this.boxNum.Location = new System.Drawing.Point(31, 39);
            this.boxNum.Name = "boxNum";
            this.boxNum.Size = new System.Drawing.Size(140, 20);
            this.boxNum.TabIndex = 0;
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(31, 65);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(140, 34);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Ввести";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(28, 23);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(143, 13);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Введите число от 1 до 100:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 129);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.boxNum);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNum;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Label lblNum;
    }
}