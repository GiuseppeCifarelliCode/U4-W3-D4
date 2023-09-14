using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rubrica
{
    public partial class detail : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RubricaDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Persone WHERE idPersona = @id", conn);
            cmd.Parameters.AddWithValue("id", Request.QueryString["idPersona"]);
            id = Request.QueryString["idPersona"];
            SqlDataReader sqlDataReader;

            conn.Open();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read()) {
                string nome = sqlDataReader["Nome"].ToString();
                string cognome = sqlDataReader["Cognome"].ToString();
                string indirizzo = sqlDataReader["Indirizzo"].ToString();
                string telefono = sqlDataReader["Telefono"].ToString();
                string email = sqlDataReader["Email"].ToString();
                string foto = sqlDataReader["Foto"].ToString();
                
                avatar.ImageUrl = $"Content/assets/{foto}";
                headerName.InnerText = cognome + nome;
                pIndirizzo.InnerText = indirizzo ;
                pTelefono.InnerText = telefono ;
                pEmail.InnerText = email ;

            }

            conn.Close();

        }

        protected void eliminaButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RubricaDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("DELETE FROM Persone WHERE idPersona = @id", conn);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("id", Request.QueryString["idPersona"]);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close() ;
            Response.Redirect("default.aspx");


        }

        protected void modificaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect($"modifica.aspx?idPersona={id}");
        }
    }
}