/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 23/10/2026
 * Hora: 07:33 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Multiplicar
{
	partial class MainForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(69, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(317, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 2:";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(44, 126);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(143, 26);
			this.txt1.TabIndex = 2;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(289, 126);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(143, 26);
			this.txt2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(225, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "X";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(182, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 38);
			this.button1.TabIndex = 5;
			this.button1.Text = "Multiplicar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(489, 272);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Multiplicar";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
