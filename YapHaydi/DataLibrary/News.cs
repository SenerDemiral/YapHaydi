namespace YapHaydi.DataLibrary;

public interface INews
{
    event Action<NewsMdl>? OnChange;
    void NotifyChanged(NewsMdl news);
}

public class News : INews
{
    public event Action<NewsMdl>? OnChange;

    public void NotifyChanged(NewsMdl news)
    {
        OnChange?.Invoke(news);
    }
}

public class NewsMdl
{
	public int FrmId { get; set; }
	public int YpnId { get; set; }
	public int RqsId { get; set; }

}