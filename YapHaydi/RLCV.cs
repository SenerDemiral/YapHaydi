namespace YapHaydi;

public class RLCV
{
	public int FrmId { get; set; } = 0;
	public int UsrId { get; set; } = 0;
	public string UsrNme { get; set; } = string.Empty;
	public string? UsrTkn { get; set; }
	public int UEXId { get; set; }
	public void SetVal(int usrId, string usrName)
	{
		this.UsrId = usrId;
		this.UsrNme = usrName;
	}
}

public class DDD
{
	public string usrId { get; set; }
}

