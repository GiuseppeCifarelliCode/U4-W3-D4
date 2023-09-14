using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rubrica
{
    public partial class modifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RubricaDB"].ToString();
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("SELECT * FROM Persone WHERE idPersona = @id", conn);
                cmd.Parameters.AddWithValue("id", Request.QueryString["idPersona"]);
                SqlDataReader sqlDataReader;

                conn.Open();
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string nome = sqlDataReader["Nome"].ToString();
                    string cognome = sqlDataReader["Cognome"].ToString();
                    string indirizzo = sqlDataReader["Indirizzo"].ToString();
                    string telefono = sqlDataReader["Telefono"].ToString();
                    string email = sqlDataReader["Email"].ToString();
                    string foto = sqlDataReader["Foto"].ToString();

                    Avatar.ImageUrl = $"Content/assets/{foto}";
                    txtCognome.Text = cognome;
                    txtNome.Text = nome;
                    txtIndirizzo.Text = indirizzo;
                    txtTelefono.Text = telefono;
                    txtEmail.Text = email;

                }

                conn.Close();
            }   

        }

        protected void modificaButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RubricaDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Persone SET Nome=@nome, Cognome=@cognome, Indirizzo=@indirizzo, Email=@email, Telefono=@telefono WHERE idPersona=@id";
            cmd.Parameters.AddWithValue("nome", txtNome.Text);
            cmd.Parameters.AddWithValue("cognome", txtCognome.Text);
            cmd.Parameters.AddWithValue("indirizzo", txtIndirizzo.Text);
            cmd.Parameters.AddWithValue("email", txtEmail.Text);
            cmd.Parameters.AddWithValue("telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("id", Request.QueryString["idPersona"]);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("default.aspx");
        }
    }
}