/*
 * Created by SharpDevelop.
 * User: kurna
 * Date: 23.08.2023
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proje2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int maas = 0 ;
			int mutfakGideri = 0;
			int elektrikGideri = 0;
			int suGideri = 0;
			int	telefonGideri= 0;
			int	internet = 0;
			int giyim = 0;
			int diğer = 0;
			
			Console.WriteLine("Maaşınızı giriniz");
			string okunanDeğer = Console.ReadLine();
			maas = Convert.ToInt32(okunanDeğer);
			Console.WriteLine("Mutfak gideri giriniz");
			mutfakGideri = Convert.ToInt32(Console.ReadLine());
		
			Console.WriteLine("Elektrik gideri giriniz");
			elektrikGideri = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Su gideri giriniz");
			suGideri = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Telefon gideri giriniz");
			telefonGideri = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("İnternet gideri giriniz");
			internet = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Giyim gideri giriniz");
			giyim = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Diğer gideri giriniz");
			diğer = Convert.ToInt32(Console.ReadLine());
			
			int sonuc = maas - mutfakGideri - elektrikGideri - suGideri - telefonGideri - internet -giyim - diğer;
			Console.WriteLine("\n Eline kalan miktar: "+ sonuc);
			Console.ReadLine();
		}
	}
}