﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MyLibrarian.Data;

namespace MyLibrarian.Data
{
    public sealed class ControllerDB
    {
        public enum Table
        {
            Reader, Book, Copy
        }

        private readonly SqlConnection connection;
        private static readonly object padlock = new object();
        private static ControllerDB instance = null;

        public static ControllerDB Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ControllerDB();
                    }
                    return instance;
                }
            }
        }

        //Setup
        private ControllerDB()
        {   
            try
            {
                connection = new SqlConnection(GetConnectionString());
                connection.Open();
            }
            catch (Exception ex)
            {
                // MessageManager.ShowMessageBox(ex);
            }
        }

        private string GetConnectionString()
        {
            return Constants.connectionString;
        }




        //Skaitytojas
        public void InsertToReader(Reader reader)
        {
            string query = "INSERT INTO db_owner.Reader (Name, Surname, Password) VALUES (@name, @surname, @hash)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@name", reader.Name);
            command.Parameters.Add("@surname", reader.Surname);
            command.Parameters.Add("@hash", reader.PasswordHash);

            command.ExecuteNonQuery();

            command.Dispose();
        }

        public DataTable GetDataTable(Table tbl)
        {
            string tableName = Enum.GetName(tbl.GetType(), tbl);
            string query = "SELECT * FROM db_owner." + tableName;

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable GetJoinedDataTable(Table tbl1, Table tbl2, params string[] columns)
        {
            string tableName1 = Enum.GetName(tbl1.GetType(), tbl1);
            string tableName2 = Enum.GetName(tbl2.GetType(), tbl2);
            StringBuilder queryBuilder = new StringBuilder("SELECT ", 255);

            foreach(string col in columns)
            {
                queryBuilder.Append(col);
                if (columns.Last() != col)
                {
                    queryBuilder.Append(", ");
                }
                else
                {
                    queryBuilder.Append(" ");
                }
            }
            queryBuilder.Append("FROM db_owner.");
            queryBuilder.Append(tableName1);
            queryBuilder.AppendFormat(", db_owner.{0}", tableName2);
            string query = queryBuilder.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void DeleteFromReader(int id)
        {
            string query = "DELETE FROM db_owner.Reader WHERE ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", id);
            command.ExecuteNonQuery();

            command.Dispose();
        }

        public bool SearchReader(int id, string password)
        {
            string query = "SELECT * FROM db_owner.Reader WHERE ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", id);

            SqlDataReader reader = command.ExecuteReader();
            Hashing hashing = new Hashing();
            reader.Read();
            if (reader.HasRows)
            {
                string hash = reader.GetString(3);

                if (hashing.Verify(password, hash))
                {
                    reader.Close();
                    command.Dispose();
                    return true;
                }
            }

            reader.Close();
            command.Dispose();
            return false;
        }

        //Knyga
        internal void InsertToBook(Book book)
        {
            string query = "INSERT INTO db_owner.Book (ISBN, Title, Author, Date) " +
                "VALUES (@isbn, @title, @author, @date)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@isbn", book.ISBN);
            command.Parameters.Add("@title", book.Title);
            command.Parameters.Add("@author", book.Author);
            command.Parameters.Add("@date", book.Date);


            command.ExecuteNonQuery();

            command.Dispose();
        }

        internal void DeleteFromBook(string isbn)
        {
            string query = "DELETE FROM db_owner.Book WHERE ISBN = @isbn";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@isbn", isbn);
            command.ExecuteNonQuery();

            command.Dispose();
        }

        public void InsertToCopy(Copy copy)
        {
            string query = "INSERT INTO db_owner.Copy (ID, Reader, ISBN, Borrowed) VALUES (@id, null, @isbn, null)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@id", copy.ID);
            command.Parameters.Add("@isbn", copy.ISBN);

            command.ExecuteNonQuery();

            command.Dispose();
        }

        public void DeleteFromCopy(Int64 id)
        {
            string query = "DELETE FROM db_owner.Copy WHERE ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", id);
            command.ExecuteNonQuery();

            command.Dispose();
        }



        //Close
        public void Close()
        {
            connection.Close();
        }


    }
}
