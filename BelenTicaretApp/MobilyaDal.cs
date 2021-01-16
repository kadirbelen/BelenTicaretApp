using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelenTicaretApp
{
    public class MobilyaDal
    {
        public void Add(Mobilya mobilya)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Mobilya (Urunler,Fiyat,Miktar) VALUES (@Urunler,@Fiyat,@Miktar)");

            command.Parameters.AddWithValue("Urunler", mobilya.Urunler);
            command.Parameters.AddWithValue("Fiyat", mobilya.Fiyat);
            command.Parameters.AddWithValue("Miktar", mobilya.Miktar);

            VTYS.SqlExecuteNonQuery(command);
        }
        public List<Mobilya> GetAll()
        {
            var mobilyaList = new List<Mobilya>();
            SqlCommand command = new SqlCommand("SELECT*FROM Mobilya");
            SqlDataReader reader = VTYS.SqlExecuteReader(command);

            while (reader.Read())
            {
                Mobilya mobilya = new Mobilya()
                {
                    Id = Convert.ToInt32(reader[0]),
                    Urunler = reader[1].ToString(),
                    Fiyat = Convert.ToInt32(reader[2]),
                    Miktar = Convert.ToInt32(reader[3])
                };
                mobilyaList.Add(mobilya);
            }
            return mobilyaList;
        }
        public void Update(Mobilya mobilya)
        {
            SqlCommand command = new SqlCommand("Update Mobilya set Urunler=@Urunler, Fiyat=@Fiyat, Miktar=@Miktar WHERE Id=@Id");
            command.Parameters.AddWithValue("Id", mobilya.Id);
            command.Parameters.AddWithValue("Urunler", mobilya.Urunler);
            command.Parameters.AddWithValue("Fiyat", mobilya.Fiyat);
            command.Parameters.AddWithValue("Miktar", mobilya.Miktar);

            VTYS.SqlExecuteNonQuery(command);
        }
    }
}
