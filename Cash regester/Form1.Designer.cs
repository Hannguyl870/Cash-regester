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
            this.Calculate = new System.Windows.Forms.Button();
            this.Subtotallable = new System.Windows.Forms.Label();
            this.Taxlable = new System.Windows.Forms.Label();
            this.Totallable = new System.Windows.Forms.Label();
            this.subtotaloutput = new System.Windows.Forms.Label();
            this.Taxtoutput = new System.Windows.Forms.Label();
            this.Totaloutput = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moneyinput = new System.Windows.Forms.TextBox();
            this.changelable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Changeoutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Recieptoutput
            // 
            this.Recieptoutput.BackColor = System.Drawing.Color.White;
            this.Recieptoutput.Location = new System.Drawing.Point(391, 9);
            this.Recieptoutput.Name = "Recieptoutput";
            this.Recieptoutput.Size = new System.Drawing.Size(375, 488);
            this.Recieptoutput.TabIndex = 0;
            this.Recieptoutput.Click += new System.EventHandler(this.Recieptoutput_Click);
            // 
            // sliceslable
            // 
            this.sliceslable.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliceslable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sliceslable.Location = new System.Drawing.Point(17, 37);
            this.sliceslable.Name = "sliceslable";
            this.sliceslable.Size = new System.Drawing.Size(141, 39);
            this.sliceslable.TabIndex = 1;
            this.sliceslable.Text = "pizza slices";
            this.sliceslable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(-9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "drink";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slicesinput
            // 
            this.slicesinput.Location = new System.Drawing.Point(164, 54);
            this.slicesinput.Name = "slicesinput";
            this.slicesinput.Size = new System.Drawing.Size(100, 22);
            this.slicesinput.TabIndex = 4;
            // 
            // wingsinput
            // 
            this.wingsinput.Location = new System.Drawing.Point(164, 82);
            this.wingsinput.Name = "wingsinput";
            this.wingsinput.Size = new System.Drawing.Size(100, 22);
            this.wingsinput.TabIndex = 5;
            // 
            // drinkintput
            // 
            this.drinkintput.Location = new System.Drawing.Point(164, 113);
            this.drinkintput.Name = "drinkintput";
            this.drinkintput.Size = new System.Drawing.Size(100, 22);
            this.drinkintput.TabIndex = 6;
            // 
            // Titlelable
            // 
            this.Titlelable.BackColor = System.Drawing.Color.Brown;
            this.Titlelable.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelable.Location = new System.Drawing.Point(4, 1);
            this.Titlelable.Name = "Titlelable";
            this.Titlelable.Size = new System.Drawing.Size(372, 36);
            this.Titlelable.TabIndex = 7;
            this.Titlelable.Text = "Foods are us ";
            this.Titlelable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calculate.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(40, 141);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(191, 33);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate Totals";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Subtotallable
            // 
            this.Subtotallable.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotallable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subtotallable.Location = new System.Drawing.Point(12, 191);
            this.Subtotallable.Name = "Subtotallable";
            this.Subtotallable.Size = new System.Drawing.Size(100, 23);
            this.Subtotallable.TabIndex = 9;
            this.Subtotallable.Text = "Subtotal";
            // 
            // Taxlable
            // 
            this.Taxlable.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taxlable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Taxlable.Location = new System.Drawing.Point(12, 227);
            this.Taxlable.Name = "Taxlable";
            this.Taxlable.Size = new System.Drawing.Size(100, 23);
            this.Taxlable.TabIndex = 10;
            this.Taxlable.Text = "Tax Total";
            // 
            // Totallable
            // 
            this.Totallable.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Totallable.Location = new System.Drawing.Point(12, 260);
            this.Totallable.Name = "Totallable";
            this.Totallable.Size = new System.Drawing.Size(100, 23);
            this.Totallable.TabIndex = 11;
            this.Totallable.Text = "Total";
            // 
            // subtotaloutput
            // 
            this.subtotaloutput.BackColor = System.Drawing.Color.White;
            this.subtotaloutput.Location = new System.Drawing.Point(161, 191);
            this.subtotaloutput.Name = "subtotaloutput";
            this.subtotaloutput.Size = new System.Drawing.Size(100, 23);
            this.subtotaloutput.TabIndex = 12;
            // 
            // Taxtoutput
            // 
            this.Taxtoutput.BackColor = System.Drawing.Color.White;
            this.Taxtoutput.Location = new System.Drawing.Point(161, 227);
            this.Taxtoutput.Name = "Taxtoutput";
            this.Taxtoutput.Size = new System.Drawing.Size(100, 23);
            this.Taxtoutput.TabIndex = 13;
            // 
            // Totaloutput
            // 
            this.Totaloutput.BackColor = System.Drawing.Color.White;
            this.Totaloutput.Location = new System.Drawing.Point(161, 260);
            this.Totaloutput.Name = "Totaloutput";
            this.Totaloutput.Size = new System.Drawing.Size(100, 23);
            this.Totaloutput.TabIndex = 14;
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.Black;
            this.printbutton.ForeColor = System.Drawing.Color.White;
            this.printbutton.Location = new System.Drawing.Point(64, 475);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(127, 43);
            this.printbutton.TabIndex = 15;
            this.printbutton.Text = "Print reciept";
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 19);
            this.label1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tendered";
            // 
            // moneyinput
            // 
            this.moneyinput.Location = new System.Drawing.Point(154, 346);
            this.moneyinput.Name = "moneyinput";
            this.moneyinput.Size = new System.Drawing.Size(100, 22);
            this.moneyinput.TabIndex = 18;
            // 
            // changelable
            // 
            this.changelable.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelable.Location = new System.Drawing.Point(17, 436);
            this.changelable.Name = "changelable";
            this.changelable.Size = new System.Drawing.Size(100, 23);
            this.changelable.TabIndex = 19;
            this.changelable.Text = "change ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "calculate change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Changeoutput
            // 
            this.Changeoutput.BackColor = System.Drawing.Color.White;
            this.Changeoutput.Location = new System.Drawing.Point(151, 440);
            this.Changeoutput.Name = "Changeoutput";
            this.Changeoutput.Size = new System.Drawing.Size(103, 23);
            this.Changeoutput.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.Changeoutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changelable);
            this.Controls.Add(this.moneyinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.Totaloutput);
            this.Controls.Add(this.Taxtoutput);
            this.Controls.Add(this.subtotaloutput);
            this.Controls.Add(this.Totallable);
            this.Controls.Add(this.Taxlable);
            this.Controls.Add(this.Subtotallable);
            this.Controls.Add(this.Calculate);
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
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Subtotallable;
        private System.Windows.Forms.Label Taxlable;
        private System.Windows.Forms.Label Totallable;
        private System.Windows.Forms.Label subtotaloutput;
        private System.Windows.Forms.Label Taxtoutput;
        private System.Windows.Forms.Label Totaloutput;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox moneyinput;
        private System.Windows.Forms.Label changelable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Changeoutput;
    }
}

