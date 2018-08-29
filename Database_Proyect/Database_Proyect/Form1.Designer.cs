namespace Database_Proyect
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
            this.txt_nocontrol = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apaterno = new System.Windows.Forms.TextBox();
            this.txt_amaterno = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lb_no_control = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_aPaterno = new System.Windows.Forms.Label();
            this.lb_aMaterno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nocontrol
            // 
            this.txt_nocontrol.Location = new System.Drawing.Point(31, 30);
            this.txt_nocontrol.Name = "txt_nocontrol";
            this.txt_nocontrol.Size = new System.Drawing.Size(146, 20);
            this.txt_nocontrol.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(31, 89);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(146, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apaterno
            // 
            this.txt_apaterno.Enabled = false;
            this.txt_apaterno.Location = new System.Drawing.Point(212, 89);
            this.txt_apaterno.Name = "txt_apaterno";
            this.txt_apaterno.Size = new System.Drawing.Size(146, 20);
            this.txt_apaterno.TabIndex = 2;
            // 
            // txt_amaterno
            // 
            this.txt_amaterno.Enabled = false;
            this.txt_amaterno.Location = new System.Drawing.Point(393, 89);
            this.txt_amaterno.Name = "txt_amaterno";
            this.txt_amaterno.Size = new System.Drawing.Size(146, 20);
            this.txt_amaterno.TabIndex = 3;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(202, 26);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(118, 27);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "BUSCAR";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(31, 125);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(105, 34);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "NUEVO";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(165, 125);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 34);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(299, 125);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 34);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "ACTUALIZAR";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(433, 125);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 34);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "CANCELAR";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 163);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_insert.Location = new System.Drawing.Point(433, 22);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(105, 34);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "GUARDAR";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Visible = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // lb_no_control
            // 
            this.lb_no_control.AutoSize = true;
            this.lb_no_control.Location = new System.Drawing.Point(28, 14);
            this.lb_no_control.Name = "lb_no_control";
            this.lb_no_control.Size = new System.Drawing.Size(94, 13);
            this.lb_no_control.TabIndex = 11;
            this.lb_no_control.Text = "Numero de control";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(28, 73);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 12;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_aPaterno
            // 
            this.lb_aPaterno.AutoSize = true;
            this.lb_aPaterno.Location = new System.Drawing.Point(209, 73);
            this.lb_aPaterno.Name = "lb_aPaterno";
            this.lb_aPaterno.Size = new System.Drawing.Size(84, 13);
            this.lb_aPaterno.TabIndex = 13;
            this.lb_aPaterno.Text = "Apellido Paterno";
            // 
            // lb_aMaterno
            // 
            this.lb_aMaterno.AutoSize = true;
            this.lb_aMaterno.Location = new System.Drawing.Point(390, 73);
            this.lb_aMaterno.Name = "lb_aMaterno";
            this.lb_aMaterno.Size = new System.Drawing.Size(86, 13);
            this.lb_aMaterno.TabIndex = 14;
            this.lb_aMaterno.Text = "Apellido Materno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 366);
            this.Controls.Add(this.lb_aMaterno);
            this.Controls.Add(this.lb_aPaterno);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_no_control);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txt_amaterno);
            this.Controls.Add(this.txt_apaterno);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_nocontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nocontrol;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apaterno;
        private System.Windows.Forms.TextBox txt_amaterno;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lb_no_control;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_aPaterno;
        private System.Windows.Forms.Label lb_aMaterno;
    }
}

