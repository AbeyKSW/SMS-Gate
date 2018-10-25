using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Office.Interop;
using System.Data.OleDb;

namespace SMS_Gate_Windows
{
    public partial class SMSGate : Form
    {
        ArrayList itmList = new ArrayList();
        ArrayList contactList = new ArrayList();
        string con = SMSEngine.GetDBConnection();
        int divCode = 0;
        string dt = "";

        public SMSGate()
        {
            InitializeComponent();

            //loadPorts();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            contactList.Clear();

            foreach (object itemChecked in chkContactLst.CheckedItems)
            { contactList.Add(itemChecked); }

            if (contactList.Count > 0)
            {
                prBar.Maximum = contactList.Count;
                SMSEngine sms = new SMSEngine("COM8"); //cmbPort.Text
                sms.Open();

                for (int k = 0; k < contactList.Count; k++)
                {
                    string number = "0" + contactList[k].ToString();
                    sms.sendSMS(number, txtMessage.Text);
                    chkContactLst.SetItemChecked(k, false);
                    k = k + 1;
                    prBar.Value = k;
                    k = k - 1;
                }

                sms.Close();
                MessageBox.Show("Message Sent!");

                //if (MessageBox.Show("Do you want to Save?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                //{

                //}
            }
        }

        private void loadPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                //cmbPort.Items.Add(port);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //int divCode = int.Parse(cmbDivCode.SelectedItem.ToString());
            DataTable contactDT = new DataTable();

            string sqlData = "SELECT ContactName, Number FROM [Sheet1$] WHERE DivCode = " + divCode + " AND ContactType IN (";

            itmList.Clear();

            foreach (object itemChecked in chkGrpSelect.CheckedItems)
            {
                itmList.Add(itemChecked);
            }

            for (int k = 0; k < itmList.Count; k++)
            {
                string mgrName = itmList[k].ToString();

                if (k == 0 && itmList.Count >= 1)
                { sqlData = sqlData + "'" + mgrName + "'"; }
                else
                { sqlData = sqlData + ", '" + mgrName + "'"; }
            }

            sqlData = sqlData + ")";


            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(sqlData, connection);

                using (OleDbDataAdapter da = new OleDbDataAdapter())
                {
                    da.SelectCommand = command;
                    da.Fill(contactDT);
                }
            }

            int contactNo = 0;
            string contactName = "";

            chkContactLst.Items.Clear();
            for (int k = 0; k < contactDT.Rows.Count; k++)
            {
                contactNo = int.Parse(contactDT.Rows[k]["Number"].ToString());
                contactName = contactDT.Rows[k]["ContactName"].ToString();
                chkContactLst.Items.Add(contactNo);
                //chkContactLst.Items.Add(contactName);
                chkContactLst.SetItemChecked(k, true);
            }

            btnSend.Enabled = true;
            btnSelectDeSelect.Enabled = true;
        }

        private void cmbDivCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDivCode.SelectedItem.ToString() == "15 Consumer")
            { divCode = 15; }
            else if (cmbDivCode.SelectedItem.ToString() == "16 Backery")
            { divCode = 16; }
            else if (cmbDivCode.SelectedItem.ToString() == "17 Hardware")
            { divCode = 17; }
            else if (cmbDivCode.SelectedItem.ToString() == "18 Pharma")
            { divCode = 18; }
            else if (cmbDivCode.SelectedItem.ToString() == "19 Confactionary")
            { divCode = 19; }

            dtDate.Value = DateTime.Now;
            txtMessage.Clear();
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            string txt = "";
            dt = dtDate.Value.ToShortDateString();

            if (divCode == 15)
            { txt = "Consumer"; }
            else if (divCode == 16)
            { txt = "Backery"; }
            else if (divCode == 17)
            { txt = "Hardware"; }
            else if (divCode == 18)
            { txt = "Pharma"; }
            else if (divCode == 19)
            { txt = "Confactionary"; }

            txtMessage.Text = "DBCL IT --- Please Download the " + txt + "  Performance for the date of '" + dt + "'";
        }

        private void btnSelectDeSelect_Click(object sender, EventArgs e)
        {
            int checkedC = chkContactLst.CheckedItems.Count;
            int itemC = chkContactLst.Items.Count;

            if (itemC == checkedC)
            {
                for (int k = 0; k < itemC; k++)
                {
                    if (chkContactLst.GetItemCheckState(k) != CheckState.Checked)
                    {
                        chkContactLst.SetItemChecked(k, true);
                    }
                    else
                    {
                        chkContactLst.SetItemChecked(k, false);
                    }
                }
            }
            else if (itemC > checkedC)
            {
                for (int k = 0; k < itemC; k++)
                {
                    if (chkContactLst.GetItemCheckState(k) != CheckState.Checked)
                    {
                        chkContactLst.SetItemChecked(k, true);
                    }
                }
            }
        }
    }
}
