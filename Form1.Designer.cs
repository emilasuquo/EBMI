namespace EBMI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.radkg = new System.Windows.Forms.RadioButton();
            this.radlb = new System.Windows.Forms.RadioButton();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(381, 67);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(65, 23);
            this.txtheight.TabIndex = 4;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(123, 67);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(69, 23);
            this.txtweight.TabIndex = 5;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(160, 315);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(194, 74);
            this.txtresult.TabIndex = 6;
            // 
            // radkg
            // 
            this.radkg.AutoSize = true;
            this.radkg.Location = new System.Drawing.Point(123, 142);
            this.radkg.Name = "radkg";
            this.radkg.Size = new System.Drawing.Size(77, 19);
            this.radkg.TabIndex = 7;
            this.radkg.TabStop = true;
            this.radkg.Text = "kilograms";
            this.radkg.UseVisualStyleBackColor = true;
            // 
            // radlb
            // 
            this.radlb.AutoSize = true;
            this.radlb.Location = new System.Drawing.Point(368, 142);
            this.radlb.Name = "radlb";
            this.radlb.Size = new System.Drawing.Size(65, 19);
            this.radlb.TabIndex = 8;
            this.radlb.TabStop = true;
            this.radlb.Text = "pounds";
            this.radlb.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(226, 213);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(83, 23);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "meter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.radlb);
            this.Controls.Add(this.radkg);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.RadioButton radkg;
        private System.Windows.Forms.RadioButton radlb;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label3;
    }
}

