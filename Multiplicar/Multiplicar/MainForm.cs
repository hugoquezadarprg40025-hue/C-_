/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 23/10/2026
 * Hora: 07:33 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplicar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double num1, num2, R;
			num1=Convert.ToDouble(txt1.Text);
			num2=Convert.ToDouble(txt2.Text);
			R=num1*num2;
			MessageBox.Show("El resultado de la multiplicacion es: "+R);
		}
	}
}
