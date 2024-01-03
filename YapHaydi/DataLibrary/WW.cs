namespace YapHaydi.DataLibrary;

public class WW
{
    public int WWID;

    public int? SbjID;

    public int? rWhoID;
    public string? rInf;

    public int? mDptID;
    public int? mWhoID;

    public int? sCntID;
    public int? sAdrID;
    public string? sInf;
    public DateTime? SED;
    public DateTime? SEDt;
    public DateTime? SAD;

    public int? fCntID;
    public int? fAdrID;
    public string? fInf;
    public DateTime? FED;
    public DateTime? FEDt;
    public DateTime? FAD;

    public int? dCntID;
    public int? dAdrID;
    public string? dInf;

    public int? InsID;
    public string? InsTS;
    public int? UpdID;
    public string? UpdTS;

    public string? Sbj;
    public string? rWho;
    public string? mDpt;
    public string? mWho;
    public string? sCnt;
    public string? sAdr;
    public string? sAdres;
    public string? fCnt;
    public string? fAdr;
    public string? fAdres;
    public string? dCnt;
    public string? dAdr;

    public string? SEDfs => SED?.ToString("dd.MM.yy HH:mm");
    public string? SADfs => SAD?.ToString("dd.MM.yy HH:mm");
    public string? FEDfs => FED?.ToString("dd.MM.yy HH:mm");
    public string? FADfs => FAD?.ToString("dd.MM.yy HH:mm");
    public string? SEDfm => Utils.Moment(SED);
    public string? FEDfm => Utils.Moment(FED);
	public bool Started => SAD != null;
    public bool Finishhed => FAD != null;


    public WW ShallowCopy()
    {
        return (WW)this.MemberwiseClone();
    }
}
