namespace HOTEL
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            Contraseñatxt = new TextBox();
            Usuariotxt = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btningresar = new Button();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(211, 39);
            label1.Name = "label1";
            label1.Size = new Size(427, 65);
            label1.TabIndex = 0;
            label1.Text = "Motel Clear Dream";
            // 
            // groupBox1
            // 
            groupBox1.CausesValidation = false;
            groupBox1.Controls.Add(Contraseñatxt);
            groupBox1.Controls.Add(Usuariotxt);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btningresar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(56, 139);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(742, 313);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Contraseñatxt
            // 
            Contraseñatxt.BackColor = Color.FromArgb(28, 40, 51);
            Contraseñatxt.ForeColor = SystemColors.MenuHighlight;
            Contraseñatxt.Location = new Point(243, 196);
            Contraseñatxt.Name = "Contraseñatxt";
            Contraseñatxt.PasswordChar = '*';
            Contraseñatxt.Size = new Size(159, 33);
            Contraseñatxt.TabIndex = 8;
            // 
            // Usuariotxt
            // 
            Usuariotxt.BackColor = Color.FromArgb(28, 40, 51);
            Usuariotxt.ForeColor = SystemColors.MenuHighlight;
            Usuariotxt.Location = new Point(243, 86);
            Usuariotxt.Name = "Usuariotxt";
            Usuariotxt.Size = new Size(159, 33);
            Usuariotxt.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(212, 239, 223);
            btnSalir.Location = new Point(550, 233);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 46);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(212, 239, 223);
            btnLimpiar.Location = new Point(550, 163);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 46);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.FromArgb(212, 239, 223);
            btningresar.Location = new Point(550, 94);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(113, 46);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 199);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 1;
            label3.Text = "Contraseña ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 89);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(849, 528);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox Contraseñatxt;
        private TextBox Usuariotxt;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btningresar;
        private Label label3;
        private Label label2;
    }
}