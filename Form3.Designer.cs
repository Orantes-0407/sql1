namespace ProyectoWindowsForms
{
    partial class Form3
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblPeso = new Label();
            lblAltura = new Label();
            pictureBox1 = new PictureBox();
            btnConsulta = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(250, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 31);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(153, 250);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(153, 300);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(61, 25);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso: ";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(153, 350);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(72, 25);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(450, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(300, 130);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(150, 40);
            btnConsulta.TabIndex = 5;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 75);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 6;
            label1.Text = "Nombre: ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 494);
            Controls.Add(label1);
            Controls.Add(btnConsulta);
            Controls.Add(pictureBox1);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "Form3";
            Text = "Consulta API";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblPeso;
        private Label lblAltura;
        private PictureBox pictureBox1;
        private Button btnConsulta;
        private Label label1;
    }
}