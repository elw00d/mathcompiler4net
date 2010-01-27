namespace ExampleApp {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.textBoxVariable1 = new System.Windows.Forms.TextBox();
            this.textBoxVariable2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(130, 127);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(12, 90);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(315, 20);
            this.textBoxExpression.TabIndex = 1;
            this.textBoxExpression.Text = "20-1+(x1+5*24.5)-sin(x1/x2-4)";
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Location = new System.Drawing.Point(255, 12);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(72, 20);
            this.textBoxValue1.TabIndex = 2;
            this.textBoxValue1.Text = "4,04";
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Location = new System.Drawing.Point(255, 38);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(72, 20);
            this.textBoxValue2.TabIndex = 3;
            this.textBoxValue2.Text = "3";
            // 
            // textBoxVariable1
            // 
            this.textBoxVariable1.Location = new System.Drawing.Point(159, 12);
            this.textBoxVariable1.Name = "textBoxVariable1";
            this.textBoxVariable1.Size = new System.Drawing.Size(71, 20);
            this.textBoxVariable1.TabIndex = 4;
            this.textBoxVariable1.Text = "x1";
            // 
            // textBoxVariable2
            // 
            this.textBoxVariable2.Location = new System.Drawing.Point(159, 38);
            this.textBoxVariable2.Name = "textBoxVariable2";
            this.textBoxVariable2.Size = new System.Drawing.Size(71, 20);
            this.textBoxVariable2.TabIndex = 5;
            this.textBoxVariable2.Text = "x2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter your variables";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVariable2);
            this.Controls.Add(this.textBoxVariable1);
            this.Controls.Add(this.textBoxValue2);
            this.Controls.Add(this.textBoxValue1);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "MainForm";
            this.Text = "Calculator example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.TextBox textBoxVariable1;
        private System.Windows.Forms.TextBox textBoxVariable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

