namespace HOTEL
{
    partial class Check_Out
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
            dataGridView2 = new DataGridView();
            Finalizar = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 239, 223);
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(467, 49);
            label1.MaximumSize = new Size(150, 150);
            label1.MinimumSize = new Size(50, 15);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 0;
            label1.Text = "Check Out";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(927, 446);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(89, 105);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(953, 288);
            dataGridView2.TabIndex = 11;
            // 
            // Finalizar
            // 
            Finalizar.Location = new Point(551, 438);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(82, 26);
            Finalizar.TabIndex = 12;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = true;
            Finalizar.Click += Finalizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(151, 441);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 13;
            label2.Text = "Ingrese el ID del hospedaje a finalizar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 438);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 14;
            // 
            // Check_Out
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(1128, 534);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(Finalizar);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Check_Out";
            Text = "Check_Out";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView2;
        private Button Finalizar;
        private Label label2;
        private TextBox textBox1;
    }
}