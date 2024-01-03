namespace YapHaydi.DataLibrary;

public class DbaMdl
{
	public int WWId;
	public int? SbjID;

	public int? rWhoID;
	public int? mDptID;
	public int? mWhoID;

	public DateTime? SED;
	public DateTime? SAD;
	public DateTime? FED;
	public DateTime? FAD;

	public string? SEDfs => SED?.ToString("dd.MM.yy HH:mm");
	public string? SADfs => SAD?.ToString("dd.MM.yy HH:mm");
	public string? FEDfs => FAD?.ToString("dd.MM.yy HH:mm");
	public string? FADfs => FAD?.ToString("dd.MM.yy HH:mm");
	public bool Started => SAD != null;
	public bool Finishhed => FAD != null;

}