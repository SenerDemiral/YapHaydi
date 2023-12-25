﻿namespace YapHaydi.DataLibrary;

public interface IDataAccess
{
    Task<T> LoadRecAsync<T, U>(string sql, U parameters);
    T LoadRec<T, U>(string sql, U parameters);
    Task<IEnumerable<T>> LoadDataAsync<T, U>(string sql, U parameters);
    IEnumerable<T> LoadData<T, U>(string sql, U parameters);
    IQueryable<T> LoadDataQ<T, U>(string sql, U parameters);

    T StoreProc<T, U>(string storeProc, U parameters);
    Task<T> StoreProcAsync<T, U>(string storeProc, U parameters);
    //Task<dynamic> StoreProc2<T>(string storeProc, T parameters);
    Task<bool> SaveDataAsync<T>(string sql, T parameters);
    bool SaveRec<T>(string sql, T parameters);

    int GetTablePK(string tblName);
    int CONN_INC_GET(string usrGuid, int usrId);
    int CONN_GIR(string usrGuid, int usrId);
    void CONN_CIK(string usrGuid);

}
