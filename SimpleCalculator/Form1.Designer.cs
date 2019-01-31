namespace SimpleCalculator
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
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblFunctions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(100, 112);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(43, 13);
            this.lblValue1.TabIndex = 0;
            this.lblValue1.Text = "Value 1";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(100, 176);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(43, 13);
            this.lblValue2.TabIndex = 1;
            this.lblValue2.Text = "Value 2";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(100, 228);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer";
            // 
            // lblFunctions
            // 
            this.lblFunctions.AutoSize = true;
            this.lblFunctions.Location = new System.Drawing.Point(359, 112);
            this.lblFunctions.Name = "lblFunctions";
            this.lblFunctions.Size = new System.Drawing.Size(53, 13);
            this.lblFunctions.TabIndex = 3;
            this.lblFunctions.Text = "Functions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFunctions);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblFunctions;
    }
}

