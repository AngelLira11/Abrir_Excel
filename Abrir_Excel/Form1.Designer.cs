namespace Abrir_Excel
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            guardarArchivoToolStripMenuItem = new ToolStripMenuItem();
            openFileDialogEditor = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewEditor = new DataGridView();
            btnColumna = new Button();
            btnFila = new Button();
            txtNameColumna = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            programasToolStripMenuItem = new ToolStripMenuItem();
            fechasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditor).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, programasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem, guardarArchivoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(224, 26);
            excelToolStripMenuItem.Text = "Abrir Archivo ( .xls)";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // guardarArchivoToolStripMenuItem
            // 
            guardarArchivoToolStripMenuItem.Name = "guardarArchivoToolStripMenuItem";
            guardarArchivoToolStripMenuItem.Size = new Size(224, 26);
            guardarArchivoToolStripMenuItem.Text = "Guardar Archivo";
            // 
            // openFileDialogEditor
            // 
            openFileDialogEditor.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewEditor, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.76659F));
            tableLayoutPanel1.Size = new Size(800, 341);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dataGridViewEditor
            // 
            dataGridViewEditor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditor.Dock = DockStyle.Fill;
            dataGridViewEditor.Location = new Point(3, 3);
            dataGridViewEditor.Name = "dataGridViewEditor";
            dataGridViewEditor.RowHeadersWidth = 51;
            dataGridViewEditor.Size = new Size(794, 335);
            dataGridViewEditor.TabIndex = 0;
            // 
            // btnColumna
            // 
            btnColumna.Location = new Point(72, 417);
            btnColumna.Name = "btnColumna";
            btnColumna.Size = new Size(148, 29);
            btnColumna.TabIndex = 2;
            btnColumna.Text = "Agregar Columna";
            btnColumna.UseVisualStyleBackColor = true;
            btnColumna.Click += btnColumna_Click;
            // 
            // btnFila
            // 
            btnFila.Location = new Point(341, 417);
            btnFila.Name = "btnFila";
            btnFila.Size = new Size(128, 29);
            btnFila.TabIndex = 3;
            btnFila.Text = "Agregar Fila";
            btnFila.UseVisualStyleBackColor = true;
            btnFila.Click += btnFila_Click;
            // 
            // txtNameColumna
            // 
            txtNameColumna.Location = new Point(154, 384);
            txtNameColumna.Name = "txtNameColumna";
            txtNameColumna.Size = new Size(125, 27);
            txtNameColumna.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 387);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre columna: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(649, 409);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Eliminar Tabla";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fechasToolStripMenuItem });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(94, 24);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // fechasToolStripMenuItem
            // 
            fechasToolStripMenuItem.Name = "fechasToolStripMenuItem";
            fechasToolStripMenuItem.Size = new Size(224, 26);
            fechasToolStripMenuItem.Text = "Fechas";
            fechasToolStripMenuItem.Click += fechasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(txtNameColumna);
            Controls.Add(btnFila);
            Controls.Add(btnColumna);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private OpenFileDialog openFileDialogEditor;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewEditor;
        private ToolStripMenuItem guardarArchivoToolStripMenuItem;
        private Button btnColumna;
        private Button btnFila;
        private TextBox txtNameColumna;
        private Label label1;
        private Button btnLimpiar;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem fechasToolStripMenuItem;
    }
}
