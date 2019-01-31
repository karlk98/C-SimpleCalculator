namespace SimpleCalculator
{
    partial class GUI
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
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
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
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(176, 109);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 20);
            this.txtValue1.TabIndex = 4;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(176, 173);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 20);
            this.txtValue2.TabIndex = 5;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(176, 225);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 6;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(458, 112);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(30, 23);
            this.btnAddition.TabIndex = 7;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(513, 154);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(30, 23);
            this.btnMultiplication.TabIndex = 8;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(458, 154);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(30, 23);
            this.btnDivision.TabIndex = 9;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(513, 112);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(30, 23);
            this.btnSubtraction.TabIndex = 10;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(458, 199);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(85, 23);
            this.btnAnswer.TabIndex = 11;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblFunctions);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Name = "GUI";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblFunctions;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAnswer;
    }
}

