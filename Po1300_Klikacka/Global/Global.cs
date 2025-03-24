namespace Po1300_Klikacka
{
	public static class Global
	{
		public static Random Rnd = new Random();

		public static byte NahodneCislo(byte min, byte max)
		{
			return (byte)Rnd.Next(min, max + 1 );
			//return (int)Math.Floor(Rnd.NextDouble() * (max - min + 1) + min);
		}
	}
}
