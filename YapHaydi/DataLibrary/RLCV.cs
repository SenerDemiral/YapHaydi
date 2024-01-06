namespace YapHaydi.DataLibrary;

public class RLCV
{
    public int FrmId { get; set; } = 0;
    public int UsrId { get; set; } = 0;
    public string Ad { get; set; } = string.Empty;
    public string? UsrTkn { get; set; }
    public int UEXId { get; set; }
	public bool Ytk1 { get; set; }
	public bool Ytk2 { get; set; }
	public bool Ytk3 { get; set; }

	public void SetVal(int usrId, string usrName)
    {
        UsrId = usrId;
        Ad = usrName;
    }
}

public class DDD
{
    public string usrId { get; set; }
}

