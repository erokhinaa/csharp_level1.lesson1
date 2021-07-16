
namespace Lesson7
{
    partial class Form3
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
            this.boxNum.Location = new System.Drawing.Point(79, 60);
            this.boxNum.Name = "boxNum";
            this.boxNum.Size = new System.Drawing.Size(100, 20);
            this.boxNum.TabIndex = 0;
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(79, 96);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(100, 32);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Ввести";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(60, 44);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(143, 13);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Введите число от 1 до 100:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 180);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.boxNum);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNum;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Label lblNum;
    }
}