namespace AppEstadistica
{
    partial class frmMain
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
            txtCantidad = new MaskedTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 125);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "N° Datos";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(145, 118);
            txtCantidad.Mask = "0000";
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(37, 27);
            txtCantidad.TabIndex = 1;
            txtCantidad.MaskInputRejected += txtCantidad_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 175);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 2;
            label2.Text = "Pregunta del Enunciado";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(220, 172);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(544, 153);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(48, 377);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 4;
            button1.Text = "Insertar Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 484);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox txtCantidad;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}