//Date: 03/01/2022
using System;
using System.Collections.Generic;


namespace AcademiaApp{
	public class WorkDay{
		//Dia
		public List<Employee> mesero{get;set;}
		public List<Employee> cocina{get;set;}
		public List<Employee> barra{get;set;}
		public List<Employee> mixto{get;set;}
		public Employee caja{get;set;}
		public Employee comodin{get;set;}
		public int maxMesero{get;set;}
		public int maxCocina{get;set;}
		public int maxBarra{get;set;}
		public int maxMixto{get;set;}
		
		//Enum
		enum positions{
			INDX_MESERO ,
			INDX_BARRA,
			INDX_COCINA,
			INDX_MIXTO,
			INDX_CAJA,
			INDX_COMODIN
		}
		
		//Constructor de dia laboral
		public WorkDay(decimal nMeseros, decimal nCocina, decimal nBarra, decimal nMixto, bool comod){
			maxMesero = (int)nMeseros;
			maxCocina = (int)nCocina;
			maxBarra = (int)nBarra;
			maxMixto = (int)nMixto;
			mesero = new List<Employee>();
			cocina = new List<Employee>();
			barra = new List<Employee>();
			mixto = new List<Employee>();
			caja = new Employee();
			if(comod){
				comodin = new Employee();
			}
		}
		
		public bool isFull(){
			if(mesero.Count == maxMesero){
				if(cocina.Count == maxCocina){
					if(barra.Count == maxBarra){
						if(mixto.Count == maxMixto){
							if(caja.iD != -1)
								return true;
						}
					}
				}
			}
			return false;
		}
		
		public bool canWorkEmployee(Employee eI){
			if(caja == eI)
				return false;
			if(mesero.Exists(eJ => eJ == eI))
				return false;
			if(mixto.Exists(eJ => eJ == eI))
				return false;
			if(barra.Exists(eJ => eJ == eI))
				return false;
			if(cocina.Exists(eJ => eJ == eI))
				return false;
			return true;
		}
		
		public string listToString(int position){
			string day = "";
			if(position == (int)positions.INDX_MESERO){
				foreach (Employee eI in mesero) {
					day += eI.name + "/";
				}
				return day;
			}else if(position == (int)positions.INDX_BARRA){
				foreach (Employee eI in barra) {
					day += eI.name + "/";
				}
				return day;
			}else if(position == (int)positions.INDX_COCINA){
				foreach (Employee eI in cocina) {
					day += eI.name + "/";
				}
				return day;
			}else if(position == (int)positions.INDX_MIXTO){
				foreach (Employee eI in mixto) {
					day += eI.name + "/";
				}
				return day;
			}else if(position == (int)positions.INDX_CAJA){
				if(caja.iD != -1)
					day = caja.name;
			}else if(position == (int)positions.INDX_COMODIN && comodin != null){
				if(comodin.iD != -1)
					day = comodin.name;
			}
			return day;
		}
		
		
	}
	
	
}
