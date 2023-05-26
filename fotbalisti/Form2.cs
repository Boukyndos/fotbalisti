using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotbalisti
{
    public partial class Form2 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=fotbalisti;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();

            connection = new SqlConnection(connectionString);

            RoundedButton backBtn = new RoundedButton(30, System.Drawing.Color.Yellow, System.Drawing.Color.Blue, 6);
            backBtn.Text = "Zpět";
            backBtn.Location = new System.Drawing.Point(539, 100);
            backBtn.Size = new System.Drawing.Size(170, 45);
            backBtn.ForeColor = System.Drawing.Color.Blue;
            Controls.Add(backBtn);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void pbField_Click(object sender, EventArgs e)
        {

        }

        private void gk_Click(object sender, EventArgs e)
        {

        }

        private void gk_MouseHover(object sender, EventArgs e)
        {

        }

        private void labelGK_MouseHover(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'brankář'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelGK, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelGK, tooltipText);

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelLB_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'levá obrana'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelLB, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelLB, tooltipText);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelRB_MouseHover(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'pravá obrana'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelRB, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelRB, tooltipText);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelCB_MouseHover(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'stoper'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelCB, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelCB, tooltipText);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelLW_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void labelLW_MouseHover(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'levá záloha'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelLW, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelLW, tooltipText);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelRW_MouseHover(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'pravá záloha'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelRW, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelRW, tooltipText);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelCM_MouseHover(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'střední záloha'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelCM, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelCM, tooltipText);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void labelST_MouseHover(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT jmeno, prijmeni, cisloDresu FROM ml_zaci WHERE pozice = 'útok'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string jmeno = reader["jmeno"].ToString();
                    string prijmeni = reader["prijmeni"].ToString();
                    string cisloDresu = reader["cisloDresu"].ToString();

                    string tooltipText = $"Jméno: {jmeno}\nPříjmení: {prijmeni}\nČíslo dresu: {cisloDresu}";

                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(labelST, tooltipText);
                }
                else
                {
                    ToolTip tooltip = new ToolTip();

                    string tooltipText = "žádné data";

                    tooltip.SetToolTip(labelST, tooltipText);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void backBtn_MouseHover(object sender, EventArgs e)
        {
            backBtn.BackColor = SystemColors.Window;
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Yellow;
        }
    }
}

