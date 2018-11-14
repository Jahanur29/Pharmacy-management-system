namespace pharmacyms
{
    partial class rmvcustomer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rmv = new System.Windows.Forms.Button();
            this.bk2main = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID  :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 32);
            this.textBox1.TabIndex = 1;
            // 
            // rmv
            // 
            this.rmv.Location = new System.Drawing.Point(210, 244);
            this.rmv.Name = "rmv";
            this.rmv.Size = new System.Drawing.Size(169, 43);
            this.rmv.TabIndex = 2;
            this.rmv.Text = "Remove";
            this.rmv.UseVisualStyleBackColor = true;
            this.rmv.Click += new System.EventHandler(this.rmv_Click);
            // 
            // bk2main
            // 
            this.bk2main.Location = new System.Drawing.Point(171, 314);
            this.bk2main.Name = "bk2main";
            this.bk2main.Size = new System.Drawing.Size(252, 42);
            this.bk2main.TabIndex = 3;
            this.bk2main.Text = "Back to main menu";
            this.bk2main.UseVisualStyleBackColor = true;
            this.bk2main.Click += new System.EventHandler(this.bk2main_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "DELETE CUSTOMER";
            // 
            // rmvcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(640, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bk2main);
            this.Controls.Add(this.rmv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "rmvcustomer";
            this.Text = "rmvcustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button rmv;
        private System.Windows.Forms.Button bk2main;
        private System.Windows.Forms.Label label2;
    }
}