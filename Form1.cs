using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

//          Boutissante Issam 
//          TDI 201 Group B

namespace Gestion_Pilote
{
    public partial class Form1 : Form
    {
        static string conString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(conString);
        }

        private void SyncroniserListe_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select pil# as Id,nom,codepostal,ville,dateNaissance from pilote",connection);
                connection.Open();
                reader= command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt16(0), reader.GetSqlString(1), reader.GetSqlString(2),
                        reader.GetSqlString(3), reader.GetSqlDateTime(4));
                }
            }catch(SqlException ex)
            {
                MessageBox.Show("error : "+ex.Message);
            }
            finally
            {
                connection.Close();
                reader.Close();
            }
        }

        private void Consulter_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from pilote where pil#="+Id.Text+";", connection);
                connection.Open();
                reader = command.ExecuteReader();
                if(!reader.Read())
                {
                    MessageBox.Show("aucun pilote avec cet id");
                    return;
                }
                Nom.Text = reader.GetSqlString(1).ToString();
                CodePostal.Text = reader.GetSqlString(2).ToString();
                Ville.Text = reader.GetSqlString(3).ToString();
                DateNaissance.Value =Convert.ToDateTime(reader.GetDateTime(4));
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                connection.Close();
                reader.Close();
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string monCommande= "insert into pilote(nom,codepostal,ville,datenaissance) " +
                    "values('" + Nom.Text +"','" + CodePostal.Text + "','" + Ville.Text + "','" + DateNaissance.Value + "');";
                command = new SqlCommand(monCommande, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("l'insersion a ete effectuee");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            //ce button peut pas supprimer que la dernier ligne de tableau pilote 
            //a cause de le constraint [PK_pilote_1__11] qui a ete cree par le microsoft
            try
            {
                command = new SqlCommand("delete from pilote where pil#="+Id.Text+";", connection);
                connection.Open();
                int numLine = command.ExecuteNonQuery();
                if (numLine == 0)
                {
                    MessageBox.Show("aucun pilote avec cette id");
                    return;
                }
                MessageBox.Show("suprission a ete efectue");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string monCommande = "update pilote set nom='" + Nom.Text + "',codepostal='" +
                CodePostal.Text + "',ville='" + Ville.Text + "',datenaissance='" + DateNaissance.Value + "' where pil#="+Id.Text+";";
            try
            {
                command = new SqlCommand(monCommande, connection);
                connection.Open();
                int numLine = command.ExecuteNonQuery();
                if (numLine == 0)
                {
                    MessageBox.Show("aucun pilote avec cette id");
                    return;
                }
                MessageBox.Show("la modification a ete effectue");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Vider_Click(object sender, EventArgs e)
        {
            Nom.Clear();
            CodePostal.Clear();
            Ville.Clear();
            DateNaissance.Value = DateTime.Now;
        }
    }
}
