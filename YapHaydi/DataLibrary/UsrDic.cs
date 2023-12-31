using System.Collections.Concurrent;

namespace YapHaydi.DataLibrary;

public sealed class UsrDic : IUsrDic
{
    // DENEME
    private ConcurrentDictionary<string, int> cd = new ConcurrentDictionary<string, int>(4, 101);
    private IDataAccess db;
    public UsrDic(IDataAccess dataAccess)
    {
        db = dataAccess;
    }
    public bool Check(string key)
    {
        if (key == null)
            return false;
        return cd.ContainsKey(key);
    }

    public bool Add(string key, int value = 0)
    {
        if (key != null)
        {
            var usr = db.LoadRec<ULT, dynamic>("select * from ULT_CHECK(@Tkn)", new { Tkn = key });
            if (usr != null)
            {
                if (usr.Id > 0)
                {
                    cd[key] = usr.Id;
                    return true;
                }
                else
                {
                    cd.TryRemove(key, out int _);
                    return false;
                }
            }
        }
        return false;
        //    if (!cd.ContainsKey(key))
        //    {
        //        // db den kaydı bul
        //        // varsa ekle
        //        // yoksa usrTkn temizle
        //        var usr = db.LoadRec<ULT, dynamic>("select * from ULT_CHECK(@Tkn)", new { Tkn = key });

        //        if (usr != null && usr.Id > 0)
        //        {
        //            cd[key] = usr.Id;
        //        }
        //    }
        //    else
        //    {
        //        var usr = db.LoadRec<ULT, dynamic>("select * from ULT_CHECK(@Tkn)", new { Tkn = key });
        //        if (usr != null && usr.Id == -1)
        //        {
        //            cd.Remove(key, out int _);  // Expired
        //        }
        //    }
        //}
    }

    public int Get(string key)
    {
        if (cd.TryGetValue(key, out int result))
            return result;

        return 0;
    }

    public void Remove(string key)
    {
        if (key != null)
            cd.TryRemove(key, out int result);
    }
}

public sealed class ULT
{
    public string Tkn { get; set; }
    public int Id { get; set; }
}
