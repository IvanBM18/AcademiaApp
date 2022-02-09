//Date: 28/12/2021
using System;

namespace AcademiaApp{
	public class Employee{
		public bool[] workDays {get;set;} //Dias laborales de la semana
		public bool[] offDays {get;set;} //Dias laborales de la semana
		public int minimumWorkDays{get;set;} //Dias laborales minimos
		public bool[] jobPositions {get;set;} //Arreglo para ver que posiciones puede ejercer
		public int defaultPosition {get;set;} //Inidice del puesto predeterminado(para en caso de ser necesario colocar mas)?
		public int actualDays{get;set;}
		
		public int iD{get;set;} //Identificador de trabajador
		public bool status{get;set;} //Active Inactive
		public string name{get;set;} //Nombre
		public string lastName{get;set;} //Apellidos
		public DateTime entryDate{get;set;} //Aun nose como moveree esto
		
		public Employee(){
			status = true;
			jobPositions = new bool[6];
			workDays = new bool[7];
			offDays = new bool[7];
			entryDate = new DateTime();
			entryDate = DateTime.Now;
			defaultPosition = -1;
			iD = -1;
		}
		
		public Employee fromString(string register){
			string[] fields = register.Split('|');
			string positions;
			if(fields.Length > 2){
				iD = int.Parse(fields[0]);
				name = fields[1];
				lastName = fields[2];
				minimumWorkDays = int.Parse(fields[3]);
				defaultPosition = int.Parse(fields[4]);
				entryDate = DateTime.Parse(fields[5]);
				positions = fields[6];
				for(int i = 0;i < positions.Length; i++){
					if(positions[i] == '1')
						jobPositions[i] = true;
					else
						jobPositions[i] = false;
				}
				
				positions = fields[7];
				for(int i = 0;i < positions.Length; i++){
					if(positions[i] == '1'){
						workDays[i] = true;
						offDays[i] = false;
					}else{
						workDays[i] = false;
						offDays[i] = true;
					}
				}
					
				if(fields[8] == "True*" || fields[8] == "True")
					status = true;
				else
					status = false;
			}
			return this;
		}
		
		//Salida de Informacion
		public override string ToString(){
			return string.Format("{0}| {1}, {2}",iD, name, lastName);
		}
		
		public string toFile(){
			return iD.ToString() + "|" + name + "|" + lastName + "|" + minimumWorkDays.ToString() + "|" + defaultPosition.ToString()
				+ "|" + entryDate.ToString() + "|" + boolToBin(jobPositions) + "|" + boolToBin(workDays) + "|"   
				+ status.ToString() + "*";
		}
		
		public string boolToBin(bool[] bArray){
			string result = "";
			foreach (bool bI in bArray) {
				if(bI)
					result += "1";
				else
					result += "0";
			}
			return result;
		}
		
		public bool canWorkPosition(int posIndx){
			return jobPositions[posIndx];
		}

	}
}
