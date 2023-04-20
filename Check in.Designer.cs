namespace HOTEL
{
    partial class Check_in
    {
        private const int V = 17;
        private const string V1 = "btnadd";

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_in));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Dias = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtTotal = new TextBox();
            btnadd = new Button();
            label8 = new Label();
            dataEntrada = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            n_noches = new NumericUpDown();
            n_edad = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            label16 = new Label();
            label14 = new Label();
            label15 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label17 = new Label();
            label18 = new Label();
            label23 = new Label();
            n_hab = new ComboBox();
            label24 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_noches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_edad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 239, 223);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(41, 231);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(212, 239, 223);
            label2.Location = new Point(96, 267);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(212, 239, 223);
            label3.Location = new Point(115, 307);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 200);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // Dias
            // 
            Dias.AutoSize = true;
            Dias.BackColor = Color.FromArgb(212, 239, 223);
            Dias.Location = new Point(101, 130);
            Dias.Name = "Dias";
            Dias.Size = new Size(47, 15);
            Dias.TabIndex = 4;
            Dias.Text = "Noches";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(212, 239, 223);
            label5.Location = new Point(40, 174);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 5;
            label5.Text = "Tipo de habitacion ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 247);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 6;
            label6.Text = " ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(212, 239, 223);
            label7.Location = new Point(74, 359);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 7;
            label7.Text = "Total a pagar";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(172, 228);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(172, 264);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(172, 356);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 24;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(212, 239, 223);
            btnadd.Location = new Point(114, 458);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 23;
            btnadd.Text = "Finalizar";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(212, 239, 223);
            label8.Location = new Point(145, 36);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 20;
            label8.Text = "Dia de entrada";
            // 
            // dataEntrada
            // 
            dataEntrada.CustomFormat = "yyyy-MM-dd";
            dataEntrada.Format = DateTimePickerFormat.Custom;
            dataEntrada.Location = new Point(65, 77);
            dataEntrada.MaxDate = new DateTime(2023, 4, 24, 0, 0, 0, 0);
            dataEntrada.MinDate = new DateTime(2023, 4, 17, 0, 0, 0, 0);
            dataEntrada.Name = "dataEntrada";
            dataEntrada.Size = new Size(223, 23);
            dataEntrada.TabIndex = 22;
            dataEntrada.Value = new DateTime(2023, 4, 17, 20, 46, 18, 0);
            dataEntrada.ValueChanged += dataEntrada_ValueChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(757, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 329);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 192, 192);
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(864, 458);
            label9.Name = "label9";
            label9.Size = new Size(98, 37);
            label9.TabIndex = 27;
            label9.Text = "Piscina";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(0, 192, 192);
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(494, 458);
            label10.Name = "label10";
            label10.Size = new Size(98, 37);
            label10.TabIndex = 28;
            label10.Text = "Piscina";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkCyan;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(402, 47);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 29;
            label11.Text = "Sencilla (1)";
            // 
            // n_noches
            // 
            n_noches.Location = new Point(172, 128);
            n_noches.Maximum = new decimal(new int[] { 21, 0, 0, 0 });
            n_noches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            n_noches.Name = "n_noches";
            n_noches.ReadOnly = true;
            n_noches.Size = new Size(120, 23);
            n_noches.TabIndex = 31;
            n_noches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // n_edad
            // 
            n_edad.Location = new Point(172, 305);
            n_edad.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            n_edad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            n_edad.Name = "n_edad";
            n_edad.ReadOnly = true;
            n_edad.Size = new Size(120, 23);
            n_edad.TabIndex = 32;
            n_edad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkCyan;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(500, 47);
            label12.Name = "label12";
            label12.Size = new Size(92, 21);
            label12.TabIndex = 34;
            label12.Text = "Sencilla (2)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkCyan;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(598, 47);
            label13.Name = "label13";
            label13.Size = new Size(92, 21);
            label13.TabIndex = 35;
            label13.Text = "Sencilla (3)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkCyan;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(767, 28);
            label16.Name = "label16";
            label16.Size = new Size(74, 40);
            label16.TabIndex = 36;
            label16.Text = "Sencilla \r\ndoble (4)\r\n";
            label16.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.DarkCyan;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(864, 28);
            label14.Name = "label14";
            label14.Size = new Size(74, 40);
            label14.TabIndex = 37;
            label14.Text = "Sencilla \r\ndoble (5)\r\n";
            label14.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.DarkCyan;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.FlatStyle = FlatStyle.Flat;
            label15.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(963, 28);
            label15.Name = "label15";
            label15.Size = new Size(74, 40);
            label15.TabIndex = 38;
            label15.Text = "Sencilla \r\ndoble (6)\r\n";
            label15.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.DarkCyan;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.FlatStyle = FlatStyle.Flat;
            label19.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ButtonFace;
            label19.Location = new Point(767, 406);
            label19.Name = "label19";
            label19.Size = new Size(83, 40);
            label19.TabIndex = 42;
            label19.Text = "VIP \r\ndoble (10)";
            label19.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.DarkCyan;
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.FlatStyle = FlatStyle.Flat;
            label20.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ButtonFace;
            label20.Location = new Point(617, 406);
            label20.Name = "label20";
            label20.Size = new Size(59, 21);
            label20.TabIndex = 41;
            label20.Text = "VIP (9)";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.DarkCyan;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.FlatStyle = FlatStyle.Flat;
            label21.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(519, 406);
            label21.Name = "label21";
            label21.Size = new Size(59, 21);
            label21.TabIndex = 40;
            label21.Text = "VIP (8)";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.DarkCyan;
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.FlatStyle = FlatStyle.Flat;
            label22.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ButtonFace;
            label22.Location = new Point(421, 406);
            label22.Name = "label22";
            label22.Size = new Size(59, 21);
            label22.TabIndex = 39;
            label22.Text = "VIP (7)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.DarkCyan;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.FlatStyle = FlatStyle.Flat;
            label17.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(864, 406);
            label17.Name = "label17";
            label17.Size = new Size(82, 40);
            label17.TabIndex = 43;
            label17.Text = "VIP \r\ndoble (11)";
            label17.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.DarkCyan;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.FlatStyle = FlatStyle.Flat;
            label18.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(963, 406);
            label18.Name = "label18";
            label18.Size = new Size(83, 40);
            label18.TabIndex = 44;
            label18.Text = "VIP \r\ndoble (12)";
            label18.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(228, 412);
            label23.Name = "label23";
            label23.Size = new Size(44, 15);
            label23.TabIndex = 45;
            label23.Text = "label23";
            // 
            // n_hab
            // 
            n_hab.FormattingEnabled = true;
            n_hab.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            n_hab.Location = new Point(172, 171);
            n_hab.Name = "n_hab";
            n_hab.Size = new Size(125, 23);
            n_hab.TabIndex = 46;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(228, 443);
            label24.Name = "label24";
            label24.Size = new Size(44, 15);
            label24.TabIndex = 47;
            label24.Text = "label24";
            // 
            // Check_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(1131, 526);
            Controls.Add(label24);
            Controls.Add(n_hab);
            Controls.Add(label23);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(n_edad);
            Controls.Add(n_noches);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataEntrada);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnadd);
            Controls.Add(txtTotal);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Dias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Check_in";
            Text = "Check_in";
            Load += Check_in_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_noches).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_edad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Dias;
        private Label label5;
        private Label label6;
        private Label label7;

        public TextBox txtNombre;
        public TextBox txtTelefono;
        public TextBox txtTotal;
        private Label label8;
        private DateTimePicker dataEntrada;
        public Button btnadd;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private NumericUpDown n_noches;
        private NumericUpDown n_edad;
        private Label label12;
        private Label label13;
        private Label label16;
        private Label label14;
        private Label label15;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label17;
        private Label label18;
        private Label label23;
        private ComboBox n_hab;
        private Label label24;
    }
}