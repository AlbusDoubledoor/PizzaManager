using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    static private byte[] CreateSignature(byte[] data,byte sgnKey)
    {
        byte[] signature = data;
        for(int i = 0; i < data.Length; ++i)
        {
            signature[i] = (byte)(data[i] * sgnKey);
        }
        return signature;
    }
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString EncryptKey(SqlString instance, int type)
    {
        byte[] instanceData = Encoding.UTF8.GetBytes(instance.ToString());
        byte sgnKey = 0;
        switch (type) {
            case 1: { sgnKey = (byte)(instance.ToString().Length + 4); break; }
            case 2: { sgnKey = (byte)(instance.ToString().Length + 3); break; }
    }
        byte[] instanceSignature = CreateSignature(instanceData, sgnKey);
        string result = Convert.ToBase64String(instanceSignature).Replace("=","");
        SqlString sqlresult = new SqlString(result);
        return sqlresult;
    }
}
