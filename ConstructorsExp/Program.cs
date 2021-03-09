using System;

namespace ConstructorsExp
{
	public class Tasit
	{

		public int hiz; // Taşıtın Maximum hızı 
		public String renk; // Taşıtın rengi
		public String marka; // Taşıtın markası

		// Parametreli yapılandırıcıda ilk değerli atıyoruz
		public Tasit(int hiz, String marka, String renk)
		{
			this.marka = marka;
			this.hiz = hiz;
			this.renk = renk;
		}

		public void tasitInfo()
		{
			String tasit = "Taşıtın markası: " + marka + " rengi: " + renk + " maximum hızı: " + hiz;

			System.Console.WriteLine(tasit);
		}

	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Taşıt tipinden nesneler oluşturuyoruz
			// Nesne oluşturuken yapılandırıcının istedği değerleri veriyoruz
			Tasit otomobil = new Tasit(200, "Renault", "Mavi");

			otomobil.tasitInfo();


		}
	}
}

