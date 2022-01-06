//Date: 03/01/2022
using System;
using System.Collections.Generic;


namespace AcademiaApp{
	public class WorkDay{
		//Dia
		public Employee[] meseros{get;set;}
		public Employee[] cocina{get;set;}
		public Employee[] barra{get;set;}
		public Employee[] mixto{get;set;}
		public Employee caja{get;set;}
		public Employee comodin{get;set;}
		
		//Constructor de dia laboral
		public WorkDay(decimal nMeseros, decimal nCocina, decimal nBarra, decimal nMixto, bool comod){
			meseros = new Employee[(int)nMeseros];
			cocina = new Employee[(int)nCocina];
			barra = new Employee[(int)nBarra];
			mixto = new Employee[(int)nMixto];
			caja = new Employee();
			if(comod){
				comodin = new Employee();
			}
		}
		
	}
	
	
}
