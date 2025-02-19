namespace Abrir_Excel
{
    partial class frmFechas
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dtpFecha_nacimiento = new DateTimePicker();
            label2 = new Label();
            dtpFechaCalculo = new DateTimePicker();
            btnCalcular = new Button();
            label3 = new Label();
            txtCurp = new TextBox();
            btnCurp = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpFecha_nacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFechaCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCalcular, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0714283F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.92857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Size = new Size(776, 224);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 16);
            label1.TabIndex = 0;
            label1.Text = "Fecha Nacimiento";
            // 
            // dtpFecha_nacimiento
            // 
            dtpFecha_nacimiento.Location = new Point(3, 19);
            dtpFecha_nacimiento.Name = "dtpFecha_nacimiento";
            dtpFecha_nacimiento.Size = new Size(296, 27);
            dtpFecha_nacimiento.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 102);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha Calculo";
            // 
            // dtpFechaCalculo
            // 
            dtpFechaCalculo.Location = new Point(3, 135);
            dtpFechaCalculo.Name = "dtpFechaCalculo";
            dtpFechaCalculo.Size = new Size(296, 27);
            dtpFechaCalculo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCalcular.Location = new Point(391, 163);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(382, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 374);
            label3.Name = "label3";
            label3.Size = new Size(101, 35);
            label3.TabIndex = 1;
            label3.Text = "CURP";
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(121, 380);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(269, 27);
            txtCurp.TabIndex = 2;
            // 
            // btnCurp
            // 
            btnCurp.Location = new Point(414, 379);
            btnCurp.Name = "btnCurp";
            btnCurp.Size = new Size(94, 29);
            btnCurp.TabIndex = 3;
            btnCurp.Text = "Curp";
            btnCurp.UseVisualStyleBackColor = true;
            // 
            // frmFechas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCurp);
            Controls.Add(txtCurp);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Name = "frmFechas";
            Text = "frmFechas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dtpFecha_nacimiento;
        private Label label2;
        private DateTimePicker dtpFechaCalculo;
        private Button btnCalcular;
        private Label label3;
        private TextBox txtCurp;
        private Button btnCurp;
    }
}