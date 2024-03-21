namespace YapHaydi.DataLibrary;

public class AppState
{
    public int FrmId = 0;
    public int UsrId = 0;
	public int UEXId = 0;
    public string Ad = string.Empty;
	public string? UsrTkn = null;
	
	public bool IsFrm = false;
	public bool IsDpt = false;
	public bool IsYpn = false;

	public string rngFld = "INSTS";
	public DateTime rngGE = DateTime.Today.AddDays(-15);
	public DateTime rngLT = DateTime.Today.AddDays(1);

	public string fltFld = "";
	public string fltCnd = "containing";
	public string fltVal = "";

	public string ordFld = "FAD";
	public string ordVal = "desc";
}
