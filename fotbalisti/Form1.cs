using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fotbalisti
{
    public partial class Form1 : Form
    {

        private SqlConnection connection;
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=fotbalisti;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

            connection = new SqlConnection(connectionString);

            RoundedButton sendBtn = new RoundedButton(30, System.Drawing.Color.Yellow, System.Drawing.Color.Blue, 6);
            sendBtn.Text = "Odeslat";
            sendBtn.Location = new System.Drawing.Point(611, 269);
            sendBtn.Size = new System.Drawing.Size(170, 45);
            sendBtn.ForeColor = System.Drawing.Color.Blue;
            Controls.Add(sendBtn);


            RoundedButton showTeamBtn = new RoundedButton(30, System.Drawing.Color.Yellow, System.Drawing.Color.Blue, 6);
            showTeamBtn.Text = "Zobrazit tým";
            showTeamBtn.Location = new System.Drawing.Point(611, 350);
            showTeamBtn.Size = new System.Drawing.Size(170, 45);
            showTeamBtn.ForeColor = System.Drawing.Color.Blue;
            Controls.Add(showTeamBtn);

            RoundedButton resetBtn = new RoundedButton(30, System.Drawing.Color.Yellow, System.Drawing.Color.Blue, 6);
            resetBtn.Text = "Reset";
            resetBtn.Location = new System.Drawing.Point(611, 431);
            resetBtn.Size = new System.Drawing.Size(170, 45);
            resetBtn.ForeColor = System.Drawing.Color.Blue;
            Controls.Add(resetBtn);

            tbName.Click += tbName_Click;
            tbSurname.Click += tbSurname_Click;
            tbDressNum.Click += tbDressNum_Click;
            tbGoals.Click += tbGoals_Click;

            sendBtn.Click += sendBtn_Click;
            showTeamBtn.Click += showTeamBtn_Click;
            resetBtn.Click += resetBtn_Click;

        }

        private void showTeamBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string jmeno = tbName.Text;
                string prijmeni = tbSurname.Text;
                int cisloDresu = Convert.ToInt32(tbDressNum.Text);
                int goly = Convert.ToInt32(tbGoals.Text);
                string pozice = cbPosition.SelectedItem.ToString();

                string query = "INSERT INTO ml_zaci (jmeno, prijmeni, cisloDresu, goly, pozice) " +
                               "VALUES (@jmeno, @prijmeni, @cisloDresu, @goly, @pozice)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@jmeno", jmeno);
                command.Parameters.AddWithValue("@prijmeni", prijmeni);
                command.Parameters.AddWithValue("@cisloDresu", cisloDresu);
                command.Parameters.AddWithValue("@goly", goly);
                command.Parameters.AddWithValue("@pozice", pozice);

                command.ExecuteNonQuery();

                MessageBox.Show("Data byla úspěšně vložena do databáze!");

                // Vyprázdnění polí
                tbName.Text = "jméno fotbalisty";
                tbSurname.Text = "příjmení fotbalisty";
                tbDressNum.Text = "číslo dresu";
                tbGoals.Text = "nastřílených gólů";
                cbPosition.SelectedIndex = -1; // Vybrání žádné položky v ComboBoxu

            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při vkládání dat do databáze: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM ml_zaci";

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Data byly vyresetovány");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při resetování dat: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbName_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "jméno fotbalisty")
            {
                tbName.Text = "";
            }
        }

        private void tbSurname_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text == "příjmení fotbalisty")
            {
                tbSurname.Text = "";
            }
        }

        private void tbDressNum_Click(object sender, EventArgs e)
        {
            {
                if (tbDressNum.Text == "číslo dresu")
                {
                    tbDressNum.Text = "";
                }
            }
        }
        private void tbGoals_Click(object sender, EventArgs e)
        {
            {
                if (tbGoals.Text == "nastřílených gólů")
                {
                    tbGoals.Text = "";
                }
            }
        }
    }
}

class RoundedButton : System.Windows.Forms.Button
{
    public const int WM_CREATE = 0x0001;
    public const int WM_NCCREATE = 0x0081;
    public const int WM_PAINT = 0x000F;

    private int nRadius = 20;

    public int Radius
    {
        get { return nRadius; }
        set { nRadius = value; }
    }

    private int nBorderSize = 4;

    public int BorderSize
    {
        get { return nBorderSize; }
        set { nBorderSize = value; }
    }

    public RoundedButton(int nRadius = 20, System.Drawing.Color? fillColor = null, System.Drawing.Color? borderColor = null, int borderSize = 4)
    {
        Radius = nRadius;
        FillColor = fillColor ?? System.Drawing.Color.White;
        BorderColor = borderColor ?? System.Drawing.Color.Red;
        BorderSize = borderSize;
    }

    private System.Drawing.Color borderColor = System.Drawing.Color.Red;

    public System.Drawing.Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; }
    }

    private System.Drawing.Color fillColor = System.Drawing.Color.White;

    public System.Drawing.Color FillColor
    {
        get { return fillColor; }
        set { fillColor = value; }
    }

    private System.Drawing.Color oldFillColor;

    protected override void OnMouseEnter(EventArgs e)
    {
        oldFillColor = FillColor;
        FillColor = System.Drawing.SystemColors.ButtonHighlight;
        this.Refresh();
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        FillColor = oldFillColor;
        this.Refresh();
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        this.BackColor = FillColor;
        int nShift = BorderSize;
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == WM_CREATE)
        {
            using (Graphics gr = Graphics.FromHwnd(Handle))
            {
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (System.Drawing.Drawing2D.GraphicsPath gp = CreatePath(new Rectangle(System.Drawing.Point.Empty, base.Size), nRadius, false))
                {
                    gr.FillPath(SystemBrushes.Window, gp);
                    Region region = new Region(gp);
                    base.Region = region;
                }
            }
            m.Result = (IntPtr)1;
        }
        else if (m.Msg == WM_PAINT)
        {
            using (Graphics gr = Graphics.FromHwnd(m.HWnd))
            {
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (System.Drawing.Drawing2D.GraphicsPath gp = CreatePath(new Rectangle(System.Drawing.Point.Empty, base.Size), nRadius, true))
                {
                    System.Drawing.Pen redPen = new System.Drawing.Pen(BorderColor, BorderSize);
                    gr.FillPath(new SolidBrush(FillColor), gp);
                    gr.DrawPath(redPen, gp);
                }

                System.Drawing.Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
                var nWidth = ((this.Width - textSize.Width) / 2);
                var nHeight = ((this.Height - textSize.Height) / 2);
                System.Drawing.Point drawPoint = new System.Drawing.Point(nWidth, nHeight);
                Rectangle normalRect = new Rectangle(drawPoint, textSize);
                TextRenderer.DrawText(gr, this.Text, this.Font, normalRect, ForeColor);
            }
            m.Result = (IntPtr)0;
        }
    }
    public static System.Drawing.Drawing2D.GraphicsPath CreatePath(Rectangle rect, int nRadius, bool bOutline)
    {
        int nShift = bOutline ? 1 : 0;
        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
        path.AddArc(rect.X + nShift, rect.Y, nRadius, nRadius, 180f, 90f);
        path.AddArc((rect.Right - nRadius) - nShift, rect.Y, nRadius, nRadius, 270f, 90f);
        path.AddArc((rect.Right - nRadius) - nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 0f, 90f);
        path.AddArc(rect.X + nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 90f, 90f);
        path.CloseFigure();
        return path;
    }
}