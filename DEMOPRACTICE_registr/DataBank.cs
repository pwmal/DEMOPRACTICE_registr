﻿using Npgsql;
using System.Data;

namespace DEMOPRACTICE_registr
{
    public class DataBank
    {
        public static string user_login = "";
        public static string user_role = "";
        public static int wrong_counter = 1;
        public static string password_symb = "~!@\"#№$;%:^?&*()-_=\\.,/|<>`+";
        public static string password_str_uppercase = "QWERTYUIOPLKJHGFDSAZXCVBNM";
        public static string password_str_lowercase = "qwertyuioplkjhgfdsazxcvbnm";
        public static DataSet ds;
        public static DataTable dt;
        public static NpgsqlConnection connString = new NpgsqlConnection("Host=localhost;Port=5432;Database=system_reg;Username=postgres;Password=1234");

        public static void SQLtoDB(string sql)
        {
            DataBank.connString.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql, connString);
            NpgsqlDataAdapter dataAd = new NpgsqlDataAdapter(sql, connString);
            DataBank.ds = new DataSet();
            DataBank.ds.Reset();
            dataAd.Fill(ds);
            DataBank.dt = ds.Tables[0];
            connString.Close();
        }

        public static void SQLtoDBwithChanges(string sql)
        {
            connString.Open();
            NpgsqlCommand comm = new NpgsqlCommand(sql, connString);
            comm.ExecuteNonQuery();
            connString.Close();
        }

        public static bool strContainsSymb(string str, string symb_str) 
        {
            for (int i = 0; i < symb_str.Length; i++)
            {
                if (str.Contains(symb_str[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}