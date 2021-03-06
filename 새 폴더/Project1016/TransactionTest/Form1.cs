﻿using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter adapter = null;
        DataSet ds = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet("emp");
           // string conStr = "Privider=MSDAORA; data source =topcredu;User ID=scott;Password=tiger";
            
                        string conStr = @"Data source= (DESCRIPTION =
                (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                (CONNECT_DATA =
                  (SERVER = DEDICATED)
                  (SERVICE_NAME = topcredu)
                )
              ); User Id=scott; Password=tiger ; Provider=OraOleDB.Oracle";
              
            using (OleDbConnection connection = new OleDbConnection(conStr))
            {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction tr = null;

                try
                {
                    connection.Open();
                    tr = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = tr;

                    command.CommandText = "insert into emp(empno, ename)" + "Values(9000,'서니니길동')";
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(i + "건 Inserted!");

                    command.CommandText = "insert into emp(empno,ename)" + "values(7911,'서니길동')";
                    i = command.ExecuteNonQuery();
                    tr.Commit();

                    adapter = new OleDbDataAdapter("select * from emp", connection);
                    adapter.Fill(ds, "EMP");
                    dataGridView1.DataSource = ds.Tables["EMP"];

                    adapter.Fill(ds, "EMP");
                }
                catch(Exception ex)
                {
                    tr?.Rollback();
                    MessageBox.Show(ex.Message, "emp Table Loading Error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
