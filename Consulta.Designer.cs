namespace HOTEL
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            lblSencilla = new Label();
            lblDoble = new Label();
            labelVIP = new Label();
            lblVipDoble = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 239, 223);
            label1.Location = new Point(476, 47);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 1;
            label1.Text = "Consulta de Habitaciones";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(212, 239, 223);
            button1.Location = new Point(1064, 458);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(436, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 255);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblSencilla
            // 
            lblSencilla.BackColor = Color.Lime;
            lblSencilla.Location = new Point(592, 172);
            lblSencilla.Name = "lblSencilla";
            lblSencilla.Size = new Size(67, 30);
            lblSencilla.TabIndex = 4;
            lblSencilla.Text = "Habitacion Sencilla";
            // 
            // lblDoble
            // 
            lblDoble.BackColor = Color.Lime;
            lblDoble.Location = new Point(486, 172);
            lblDoble.Name = "lblDoble";
            lblDoble.Size = new Size(67, 30);
            lblDoble.TabIndex = 5;
            lblDoble.Text = "Habitacion Doble";
            // 
            // labelVIP
            // 
            labelVIP.BackColor = Color.Lime;
            labelVIP.Location = new Point(592, 304);
            labelVIP.Name = "labelVIP";
            labelVIP.Size = new Size(67, 30);
            labelVIP.TabIndex = 6;
            labelVIP.Text = "Habitacion VIP";
            // 
            // lblVipDoble
            // 
            lblVipDoble.BackColor = Color.Lime;
            lblVipDoble.Location = new Point(486, 304);
            lblVipDoble.Name = "lblVipDoble";
            lblVipDoble.Size = new Size(67, 30);
            lblVipDoble.TabIndex = 7;
            lblVipDoble.Text = "VIP Doble";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(730, 265);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 8;
            label6.Text = "Disponible";
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(1151, 493);
            Controls.Add(label6);
            Controls.Add(lblVipDoble);
            Controls.Add(labelVIP);
            Controls.Add(lblDoble);
            Controls.Add(lblSencilla);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Consulta";
            Text = "Consulta";
            Load += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label6;
        public Label lblSencilla;
        public Label lblDoble;
        public Label labelVIP;
        public Label lblVipDoble;
    }
}