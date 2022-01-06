//Date: 09/12/2021
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


//Miniform o apartado para el calculo de la propina
//Miniform para ver datos sobre el horario actual
//(Extra)Poder arrstrar empleados al horario
//Para el horario tomar primero las personas con dias minimos de mayor a menor, tomando si es posible su puesto preferido
//Cuando hacen falta personas, pero no hay personal disponible, dejarlo en blanco o poner de las personas con menos dias?
//Pasar Acciones
//CASO: Si puedes dame el lunes sino no pasa nada

namespace AcademiaApp{
	public partial class MainForm : Form
	{
		//Lista de Empleados
		List<Employee> eL;
		
		//Variables auxiliares
		DateTime date;
		EmployeeForm employeeAdmin;
		WorkDay[] week;
		bool comod;
		
		//Manejo de archivo
		string pathFile = "employees.txt";
		TextReader read; //Usado en lectura
		TextWriter write; //Usado en Escritura
		StreamWriter append; //Usado en Append
		
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
		
		public MainForm(){
			InitializeComponent();
			dataGridSchedule.DefaultCellStyle.Font = new Font("Arial", 9);
			employeeAdmin = new EmployeeForm();
			
		}
		
		//Interfaz
		void ButtonEmployeeClick(object sender, EventArgs e){
			
			employeeAdmin.Show();
			eL = employeeAdmin.EmployeeList;
		}
		
		//Generar Horario
		void ButtonScheduleClick(object sender, EventArgs e){
			week = generateWeek();
			eL = employeeAdmin.EmployeeList;
			if(eL.Count <= 2){
				eL = generateList();
			}
			sortListByDays();
			foreach (Employee eI in eL) {
				if(!eI.status)
					continue;
				
			}
		}
		
//Metodos Generales
		//Generacion de Semana
		WorkDay[] generateWeek(){
			WorkDay[] w = new WorkDay[7];
			if(radioButtonYes.Checked){
				comod = true;
			}
			w = new WorkDay[7];
			//Lunes
			
			w[(int)days.INDX_MONDAY] = new WorkDay(numericMesL.Value,numericCocL.Value, numericBarrL.Value, numericMixL.Value, comod);
			//Martes
			w[(int)days.INDX_TUESDAY] = new WorkDay(numericMesM.Value,numericCocM.Value, numericBarrM.Value, numericMixM.Value, comod);
			//Miercoles
			w[(int)days.INDX_WEDNESDAY] = new WorkDay(numericMesI.Value,numericCocI.Value, numericBarrI.Value, numericMixI.Value, comod);
			//Jueves
			w[(int)days.INDX_THURSDAY] = new WorkDay(numericMesJ.Value,numericCocJ.Value, numericBarrJ.Value, numericMixJ.Value, comod);
			//Viernes
			w[(int)days.INDX_FRIDAY] = new WorkDay(numericMesV.Value,numericCocV.Value, numericBarrV.Value, numericMixV.Value, comod);
			//Sabado
			w[(int)days.INDX_SATURDAY] = new WorkDay(numericMesS.Value,numericCocS.Value, numericBarrS.Value, numericMixS.Value, comod);
			//Domingo
			w[(int)days.INDX_SUNDAY] = new WorkDay(numericMesD.Value,numericCocD.Value, numericBarrD.Value, numericMixD.Value, comod);
			
			
			return w; 
				
		}
		
		//Generacion de Lista
		List<Employee> generateList(){
			List<Employee> employeeList = new List<Employee>();
			read = new StreamReader(pathFile);
			string[] registers = read.ReadLine().Split('*');
			foreach (string reg in registers) {
				if(reg.Length > 2){
					//MessageBox.Show(reg);
					employeeList.Add(new Employee().fromString(reg));
				}
			}
			read.Close();
			return employeeList;
		}
		
		//Ordenamos Personas en base a su minimo de dias(Insertion Sort)
		void sortListByDays(){
			Employee aux;
			bool flag;
			int n = eL.Count;
			int val;
			for(int i = 1; i < n; i++){
				val = eL[i].minimumWorkDays;
				flag = false;
				aux = eL[i];
				for(int j = i - 1; j >= 0 && !flag;){
					if(val > eL[j].minimumWorkDays){
						eL[j+1] = eL[j];
						j--;
						eL[j+1] = aux;
					}else {
						flag = true;
					}
				}
			}
			
		}
		
		
	}
}

