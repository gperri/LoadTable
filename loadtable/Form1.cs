using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Teradata.Client.Provider;
using System.Diagnostics;

namespace loadtable
{
    public partial class Form1 : Form
    {
        private  char SEPARATOR = ';';
        private string host { get; set; }
        private string uid { get; set; }
        private string pwd { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Teradata.Client.Provider.TdConnection mainConn = new Teradata.Client.Provider.TdConnection();
            TdConnectionStringBuilder stringBuilder = new TdConnectionStringBuilder();
            stringBuilder.CommandTimeout = 300;
            stringBuilder.ConnectionTimeout = 100;
            stringBuilder.DataSource = host;
            stringBuilder.UserId = uid;
            stringBuilder.Password = pwd;
            mainConn.ConnectionString = stringBuilder.ConnectionString;
            this.Text = host;
            mainConn.Open();


            StreamReader gperead =new StreamReader(@txtFile.Text);
            string szLine="";
            string[] szFields;
            string[] szHeader;
      
            szLine = gperead.ReadLine();
            szLine = szLine.Replace("\"", "");
            szHeader = szLine.Split(SEPARATOR);
            Teradata.Client.Provider.TdCommand gpeCmd = new Teradata.Client.Provider.TdCommand("SELECT * FROM " + cboDatabaseList.Text + "." + cboTables.Text, mainConn);
            gpeCmd.CommandTimeout = 10000;

            int counter = 0;

            Teradata.Client.Provider.TdDataAdapter gpeAdapter = new Teradata.Client.Provider.TdDataAdapter(gpeCmd);
            gpeAdapter.UpdateBatchSize = 50000;
            
            gpeAdapter.KeepCommandBatchSequence = false;
            Teradata.Client.Provider.TdCommandBuilder cb = new Teradata.Client.Provider.TdCommandBuilder(gpeAdapter);
            DataTable dt = new DataTable();
            gpeAdapter.Fill(dt);

            int iNonBlockingErrors = 0;
            while ((szLine = gperead.ReadLine()) != null) {
                szFields = szLine.Replace("\"", "").Split(SEPARATOR);

                DataRow dr = dt.NewRow();
                

                if(szFields.GetUpperBound(0)==szHeader.GetUpperBound(0)) {
                    for (int i = 0; i < szHeader.GetLength(0); i++) {
                        if (szFields[i] == "?")
                            dr[szHeader[i]] = DBNull.Value;
                        else if (dr.Table.Columns[szHeader[i]].DataType == typeof(DateTime))
                            try {
                                dr[szHeader[i]] = Convert.ToDateTime(szFields[i].Trim('\"'));
                            }
                            catch (Exception ex) {
                                dr[szHeader[i]] = DBNull.Value;
                                iNonBlockingErrors++;
                            }
                        else if (dr.Table.Columns[szHeader[i]].DataType == typeof(double))
                            dr[szHeader[i]] = Convert.ToDecimal(szFields[i].Trim('\"').Replace('.', ','));
                        else
                            try {
                                dr[szHeader[i]] = szFields[i].Trim('\"');
                            }
                            catch (Exception ex) {
                                dr[szHeader[i]] = DBNull.Value;
                                iNonBlockingErrors++;
                            }
                    }

                    dt.Rows.Add(dr);
                }



                if ((counter++ % 50000) == 0) {
                    try {
                        gpeAdapter.Update(dt);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(this, ex.Message);
                    }
                    
                    textBox1.Text = (counter-1).ToString("###,###");
                }

                Application.DoEvents();
            }

            gpeAdapter.Update(dt);
            textBox1.Text = counter.ToString("###,###");

            dt.Dispose();
            gpeCmd.Dispose();
            mainConn.Close();
            mainConn.Dispose();
            gperead.Close();
            sw.Stop();
            MessageBox.Show("Done!\n" + sw.Elapsed + "\nErrors: " + iNonBlockingErrors.ToString("###,###"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDiag = new OpenFileDialog();

            DialogResult result = myDiag.ShowDialog();

            if (result != DialogResult.Cancel) {
                txtFile.Text = myDiag.FileName;
            }
            myDiag.Dispose();
        }

        private void populateComboes()
        {
            TdConnectionStringBuilder stringBuilder = new TdConnectionStringBuilder();
            stringBuilder.CommandTimeout = 300;
            stringBuilder.ConnectionTimeout = 100;
            stringBuilder.DataSource = host;
            stringBuilder.UserId = uid;
            stringBuilder.Password = pwd;

            using (TdConnection dbConnection = new TdConnection(stringBuilder.ConnectionString )) {
                dbConnection.Open();
                TdDataAdapter adapter = new TdDataAdapter();
                DataTable dt = new DataTable();
                TdCommand myCommand = new TdCommand("select databasename from dbc.databases", dbConnection);
                TdDataReader myReader = myCommand.ExecuteReader();
                
                while (myReader.Read()) {
                    cboDatabaseList.Items.Add(myReader[0].ToString().Trim());
                }


                myReader.Close();
                myCommand.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog(this);
            if (fLogin.fCancel)
                Application.Exit();
            else {
                host = fLogin.strHost;
                uid = fLogin.strUID;
                pwd = fLogin.strPWD;
                populateComboes();
            }
            fLogin.Dispose();
            txtSeparator.Text  = SEPARATOR.ToString();
        }

        private void cboDatabaseList_TextChanged(object sender, EventArgs e)
        {
            TdConnectionStringBuilder stringBuilder = new TdConnectionStringBuilder();
            stringBuilder.CommandTimeout = 300;
            stringBuilder.ConnectionTimeout = 100;
            stringBuilder.DataSource = host;
            stringBuilder.UserId = uid;
            stringBuilder.Password = pwd;

            using (TdConnection dbConnection = new TdConnection(stringBuilder.ConnectionString)) {
                dbConnection.Open();
                TdDataAdapter adapter = new TdDataAdapter();
                DataTable dt = new DataTable();
                TdCommand myCommand = new TdCommand("select tablename from dbc.TablesVX where databasename='" + cboDatabaseList.Text + "'", dbConnection);
                TdDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read()) {
                    cboTables.Items.Add(myReader[0].ToString().Trim());
                }


                myReader.Close();
                myCommand.Dispose();
            }
        }


        private void cmdKo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addColumns(string[] headers)
        {
            dgvPreview.Columns.Clear();
            for (int count = headers.GetLowerBound(0); count < headers.GetLength(0); count++)
                dgvPreview.Columns.Add(headers[count].ToString(), headers[count].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPreview.Rows.Clear();
            using (FileStream file = new FileStream(txtFile.Text , FileMode.Open, FileAccess.Read, FileShare.Read, 4096)) {
                using (StreamReader reader = new StreamReader(file)) {
                    string [] headerLine= reader.ReadLine().Replace("\"","").Split(SEPARATOR);
                    addColumns(headerLine);
                    while (!reader.EndOfStream) {
                        var fields = reader.ReadLine().Replace("\"", "").Split(SEPARATOR);
                        dgvPreview.Rows.Add(fields);
                    }
                }
            }
        }
    }
}
