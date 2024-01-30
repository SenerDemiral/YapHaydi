namespace YapHaydi.DataLibrary;
// Actor
public class TA
{
	public int TAID;
	public int FFID;
	public string? Ad;
	public string? Tel;
	public string? Adres;
	public string? Mail;
	public string? Inf;
	public int Ytk1;
	public int Ytk2;
	public int Ytk3;

	public bool Ytk1b
	{
		get => Ytk1 == 0 ? false : true;
		set
		{
			Ytk1 = value == false ? 0 : 1;
		}
	}
	public bool Ytk2b
	{
		get => Ytk2 == 0 ? false : true;
		set
		{
			Ytk2 = value == false ? 0 : 1;
		}
	}
	public bool Ytk3b
	{
		get => Ytk3 == 0 ? false : true;
		set
		{
			Ytk3 = value == false ? 0 : 1;
		}
	}

}
