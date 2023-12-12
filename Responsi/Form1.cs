using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            try
            {
                conn.Open();
                string sql = "SELECT id_dep, name_dep FROM departemen";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbDep.DataSource = dt;
                cbDep.DisplayMember = "name_dep";
                cbDep.ValueMember = "id_dep";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAILL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM kry_select()";
                dgv.DataSource = null;
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgv.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAILL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgv.DataSource = null;

                string sql = "SELECT * FROM kry_insert(:_name, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", tbName.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.SelectedValue);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasi diinputkan!! ", "WELL DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbName.Text = cbDep.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAILL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon Pilih baris data yang akan diupdate!! ", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();

                string sql = @"SELECT * FROM kry_update(:_id_karyawan, :_name, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", tbName.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.SelectedValue);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasi diupdate!! ", "WELL DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbName.Text = cbDep.Text = null;
                    r = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update FAILL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv.Rows[e.RowIndex];
                tbName.Text = r.Cells["_name"].Value.ToString();
                cbDep.Text = r.Cells["_name_dep"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon Pilih baris data yang akan didelete!! ", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Apakah Benar Anda ingin mneghapus data" + r.Cells["_name"].Value.ToString() + " ?", "Hapus Data Terkonfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT * FROM kry_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users Berhasi didelete!!", "WELL DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoad.PerformClick();
                        tbName.Text = cbDep.Text = null;
                        r = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete FAILL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
