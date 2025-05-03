namespace ProyectoWindowsForms
{
    partial class Form2
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
            btnSync = new Button();
            btnAsync = new Button();
            lblEstado = new Label();
            lblCafe = new Label();
            lblTostadas = new Label();
            lblJugo = new Label();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Location = new Point(100, 50);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(200, 40);
            btnSync.TabIndex = 0;
            btnSync.Text = "Preparar Síncrono";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnAsync
            // 
            btnAsync.Location = new Point(400, 50);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(200, 40);
            btnAsync.TabIndex = 1;
            btnAsync.Text = "Preparar Async";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += btnAsync_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(100, 120);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(151, 32);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Esperando...";
            // 
            // lblCafe
            // 
            lblCafe.AutoSize = true;
            lblCafe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCafe.Location = new Point(100, 180);
            lblCafe.Name = "lblCafe";
            lblCafe.Size = new Size(94, 30);
            lblCafe.TabIndex = 3;
            lblCafe.Text = "Café: ❌";
            // 
            // lblTostadas
            // 
            lblTostadas.AutoSize = true;
            lblTostadas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTostadas.Location = new Point(100, 230);
            lblTostadas.Name = "lblTostadas";
            lblTostadas.Size = new Size(137, 30);
            lblTostadas.TabIndex = 4;
            lblTostadas.Text = "Tostadas: ❌";
            // 
            // lblJugo
            // 
            lblJugo.AutoSize = true;
            lblJugo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugo.Location = new Point(100, 280);
            lblJugo.Name = "lblJugo";
            lblJugo.Size = new Size(100, 30);
            lblJugo.TabIndex = 5;
            lblJugo.Text = "Jugo: ❌";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 350);
            Controls.Add(lblJugo);
            Controls.Add(lblTostadas);
            Controls.Add(lblCafe);
            Controls.Add(lblEstado);
            Controls.Add(btnAsync);
            Controls.Add(btnSync);
            Name = "Form2";
            Text = "Preparación de Desayuno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSync;
        private Button btnAsync;
        private Label lblEstado;
        private Label lblCafe;
        private Label lblTostadas;
        private Label lblJugo;
    }
}