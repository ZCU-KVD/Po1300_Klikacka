namespace Po1300_Klikacka.Models
{
	public class Grafika
	{
		public Grafika()
		{
			//vytvorime matici 6x8
			PripravPole(radek: 6,sloupcu: 8, cisloDo: 1);
		}

		public Grafika(int radek, int sloupcu, byte barev = 4)
		{
			PripravBarvy(barev);
			//vytvorime matici radek x sloupcu
			PripravPole(radek: radek, sloupcu: sloupcu, cisloDo: barev);
			
			ZvolenaBarva = 3;
			BarvySeznam[ZvolenaBarva].Selected = true;
		}

		public Bunka[,] Pole { get; private set; }

		public List<BunkaBarva> BarvySeznam { get; set; } = new List<BunkaBarva>();
		public byte ZvolenaBarva { get; private set; } = 2;
		private void PripravPole(int radek, int sloupcu, byte cisloDo)
		{
			Pole = new Bunka[radek, sloupcu];
			for (int i = 0; i < radek; i++)
			{
				for (int j = 0; j < sloupcu; j++)
				{
					Pole[i, j] = new Bunka(Global.NahodneCislo(0, cisloDo), i, j);
				}
			}
		}
		private void PripravBarvy(int sloupcu)
		{
			BarvySeznam.Clear();
			for (int i = 0; i <= sloupcu; i++)
			{
				BarvySeznam.Add(new BunkaBarva((byte)i, i));
			}
		}

		public void OnCellClick(Bunka bunka)
		{
			if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva
				|| BarvySeznam.Count > 0)
			{
				bunka.StyleClassIndex = ZvolenaBarva;
			}
			else
			{
				bunka.StyleClassIndex = 0;
			}

		}

		public void OnCellClick(BunkaBarva bunka)
		{
			foreach (var item in BarvySeznam)
			{
				item.Selected = false;
			}
			bunka.Selected = true;

			ZvolenaBarva = bunka.Hodnota;
		}
	}
}
