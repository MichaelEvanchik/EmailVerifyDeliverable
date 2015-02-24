using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using R1EmailVerifier;
using System.Threading;

namespace WinEmailVerifier
{

    public partial class frmMain : Form
    {
        string suser = "";
        clsEmailVerifier verifyDB;
        clsEmailVerifier verify = new clsEmailVerifier();
        DataSet dsUserSettings;
        DataSet data;
        bool bend = false;
        int iConnectionType = -1;

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmbConnectionStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConnectionString.Text = txtKeyField.Text;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmInput frm = new frmInput(this);
            frm.ShowDialog();



            clsEmailVerifier verifyDB2 = new clsEmailVerifier(); ;
            string sret = "";
            dsUserSettings = new DataSet();
            sret = verifyDB2.DbConnectSourceDB("Data Source=sql2012a;Initial Catalog=EmailVerifier;User Id=sa;Password=Yankeesmets1;", 1);
            try
            {
                dsUserSettings = verifyDB2.DbDataSetDB("select * from last_settings where user_name = '" + lblEmailFieldTo.Text + "'", 1);

                txtKeyField2.Text = dsUserSettings.Tables[0].Rows[0]["id_field"].ToString();
                txtConnectionString.Text = dsUserSettings.Tables[0].Rows[0]["ConnectionString"].ToString();
                iConnectionType = (byte)dsUserSettings.Tables[0].Rows[0]["iConnectionType"];
                txtConnectionString.Text = txtConnectionString.Text.Replace("\\\\","\\");
                txtTableName.Text = dsUserSettings.Tables[0].Rows[0]["table_name"].ToString();
                txtEmailFieldFrom.Text = dsUserSettings.Tables[0].Rows[0]["email_field_name"].ToString();
                txtDns.Text = dsUserSettings.Tables[0].Rows[0]["dns_server"].ToString();
                chkFixTyposMajorISP.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkFixTyposMajorISP"];
                chkFixKnownTyposGeneral.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkFixKnownTyposGeneral"];
                chkDeleteFictitiousDomains.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteFictitiousDomains"];
                chkDeleteSpamTrapDomains.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteSpamTrapDomains"];
                chkDeleteSpamTrapAddresses.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteSpamTrapAddresses"];
                chkDeleteWirelessDomains.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteWirelessDomains"];
                chkDeleteRoleUsernames.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteRoleUsernames"];
                chkFixTypoSuffix.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkFixTypoSuffix"];
                chkDeleteBadFormatedEmails.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteBadFormatedEmails"];
                chkDeleteBadFormatedMajorISP.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteBadFormatedMajorISP"];
                chkDeleteEmailsWithNoMXgeneral.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteEmailsWithNoMXgeneral"];
                chkDeleteEmailifMXcantVerifyMajorISP.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteEmailifMXcantVerifyMajorISP"];
                chkDeleteEmailifMXcantVerifyGeneral.Checked = (bool)dsUserSettings.Tables[0].Rows[0]["chkDeleteEmailifMXcantVerifyGeneral"];
            }
            catch
            {
            }

            verifyDB2.DbClose(1);
        }

        public string LabelText
        {
            get { return lblEmailFieldTo.Text; }
            set { lblEmailFieldTo.Text = value; }
        }

        private void Runit()
        {
            string sConnectionString = "";
            char quotes = '"';

            string sret = "";
            // connect to source
            sConnectionString = txtConnectionString.Text.Substring(txtConnectionString.Text.IndexOf("-") + 2);
            iConnectionType = Convert.ToInt32(txtConnectionString.Text.Substring(0, 1));
            verify.SetSettings(txtKeyField2.Text, sConnectionString, iConnectionType, txtTableName.Text, txtEmailFieldFrom.Text, txtEmailFieldTo.Text, txtReasonID.Text, txtSupressionID.Text, chkFixTyposMajorISP.Checked, chkFixKnownTyposGeneral.Checked, chkDeleteFictitiousDomains.Checked, chkDeleteSpamTrapDomains.Checked, chkDeleteSpamTrapAddresses.Checked, chkDeleteWirelessDomains.Checked, chkDeleteRoleUsernames.Checked, chkFixTypoSuffix.Checked, chkDeleteBadFormatedEmails.Checked, chkDeleteBadFormatedMajorISP.Checked, chkDeleteEmailsWithNoMXgeneral.Checked, chkDeleteEmailifMXcantVerifyMajorISP.Checked, chkDeleteEmailifMXcantVerifyGeneral.Checked,txtDns.Text);
            
            sret = verify.DbConnectSource(sConnectionString,iConnectionType);

                   
            string ssqlmx = "";
            if(iConnectionType == 2)
            {
                ssqlmx = "SELECT DISTINCT " + txtTableName.Text + "." + txtKeyField2.Text + "," + txtTableName.Text + "." + txtEmailFieldTo.Text + " FROM " + txtTableName.Text + " LEFT JOIN dbo_popular_domains ON Mid(" + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "],Instr(" + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "]," + quotes + "@" + quotes + ") +1) = dbo_popular_domains.[domain] WHERE (((dbo_popular_domains.[domain]) Is Null) And ((InStr(" + txtTableName.Text + "." + txtEmailFieldTo.Text + "," + quotes + "yahoo" + quotes + "))=0) And ((InStr(" + txtTableName.Text + "." + txtEmailFieldTo.Text + "," + quotes + "hotmail" + quotes + "))=0) And ((InStr(" + txtTableName.Text + "." + txtEmailFieldTo.Text + "," + quotes + "aol" + quotes + "))=0) And (" + txtTableName.Text + ".reasoncode > 99));";
            }
            else
            {
                ssqlmx = "SELECT DISTINCT " + txtTableName.Text + "." + txtKeyField2.Text + ", " + txtTableName.Text + "." + txtEmailFieldTo.Text + "  FROM " + txtTableName.Text + " LEFT JOIN popular_domains ON substring(" + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "],charindex('@'," + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "]) +1,len(" + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "])) = popular_domains.[domain] WHERE (((popular_domains.[domain]) Is Null) And ((charindex('yahoo'," + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "]))=0) And ((charindex('hotmail'," + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "]))=0) And ((charindex('aol'," + txtTableName.Text + ".[" + txtEmailFieldTo.Text + "]))=0) And (reasoncode > 99))";
            }
                
                //to do
                //update and all the fields for this user back to the db
            if (chkContinue.Checked == true)
            {
                data = verify.DbDataSet("select " + txtKeyField2.Text + "," + txtEmailFieldFrom.Text + " from  " + txtTableName.Text + " where " + txtEmailFieldTo.Text + " is null", iConnectionType);
            }
            else if(chkReRun.Checked == true)
            {
                data = verify.DbDataSet("select " + txtKeyField2.Text + "," + txtEmailFieldFrom.Text + " from  " + txtTableName.Text + " where " + txtEmailFieldTo.Text + " = 'invalid' and len(" + txtEmailFieldFrom.Text + ") > 6", iConnectionType);
            }
            else if (chkMajorIsp.Checked == true)
            {
                data = verify.DbDataSet("select " + txtKeyField2.Text + ",new_email from  " + txtTableName.Text + " where reasoncode >  99 and Mid(new_email,InStr(new_email,'@')+1) = 'gmail.com'", iConnectionType);
            }
            else if (chkMXCheck.Checked == true)
            {
                data = verify.DbDataSet(ssqlmx, iConnectionType);           
            }
            else
            {
                data = verify.DbDataSet("select " + txtKeyField2.Text + "," + txtEmailFieldFrom.Text + " from  " + txtTableName.Text, iConnectionType);
            }
              //  sret = verify.DbConnectSource(sConnectionString, iConnectionType);


                sret = verify.DbConnectSourceDB("Data Source=sql2012a;Initial Catalog=EmailVerifier;User Id=sa;Password=Yankeesmets1;", 1);
                if (chkBoxRestart.Checked == true)
                {
                    sret = verify.DbExecute("update " + txtTableName.Text + " set reasoncode = 0", iConnectionType);
                }

                sret = verify.DbScalarDB("select count(*) from last_settings where user_name = '" + lblEmailFieldTo.Text + "'", 1);
                if (sret == "0")
                {
                    sret = verify.DbExecuteDB("insert into last_settings(user_name,ConnectionString,iConnectionType,id_field,table_name,email_field_name,dns_server,chkFixTyposMajorISP,chkFixKnownTyposGeneral,chkDeleteFictitiousDomains,chkDeleteSpamTrapDomains,chkDeleteSpamTrapAddresses,chkDeleteWirelessDomains,chkDeleteRoleUsernames,chkFixTypoSuffix,chkDeleteBadFormatedEmails,chkDeleteBadFormatedMajorISP,chkDeleteEmailsWithNoMXgeneral,chkDeleteEmailifMXcantVerifyMajorISP,chkDeleteEmailifMXcantVerifyGeneral) values('" + lblEmailFieldTo.Text + "','" + txtConnectionString.Text + "'," + iConnectionType + ",'" + txtKeyField2.Text + "','" + txtTableName.Text + "','" + txtEmailFieldFrom.Text + "','" + txtDns.Text + "',"  + Convert.ToByte(chkFixTyposMajorISP.Checked) + "," + Convert.ToByte(chkFixKnownTyposGeneral.Checked) + "," + Convert.ToByte(chkDeleteFictitiousDomains.Checked) + "," + Convert.ToByte(chkDeleteSpamTrapDomains.Checked) + "," + Convert.ToByte(chkDeleteSpamTrapAddresses.Checked) + "," + Convert.ToByte(chkDeleteWirelessDomains.Checked) + "," + Convert.ToByte(chkDeleteRoleUsernames.Checked) + "," + Convert.ToByte(chkFixTypoSuffix.Checked) + "," + Convert.ToByte(chkDeleteBadFormatedEmails.Checked) + "," + Convert.ToByte(chkDeleteBadFormatedMajorISP.Checked) + "," + Convert.ToByte(chkDeleteEmailsWithNoMXgeneral.Checked) + "," + Convert.ToByte(chkDeleteEmailifMXcantVerifyMajorISP.Checked) + "," + Convert.ToByte(chkDeleteEmailifMXcantVerifyGeneral.Checked) + ")" , 1);
                }
                else if (Convert.ToInt32(sret) > 1)
                {
                    MessageBox.Show("Somehow you have more then one profile, all your profiles under this name are being deleted and this new one is being saved");
                    sret = verify.DbExecuteDB("delete from last_settings  where user_name = '" + lblEmailFieldTo.Text + "'", 1);
                    sret = verify.DbExecuteDB("insert into last_settings(user_name,ConnectionString,iConnectionType,id_field,table_name,email_field_name,dns_server,chkFixTyposMajorISP,chkFixKnownTyposGeneral,chkDeleteFictitiousDomains,chkDeleteSpamTrapDomains,chkDeleteSpamTrapAddresses,chkDeleteWirelessDomains,chkDeleteRoleUsernames,chkFixTypoSuffix,chkDeleteBadFormatedEmails,chkDeleteBadFormatedMajorISP,chkDeleteEmailsWithNoMXgeneral,chkDeleteEmailifMXcantVerifyMajorISP,chkDeleteEmailifMXcantVerifyGeneral) values('" + lblEmailFieldTo.Text + "','" + txtConnectionString.Text + "'," + iConnectionType + ",'" + txtKeyField2.Text + "','" + txtTableName.Text + "','" + txtEmailFieldFrom.Text + "','" + txtDns.Text + "'," + Convert.ToByte(chkFixTyposMajorISP.Checked) + "," + Convert.ToByte(chkFixKnownTyposGeneral.Checked) + "," + Convert.ToByte(chkDeleteFictitiousDomains.Checked) + "," + Convert.ToByte(chkDeleteSpamTrapDomains.Checked) + "," + Convert.ToByte(chkDeleteSpamTrapAddresses.Checked) + "," + Convert.ToByte(chkDeleteWirelessDomains.Checked) + "," + Convert.ToByte(chkDeleteRoleUsernames.Checked) + "," + Convert.ToByte(chkFixTypoSuffix.Checked) + "," + Convert.ToByte(chkDeleteBadFormatedEmails.Checked) + "," + Convert.ToByte(chkDeleteBadFormatedMajorISP.Checked) + "," + Convert.ToByte(chkDeleteEmailsWithNoMXgeneral.Checked) + "," + Convert.ToByte(chkDeleteEmailifMXcantVerifyMajorISP.Checked) + "," + Convert.ToByte(chkDeleteEmailifMXcantVerifyGeneral.Checked) + ")", 1);
                }
                else 
                {
                    sret = verify.DbExecuteDB("update last_settings set ConnectionString = '" + txtConnectionString.Text + "',iConnectionType = " + iConnectionType + ",id_field = '" + txtKeyField2.Text + "',table_name = '" + txtTableName.Text + "',email_field_name = '" + txtEmailFieldFrom.Text + "',dns_server = '" + txtDns.Text + "',  chkFixTyposMajorISP = " + Convert.ToByte(chkFixTyposMajorISP.Checked) + ",chkFixKnownTyposGeneral = " + Convert.ToByte(chkFixKnownTyposGeneral.Checked) + ",chkDeleteFictitiousDomains = " + Convert.ToByte(chkDeleteFictitiousDomains.Checked) + ",chkDeleteSpamTrapDomains = " + Convert.ToByte(chkDeleteSpamTrapDomains.Checked) + ",chkDeleteSpamTrapAddresses = " + Convert.ToByte(chkDeleteSpamTrapAddresses.Checked) + ",chkDeleteWirelessDomains = " + Convert.ToByte(chkDeleteWirelessDomains.Checked) + ",chkDeleteRoleUsernames = " + Convert.ToByte(chkDeleteRoleUsernames.Checked) + ",chkFixTypoSuffix = " + Convert.ToByte(chkFixTypoSuffix.Checked) + ",chkDeleteBadFormatedEmails = " + Convert.ToByte(chkDeleteBadFormatedEmails.Checked) + ",chkDeleteBadFormatedMajorISP = " + Convert.ToByte(chkDeleteBadFormatedMajorISP.Checked) + ",chkDeleteEmailsWithNoMXgeneral = " + Convert.ToByte(chkDeleteEmailsWithNoMXgeneral.Checked) + ",chkDeleteEmailifMXcantVerifyMajorISP = " + Convert.ToByte(chkDeleteEmailifMXcantVerifyMajorISP.Checked) + ",chkDeleteEmailifMXcantVerifyGeneral = " + Convert.ToByte(chkDeleteEmailifMXcantVerifyGeneral.Checked) + " where user_name = '" + lblEmailFieldTo.Text + "'", 1);
                }


            threadInfo tt =new threadInfo();
            tt.d = data;
            tt.v = verify;
            

            progressBar1.Minimum = 1;
            progressBar1.Step = 1;


            int icntr = 0;
            lblTotal.Text = verify.DbScalar("select count(*) from " + txtTableName.Text, iConnectionType);
            lbltoDo.Text = verify.DbScalar("select count(*) from " + txtTableName.Text + " where reasoncode > 0", iConnectionType);

            try
            {
                progressBar1.Maximum = Convert.ToInt32(lblTotal.Text);
                if (Convert.ToInt32(lbltoDo.Text) == 0)
                {
                    progressBar1.Value = 1;
                }
                else
                {
                    progressBar1.Value = Convert.ToInt32(lbltoDo.Text);
                }
            }
            catch { }

            backgroundWorker1.RunWorkerAsync(tt);

            try
            {
                int iperf = 0;
                int ilast = 0;
                int templast = 0;
                bool firsttime = true;
                while (bend == false)
                {
                    Thread.Sleep(20);
                    Application.DoEvents();
                    icntr++;

                    if (icntr > 1000)// 30 seconds (calculated it on rel5)
                    {
                        icntr = 0;
                        if (firsttime == false)
                        {
                            templast = Convert.ToInt32(lbltoDo.Text);
                        }
                        lbltoDo.Text = verify.DbScalar("select count(*) from " + txtTableName.Text + " where reasoncode > 0", iConnectionType);
                        iperf++;



                        if (firsttime == false)
                        {
                            ilast = Convert.ToInt32(lbltoDo.Text) - templast;
                        }
                        firsttime = false;


                        progressBar1.Value = Convert.ToInt32(lbltoDo.Text);
                    }
                    if (iperf == 2) //60 seconds
                    {
                        iperf = 0;
                        txtPerMin.Text = Convert.ToString(ilast * 2);
                        label10.Text = Convert.ToString((Convert.ToInt32(lbltoDo.Text) * 100) / Convert.ToInt32(lblTotal.Text));
                        txtMin.Text = Convert.ToString((Convert.ToInt32(lblTotal.Text) - Convert.ToInt32(lbltoDo.Text)) / Convert.ToInt32(txtPerMin.Text));
                    }

                }
            }
            catch { }
    
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (chkDeleteEmailsWithNoMXgeneral.Checked == true && txtDns.Text == "")
            {
                MessageBox.Show("Please fill in a DNS server to use");
                return;
            }
            if (txtTableName.Text == "" || txtEmailFieldFrom.Text == "" || txtEmailFieldTo.Text == "" || txtReasonID.Text == "" || txtSupressionID.Text == "")
            {
                MessageBox.Show("Please fill in the required textboxes");
                return;
            }
            Runit();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            verifyDB = new clsEmailVerifier();
            string sret = string.Empty;
            sret = verifyDB.DbConnectSourceDB("Server=mssql2012;Database=EmailVerifier;User Id=sa;Password=lalalala;", 1);
            verifyDB.SetSettings(txtKeyField2.Text, "Server=mssql2012;Database=EmailVerifier;User Id=sa;Password=lalalala;", 1, txtTableName.Text, txtEmailFieldFrom.Text, txtEmailFieldTo.Text, txtReasonID.Text, txtSupressionID.Text, chkFixTyposMajorISP.Checked, chkFixKnownTyposGeneral.Checked, chkDeleteFictitiousDomains.Checked, chkDeleteSpamTrapDomains.Checked, chkDeleteSpamTrapAddresses.Checked, chkDeleteWirelessDomains.Checked, chkDeleteRoleUsernames.Checked, chkFixTypoSuffix.Checked, chkDeleteBadFormatedEmails.Checked, chkDeleteBadFormatedMajorISP.Checked, chkDeleteEmailsWithNoMXgeneral.Checked, chkDeleteEmailifMXcantVerifyMajorISP.Checked, chkDeleteEmailifMXcantVerifyGeneral.Checked, txtDns.Text);
            sret = verifyDB.Verify(sTestEmail.Text);
            MessageBox.Show(sret);

        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            threadInfo t = e.Argument as threadInfo;
            try
            {
                if (chkMajorIsp.Checked == true)
                {
                    t.v.VerifyVRFY(t.d);
                }
                else if (chkMXCheck.Checked == true)
                {
                    t.v.VerifyMX(t.d);
                }
                else
                {
                    t.v.Verify(t.d);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thread crashed due to:" + ex.Message);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          //  bend = true;
          //  MessageBox.Show("Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Convert.ToByte(chkFixTyposMajorISP.Checked)));
        }

        private void chkMajorIsp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMXCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            bend = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        } 
    }
    public class threadInfo
    {
        public clsEmailVerifier v;
        public DataSet d;
    }

}
