using System.Windows.Forms;

namespace DrawingStuff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rotateYzDegrees = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rotateXzDegrees = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rotateXyDegrees = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.scalePoints = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.scalePoints);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.rotateYzDegrees);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.rotateXzDegrees);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.rotateXyDegrees);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.draw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 693);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 41);
            this.panel1.TabIndex = 0;
            // 
            // rotateYzDegrees
            // 
            this.rotateYzDegrees.Location = new System.Drawing.Point(317, 11);
            this.rotateYzDegrees.Name = "rotateYzDegrees";
            this.rotateYzDegrees.Size = new System.Drawing.Size(31, 20);
            this.rotateYzDegrees.TabIndex = 9;
            this.rotateYzDegrees.Text = "1";
            this.rotateYzDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "RotateYz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rotateXzDegrees
            // 
            this.rotateXzDegrees.Location = new System.Drawing.Point(194, 11);
            this.rotateXzDegrees.Name = "rotateXzDegrees";
            this.rotateXzDegrees.Size = new System.Drawing.Size(31, 20);
            this.rotateXzDegrees.TabIndex = 7;
            this.rotateXzDegrees.Text = "1";
            this.rotateXzDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "RotateXz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rotateXyDegrees
            // 
            this.rotateXyDegrees.Location = new System.Drawing.Point(74, 11);
            this.rotateXyDegrees.Name = "rotateXyDegrees";
            this.rotateXyDegrees.Size = new System.Drawing.Size(31, 20);
            this.rotateXyDegrees.TabIndex = 5;
            this.rotateXyDegrees.Text = "1";
            this.rotateXyDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "RotateXy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.White;
            this.draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.draw.Dock = System.Windows.Forms.DockStyle.Right;
            this.draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draw.Location = new System.Drawing.Point(791, 0);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(44, 41);
            this.draw.TabIndex = 3;
            this.draw.Text = "Go";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(835, 693);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // scalePoints
            // 
            this.scalePoints.Location = new System.Drawing.Point(435, 11);
            this.scalePoints.Name = "scalePoints";
            this.scalePoints.Size = new System.Drawing.Size(43, 20);
            this.scalePoints.TabIndex = 11;
            this.scalePoints.Text = "1.001";
            this.scalePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Scale";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 734);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hello my name is Simon and I like to do drawings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel canvas;
        private Button draw;
        private Button button1;
        private TextBox rotateXyDegrees;
        private TextBox rotateYzDegrees;
        private Button button3;
        private TextBox rotateXzDegrees;
        private Button button2;
        private TextBox scalePoints;
        private Button button4;

    }
}

