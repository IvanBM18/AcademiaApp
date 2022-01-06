//Date: 03/01/2022
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Al presionar boton retornar una lista de Dias
namespace AcademiaApp{
	public partial class OptionForm : Form{
		
		WorkDay[] week;
		bool comod;
		//Enum dias
		enum days{
			INDX_MONDAY ,
			INDX_TUESDAY,
			INDX_WEDNESDAY,
			INDX_THURSDAY,
			INDX_FRIDAY,
			INDX_SATURDAY,
			INDX_SUNDAY
		}
		
		public OptionForm(){
			InitializeComponent();
			week = new WorkDay[7];
			comod = false;
		}
		
		//Getter
		public WorkDay[] WeeK {
			get { return week; }
		}
		
		void Button1Click(object sender, EventArgs e){
			if(radioButtonYes.Checked){
				comod = true;
			}
			//Lunes
			week[(int)days.INDX_MONDAY] = new WorkDay(numericMesL.Value,numericCocL.Value, numericBarrL.Value, numericMixL.Value, comod);
			//Martes
			week[(int)days.INDX_TUESDAY] = new WorkDay(numericMesM.Value,numericCocM.Value, numericBarrM.Value, numericMixM.Value, comod);
			//Miercoles
			week[(int)days.INDX_WEDNESDAY] = new WorkDay(numericMesI.Value,numericCocI.Value, numericBarrI.Value, numericMixI.Value, comod);
			//Jueves
			week[(int)days.INDX_THURSDAY] = new WorkDay(numericMesJ.Value,numericCocJ.Value, numericBarrJ.Value, numericMixJ.Value, comod);
			//Viernes
			week[(int)days.INDX_FRIDAY] = new WorkDay(numericMesV.Value,numericCocV.Value, numericBarrV.Value, numericMixV.Value, comod);
			//Sabado
			week[(int)days.INDX_SATURDAY] = new WorkDay(numericMesS.Value,numericCocS.Value, numericBarrS.Value, numericMixS.Value, comod);
			//Domingo
			week[(int)days.INDX_SUNDAY] = new WorkDay(numericMesD.Value,numericCocD.Value, numericBarrD.Value, numericMixD.Value, comod);
			
		}
	}
	
	
}
