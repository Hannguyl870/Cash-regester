namespace Cash_regester
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
            this.Recieptoutput = new System.Windows.Forms.Label();
            this.sliceslable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slicesinput = new System.Windows.Forms.TextBox();
            this.wingsoutput = new System.Windows.Forms.TextBox();
            this.drinkoutput = new System.Windows.Forms.TextBox();
            this.Titlelable = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Recieptoutput
            // 
            this.Recieptoutput.Location = new System.Drawing.Point(476, 9);
            this.Recieptoutput.Name = "Recieptoutput";
            this.Recieptoutput.Size = new System.Drawing.Size(323, 445);
            this.Recieptoutput.TabIndex = 0;
            this.Recieptoutput.Text = "Reciept";
            this.Recieptoutput.Click += new System.EventHandler(this.Recieptoutput_Click);
            // 
            // sliceslable
            // 
            this.sliceslable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliceslable.Location = new System.Drawing.Point(17, 70);
            this.sliceslable.Name = "sliceslable";
            this.sliceslable.Size = new System.Drawing.Size(121, 37);
            this.sliceslable.TabIndex = 1;
            this.sliceslable.Text = "pizza slices";
            this.sliceslable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "drink";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slicesinput
            // 
            this.slicesinput.Location = new System.Drawing.Point(164, 80);
            this.slicesinput.Name = "slicesinput";
            this.slicesinput.Size = new System.Drawing.Size(100, 22);
            this.slicesinput.TabIndex = 4;
            // 
            // wingsoutput
            // 
            this.wingsoutput.Location = new System.Drawing.Point(164, 119);
            this.wingsoutput.Name = "wingsoutput";
            this.wingsoutput.Size = new System.Drawing.Size(100, 22);
            this.wingsoutput.TabIndex = 5;
            // 
            // drinkoutput
            // 
            this.drinkoutput.Location = new System.Drawing.Point(164, 152);
            this.drinkoutput.Name = "drinkoutput";
            this.drinkoutput.Size = new System.Drawing.Size(100, 22);
            this.drinkoutput.TabIndex = 6;
            // 
            // Titlelable
            // 
            this.Titlelable.Location = new System.Drawing.Point(4, 1);
            this.Titlelable.Name = "Titlelable";
            this.Titlelable.Size = new System.Drawing.Size(372, 66);
            this.Titlelable.TabIndex = 7;
            this.Titlelable.Text = "label1";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(83, 262);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(127, 43);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Titlelable);
            this.Controls.Add(this.drinkoutput);
            this.Controls.Add(this.wingsoutput);
            this.Controls.Add(this.slicesinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sliceslable);
            this.Controls.Add(this.Recieptoutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recieptoutput;
        private System.Windows.Forms.Label sliceslable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox slicesinput;
        private System.Windows.Forms.TextBox wingsoutput;
        private System.Windows.Forms.TextBox drinkoutput;
        private System.Windows.Forms.Label Titlelable;
        private System.Windows.Forms.Button calculate;
    }
}

