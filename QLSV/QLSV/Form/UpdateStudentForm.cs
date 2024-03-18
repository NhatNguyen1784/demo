using QLSV.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void btFind_Click(object sender, EventArgs e)
        {
            // tim theo id, phan mo rong se tim theo dien thoai. neu tim theo ten thi se xuat hien 1 form khac list toan bo ket qua trung ten private void buttonFind_Click(object sender, EventArgs e)

            int id = int.Parse(txtStdID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, Iname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtFname.Text = table.Rows[0]["name"].ToString();
                txtLname.Text = table.Rows[0]["name"].ToString();
                dtpkBDate.Value = (DateTime)table.Rows[0]["bdate"];
                // gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                    radFemale.Checked = true;
                else
                    radMale.Checked = true;
                txtPhone.Text = table.Rows[0]["phone"].ToString();
                txtAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                picAvt.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
