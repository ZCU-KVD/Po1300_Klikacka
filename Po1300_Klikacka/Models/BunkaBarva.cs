namespace Po1300_Klikacka.Models
{
	public class BunkaBarva:Bunka
	{
		public BunkaBarva(byte hodnota, int sloupec) : base(hodnota, radek: 0, sloupec)
		{
			StyleClassIndex = (byte)sloupec;
		}

		public bool Selected { get; set; } = false;

		public string StyleClassNameSelected => Selected ? "selected" : "";
		public override string StyleClass => $"{base.StyleClass} {StyleClassNameSelected}";
	}
}
