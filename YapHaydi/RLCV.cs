namespace YapHaydi;

public class RLCV
{
    public int usrId {  get; set; }
    public string usrName { get; set; } = string.Empty;
    public void SetVal(int usrId, string usrName)
    {
        this.usrId = usrId;
        this.usrName = usrName;
        
    }
}

public class DDD
{
    public string usrId { get; set; }
}