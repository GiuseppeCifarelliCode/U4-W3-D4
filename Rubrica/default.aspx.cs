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
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RubricaDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Persone", conn);
            SqlDataReader sqlDataReader;

            conn.Open();
            List<Persona> listaContatti = new List<Persona>();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Persona persona = new Persona();
                persona.Id = Convert.ToInt32(sqlDataReader["idPersona"]);
                persona.Nome = sqlDataReader["Nome"].ToString();
                persona.Cognome = sqlDataReader["Cognome"].ToString();
                persona.Indirizzo = sqlDataReader["Indirizzo"].ToString();
                persona.Telefono = sqlDataReader["Telefono"].ToString();
                persona.Email = sqlDataReader["Email"].ToString();
                persona.Foto = sqlDataReader["Foto"].ToString();
                listaContatti.Add(persona);
            }

            Repeater1.DataSource = listaContatti;
            Repeater1.DataBind();

            conn.Close();

        }
    }
}