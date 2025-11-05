namespace ObserverPatternExample1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetTemp = new System.Windows.Forms.Button();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // buttonSetTemp
            // 
            this.buttonSetTemp.Location = new System.Drawing.Point(163, 238);
            this.buttonSetTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSetTemp.Name = "buttonSetTemp";
            this.buttonSetTemp.Size = new System.Drawing.Size(100, 32);
            this.buttonSetTemp.TabIndex = 2;
            this.buttonSetTemp.Text = "button1";
            this.buttonSetTemp.UseVisualStyleBackColor = true;
            this.buttonSetTemp.Click += new System.EventHandler(this.buttonSetTemp_Click);
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(240, 66);
            this.textBoxTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(132, 25);
            this.textBoxTemp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 514);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.buttonSetTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetTemp;
        private System.Windows.Forms.TextBox textBoxTemp;
    }
}

