namespace Po1300_Klikacka.Models
{
	public class Bunka
	{
		public Bunka(byte hodnota, int radek, int sloupec)
		{
			Hodnota = hodnota;
			Radek = radek;
			Sloupec = sloupec;
		}

		public byte Hodnota { get; private set; }
		public byte StyleClassIndex { get; set; } = 0;
		public string StyleClass => $"barva-{StyleClassIndex}";
		public int Radek { get;  }
		public int Sloupec { get;  }
	}
}
