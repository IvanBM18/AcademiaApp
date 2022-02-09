//Date: 09/12/2021
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


//Trabajo Actual: PreBeta 
//Mejorar Visualizacion del Header de la tabla (Crear clase semana tal vez?)
//Requerido generar opciones antes de crear el horario
//Pre Beta: Intercambio de trabajos para intentar que todos tengan sus dias(ordenar por menos dias laborales?)
//Intercambio si 1 persona con puesto x trabaja en el preferido de otro el mismo dia
//Intercambio cuando alguien como mixto trabaja mas de 2 dias de lo normal(quitaselo alv)

//Post BETA->
//Miniform o apartado para el calculo de la propina
//Miniform para ver datos sobre el horario actual
//Post Beta: Max Dias, Boton Dudas, Hacerlo mas Bonito, funcion comodin.

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
		
		//Enumerado para posiciones
		enum positions{ //Mes->Mixto->Barra->Cocina
			INDX_MESERO ,
			INDX_BARRA,
			INDX_COCINA,
			INDX_MIXTO,
			INDX_CAJA,
			INDX_COMODIN
		}
		
		public MainForm(){
			InitializeComponent();
			dataGridSchedule.DefaultCellStyle.Font = new Font("Georgia", 13);
			employeeAdmin = new EmployeeForm();
			for(int i = dataGridSchedule.Rows.Count; i < 7; i++){
				dataGridSchedule.Rows.Add();
			}
			
		}
		
		//Interfaz
		void ButtonEmployeeClick(object sender, EventArgs e){
			try {
				employeeAdmin.ShowDialog();
			} catch (Exception) {
				employeeAdmin = new EmployeeForm();
				employeeAdmin.ShowDialog();
				throw;
			}
			
			eL = employeeAdmin.EmployeeList;
		}
		
		//Generar Horario
		void ButtonScheduleClick(object sender, EventArgs e){
			comod = radioButtonYes.Checked;
			week = generateWeek();
			eL = employeeAdmin.EmployeeList;
			//Variables aux
			int nMeseros,nCocina,nMixto,nBarra;
			
			if(eL.Count <= 2){
				eL = generateList();
			}
			sortListByDays();
			
			//Iniciamos a Generar el Horario
			
			//Asginacion de empleados a sus dias
			foreach (Employee eI in eL) {
				if(!eI.status)
					continue;
				//Ciclar una vez para su dia preferido, otra para ver donde lo podemos poner
				for(int i = 0;i < week.Length;i++){
					if(eI.actualDays == eI.minimumWorkDays)
						break;
					if(eI.workDays[i]){ //Si puede trabajar Hoy
						//Obtenemos los dias disponibles
						//Tratamos primero con su posicion por default
						tryWork(eI,week[i],eI.defaultPosition);
						
					}
				}
				
				//Cicla para ver en donde lo podemos poner tomando en cuenta su minimo de dias como maximo
				for(int i = 0;i < week.Length;i++){
					if(eI.actualDays == eI.minimumWorkDays)
						break;
					if(eI.workDays[i]){ //Si puede trabajar Hoy
						//Aqui debera de tratar de ponerlo trabajar en cualquier posicion que tenga
						for (int j = 0; j < 6; j++) {
							if(eI.jobPositions[j])
								tryWork(eI,week[i],j);
						}
						
					}
				}
			}
			
			//Trataremos de llenar huecos
			for (int i = 0; i < week.Length; i++) {
				//El dia no esta lleno
				if(!week[i].isFull()){
					if(week[i].mesero.Count < week[i].maxMesero){
						foreach (Employee eI in eL) {
							if(eI.workDays[i])
								tryWork(eI,week[i],(int)positions.INDX_MESERO);
						}
					}
					if(week[i].mixto.Count < week[i].maxMixto){
						foreach (Employee eI in eL) {
							if(eI.workDays[i])
								tryWork(eI,week[i],(int)positions.INDX_MIXTO);
						}
					}
					if(week[i].barra.Count < week[i].maxBarra){
						foreach (Employee eI in eL) {
							if(eI.workDays[i])
								tryWork(eI,week[i],(int)positions.INDX_BARRA);
						}
					}
					if(week[i].cocina.Count < week[i].maxCocina){
						foreach (Employee eI in eL) {
							if(eI.workDays[i])
								tryWork(eI,week[i],(int)positions.INDX_COCINA);
						}
					}
					if(week[i].caja.iD == -1){
						foreach (Employee eI in eL) {
							if(eI.workDays[i])
								tryWork(eI,week[i],(int)positions.INDX_CAJA);
						}
					}
				}
				
			}
			
			
			updateDataView();
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
		
		//Ver si el empleado puede trabajar el dia en la posicion deseada 
		bool tryWork(Employee eI, WorkDay day, int position){
			int capp;//Limite
			if(!eI.canWorkPosition(position) || !day.canWorkEmployee(eI))
				return false;
			if(position == (int)positions.INDX_MESERO){
				if(day.mesero.Count < day.maxMesero){
					day.mesero.Add(eI);
					eI.actualDays++;
					return true;
				}
			}else if(position == (int)positions.INDX_BARRA){
				if(day.barra.Count < day.maxBarra){
					day.barra.Add(eI);
					eI.actualDays++;
					return true;
				}
			}else if(position == (int)positions.INDX_COCINA){
				if(day.cocina.Count < day.maxCocina){
					day.cocina.Add(eI);
					eI.actualDays++;
					return true;
				}
			}else if(position == (int)positions.INDX_MIXTO){
				if(day.mixto.Count < day.maxMixto){
					day.mixto.Add(eI);
					eI.actualDays++;
					return true;
				}
			}else if(position == (int)positions.INDX_CAJA){
				if(day.caja != null){
					day.caja = eI;
					eI.actualDays++;
					return true;
				}
			}else if(position == (int)positions.INDX_COMODIN && comod){
				if(day.comodin != null){
					day.comodin = eI;
					eI.actualDays++;
					return true;
				}
			}
			return false;
			
		}
		
		//Actualiza la DataViewGrid
		void updateDataView(){
//			int nRow,day;
//			
//			nRow = (int)positions.INDX_MESERO;
//			//Insertamos Mesero
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_MONDAY].Value = week[(int)days.INDX_MONDAY].listToString(nRow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_TUESDAY].Value = week[(int)days.INDX_TUESDAY].listToString(nrow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_WEDNESDAY].Value = week[(int)days.INDX_WEDNESDAY].listToString(nrow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_THURSDAY].Value = week[(int)days.INDX_THURSDAY].listToString(nrow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_FRIDAY].Value = week[(int)days.INDX_FRIDAY].listToString(nrow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_SATURDAY].Value = week[(int)days.INDX_SATURDAY].listToString(nrow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_SUNDAY].Value = week[(int)days.INDX_SUNDAY].listToString(nrow);
//			
//			//Insertamos Barra
//			nRow = (int)positions.INDX_BARRA;
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_MONDAY].Value = week[(int)days.INDX_MONDAY].listToString(nRow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_TUESDAY].Value = week[(int)days.INDX_TUESDAY].listToString(nRow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_WEDNESDAY].Value = week[(int)days.INDX_WEDNESDAY].listToString(nRow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_THURSDAY].Value = week[(int)days.INDX_THURSDAY].listToString(nRow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_FRIDAY].Value = week[(int)days.INDX_FRIDAY].listToString(nRow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_SATURDAY].Value = week[(int)days.INDX_SATURDAY].listToString(nRow);
//			dataGridSchedule.Rows[nRow].Cells[(int)days.INDX_SUNDAY].Value = week[(int)days.INDX_SUNDAY].listToString(nRow);
			for (int iDay = 0; iDay <= (int)days.INDX_SUNDAY; iDay++) {
				for(int jRole = 0 ;jRole <= (int)positions.INDX_COMODIN;jRole++){
					dataGridSchedule.Rows[jRole].Cells[iDay].Value = week[iDay].listToString(jRole);
				}
			}
		}
	}
}

