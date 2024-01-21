namespace YapHaydi.DataLibrary;

public class OO
{
	public int OOID;

	public int SbjID;
	public int ReqID;
	public int ActID;


	public DateTime? RSD;
	public DateTime? RSDt = DateTime.Today;
	public DateTime? ASD;

	public DateTime? RFD;
	public DateTime? RFDt = DateTime.Today;
	public DateTime? AFD;
	public string? Inf;
	public string? Msj;

	public int InsID;
	public int UpdID;
	public DateTime? InsTS;
	public DateTime? UpdTS;

	public int sdh;
	public int fdh;

	public string Sbj;
	public string Req;
	public string Act;

	public string? RSDfs => RSD?.ToString("dd.MM.yy HH:mm");
	public string? ASDfs => ASD?.ToString("dd.MM.yy HH:mm");
	public string? RFDfs => RFD?.ToString("dd.MM.yy HH:mm");
	public string? AFDfs => AFD?.ToString("dd.MM.yy HH:mm");
	public bool Started => ASD != null;
	public bool Finishhed => AFD != null;
	
	public string InsUsr;
	public string UpdUsr;
	public string? InsTSfs => InsTS?.ToString("dd.MM.yy HH:mm");
	public string? UpdTSfs => UpdTS?.ToString("dd.MM.yy HH:mm");

	public bool UpdatePending = false;
	public int UpdateSoF;   // 1:Started, 2:Finished

	public OO ShallowCopy()
	{
		return (OO)this.MemberwiseClone();
	}
}

