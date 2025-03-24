namespace Po1300_Klikacka.Models
{
	public class Grafika
	{
		public Grafika()
		{
			//vytvorime matici 6x8
			PripravPole(radek: 6,sloupcu: 8, cisloDo: 1);
		}

		public Bunka[,] Pole { get; private set; }
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

		public void OnCellClick(Bunka bunka)
		{
			if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva)
			{
				bunka.StyleClassIndex = ZvolenaBarva;
			}
			else
			{
				bunka.StyleClassIndex = 0;
			}

		}
	}
}
