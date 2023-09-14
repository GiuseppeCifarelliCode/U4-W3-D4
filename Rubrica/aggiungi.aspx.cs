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
    public partial class aggiungi : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

protected void aggiungiContatto_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if(fileFoto.HasFile)
            {
                fileName = fileFoto.FileName;
                fileFoto.SaveAs(Server.MapPath($"/Content/assets/{fileFoto.FileName}"));
            }

            string connectionString = ConfigurationManager.ConnectionStrings["RubricaDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Persone VALUES(@nome,@cognome,@indirizzo,@telefono,@email,@foto)";
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("cognome", txtCognome.Text);
                cmd.Parameters.AddWithValue("indirizzo", txtIndirizzo.Text);
                cmd.Parameters.AddWithValue("telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("foto", fileName);

                int insRiuscito = cmd.ExecuteNonQuery();
                if (insRiuscito != 0)
                {
                    Response.Redirect("default.aspx");
                }

            }
            catch (Exception ex) {
                Response.Write(ex);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}