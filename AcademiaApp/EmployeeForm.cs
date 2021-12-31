//Date: 31/12/2021
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Boton de Dudas
//Minimo de dias
//AutoAsignar Id
//Cuando se selecciona domingo como laboral, se deselecciona de dia libre y al reves
//Boton Limpiar/Nuevo

namespace AcademiaApp{
	public partial class EmployeeForm : Form{
		
		//Enumerado para dias
		enum days{
			INDX_MONDAY ,
			INDX_TUESDAY,
			INDX_WEDNESDAY,
			INDX_THURSDAY,
			INDX_FRIDAY,
			INDX_SATURDAY,
			INDX_SUNDAY
		}
		
		//Enumerado para posiciones
		enum positions{
			INDX_MESERO ,
			INDX_MIXTO,
			INDX_BARRA,
			INDX_COCINA,
			INDX_CAJA,
			INDX_COMODIN
		}
		
		//Manejo de archivos
		string pathFile = "employees.txt";
		TextReader read; //Usado en lectura
		TextWriter write; //Usado en Escritura
		StreamWriter append; //Usado en Append 
		
		//Lista de Empleados
		List<Employee> employeeList;
		
		//Variables
		bool selectedEmployee;
		
		public EmployeeForm(){
			InitializeComponent();
			if (!File.Exists(pathFile))
				File.Create(pathFile);
			else{
				generateList();
				if(employeeList.Count > 0){
					treeViewE.BeginUpdate();
					foreach (Employee eI in employeeList) {
						treeViewE.Nodes.Add(eI.ToString());
					}
					treeViewE.EndUpdate();
				}
				
			}
			selectedEmployee = false;
		}
		
//Interfaz Grafica
		//Añadir Empleados
		void ButtonClearClick(object sender, EventArgs e){
			clearAll();
		}
		
		//Eliminar Empleados
		void ButtonDeleteClick(object sender, EventArgs e){
			int n;
			if(textBoxID.Text == "" || !int.TryParse(textBoxID.Text, out n))
				MessageBox.Show("[ERROR] Inserta un numero entero ");
			else{
				//Eliminamos de la lista y del treeview
				foreach (Employee eI in employeeList) {
					if(eI.iD == int.Parse(textBoxID.Text)){
						//Eliminamos del archivo
						File.Create("backup.txt");
						read = new StreamReader(pathFile);
						write = new StreamWriter("backup.txt");
						string[] registers = read.ReadLine().Split('*');
						foreach (string reg in registers) { //Pasamos casi toda la info al archivo de respaldo
							if(reg.Length > 2)
								if(int.Parse(reg.Split('|')[0]) != eI.iD)
									write.Write(reg);
						}
						read.Close();
						write.Close();
						
						write = new StreamWriter(pathFile);
						read = new StreamReader("backup.txt");
						write.Write(read.ReadLine());
						
						read.Close();
						write.Close();
						File.Delete("backup.txt");
						
						//Eliminamos de la lista
						employeeList.Remove(eI);
						
						//Eliminamos del treeView
						treeViewE.BeginUpdate();
						treeViewE.Nodes.Clear();
						foreach (Employee eJ in employeeList) {
							treeViewE.Nodes.Add(eJ.ToString());
						}
						treeViewE.EndUpdate();
						break;
					}
				}
				
				
			}
		}
		
		//Modificar a un empleado
		void ButtonSaveClick(object sender, EventArgs e){
			//Nuevo empleado
			if(!selectedEmployee){
				//Variables
				Employee myE = generateEmployee();
				
				//Checar primero si no existe el empleado
				if(myE != null){
					//Actualizamos treeView
					treeViewE.BeginUpdate();
					treeViewE.Nodes.Add(myE.ToString());
					treeViewE.EndUpdate();
					
					//Añadimos al archivo
					append = File.AppendText(pathFile);
					append.WriteLine(myE.toFile());
					append.Close();
				}
				selectedEmployee = true;
			}else{ //Edicion de empleado ya existente
				return;
			}
		}
		
		//Seleccion de Empleados
		void TreeViewENodeMouseClick(object sender, TreeNodeMouseClickEventArgs e){
			int nodeID = int.Parse(e.Node.Text.Split('|')[0]);
			foreach (Employee eI in employeeList){
				if(eI.iD == nodeID){
					selectEmployee(eI);
					selectedEmployee = true;
					return;
				}
					
			}
		}
		
		//Seleccion de un dia de descanso
		void CheckedListBoxOffDaysItemCheck(object sender, ItemCheckEventArgs e){
			if(checkedListBoxWorkDays.GetItemChecked(e.Index))
				checkedListBoxWorkDays.SetItemChecked(e.Index,false);
		}
		
		//Seleccion de un dia Laboral
		void CheckedListBoxWorkDaysItemCheck(object sender, ItemCheckEventArgs e){
			if(checkedListBoxOffDays.GetItemChecked(e.Index))
				checkedListBoxOffDays.SetItemChecked(e.Index,false);
		}
		
//Metodos del Form
		//Generacion de Empleado
		Employee generateEmployee(){
			Employee myE = new Employee();
			
			myE.name = textBoxName.Text;
			myE.lastName = textBoxLastName.Text;
			myE.entryDate = dateTimePicker.Value;
			
			try {
				myE.iD = int.Parse(textBoxID.Text);
			}catch(FormatException){
				MessageBox.Show("[ERROR]: Se introdujo valores invalidos en iD");
				return null;
			}
			try {
				myE.minimumWorkDays = int.Parse(textBoxMinimumDays.Text);
			} catch (FormatException) {
				MessageBox.Show("[ERROR]: Se introdujo valores invalidos en dias minimos");
				return null;
			}
			
			//Estado
			if(comboBoxStatus.SelectedItem == null){
				myE.status = true;
			}else if(comboBoxStatus.SelectedItem.ToString() == "Activo"){
				myE.status = true;
			}else if(comboBoxStatus.SelectedItem.ToString() == "Inactivo"){
				myE.status = false;
			}else{
				myE.status = true;
			}
			
			//Asignacion de puestos
			if(checkBoxMesero.Checked)
				myE.jobPositions[(int)positions.INDX_MESERO] = true;
			if(checkBoxMixto.Checked)
				myE.jobPositions[(int)positions.INDX_MIXTO] = true;
			if(checkBoxBarra.Checked)
				myE.jobPositions[(int)positions.INDX_BARRA] = true;
			if(checkBoxCocina.Checked)
				myE.jobPositions[(int)positions.INDX_COCINA] = true;
			if(checkBoxCaja.Checked)
				myE.jobPositions[(int)positions.INDX_CAJA] = true;
			if(checkBoxComodin.Checked)
				myE.jobPositions[(int)positions.INDX_COMODIN] = true;
			
			//Asignacion de puesto Preferido
			if(radioButtonMesero.Checked)
				myE.defaultPosition = (int)positions.INDX_MESERO;
			else if(radioButtonMixto.Checked)
				myE.defaultPosition = (int)positions.INDX_MIXTO;
			else if(radioButtonBarra.Checked)
				myE.defaultPosition = (int)positions.INDX_BARRA;
			else if(radioButtonCocina.Checked)
				myE.defaultPosition = (int)positions.INDX_COCINA;
			else if(radioButtonCaja.Checked)
				myE.defaultPosition = (int)positions.INDX_CAJA;
			else if(radioButtonComodin.Checked)
				myE.defaultPosition = (int)positions.INDX_COMODIN;
			else //Sin posicion Preferida, lo que caiga
				myE.defaultPosition = -1;
			
			//Asignacion de dias laborales
			foreach (object item in checkedListBoxWorkDays.CheckedItems) {
				if(item.ToString() == "Lunes"){
					myE.workDays[(int)days.INDX_MONDAY] = true;
					continue;
				}else if(item.ToString() == "Martes"){
					myE.workDays[(int)days.INDX_TUESDAY] = true;
					continue;
				}else if(item.ToString() == "Miercoles"){
					myE.workDays[(int)days.INDX_WEDNESDAY] = true;
					continue;
				}else if(item.ToString() == "Jueves"){
					myE.workDays[(int)days.INDX_THURSDAY] = true;
					continue;
				}else if(item.ToString() == "Viernes"){
					myE.workDays[(int)days.INDX_FRIDAY] = true;
					continue;
				}else if(item.ToString() == "Sabado"){
					myE.workDays[(int)days.INDX_SATURDAY] = true;
					continue;
				}else if(item.ToString() == "Domingo"){
					myE.workDays[(int)days.INDX_SUNDAY] = true;
					continue;
				}
			}
			
			//Asignacion de dias libres
			foreach (object item in checkedListBoxOffDays.CheckedItems) {
				if(item.ToString() == "Lunes"){
					myE.offDays[(int)days.INDX_MONDAY] = true;
					continue;
				}
				if(item.ToString() == "Martes"){
					myE.offDays[(int)days.INDX_TUESDAY] = true;
					continue;
				}
				if(item.ToString() == "Miercoles"){
					myE.offDays[(int)days.INDX_WEDNESDAY] = true;
					continue;
				}
				if(item.ToString() == "Jueves"){
					myE.offDays[(int)days.INDX_THURSDAY] = true;
					continue;
				}
				if(item.ToString() == "Viernes"){
					myE.offDays[(int)days.INDX_FRIDAY] = true;
					continue;
				}
				if(item.ToString() == "Sabado"){
					myE.offDays[(int)days.INDX_SATURDAY] = true;
					continue;
				}
				if(item.ToString() == "Domingo"){
					myE.offDays[(int)days.INDX_SUNDAY] = true;
					continue;
				}
			}
			
			return myE;
		}
		
		//Generacion de listas de Empleados
		void generateList(){
			employeeList = new List<Employee>();
			read = new StreamReader(pathFile);
			string[] registers = read.ReadLine().Split('*');
			foreach (string reg in registers) {
				if(reg.Length > 2){
					//MessageBox.Show(reg);
					employeeList.Add(new Employee().fromString(reg));
				}
			}
			read.Close();
		}
		
		//Actualizacion de Objetos en base a un empleado
		void selectEmployee(Employee eI){
			clearAll();
			textBoxID.Text = eI.iD.ToString();
			textBoxName.Text = eI.name;
			textBoxLastName.Text = eI.lastName;
			textBoxMinimumDays.Text = eI.minimumWorkDays.ToString();
			dateTimePicker.Value = eI.entryDate;
			if(eI.status){
				comboBoxStatus.SelectedIndex = 0;
				comboBoxStatus.Text = comboBoxStatus.Items[0].ToString();
			}else{
				comboBoxStatus.SelectedIndex = 1;
				comboBoxStatus.Text = comboBoxStatus.Items[1].ToString();
			}
			
			//Check posiciones Laborales 
			for(int i = 0; i < eI.jobPositions.Length; i++){
				switch (i) {
					case 0://Mesero
						if(eI.jobPositions[i])
							checkBoxMesero.Checked = true;
						else
							checkBoxMesero.Checked = false;
						break;
					case 1://Mixto
						if(eI.jobPositions[i])
							checkBoxMixto.Checked = true;
						else
							checkBoxMixto.Checked = false;
						break;
					case 2://Barra
						if(eI.jobPositions[i])
							checkBoxBarra.Checked = true;
						else
							checkBoxBarra.Checked = false;
						break;
					case 3://Cocina
						if(eI.jobPositions[i])
							checkBoxCocina.Checked = true;
						else
							checkBoxCocina.Checked = false;
						break;
					case 4://Caja
						if(eI.jobPositions[i])
							checkBoxCaja.Checked = true;
						else
							checkBoxCaja.Checked = false;
						break;
					case 5://Comodin
						if(eI.jobPositions[i])
							checkBoxComodin.Checked = true;
						else
							checkBoxComodin.Checked = false;
						break;
					default:
						break;
				}
			}
			
			//Check Dia laboral Preferido
			if(eI.defaultPosition == (int)positions.INDX_MESERO)
				radioButtonMesero.Checked = true;
			else if(eI.defaultPosition == (int)positions.INDX_MIXTO)
				radioButtonMixto.Checked = true;
			else if(eI.defaultPosition == (int)positions.INDX_BARRA)
				radioButtonBarra.Checked = true;
			else if(eI.defaultPosition == (int)positions.INDX_COCINA)
				radioButtonCocina.Checked = true;
			else if(eI.defaultPosition == (int)positions.INDX_CAJA)
				radioButtonCaja.Checked = true;
			else if(eI.defaultPosition == (int)positions.INDX_COMODIN)
				radioButtonComodin.Checked = true;
			
			//Check DiasLaborales
			for(int i = 0; i < eI.workDays.Length; i++){
				if(eI.workDays[i])
					checkedListBoxWorkDays.SetItemChecked(i,true);
				else
					checkedListBoxWorkDays.SetItemChecked(i,false);
			}
			
			//Check DiasDescanso
			for(int i = 0; i < eI.offDays.Length; i++){
				if(eI.workDays[i])
					checkedListBoxOffDays.SetItemChecked(i,true);
				else
					checkedListBoxOffDays.SetItemChecked(i,false);
			}
		}
		
		//Limpiamos Interfaz
		void clearAll(){
			textBoxID.Clear();
			textBoxName.Clear();
			textBoxLastName.Clear();
			textBoxMinimumDays.Clear();
			comboBoxStatus.Text = "";
			dateTimePicker.Value = DateTime.Now;
			
			checkBoxMesero.Checked = false;
			checkBoxMixto.Checked = false;
			checkBoxBarra.Checked = false;
			checkBoxCocina.Checked = false;
			checkBoxCaja.Checked = false;
			checkBoxComodin.Checked = false;
			
			radioButtonMesero.Checked = false;
			radioButtonMixto.Checked = false;
			radioButtonBarra.Checked = false;
			radioButtonCocina.Checked = false;
			radioButtonCaja.Checked = false;
			radioButtonComodin.Checked = false;
			
			for(int i = 0; i < checkedListBoxWorkDays.Items.Count;i++){
				checkedListBoxWorkDays.SetItemChecked(i,true);
			}
			
			for(int i = 0; i < checkedListBoxWorkDays.Items.Count;i++){
				checkedListBoxOffDays.SetItemChecked(i,false);
			}
			selectedEmployee = false;
		}
		
		
		
	}
}
