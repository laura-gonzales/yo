namespace WinFormsApp1
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
            txtnombre = new TextBox();
            pictureBox1 = new PictureBox();
            btnCrear = new Button();
            dataGridView1 = new DataGridView();
            txtapellido = new TextBox();
            btnActualizar = new Button();
            btnDelete = new Button();
            LBLID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(43, 41);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(177, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 124);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(29, 424);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(436, 150);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(43, 117);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(206, 424);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(390, 424);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // LBLID
            // 
            LBLID.Location = new Point(177, 196);
            LBLID.Name = "LBLID";
            LBLID.Size = new Size(100, 23);
            LBLID.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(LBLID);
            Controls.Add(btnDelete);
            Controls.Add(btnActualizar);
            Controls.Add(txtapellido);
            Controls.Add(dataGridView1);
            Controls.Add(btnCrear);
            Controls.Add(pictureBox1);
            Controls.Add(txtnombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private PictureBox pictureBox1;
        private Button btnCrear;
        private DataGridView dataGridView1;
        private TextBox txtapellido;
        private Button btnActualizar;
        private Button btnDelete;
        private Label LBLID;
    }
}
