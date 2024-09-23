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
            txtPrueba = new TextBox();
            b1txt = new TextBox();
            b0txt = new TextBox();
            Rcuadradotxt = new TextBox();
            Rtxt = new TextBox();
            RVtxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txttt = new Label();
            label5 = new Label();
            label6 = new Label();
            Ttxt = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToResizeColumns = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { EjeX, EjeY, X_Cuadrado, Y_Cuadrado, XPORY });
            dgvDatos.Location = new Point(12, 179);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(677, 361);
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
            X_Cuadrado.ReadOnly = true;
            X_Cuadrado.Width = 125;
            // 
            // Y_Cuadrado
            // 
            Y_Cuadrado.HeaderText = "Y^2";
            Y_Cuadrado.MinimumWidth = 6;
            Y_Cuadrado.Name = "Y_Cuadrado";
            Y_Cuadrado.ReadOnly = true;
            Y_Cuadrado.Width = 125;
            // 
            // XPORY
            // 
            XPORY.HeaderText = "X*Y";
            XPORY.MinimumWidth = 6;
            XPORY.Name = "XPORY";
            XPORY.ReadOnly = true;
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
            button1.Click += button1_Click;
            // 
            // txtPrueba
            // 
            txtPrueba.Location = new Point(744, 179);
            txtPrueba.Name = "txtPrueba";
            txtPrueba.Size = new Size(125, 27);
            txtPrueba.TabIndex = 3;
            // 
            // b1txt
            // 
            b1txt.Location = new Point(744, 244);
            b1txt.Name = "b1txt";
            b1txt.Size = new Size(125, 27);
            b1txt.TabIndex = 4;
            // 
            // b0txt
            // 
            b0txt.Location = new Point(744, 315);
            b0txt.Name = "b0txt";
            b0txt.Size = new Size(125, 27);
            b0txt.TabIndex = 5;
            // 
            // Rcuadradotxt
            // 
            Rcuadradotxt.Location = new Point(744, 371);
            Rcuadradotxt.Name = "Rcuadradotxt";
            Rcuadradotxt.Size = new Size(125, 27);
            Rcuadradotxt.TabIndex = 6;
            // 
            // Rtxt
            // 
            Rtxt.Location = new Point(899, 371);
            Rtxt.Name = "Rtxt";
            Rtxt.Size = new Size(125, 27);
            Rtxt.TabIndex = 7;
            // 
            // RVtxt
            // 
            RVtxt.Location = new Point(744, 434);
            RVtxt.Name = "RVtxt";
            RVtxt.Size = new Size(125, 27);
            RVtxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(794, 221);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 9;
            label2.Text = "b1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(794, 292);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 10;
            label3.Text = "b0";
            // 
            // txttt
            // 
            txttt.AutoSize = true;
            txttt.Location = new Point(794, 348);
            txttt.Name = "txttt";
            txttt.Size = new Size(36, 20);
            txttt.TabIndex = 11;
            txttt.Text = "R^2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(794, 411);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 12;
            label5.Text = "RV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(945, 348);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 13;
            label6.Text = "R";
            // 
            // Ttxt
            // 
            Ttxt.Location = new Point(899, 434);
            Ttxt.Name = "Ttxt";
            Ttxt.Size = new Size(125, 27);
            Ttxt.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(925, 411);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 15;
            label4.Text = "t-student";
            // 
            // frmDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 552);
            Controls.Add(label4);
            Controls.Add(Ttxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txttt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RVtxt);
            Controls.Add(Rtxt);
            Controls.Add(Rcuadradotxt);
            Controls.Add(b0txt);
            Controls.Add(b1txt);
            Controls.Add(txtPrueba);
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
        private TextBox txtPrueba;
        private TextBox b1txt;
        private TextBox b0txt;
        private TextBox Rcuadradotxt;
        private TextBox Rtxt;
        private TextBox RVtxt;
        private Label label2;
        private Label label3;
        private Label txttt;
        private Label label5;
        private Label label6;
        private TextBox Ttxt;
        private Label label4;
    }
}