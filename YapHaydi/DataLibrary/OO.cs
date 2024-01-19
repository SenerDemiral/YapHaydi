namespace YapHaydi.DataLibrary;

public class OO
{
	public int OOID;

	public int SbjID;
	public int ReqID;
	public int ActID;

	public DateTime? RQD;

	public DateTime? ESD;
	public DateTime? ESDt = DateTime.Today;
	public DateTime? ASD;

	public DateTime? EFD;
	public DateTime? EFDt = DateTime.Today;
	public DateTime? AFD;

	public string? Inf;
	public string? Msj;

	public int sdh;
	public int fdh;


	public string Sbj;
	public string Req;
	public string Act;

	public string? RQDfs => RQD?.ToString("dd.MM.yy HH:mm");
	public string? ESDfs => ESD?.ToString("dd.MM.yy HH:mm");
	public string? ASDfs => ASD?.ToString("dd.MM.yy HH:mm");
	public string? EFDfs => EFD?.ToString("dd.MM.yy HH:mm");
	public string? AFDfs => AFD?.ToString("dd.MM.yy HH:mm");


	public OO ShallowCopy()
	{
		return (OO)this.MemberwiseClone();
	}
}

