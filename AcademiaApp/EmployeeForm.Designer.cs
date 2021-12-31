//Date: 31/12/2021
namespace AcademiaApp
{
	partial class EmployeeForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.treeViewE = new System.Windows.Forms.TreeView();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxComodin = new System.Windows.Forms.CheckBox();
			this.checkBoxCaja = new System.Windows.Forms.CheckBox();
			this.checkBoxCocina = new System.Windows.Forms.CheckBox();
			this.checkBoxBarra = new System.Windows.Forms.CheckBox();
			this.checkBoxMixto = new System.Windows.Forms.CheckBox();
			this.checkBoxMesero = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButtonComodin = new System.Windows.Forms.RadioButton();
			this.radioButtonCaja = new System.Windows.Forms.RadioButton();
			this.radioButtonCocina = new System.Windows.Forms.RadioButton();
			this.radioButtonBarra = new System.Windows.Forms.RadioButton();
			this.radioButtonMixto = new System.Windows.Forms.RadioButton();
			this.radioButtonMesero = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.checkedListBoxWorkDays = new System.Windows.Forms.CheckedListBox();
			this.checkedListBoxOffDays = new System.Windows.Forms.CheckedListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxMinimumDays = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Datos del Empleado";
			// 
			// treeViewE
			// 
			this.treeViewE.Location = new System.Drawing.Point(13, 35);
			this.treeViewE.Name = "treeViewE";
			this.treeViewE.Size = new System.Drawing.Size(190, 488);
			this.treeViewE.TabIndex = 1;
			this.treeViewE.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewENodeMouseClick);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClear.Location = new System.Drawing.Point(308, 14);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(143, 58);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "Nuevo/Limpiar";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(457, 14);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(96, 58);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "Eliminar";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Location = new System.Drawing.Point(559, 14);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(143, 58);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "Guardar Cambios";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(210, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "ID:";
			// 
			// textBoxID
			// 
			this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxID.Location = new System.Drawing.Point(237, 78);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(33, 24);
			this.textBoxID.TabIndex = 7;
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.Location = new System.Drawing.Point(337, 78);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(130, 24);
			this.textBoxName.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(276, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nombre: ";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLastName.Location = new System.Drawing.Point(539, 78);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(163, 24);
			this.textBoxLastName.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(471, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Apellidos:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(209, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Estado:";
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboBoxStatus.Items.AddRange(new object[] {
									"Activo",
									"Inactivo"});
			this.comboBoxStatus.Location = new System.Drawing.Point(265, 111);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(96, 26);
			this.comboBoxStatus.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(367, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Fecha Entrada:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "dd/ MMMM / yyyy";
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Location = new System.Drawing.Point(471, 111);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(231, 24);
			this.dateTimePicker.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxComodin);
			this.groupBox1.Controls.Add(this.checkBoxCaja);
			this.groupBox1.Controls.Add(this.checkBoxCocina);
			this.groupBox1.Controls.Add(this.checkBoxBarra);
			this.groupBox1.Controls.Add(this.checkBoxMixto);
			this.groupBox1.Controls.Add(this.checkBoxMesero);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(210, 141);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(492, 53);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Puestos";
			// 
			// checkBoxComodin
			// 
			this.checkBoxComodin.Location = new System.Drawing.Point(370, 21);
			this.checkBoxComodin.Name = "checkBoxComodin";
			this.checkBoxComodin.Size = new System.Drawing.Size(104, 24);
			this.checkBoxComodin.TabIndex = 5;
			this.checkBoxComodin.Text = "Comodin";
			this.checkBoxComodin.UseVisualStyleBackColor = true;
			// 
			// checkBoxCaja
			// 
			this.checkBoxCaja.Location = new System.Drawing.Point(317, 21);
			this.checkBoxCaja.Name = "checkBoxCaja";
			this.checkBoxCaja.Size = new System.Drawing.Size(104, 24);
			this.checkBoxCaja.TabIndex = 4;
			this.checkBoxCaja.Text = "Caja";
			this.checkBoxCaja.UseVisualStyleBackColor = true;
			// 
			// checkBoxCocina
			// 
			this.checkBoxCocina.Location = new System.Drawing.Point(241, 21);
			this.checkBoxCocina.Name = "checkBoxCocina";
			this.checkBoxCocina.Size = new System.Drawing.Size(104, 24);
			this.checkBoxCocina.TabIndex = 3;
			this.checkBoxCocina.Text = "Cocina";
			this.checkBoxCocina.UseVisualStyleBackColor = true;
			// 
			// checkBoxBarra
			// 
			this.checkBoxBarra.Location = new System.Drawing.Point(175, 21);
			this.checkBoxBarra.Name = "checkBoxBarra";
			this.checkBoxBarra.Size = new System.Drawing.Size(104, 24);
			this.checkBoxBarra.TabIndex = 2;
			this.checkBoxBarra.Text = "Barra";
			this.checkBoxBarra.UseVisualStyleBackColor = true;
			// 
			// checkBoxMixto
			// 
			this.checkBoxMixto.Location = new System.Drawing.Point(117, 21);
			this.checkBoxMixto.Name = "checkBoxMixto";
			this.checkBoxMixto.Size = new System.Drawing.Size(104, 24);
			this.checkBoxMixto.TabIndex = 1;
			this.checkBoxMixto.Text = "Mixto";
			this.checkBoxMixto.UseVisualStyleBackColor = true;
			// 
			// checkBoxMesero
			// 
			this.checkBoxMesero.Location = new System.Drawing.Point(39, 21);
			this.checkBoxMesero.Name = "checkBoxMesero";
			this.checkBoxMesero.Size = new System.Drawing.Size(104, 24);
			this.checkBoxMesero.TabIndex = 0;
			this.checkBoxMesero.Text = "Mesero";
			this.checkBoxMesero.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButtonComodin);
			this.groupBox2.Controls.Add(this.radioButtonCaja);
			this.groupBox2.Controls.Add(this.radioButtonCocina);
			this.groupBox2.Controls.Add(this.radioButtonBarra);
			this.groupBox2.Controls.Add(this.radioButtonMixto);
			this.groupBox2.Controls.Add(this.radioButtonMesero);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(209, 201);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(493, 54);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Puesto Preferido:";
			// 
			// radioButtonComodin
			// 
			this.radioButtonComodin.Location = new System.Drawing.Point(371, 21);
			this.radioButtonComodin.Name = "radioButtonComodin";
			this.radioButtonComodin.Size = new System.Drawing.Size(104, 24);
			this.radioButtonComodin.TabIndex = 18;
			this.radioButtonComodin.TabStop = true;
			this.radioButtonComodin.Text = "Comodin";
			this.radioButtonComodin.UseVisualStyleBackColor = true;
			// 
			// radioButtonCaja
			// 
			this.radioButtonCaja.Location = new System.Drawing.Point(318, 21);
			this.radioButtonCaja.Name = "radioButtonCaja";
			this.radioButtonCaja.Size = new System.Drawing.Size(104, 24);
			this.radioButtonCaja.TabIndex = 19;
			this.radioButtonCaja.TabStop = true;
			this.radioButtonCaja.Text = "Caja";
			this.radioButtonCaja.UseVisualStyleBackColor = true;
			// 
			// radioButtonCocina
			// 
			this.radioButtonCocina.Location = new System.Drawing.Point(242, 21);
			this.radioButtonCocina.Name = "radioButtonCocina";
			this.radioButtonCocina.Size = new System.Drawing.Size(104, 24);
			this.radioButtonCocina.TabIndex = 18;
			this.radioButtonCocina.TabStop = true;
			this.radioButtonCocina.Text = "Cocina";
			this.radioButtonCocina.UseVisualStyleBackColor = true;
			// 
			// radioButtonBarra
			// 
			this.radioButtonBarra.Location = new System.Drawing.Point(176, 21);
			this.radioButtonBarra.Name = "radioButtonBarra";
			this.radioButtonBarra.Size = new System.Drawing.Size(104, 24);
			this.radioButtonBarra.TabIndex = 18;
			this.radioButtonBarra.TabStop = true;
			this.radioButtonBarra.Text = "Barra";
			this.radioButtonBarra.UseVisualStyleBackColor = true;
			// 
			// radioButtonMixto
			// 
			this.radioButtonMixto.Location = new System.Drawing.Point(118, 21);
			this.radioButtonMixto.Name = "radioButtonMixto";
			this.radioButtonMixto.Size = new System.Drawing.Size(104, 24);
			this.radioButtonMixto.TabIndex = 1;
			this.radioButtonMixto.TabStop = true;
			this.radioButtonMixto.Text = "Mixto";
			this.radioButtonMixto.UseVisualStyleBackColor = true;
			// 
			// radioButtonMesero
			// 
			this.radioButtonMesero.Location = new System.Drawing.Point(40, 21);
			this.radioButtonMesero.Name = "radioButtonMesero";
			this.radioButtonMesero.Size = new System.Drawing.Size(104, 24);
			this.radioButtonMesero.TabIndex = 0;
			this.radioButtonMesero.TabStop = true;
			this.radioButtonMesero.Text = "Mesero";
			this.radioButtonMesero.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(210, 258);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 23);
			this.label7.TabIndex = 18;
			this.label7.Text = "Dias de Trabajo";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(559, 258);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(119, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "Dias Libres";
			// 
			// checkedListBoxWorkDays
			// 
			this.checkedListBoxWorkDays.CheckOnClick = true;
			this.checkedListBoxWorkDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkedListBoxWorkDays.FormattingEnabled = true;
			this.checkedListBoxWorkDays.Items.AddRange(new object[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes",
									"Sabado",
									"Domingo"});
			this.checkedListBoxWorkDays.Location = new System.Drawing.Point(210, 284);
			this.checkedListBoxWorkDays.Name = "checkedListBoxWorkDays";
			this.checkedListBoxWorkDays.Size = new System.Drawing.Size(143, 236);
			this.checkedListBoxWorkDays.TabIndex = 21;
			this.checkedListBoxWorkDays.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxWorkDaysItemCheck);
			// 
			// checkedListBoxOffDays
			// 
			this.checkedListBoxOffDays.CheckOnClick = true;
			this.checkedListBoxOffDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkedListBoxOffDays.FormattingEnabled = true;
			this.checkedListBoxOffDays.Items.AddRange(new object[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes",
									"Sabado",
									"Domingo"});
			this.checkedListBoxOffDays.Location = new System.Drawing.Point(559, 284);
			this.checkedListBoxOffDays.Name = "checkedListBoxOffDays";
			this.checkedListBoxOffDays.Size = new System.Drawing.Size(143, 236);
			this.checkedListBoxOffDays.TabIndex = 22;
			this.checkedListBoxOffDays.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxOffDaysItemCheck);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(364, 284);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(189, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "Minimo de dias Laborales:";
			// 
			// textBoxMinimumDays
			// 
			this.textBoxMinimumDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMinimumDays.Location = new System.Drawing.Point(367, 311);
			this.textBoxMinimumDays.Name = "textBoxMinimumDays";
			this.textBoxMinimumDays.Size = new System.Drawing.Size(175, 24);
			this.textBoxMinimumDays.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(209, 29);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 30);
			this.label10.TabIndex = 25;
			this.label10.Text = "Opciones:";
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 535);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBoxMinimumDays);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.checkedListBoxOffDays);
			this.Controls.Add(this.checkedListBoxWorkDays);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.treeViewE);
			this.Controls.Add(this.label1);
			this.Name = "EmployeeForm";
			this.Text = "EmployeeForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxMinimumDays;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckedListBox checkedListBoxOffDays;
		private System.Windows.Forms.CheckedListBox checkedListBoxWorkDays;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton radioButtonMesero;
		private System.Windows.Forms.RadioButton radioButtonMixto;
		private System.Windows.Forms.RadioButton radioButtonBarra;
		private System.Windows.Forms.RadioButton radioButtonCocina;
		private System.Windows.Forms.RadioButton radioButtonCaja;
		private System.Windows.Forms.RadioButton radioButtonComodin;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxMesero;
		private System.Windows.Forms.CheckBox checkBoxMixto;
		private System.Windows.Forms.CheckBox checkBoxBarra;
		private System.Windows.Forms.CheckBox checkBoxCocina;
		private System.Windows.Forms.CheckBox checkBoxCaja;
		private System.Windows.Forms.CheckBox checkBoxComodin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TreeView treeViewE;
		private System.Windows.Forms.Label label1;
	}
}
