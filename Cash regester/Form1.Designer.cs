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
            this.wingsinput = new System.Windows.Forms.TextBox();
            this.drinkintput = new System.Windows.Forms.TextBox();
            this.Titlelable = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.Subtotallable = new System.Windows.Forms.Label();
            this.Taxlable = new System.Windows.Forms.Label();
            this.Totallable = new System.Windows.Forms.Label();
            this.subtotaloutput = new System.Windows.Forms.Label();
            this.Taxtoutput = new System.Windows.Forms.Label();
            this.Totaloutput = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
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
            this.sliceslable.Location = new System.Drawing.Point(17, 55);
            this.sliceslable.Name = "sliceslable";
            this.sliceslable.Size = new System.Drawing.Size(121, 37);
            this.sliceslable.TabIndex = 1;
            this.sliceslable.Text = "pizza slices";
            this.sliceslable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "drink";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slicesinput
            // 
            this.slicesinput.Location = new System.Drawing.Point(164, 70);
            this.slicesinput.Name = "slicesinput";
            this.slicesinput.Size = new System.Drawing.Size(100, 22);
            this.slicesinput.TabIndex = 4;
            // 
            // wingsinput
            // 
            this.wingsinput.Location = new System.Drawing.Point(164, 110);
            this.wingsinput.Name = "wingsinput";
            this.wingsinput.Size = new System.Drawing.Size(100, 22);
            this.wingsinput.TabIndex = 5;
            // 
            // drinkintput
            // 
            this.drinkintput.Location = new System.Drawing.Point(164, 145);
            this.drinkintput.Name = "drinkintput";
            this.drinkintput.Size = new System.Drawing.Size(100, 22);
            this.drinkintput.TabIndex = 6;
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
            this.calculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculate.ForeColor = System.Drawing.Color.White;
            this.calculate.Location = new System.Drawing.Point(73, 191);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(127, 43);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate Totals";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Subtotallable
            // 
            this.Subtotallable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotallable.Location = new System.Drawing.Point(38, 279);
            this.Subtotallable.Name = "Subtotallable";
            this.Subtotallable.Size = new System.Drawing.Size(100, 23);
            this.Subtotallable.TabIndex = 9;
            this.Subtotallable.Text = "Subtotal";
            // 
            // Taxlable
            // 
            this.Taxlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taxlable.Location = new System.Drawing.Point(38, 314);
            this.Taxlable.Name = "Taxlable";
            this.Taxlable.Size = new System.Drawing.Size(100, 23);
            this.Taxlable.TabIndex = 10;
            this.Taxlable.Text = "Tax Total";
            // 
            // Totallable
            // 
            this.Totallable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallable.Location = new System.Drawing.Point(38, 346);
            this.Totallable.Name = "Totallable";
            this.Totallable.Size = new System.Drawing.Size(100, 23);
            this.Totallable.TabIndex = 11;
            this.Totallable.Text = "Total";
            // 
            // subtotaloutput
            // 
            this.subtotaloutput.BackColor = System.Drawing.Color.White;
            this.subtotaloutput.Location = new System.Drawing.Point(161, 279);
            this.subtotaloutput.Name = "subtotaloutput";
            this.subtotaloutput.Size = new System.Drawing.Size(100, 23);
            this.subtotaloutput.TabIndex = 12;
            // 
            // Taxtoutput
            // 
            this.Taxtoutput.BackColor = System.Drawing.Color.White;
            this.Taxtoutput.Location = new System.Drawing.Point(164, 319);
            this.Taxtoutput.Name = "Taxtoutput";
            this.Taxtoutput.Size = new System.Drawing.Size(100, 23);
            this.Taxtoutput.TabIndex = 13;
            // 
            // Totaloutput
            // 
            this.Totaloutput.BackColor = System.Drawing.Color.White;
            this.Totaloutput.Location = new System.Drawing.Point(164, 351);
            this.Totaloutput.Name = "Totaloutput";
            this.Totaloutput.Size = new System.Drawing.Size(100, 23);
            this.Totaloutput.TabIndex = 14;
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.Black;
            this.printbutton.ForeColor = System.Drawing.Color.White;
            this.printbutton.Location = new System.Drawing.Point(73, 401);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(127, 43);
            this.printbutton.TabIndex = 15;
            this.printbutton.Text = "Print reciept";
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.Totaloutput);
            this.Controls.Add(this.Taxtoutput);
            this.Controls.Add(this.subtotaloutput);
            this.Controls.Add(this.Totallable);
            this.Controls.Add(this.Taxlable);
            this.Controls.Add(this.Subtotallable);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Titlelable);
            this.Controls.Add(this.drinkintput);
            this.Controls.Add(this.wingsinput);
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
        private System.Windows.Forms.TextBox wingsinput;
        private System.Windows.Forms.TextBox drinkintput;
        private System.Windows.Forms.Label Titlelable;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label Subtotallable;
        private System.Windows.Forms.Label Taxlable;
        private System.Windows.Forms.Label Totallable;
        private System.Windows.Forms.Label subtotaloutput;
        private System.Windows.Forms.Label Taxtoutput;
        private System.Windows.Forms.Label Totaloutput;
        private System.Windows.Forms.Button printbutton;
    }
}

