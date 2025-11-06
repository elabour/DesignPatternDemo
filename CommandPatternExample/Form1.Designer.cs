namespace CommandPatternExample
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
            this.BtnChangeText = new System.Windows.Forms.Button();
            this.BtnChangeColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnChangeText
            // 
            this.BtnChangeText.Location = new System.Drawing.Point(471, 204);
            this.BtnChangeText.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChangeText.Name = "BtnChangeText";
            this.BtnChangeText.Size = new System.Drawing.Size(121, 61);
            this.BtnChangeText.TabIndex = 0;
            this.BtnChangeText.Text = "changeText";
            this.BtnChangeText.UseVisualStyleBackColor = true;
            this.BtnChangeText.Click += new System.EventHandler(this.BtnChangeText_Click);
            // 
            // BtnChangeColor
            // 
            this.BtnChangeColor.Location = new System.Drawing.Point(298, 204);
            this.BtnChangeColor.Name = "BtnChangeColor";
            this.BtnChangeColor.Size = new System.Drawing.Size(121, 61);
            this.BtnChangeColor.TabIndex = 1;
            this.BtnChangeColor.Text = "Change Color";
            this.BtnChangeColor.UseVisualStyleBackColor = true;
            this.BtnChangeColor.Click += new System.EventHandler(this.BtnChangeColor_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(221, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(493, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(455, 320);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(144, 52);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add button";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 399);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnChangeColor);
            this.Controls.Add(this.BtnChangeText);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChangeText;
        private System.Windows.Forms.Button BtnChangeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
    }
}

