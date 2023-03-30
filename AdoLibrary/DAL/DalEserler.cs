using AdoLibrary.Models;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace AdoLibrary.DAL
{
    public class DalEserler
    {
        public static  int EserEkle(EntityEserler parametre)
        {

            SqlCommand cmd =
            new SqlCommand("insert into ESERLER (name,category,writer,publishdate) values (@P1,@P2,@P3,@P4)", Connection.con);

            if (cmd.Connection.State != ConnectionState.Open)
            {

                cmd.Connection.Open();

            }

            cmd.Parameters.AddWithValue("@P1", parametre.name);
            cmd.Parameters.AddWithValue("@P2", parametre.category);
            cmd.Parameters.AddWithValue("@P3", parametre.writer);
            cmd.Parameters.AddWithValue("@P4", parametre.publishdate);

            return cmd.ExecuteNonQuery();

        }

        public static List<EntityEserler> EserListesi()
        {
            List<EntityEserler> eserler = new List<EntityEserler>();
            SqlCommand cmd = new SqlCommand("select * from ESERLER", Connection.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                EntityEserler x = new EntityEserler();
                x.id = int.Parse(dr[0].ToString());
                x.name = dr[1].ToString();
                x.category = int.Parse(dr[2].ToString());
                x.writer = int.Parse(dr[3].ToString());
                x.publishdate = int.Parse(dr[4].ToString());
                eserler.Add(x);

            }

            dr.Close();
            return eserler.ToList();

        }

       
        public static EntityEserler EserSilme(int id)
        {

            EntityEserler eserler = new EntityEserler();
            SqlCommand cmd = new SqlCommand("select * from ESERLER where id = @P1", Connection.con);
            cmd.Parameters.AddWithValue("@P1", id);

            if (Connection.con.State != ConnectionState.Open)
            {
                Connection.con.Open();
            }


            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                eserler.id = int.Parse(dr[0].ToString());
                eserler.name = dr[1].ToString();
                eserler.category = int.Parse(dr[2].ToString());
                eserler.writer = int.Parse(dr[3].ToString());
                eserler.publishdate = int.Parse(dr[4].ToString());

            }
            dr.Close();
            return eserler;

        }


   
        public static int EserSil(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from ESERLER where id = @P1", Connection.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", id);
            return cmd.ExecuteNonQuery();

        }

        public static EntityEserler EserGüncelle(int id)
        {

            EntityEserler eserler = new EntityEserler();
            SqlCommand cmd = new SqlCommand("select * from ESERLER where id = @P1" , Connection.con);
            cmd.Parameters.AddWithValue("@P1", id);

            if (Connection.con.State != ConnectionState.Open)
            {
                Connection.con.Open();
            }


            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                eserler.id = int.Parse(dr[0].ToString());
                eserler.name = dr[1].ToString();
                eserler.category = int.Parse(dr[2].ToString());
                eserler.writer = int.Parse(dr[3].ToString());
                eserler.publishdate = int.Parse(dr[4].ToString());

            }
            dr.Close();
            return eserler;
        }


        public static int EserGüncelle(EntityEserler paramere)
        {

            string query = "update ESERLER set name = @P1,category=@P2,writer=@P3,publishdate =@P4 Where id = @P5";

            SqlCommand cmd = new SqlCommand(query, Connection.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", paramere.name);
            cmd.Parameters.AddWithValue("@P2", paramere.category);
            cmd.Parameters.AddWithValue("@P3", paramere.writer);
            cmd.Parameters.AddWithValue("@P4", paramere.publishdate);
            cmd.Parameters.AddWithValue("@P5", paramere.id);
            return cmd.ExecuteNonQuery();
        }
    }
}
