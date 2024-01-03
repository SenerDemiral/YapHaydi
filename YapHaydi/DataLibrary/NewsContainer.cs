namespace YapHaydi.DataLibrary;

public interface INewsContainer
{
    event Action<NewsMdl>? OnChange;
    void NotifyChanged(NewsMdl news);
}

public class NewsContainer : INewsContainer
{
    public event Action<NewsMdl>? OnChange;

    public void NotifyChanged(NewsMdl news)
    {
        OnChange?.Invoke(news);
    }
}
