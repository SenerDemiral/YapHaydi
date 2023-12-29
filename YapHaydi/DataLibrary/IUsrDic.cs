namespace YapHaydi.DataLibrary
{
    public interface IUsrDic
    {
        bool Add(string key, int value = 0);
        bool Check(string key);
        int Get(string key);
        void Remove(string key);
    }
}