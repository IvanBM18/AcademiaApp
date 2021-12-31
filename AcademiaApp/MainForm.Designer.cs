//Date: 31/12/2021
namespace AcademiaApp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonSchedule = new System.Windows.Forms.Button();
			this.buttonEmployee = new System.Windows.Forms.Button();
			this.buttonTip = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.dataGridSchedule = new System.Windows.Forms.DataGridView();
			this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 341);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 44);
			this.button1.TabIndex = 13;
			this.button1.Text = "Consultar Empleado";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(85, 341);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(189, 22);
			this.textBox1.TabIndex = 12;
			// 
			// buttonSchedule
			// 
			this.buttonSchedule.Location = new System.Drawing.Point(759, 211);
			this.buttonSchedule.Name = "buttonSchedule";
			this.buttonSchedule.Size = new System.Drawing.Size(111, 49);
			this.buttonSchedule.TabIndex = 11;
			this.buttonSchedule.Text = "Generar Horario";
			this.buttonSchedule.UseVisualStyleBackColor = true;
			// 
			// buttonEmployee
			// 
			this.buttonEmployee.Location = new System.Drawing.Point(759, 122);
			this.buttonEmployee.Name = "buttonEmployee";
			this.buttonEmployee.Size = new System.Drawing.Size(111, 49);
			this.buttonEmployee.TabIndex = 10;
			this.buttonEmployee.Text = "Empleados";
			this.buttonEmployee.UseVisualStyleBackColor = true;
			this.buttonEmployee.Click += new System.EventHandler(this.ButtonEmployeeClick);
			// 
			// buttonTip
			// 
			this.buttonTip.Location = new System.Drawing.Point(759, 67);
			this.buttonTip.Name = "buttonTip";
			this.buttonTip.Size = new System.Drawing.Size(111, 49);
			this.buttonTip.TabIndex = 9;
			this.buttonTip.Text = "Calcular Propina";
			this.buttonTip.UseVisualStyleBackColor = true;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(759, 12);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(111, 49);
			this.buttonReset.TabIndex = 8;
			this.buttonReset.Text = "Reiniciar";
			this.buttonReset.UseVisualStyleBackColor = true;
			// 
			// dataGridSchedule
			// 
			this.dataGridSchedule.AllowUserToOrderColumns = true;
			this.dataGridSchedule.BackgroundColor = System.Drawing.Color.PeachPuff;
			this.dataGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Lunes,
									this.Martes,
									this.Miercoles,
									this.Jueves,
									this.Viernes,
									this.Sabado,
									this.Domingo});
			this.dataGridSchedule.GridColor = System.Drawing.SystemColors.InfoText;
			this.dataGridSchedule.Location = new System.Drawing.Point(12, 12);
			this.dataGridSchedule.Name = "dataGridSchedule";
			this.dataGridSchedule.RowTemplate.Height = 24;
			this.dataGridSchedule.Size = new System.Drawing.Size(740, 320);
			this.dataGridSchedule.TabIndex = 7;
			// 
			// Lunes
			// 
			this.Lunes.HeaderText = "Lunes";
			this.Lunes.Name = "Lunes";
			// 
			// Martes
			// 
			this.Martes.HeaderText = "Martes";
			this.Martes.Name = "Martes";
			// 
			// Miercoles
			// 
			this.Miercoles.HeaderText = "Miercoles";
			this.Miercoles.Name = "Miercoles";
			// 
			// Jueves
			// 
			this.Jueves.HeaderText = "Jueves";
			this.Jueves.Name = "Jueves";
			// 
			// Viernes
			// 
			this.Viernes.HeaderText = "Viernes";
			this.Viernes.Name = "Viernes";
			// 
			// Sabado
			// 
			this.Sabado.HeaderText = "Sabado";
			this.Sabado.Name = "Sabado";
			// 
			// Domingo
			// 
			this.Domingo.HeaderText = "Domingo";
			this.Domingo.Name = "Domingo";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 540);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonSchedule);
			this.Controls.Add(this.buttonEmployee);
			this.Controls.Add(this.buttonTip);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.dataGridSchedule);
			this.Name = "MainForm";
			this.Text = "AcademiaApp";
			((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
		private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
		private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
		private System.Windows.Forms.DataGridView dataGridSchedule;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonTip;
		private System.Windows.Forms.Button buttonEmployee;
		private System.Windows.Forms.Button buttonSchedule;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}
