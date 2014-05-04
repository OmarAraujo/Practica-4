/*
 * Creado por SharpDevelop.
 * Usuario: Ing. Omar
 * Fecha: 03/05/2014
 * Hora: 23:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace PracticaCuatro
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("M E N U\n");
			
			Console.WriteLine("Seleccione una opción:\n");
			
			Console.WriteLine("1.- Imprimir\n");
			Console.WriteLine("2.- Capturar nuevo producto\n");
			Console.WriteLine("3.- Salir\n");
			
			switch(Console.Read())
			{
					
					case '1': Console.Write("Imprimir..\n");
					//metodos
					break;
					
					case '2': Console.WriteLine("\tNUEVO PRODUCTO\n");
					
					Console.WriteLine("Dame el nombre: \n");
					string nombre=Console.ReadLine();
					Console.Write("Dame el codigo: \n");
					string codigo=Console.ReadLine();
					Console.WriteLine("Dame descripción: \n");
					string descripcion=Console.ReadLine();
					
					Console.WriteLine("Nuevo producto: \n"+ nombre +
					                  codigo + descripcion );
					break;
					
					case '3': Console.Write("Saliendo del programa..\n");
					Console.ReadKey(true);
					break;
					
			
			}
		
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}