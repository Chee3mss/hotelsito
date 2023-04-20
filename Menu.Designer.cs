namespace HOTEL
{
    partial class Menu
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 239, 223);
            label1.Location = new Point(408, 97);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "MENÚ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(212, 239, 223);
            button1.Location = new Point(348, 155);
            button1.Name = "button1";
            button1.Size = new Size(168, 50);
            button1.TabIndex = 1;
            button1.Text = "Check in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(212, 239, 223);
            button2.Location = new Point(348, 252);
            button2.Name = "button2";
            button2.Size = new Size(168, 50);
            button2.TabIndex = 2;
            button2.Text = "Check Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(212, 239, 223);
            button3.Location = new Point(348, 359);
            button3.Name = "button3";
            button3.Size = new Size(168, 50);
            button3.TabIndex = 3;
            button3.Text = "Consulta de habitaciones";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(212, 239, 223);
            button4.Location = new Point(1, 1);
            button4.Name = "button4";
            button4.Size = new Size(107, 35);
            button4.TabIndex = 4;
            button4.Text = "Cerrar sesion ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(852, 628);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}