using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_maquina
{
    class producto
    {
		public static int devuelta = 0;
		public static int llevar = 0;
		public static int total = 0;
		public static int presupuesto = 0;
		public void Menu()
		{
			
			int decidir = 0;

			bool repeticion = true;
			titulo();
			Console.WriteLine("Cual es su presupuesto?");
			 int presupuesto = int.Parse(Console.ReadLine());
			limpiar();
			while (repeticion)
			{

				titulo();
				decida();
				productos();
				decidir = int.Parse(Console.ReadLine());
				limpiar();
				
				switch (decidir)
				{
					
				
					
					case 1:
						refresco();
						pausa();
						limpiar();
						repitiendo();
						limpiar();
						break;
					case 2:
						agua();
						pausa();
						limpiar();
						repitiendo();
						limpiar();
						break;
					case 3:
						jugo();
						pausa();
						limpiar();
						repitiendo();
						limpiar();
						break;
				
					case 4:
						cheetos();
						pausa();
						limpiar();
						repitiendo();
						limpiar();
						break;
					case 5:
						doritos();
						pausa();
						limpiar();
						repitiendo();
						limpiar();
						break;
					case 6:
						chocolate();
						pausa();
						limpiar();
						repitiendo();
						limpiar();
						break;
					

				}



			}
		}

		static void repitiendo()
		{
			int decidirr = 0;
			Console.WriteLine("Quiere algo mas?");
			Console.WriteLine("1 - Si");
			Console.WriteLine("2 - No");
			decidirr = int.Parse(Console.ReadLine());
			if (decidirr == 1)
			{
				Console.ReadKey();
			}
			if (decidirr == 2)
			{
				Console.WriteLine("Gracias vuelva pronto");
				Console.ReadKey();
				Environment.Exit(35);
			}
		}

		static void limpiar()
		{
			Console.Clear();
		}
		static void pausa()
		{
			Console.ReadKey();
		}

		static void titulo()
		{
			Console.WriteLine("----Maquina Dispensadora----");
		}
		

		
		static void productos()
		{
			
			Console.WriteLine("1-Refresco");
			Console.WriteLine("2-Agua");
			Console.WriteLine("3-Jugo");
			
			Console.WriteLine("4-Cheetos");
			Console.WriteLine("5-Doritos");
			Console.WriteLine("6-Chocolate");
			
		}


		
		static void refresco()
		{

			Console.WriteLine("Producto --- Refresco");
			Console.WriteLine("Precio --- 20$ ");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			int total = llevar * 20;
			if (presupuesto < total)
			{
				Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
			}
			if (presupuesto >= total)
			{
				int devuelta = presupuesto - total;
				Console.WriteLine("Tenga su/s refresco/s");
				Console.WriteLine("Le quedan " + devuelta);
			}
			presupuesto = devuelta;
		}

		static void agua()
		{

			Console.WriteLine("Producto --- Botella de agua ");
			Console.WriteLine("Precio --- 10$ ");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Cuantas desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			int total = llevar * 10;
			if (presupuesto < total)
			{
				Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
			}
			if (presupuesto >= total)
			{
			int 	devuelta = presupuesto - total;
				Console.WriteLine("Tenga su/s botella/s de agua");
				Console.WriteLine("Le quedan " + devuelta);
			}
			presupuesto = devuelta;
		}

		static void jugo()
		{

			Console.WriteLine("Producto --- Jugo");
			Console.WriteLine("Precio --- 20$ ");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			int total = llevar * 20;
			if (presupuesto < total)
			{
				Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
			}
			if (presupuesto >= total)
			{
				devuelta = presupuesto - total;
				Console.WriteLine("Tenga su/s jugo/s");
				Console.WriteLine("Le quedan " + devuelta);
			}
			presupuesto = devuelta;
		}

		

		static void cheetos()
		{

			Console.WriteLine("Producto --- Cheetos");
			Console.WriteLine("Precio --- 25$ ");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Cuantos desea llevar?");
		int	llevar = int.Parse(Console.ReadLine());
			 int total = llevar * 25;
			if (presupuesto < total)
			{
				Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
			}
			if (presupuesto >= total)
			{
				devuelta = presupuesto - total;
				Console.WriteLine("Tenga su/s Cheetos");
				Console.WriteLine("Le quedan " + devuelta);
			}
			presupuesto = devuelta;
		}

		static void doritos()
		{

			Console.WriteLine("Producto --- Doritos");
			Console.WriteLine("Precio --- 25$ ");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			int total = llevar * 20;
			if (presupuesto < total)
			{
				Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
			}
			if (presupuesto >= total)
			{
				devuelta = presupuesto - total;
				Console.WriteLine("Tenga su/s Doritos");
				Console.WriteLine("Le quedan " + devuelta);
			}
			presupuesto = devuelta;
		}

		static void chocolate()
		{

			Console.WriteLine("Producto --- Chocolate");
			Console.WriteLine("Precio --- 45$ ");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
		int	total = llevar * 45;
			if (presupuesto < total)
			{
				Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
			}
			if (presupuesto >= total)
			{
				devuelta = presupuesto - total;
				Console.WriteLine("Tenga su/s chocolate/s");
				Console.WriteLine("Le quedan " + devuelta);
			}
			presupuesto = devuelta;
		}

		
		

		static void decida()
		{
			Console.WriteLine("Elija una opcion");
		}


	}
	}

