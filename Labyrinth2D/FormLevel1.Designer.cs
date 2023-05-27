namespace Labyrinth2D
{
    partial class FormLevel1
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
            this.label_start = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_start
            // 
            this.label_start.BackColor = System.Drawing.Color.GreenYellow;
            this.label_start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_start.Location = new System.Drawing.Point(12, 10);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(70, 35);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "Старт";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(718, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фініш";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(-1, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 12);
            this.label2.TabIndex = 3;
            this.label2.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(-1, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(801, 12);
            this.label3.TabIndex = 4;
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(0, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 451);
            this.label4.TabIndex = 5;
            this.label4.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(790, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 451);
            this.label5.TabIndex = 6;
            this.label5.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(225, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 344);
            this.label6.TabIndex = 7;
            this.label6.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // FormLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevel1";
            this.Shown += new System.EventHandler(this.FormLevel1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_start;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}