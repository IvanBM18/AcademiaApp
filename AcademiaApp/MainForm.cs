//Date: 09/12/2021
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Un Form para manejo del perfil de Trabajador
//Miniform o apartado para el calculo de la propina
//Miniorm para ver datos sobre el horario actual
//(Extra)Poder arrstrar empleados al horario
//(Extra)Generador de nomina automatica
//(Extra)AllowDrop en dtaviewGrid
//Habilitar comodines(
//cantidad de personas por puesto DIARIAS)
//Puesto Preferido -1 == no existe
//Para el horario tomar primero las personas con dias minimos de mayor a menor, tomando si es posible su puesto preferido
//Colocar cuantos dias querra el gerente
//Pasar Acciones

//Manejo de archivos en c#

namespace AcademiaApp{
	public partial class MainForm : Form
	{
		
		DateTime date;
		EmployeeForm employeeAdmin;
		public MainForm(){
			InitializeComponent();
			employeeAdmin = new EmployeeForm();
			
		}
		
		//Interfaz
		void ButtonEmployeeClick(object sender, EventArgs e){
			employeeAdmin.Show();
		}
	}
}

