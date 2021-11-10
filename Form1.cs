using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.SQLite;

namespace test_sqlite_net
{
    public partial class Form1 : Form
    {
        private DataTable table;
        private SQLiteDataAdapter dataAdapter;
        private SQLiteCommandBuilder cmdBuilder;
        private SQLiteConnection sqLiteConn;
        private SQLiteCommand sqLiteCmd;
        private String strFmt, connStr;
        private String currDir;

        public Form1()
        {
            InitializeComponent();

            currDir = Directory.GetCurrentDirectory();
            strFmt = "data source=\"" + currDir + "/{0}\""
                    + ";page size=32768;"
                    + "cache size=0;"
                    + "Password=20130321;"
                    + "foreign keys=True;"
                    + "journal mode=Off";

            LoadSQLiteAssembly(currDir + "/System.Data.SQLite.dll");
        }

        private static void LoadSQLiteAssembly(string assemFileName)
        {
            if (File.Exists(assemFileName))
            {
                Assembly.LoadFrom(assemFileName);
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            string strSql_factoryCar = "CREATE TABLE factoryCar(sn INTEGER PRIMARY KEY, name TEXT, acronym TEXT)";

            connStr = string.Format(strFmt, edtDB.Text);
            //
            sqLiteConn = new SQLiteConnection(connStr);
            sqLiteConn.Open();

            sqLiteCmd = new SQLiteCommand(strSql_factoryCar);
            sqLiteCmd.Connection = sqLiteConn;
            
            sqLiteCmd.ExecuteNonQuery();
            sqLiteConn.Close();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string strDataSource = "";
            strDataSource = "Data Source=" + currDir + "/" + edtDB.Text;
            SQLiteConnection cnn = new SQLiteConnection(strDataSource);
            cnn.Open();
            cnn.ChangePassword("20130321");
            cnn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (edtStmt.Text.IndexOf(";") < 0)
            {
                MessageBox.Show("Please enter a SQL statement terminator - ';'");
                return;
            }
            connStr = string.Format(strFmt, edtDB.Text);

            String statementStr = edtStmt.Text.ToLower();

            int iPos = statementStr.LastIndexOf("from") + 5;

            String tblName = statementStr.Substring(iPos, (statementStr.Length - 1) - iPos);

            sqLiteConn = new SQLiteConnection(connStr);

            sqLiteCmd = new SQLiteCommand(edtStmt.Text);
            sqLiteCmd.Connection = sqLiteConn;

            dataAdapter = new SQLiteDataAdapter(sqLiteCmd);
            cmdBuilder = new SQLiteCommandBuilder(dataAdapter);

            table = new DataTable(tblName);
            dataAdapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (edtStmt.Text.ToLower().IndexOf("insert") < 0) return;

            connStr = string.Format(strFmt, edtDB.Text);
            //
            sqLiteConn = new SQLiteConnection(connStr);
            sqLiteConn.Open();

            int i = edtStmt.Lines.Length;
            for (int j = 0; j < i; j++)
            {
                String strSta = edtStmt.Lines[j].ToString();
                sqLiteCmd = new SQLiteCommand(edtStmt.Text);
                sqLiteCmd.Connection = sqLiteConn;
                sqLiteCmd.ExecuteNonQuery();
            }
            MessageBox.Show("Insert Done");

            sqLiteConn.Close();
        }
    }
}
