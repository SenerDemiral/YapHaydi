using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace YapHaydi.DataLibrary;

public interface IDbCon
{
    IDbConnection GetConnection();
}

public class DbCon : IDbCon
{
    private string? conStr;

    public DbCon(IConfiguration config)
    {
        conStr = config.GetConnectionString("Default");
        FbConnectionStringBuilder csb = new FbConnectionStringBuilder(conStr);
        csb.PacketSize = 16384;
        csb.ClientLibrary = "fbclient.dll"; //Default: fbembed
        conStr = csb.ConnectionString;
    }

    public IDbConnection GetConnection()
    {
        return new FbConnection(conStr);
    }

}
