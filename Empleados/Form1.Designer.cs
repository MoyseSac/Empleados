namespace Empleados
{
    partial class Form1
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
            this.dataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Sueldo = new System.Windows.Forms.Button();
            this.desplegable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAsistencia
            // 
            this.dataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencia.Location = new System.Drawing.Point(398, 56);
            this.dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            this.dataGridViewAsistencia.RowHeadersWidth = 51;
            this.dataGridViewAsistencia.RowTemplate.Height = 24;
            this.dataGridViewAsistencia.Size = new System.Drawing.Size(301, 217);
            this.dataGridViewAsistencia.TabIndex = 1;
            this.dataGridViewAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAsistencia_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cargar datos ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(51, 56);
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.RowHeadersWidth = 51;
            this.dataGridViewEmpleado.RowTemplate.Height = 24;
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(319, 217);
            this.dataGridViewEmpleado.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 186);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button_Sueldo
            // 
            this.button_Sueldo.Location = new System.Drawing.Point(709, 434);
            this.button_Sueldo.Name = "button_Sueldo";
            this.button_Sueldo.Size = new System.Drawing.Size(137, 77);
            this.button_Sueldo.TabIndex = 6;
            this.button_Sueldo.Text = "Mostrar sueldo";
            this.button_Sueldo.UseVisualStyleBackColor = true;
            this.button_Sueldo.Click += new System.EventHandler(this.button_Sueldo_Click);
            // 
            // desplegable
            // 
            this.desplegable.FormattingEnabled = true;
            this.desplegable.Location = new System.Drawing.Point(637, 354);
            this.desplegable.Name = "desplegable";
            this.desplegable.Size = new System.Drawing.Size(228, 24);
            this.desplegable.TabIndex = 7;
            this.desplegable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desplegable);
            this.Controls.Add(this.button_Sueldo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewEmpleado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewAsistencia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAsistencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Sueldo;
        private System.Windows.Forms.ComboBox desplegable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

