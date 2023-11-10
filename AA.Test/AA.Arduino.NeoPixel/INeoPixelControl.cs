namespace AA.Arduino.NeoPixel
{
	public interface INeoPixelControl
	{
		int PixelIndex { get; set; }
		int PixelCount { get; }
	}
}