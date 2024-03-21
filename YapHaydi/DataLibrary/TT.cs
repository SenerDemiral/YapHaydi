namespace YapHaydi.DataLibrary;

public class TT
{
	public int TTID;
	public string? Typ;
	public string? Ad;
	public string? Tag;
	public string? Tel;
	public string? Adres;
	public string? Mail;
	public string? Inf;
	public int IsFrm;
    public int IsDpt;
	public int IsYpn;

	public bool IsFrmb
	{
		get => IsFrm == 0 ? false : true;
		set
		{
			IsFrm = value == false ? 0 : 1;
		}
	}
	public bool IsDptb
	{
		get => IsDpt == 0 ? false : true;
		set
		{
			IsDpt = value == false ? 0 : 1;
		}
	}
	public bool IsYpnb
	{
		get => IsYpn == 0 ? false : true;
		set
		{
			IsYpn = value == false ? 0 : 1;
		}
	}
}
