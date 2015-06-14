using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using VisitorCountApp.DAL.Model;

namespace VisitorCountApp.DAL.Gateway
{
    class VisitorGateway
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connectionDb"].ConnectionString;

        public int SaveVisitor(Visitor aVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO VisitorTBL VALUES('" + aVisitor.Name + "','"+aVisitor.Email+"','"+aVisitor.ContactNumber+"','"+aVisitor.AZon.Id+"')";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Visitor> GetSelectedZoneVisitors(int id)
        {
            List<Visitor> visitorList = new List<Visitor>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM VisitorTBL WHERE ZoneId='"+id+"'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                Visitor aVisitor = new Visitor();
                aVisitor.Name = reader["Name"].ToString();
                aVisitor.Email = reader["Email"].ToString();
                aVisitor.ContactNumber = reader["ContactNumber"].ToString();

                visitorList.Add(aVisitor);
            }
            reader.Close();
            connection.Close();
            return visitorList;
        }
    }
}
