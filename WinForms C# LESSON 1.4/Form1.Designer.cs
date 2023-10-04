using System.Drawing.Drawing2D;

namespace WinForms_C__LESSON_1._4
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
            button1 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(348, 40);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = "BAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(path);

            // 
            // b1
            // 
            b1.Location = new Point(408, 40);
            b1.Name = "b1";
            b1.Size = new Size(30, 30);
            b1.TabIndex = 1;
            b1.UseVisualStyleBackColor = true;
            b1.Visible = false;
            button1.FlatStyle = FlatStyle.Popup;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(0, 0, b1.Width, b1.Height);
            b1.Region = new Region(path1);

            // 
            // b2
            // 
            b2.Location = new Point(368, 40);
            b2.Name = "b2";
            b2.Size = new Size(30, 30);
            b2.TabIndex = 2;
            b2.UseVisualStyleBackColor = true;
            b2.Visible = false;

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(0, 0, b2.Width, b2.Height);
            b2.Region = new Region(path2);

            // 
            // b3
            // 
            b3.Location = new Point(388, 40);
            b3.Name = "b3";
            b3.Size = new Size(30, 30);
            b3.TabIndex = 3;
            b3.UseVisualStyleBackColor = true;
            b3.Visible = false;


            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(0, 0, b3.Width, b3.Height);
            b3.Region = new Region(path3);

            // 
            // b4
            // 
            b4.Location = new Point(398, 40);
            b4.Name = "b4";
            b4.Size = new Size(30, 30);
            b4.TabIndex = 4;
            b4.UseVisualStyleBackColor = true;
            b4.Visible = false;

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(0, 0, b4.Width, b4.Height);
            b4.Region = new Region(path4);

            // 
            // b5
            // 
            b5.Location = new Point(418, 40);
            b5.Name = "b5";
            b5.Size = new Size(30, 30);
            b5.TabIndex = 5;
            b5.UseVisualStyleBackColor = true;
            b5.Visible = false;

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(0, 0, b5.Width, b5.Height);
            b5.Region = new Region(path5);

            // 
            // b6
            // 
            b6.Location = new Point(408, 40);
            b6.Name = "b6";
            b6.Size = new Size(30, 30);
            b6.TabIndex = 6;
            b6.UseVisualStyleBackColor = true;
            b6.Visible = false;

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(0, 0, b6.Width, b6.Height);
            b6.Region = new Region(path6);


            // 
            // b7
            // 
            b7.Location = new Point(368, 40);
            b7.Name = "b7";
            b7.Size = new Size(30, 30);
            b7.TabIndex = 7;
            b7.UseVisualStyleBackColor = true;
            b7.Visible = false;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddEllipse(0, 0, b7.Width, b7.Height);
            b7.Region = new Region(path7);

            // 
            // b8
            // 
            b8.Location = new Point(398, 40);
            b8.Name = "b8";
            b8.Size = new Size(30, 30);
            b8.TabIndex = 8;
            b8.UseVisualStyleBackColor = true;
            b8.Visible = false;

            GraphicsPath path8 = new GraphicsPath();
            path8.AddEllipse(0, 0, b8.Width, b8.Height);
            b8.Region = new Region(path8);


            // 
            // b9
            // 
            b9.Location = new Point(378, 40);
            b9.Name = "b9";
            b9.Size = new Size(30, 30);
            b9.TabIndex = 9;
            b9.UseVisualStyleBackColor = true;
            b9.Visible = false;

            GraphicsPath path9 = new GraphicsPath();
            path9.AddEllipse(0, 0, b9.Width, b9.Height);
            b9.Region = new Region(path9);


            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(button1);

            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);

            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }



        #endregion

        private Button button1;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
    }
}