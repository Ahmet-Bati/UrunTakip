using Npgsql;

namespace UrunTakip.Services
{
    public static class DolarService
    {
        private static string _hedefString = BaglantiInfo.PostConnectionString;
        public static decimal GuncelKurGetir()
        {
            decimal dolar = 0;
            NpgsqlConnection postcon = new NpgsqlConnection(_hedefString);
            postcon.Open();
            string sorgu = $"SELECT dolar  FROM doviz  ORDER BY id DESC limit 1";
            NpgsqlCommand cmd = new NpgsqlCommand(sorgu, postcon);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dolar = reader.GetDecimal(0);
                }
            }
            postcon.Close();
            return dolar;
        }
        public static bool VeriVarMı()
        {
            var hasData = false;
            NpgsqlConnection postcon = new NpgsqlConnection(_hedefString);
            postcon.Open();
            string sorgu = $"SELECT dolar  FROM doviz";
            NpgsqlCommand cmd = new NpgsqlCommand(sorgu, postcon);
            using (var reader = cmd.ExecuteReader())
            {
                hasData = reader.Read();



            }
            postcon.Close();
            return hasData;
        }
    }
}
