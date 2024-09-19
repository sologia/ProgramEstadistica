namespace AppEstadistica
{
    partial class frmDatos
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
            dgvDatos = new DataGridView();
            EjeX = new DataGridViewTextBoxColumn();
            EjeY = new DataGridViewTextBoxColumn();
            X_Cuadrado = new DataGridViewTextBoxColumn();
            Y_Cuadrado = new DataGridViewTextBoxColumn();
            XPORY = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { EjeX, EjeY, X_Cuadrado, Y_Cuadrado, XPORY });
            dgvDatos.Location = new Point(12, 179);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(678, 361);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            dgvDatos.CellValueChanged += dgvDatos_CellValueChanged;
            dgvDatos.ColumnAdded += dgvDatos_ColumnAdded;
            dgvDatos.RowsAdded += dgvDatos_RowsAdded;
            // 
            // EjeX
            // 
            EjeX.HeaderText = "X";
            EjeX.MinimumWidth = 6;
            EjeX.Name = "EjeX";
            EjeX.Width = 125;
            // 
            // EjeY
            // 
            EjeY.HeaderText = "Y";
            EjeY.MinimumWidth = 6;
            EjeY.Name = "EjeY";
            EjeY.Width = 125;
            // 
            // X_Cuadrado
            // 
            X_Cuadrado.HeaderText = "X^2";
            X_Cuadrado.MinimumWidth = 6;
            X_Cuadrado.Name = "X_Cuadrado";
            X_Cuadrado.Width = 125;
            // 
            // Y_Cuadrado
            // 
            Y_Cuadrado.HeaderText = "Y^2";
            Y_Cuadrado.MinimumWidth = 6;
            Y_Cuadrado.Name = "Y_Cuadrado";
            Y_Cuadrado.Width = 125;
            // 
            // XPORY
            // 
            XPORY.HeaderText = "X*Y";
            XPORY.MinimumWidth = 6;
            XPORY.Name = "XPORY";
            XPORY.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(346, 20);
            label1.TabIndex = 1;
            label1.Text = "Por favor, Inserte Los datos del eje X y Y en el Panel";
            // 
            // button1
            // 
            button1.Location = new Point(385, 114);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 552);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Name = "frmDatos";
            Text = "frmDatos";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn EjeX;
        private DataGridViewTextBoxColumn EjeY;
        private DataGridViewTextBoxColumn X_Cuadrado;
        private DataGridViewTextBoxColumn Y_Cuadrado;
        private DataGridViewTextBoxColumn XPORY;
    }
}