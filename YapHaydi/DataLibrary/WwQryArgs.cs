namespace YapHaydi.DataLibrary;

public class WwQryArgs
{
	public int FFId = 101;
	public string rngFld = "FAD";
	public DateTime rngGE = DateTime.Today.AddDays(-15);
	public DateTime rngLT = DateTime.Today.AddDays(1);

	public string fltFld = "mwho";
	public string fltCnd = "containing";
	public string fltVal = "";

	public string ordFld = "FAD";
	public string ordVal = "desc";
}
