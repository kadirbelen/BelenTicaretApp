using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelenTicaretApp
{
    class BekoDal
    {
        
        
        public void Add(Beko beko)
        {
            //SqlConnection conn = new SqlConnection(connString);
            //conn.Open();
            //command.Connection = conn;
            //command.ExecuteNonQuery();

            //command.Dispose();
            //conn.Dispose();
            //conn.Close();


            SqlCommand command = new SqlCommand("INSERT INTO Beko (Urunler,Fiyat,Miktar) VALUES (@Urunler,@Fiyat,@Miktar)");
          
            command.Parameters.AddWithValue("Urunler", beko.Urunler);
            command.Parameters.AddWithValue("Fiyat", beko.Fiyat);
            command.Parameters.AddWithValue("Miktar", beko.Miktar);

            VTYS.SqlExecuteNonQuery(command);
            
        }
        public List<Beko> GetAll()
        {
            var bekoList = new List<Beko>();
            SqlCommand command = new SqlCommand("Select*From Beko");
            SqlDataReader reader = VTYS.SqlExecuteReader(command);
            while (reader.Read())
            {
                Beko beko = new Beko()
                {
                    Id = Convert.ToInt32(reader[0]),
                    Urunler = reader[1].ToString(),
                    Fiyat=Convert.ToInt32(reader[2]),
                    Miktar=Convert.ToInt32(reader[3])
                };
                bekoList.Add(beko);
            }
            return bekoList;
        }
        public void Update(Beko beko)
        {
            SqlCommand command = new SqlCommand("Update Beko set Urunler=@Urunler, Fiyat=@Fiyat, Miktar=@Miktar WHERE Id=@Id");
            command.Parameters.AddWithValue("Id", beko.Id);
            command.Parameters.AddWithValue("Urunler", beko.Urunler);
            command.Parameters.AddWithValue("Fiyat", beko.Fiyat);
            command.Parameters.AddWithValue("Miktar", beko.Miktar);

            VTYS.SqlExecuteNonQuery(command);
        }
        
        

    }
}
