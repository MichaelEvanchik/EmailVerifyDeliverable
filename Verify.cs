    public class clsEmailVerifier
    {
        bool bblnFixTyposMajorISP = false;
        bool bblnFixKnownTyposGeneral = false;
        bool bblnDeleteFictitiousDomains = false;
        bool bblnDeleteSpamTrapDomains = false;
        bool bblnDeleteSpamTrapAddresses = false;
        bool bblnDeleteWirelessDomains = false;
        bool bblnDeleteRoleUsernames = false;
        bool bblnFixTypoSuffix = false;
        bool bblnDeleteBadFormatedEmails = false;
        bool bblnDeleteBadFormatedMajorISP = false;
        bool bblnDeleteEmailsWithNoMXgeneral = false;
        bool bblnDeleteEmailifMXcantVerifyMajorISP = false;
        bool bblnDeleteEmailifMXcantVerifyGeneral = false;
        string slTableName = "";
        string slFieldFrom = "";
        string slNewEmailFieldName = "";
        string slReasonFieldName = "";
        string slSuprreesionIDFieldName = "";
        string slConnectionString = "";
        string slKeyField = "";
        int slConnectionType = 0;
        int iReasonCode = 0;
        int iSuppressionID = 0;
        int[] resp;
        string svaliddomain = "";
        string ssdns = "";

        public clsEmailVerifier()
        {

        }

         public void Verify(DataSet semails)
        {
            string email = "";
            int keyfield = 0;
            string sSuffix = "";
            string domain = "";
            string user = "";
            string suffix = "";
            int i = 0;

            DataTable retDT = new DataTable();
            retDT = semails.Tables[0];




            foreach (DataRow sEmail in retDT.Rows)
            {
                while (true)
                {
                    string stempEmail = "";
                    bool validsuffix = false;
                    #region suffix_validation           
                    ///////////////////////////////////////////////////////////////////////////////
                    email = sEmail[1].ToString().Replace(" ", "").ToLower();
                    stempEmail = email;
                    keyfield = Convert.ToInt32(sEmail[0].ToString());
                    string tsuffix = "";

                    if (email.IndexOf("live.net") > -1)
                    {
                        email = email.Replace("live.net", "live.com");
                    }

                    if (email.IndexOf(".com.com") > -1)
                    {
                        email = email.Replace(".com.com", ".com");
                    }

                    if (email.IndexOf(".com.net") > -1)
                    {
                        email = email.Replace(".com.net", ".net");
                    }


                    if (email.IndexOf("gmailcom") > -1)
                    {
                        email = email.Replace("gmailcom", "gmail.com");
                    }
                    if (email.IndexOf("yahoocom") > -1)
                    {
                        email = email.Replace("yahoocom", "yahoo.com");
                    }
                    if (email.IndexOf("hotmailcom") > -1)
                    {
                        email = email.Replace("hotmailcom", "hotmail.com");
                    }
                    if (email.IndexOf("aolcom") > -1)
                    {
                        email = email.Replace("aolcom", "aol.com");
                    }
                    if (email.IndexOf("aimcom") > -1)
                    {
                        email = email.Replace("aimcom", "aim.com");
                    }
                    if (email.IndexOf("@.") > -1)
                    {
                        email = email.Replace("@.", "@");
                    }

                    sSuffix = email;
                    if (sSuffix.IndexOf("@") > -1)
                    {
                        sSuffix = sSuffix.Substring(email.IndexOf("@") + 1);
                        validsuffix = true;
                    }
                    else if (sSuffix.IndexOf("#") > -1)
                    {
                        sSuffix = sSuffix.Substring(email.IndexOf("#") + 1);
                        validsuffix = true;
          
                    }
                    else if (sSuffix.IndexOf("!") > -1)
                    {
                        sSuffix = sSuffix.Substring(sSuffix.IndexOf("!") + 1);
                        validsuffix = true;
                    }

                if (sSuffix.IndexOf(".") > -1)
                {
                    sSuffix = sSuffix.Substring(sSuffix.IndexOf("."));
                    validsuffix = true;
                }
                else if (sSuffix.IndexOf("/") > -1)
                {
                    sSuffix = sSuffix.Substring(sSuffix.IndexOf("/"));
                    email = email.Replace("/", ".");
                    validsuffix = true;
                }
                else if (sSuffix.IndexOf(",") > -1)
                {
                    sSuffix = sSuffix.Substring(sSuffix.IndexOf(","));
                    email = email.Replace(",", ".");
                    validsuffix = true;
                }

                    if (validsuffix == false)
                    {
                        DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 16, " + slSuprreesionIDFieldName + " = 4," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                        break;
                    }


            suffix = sSuffix;
            if (suffix.IndexOf("..") > -1)
            {
                suffix = suffix.Replace("..", ".");
                email = email.Replace("..", ".");
            }
            if (IsValidSuffix(suffix) == false)
            {
                if (suffix.IndexOf("\\") > -1)
                {
                    suffix = suffix.Replace("\\", "");
                    email = email.Replace("\\", "");
                }
                if (suffix.IndexOf("/") > -1)
                {
                    suffix = suffix.Replace("/", ".");
                    email = email.Replace("/", "");
                }
                if (suffix.IndexOf(",") > -1)
                {
                    suffix = suffix.Replace(",", ".");
                    email = email.Replace(",", "");
                }
                if (suffix.IndexOf("..") > -1)
                {
                    suffix = suffix.Replace("..", ".");
                    email = email.Replace("..", ".");
                }
                if (suffix.IndexOf("'") > -1)
                {
                    suffix = suffix.Replace("'", "");
                    email = email.Replace("'", "");
                }
                if (suffix.IndexOf("`") > -1)
                {
                    suffix = suffix.Replace("`", "");
                    email = email.Replace("`", "");
                }
                if (suffix.IndexOf("-") > -1)
                {
                    suffix = suffix.Replace("-", "");
                }
                if (suffix.IndexOf("&") > -1)
                {
                    suffix = suffix.Replace("&", "");
                    email = email.Replace("&", "");
                }
                if (suffix.IndexOf("\\") > -1)
                {
                    suffix = suffix.Replace("\\", "");
                    email = email.Replace("\\", "");
                }
                if (suffix.IndexOf("?") > -1)
                {
                    suffix = suffix.Replace("?", "");
                    email = email.Replace("?", "");
                }
                if (suffix.IndexOf("=") > -1)
                {
                    suffix = suffix.Replace("=", "");
                    email = email.Replace("=", "");
                }
                if (suffix.IndexOf("%") > -1)
                {
                    suffix = suffix.Replace("%", "");
                    email = email.Replace("%", "");
                }

                if (IsValidSuffix(suffix) == false)
                {
                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 15, " + slSuprreesionIDFieldName + " = 3," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                    break;
                }
            }
            

            else
            {

                if (bblnFixTypoSuffix == true)
                {
                    tsuffix = DbScalarDB("select replace_with from supression where reason = 8 and email_or_string = '" + suffix + "'", 1);
                    if (tsuffix == null && tsuffix.Length > 0)
                    {
                        suffix = tsuffix;
                    }
                    else
                    {
                        if (IsValidSuffix(suffix) == false)
                        {
                            if (suffix.Substring(0, 1) == ".")
                            {
                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 14, " + slSuprreesionIDFieldName + " = 3," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                break;
                            }

                            if (suffix.IndexOf("/") > 0 || suffix.IndexOf(",") > 0)
                            {
                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 13, " + slSuprreesionIDFieldName + " = 4," + slNewEmailFieldName + " = 'invalid'where " + slKeyField + " = " + keyfield, slConnectionType);
                                break;
                            }
                        }
                    }
                }
            }


                
            
                    ///////////////////////////////////////////////////////////////////////////////////////////
                    #endregion

                    bool validuser = false;
                    #region user_name
                        //user/////////////////////////////////////////////////////////////////////////////////
                        if (email.IndexOf("@") > -1)
                        {
                            user = email.Substring(0, email.IndexOf("@") + 1);
                            validuser = true;
                        }
                        else if (email.IndexOf("#") > -1)
                        {
                            user = email.Substring(0, email.IndexOf("#") + 1);
                            user = user.Substring(0, user.Length - 1) + "@";
                            email = email.Replace("#", "@");
                            validuser = true;
                        }
                        else if (email.IndexOf("!") > -1)
                        {
                            user = email.Substring(0, email.IndexOf("!") + 1);
                            user = user.Substring(0, user.Length - 1) + "@";
                            email = email.Replace("!", "@");
                            validuser = true;
                        }

                        if (validuser == false)
                        {
                            DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 12, " + slSuprreesionIDFieldName + " = 5," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                            break;
                        }

                        if (IsGoodUser(user.Substring(0, user.Length - 1)) == false)
                        {
                            if (user.IndexOf("#") > -1)
                            {
                                user = user.Replace("#", "");
                            }
                            if (user.IndexOf("`") > -1)
                            {
                                user = user.Replace("`", "");
                            }
                            if (user.IndexOf("$") > -1)
                            {
                                user = user.Replace("$", "4");

                            }
                            if (user.IndexOf("=") > -1)
                            {
                                user = user.Replace("=", "");

                            }
                            if (user.IndexOf("`") > -1)
                            {
                                user = user.Replace("`", "");

                            }
                            if (user.IndexOf("\\") > -1)
                            {
                                user = user.Replace("\\", "");
                            }
                            if (user.IndexOf("^") > -1)
                            {
                                user = user.Replace("^", "5");
                            }
                            if (user.IndexOf("+") > -1)
                            {
                                user = user.Replace("+", "");
                            }
                            if (user.IndexOf("/") > -1)
                            {
                                user = user.Replace("/", "");
                            }
                            if (user.IndexOf("&") > -1)
                            {
                                user = user.Replace("&", "");
                            }
                            if (user.IndexOf("'") > -1)
                            {
                                user = user.Replace("'", "");
                            }
                            if (user.IndexOf("?") > -1)
                            {
                                user = user.Replace("?", "");
                            }
                            if (user.IndexOf("*") > -1)
                            {
                                user = user.Replace("*", "8");
                            }
                            if (user.IndexOf("~") > -1)
                            {
                                user = user.Replace("~", "");
                            }
                            if (user.IndexOf("!") > -1)
                            {
                                user = user.Replace("!", "");
                            }
                            if (user.IndexOf("_") == 0)
                            {
                                user = user.Substring(1);
                            }
                            if (user.IndexOf(".") == 0)
                            {
                                user = user.Substring(1);
                            }
                            if (user.IndexOf(",") > -1)
                            {
                                user = user.Replace(",", ".");
                            }
                            if (IsGoodUser(user.Substring(0, user.Length - 1)) == false)
                            {
                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 11, " + slSuprreesionIDFieldName + " = 6," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                break;
                            }
                        }

                        if (user.IndexOf("@") < 2)
                        {
                            DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 10, " + slSuprreesionIDFieldName + " = 7," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                            break;
                        }

                        if (user.Substring(0, 1) == "." || user.Substring(0, 1) == "-" || user.Substring(0, 1) == "_")
                        {
                            DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 10, " + slSuprreesionIDFieldName + " = 7," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                            break;
                        }
                                    
                            if (bblnDeleteRoleUsernames == true)
                            {
                                string tuser = "";
                                tuser = DbScalarDB("select id  from supression where reason = 7 and email_or_string = '" + user.Substring(0, user.Length - 1) + "'", 1);
                                if (tuser == null && tuser.Length > 0)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 7, " + slSuprreesionIDFieldName + " = " + tuser.ToString() + "," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                            }

                                string tuser2 = "";
                                tuser2 = DbScalarDB("select id  from supression where reason = 3 and email_or_string = '" + user.Substring(0, user.Length - 1) + "'", 1);
                                if (tuser2 == null && tuser2.Length > 0)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 3, " + slSuprreesionIDFieldName + " = " + tuser2.ToString() + "," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }

         

                                if (bblnDeleteSpamTrapDomains == true)
                                {
                                    string tuser3 = "";
                                    tuser3 = DbScalarDB("select id  from supression where reason = 14 and email_or_string = '" + user.Substring(0, user.Length - 1) + "'", 1);
                                    if (tuser3 == null && tuser3.Length > 0)
                                    {
                                        DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 19, " + slSuprreesionIDFieldName + " = " + tuser3.ToString() + "," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                        break;
                                    }
                                }
                        ///user//////////////////////////////////////////////////////////////////////////////////
                        #endregion


                    bool validdomain = false;
                    string tdomain = "";
    
                    #region domain_check
                        ////////////////////////////////////////////////////////////////////////////////
                            if (email.IndexOf("@") > -1)
                            {
                                domain = email.Substring(email.IndexOf("@") + 1);
                                validdomain = true;
                            }
                            else if (email.IndexOf("#") > -1)
                            {
                                domain = email.Substring(email.IndexOf("#") + 1);
                                email = email.Replace("#", "@");
                                validdomain = true;
                            }
                            else if (email.IndexOf("!") > -1)
                            {
                                domain = email.Substring(email.IndexOf("!") + 1);
                                email = email.Replace("!", "@");
                                validdomain = true;
                            }

                            if (validdomain == false)
                            {
                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 9, " + slSuprreesionIDFieldName + " = 8," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                break;
                            }

                            if (IsGoodDomain(domain) == false)
                            {
                                domain = domain.Replace("@", "");
                                if (domain.IndexOf("#") > -1)
                                {
                                    domain = domain.Replace("#", "");
                                    email = email.Replace("#", "");
                                }
                                if (domain.IndexOf("!") > -1)
                                {
                                    domain = domain.Replace("!", "");
                                    email = email.Replace("!", "");
                                }
                                if (domain.IndexOf(",") > -1)
                                {
                                    domain = domain.Replace(",", "");
                                    email = email.Replace(",", "");
                                }
                                if (domain.IndexOf("&") > -1)
                                {
                                    domain = domain.Replace("&", "");
                                    email = email.Replace("&", "");
                                }
                                if (domain.IndexOf("/") > -1)
                                {
                                    domain = domain.Replace("/", "");
                                    email = email.Replace("/", "");
                                }
                                if (domain.IndexOf("\\") > -1)
                                {
                                    domain = domain.Replace("\\", "");
                                    email = email.Replace("\\", "");
                                }
                                if (domain.IndexOf("?") > -1)
                                {
                                    domain = domain.Replace("?", "");
                                    email = email.Replace("?", "");
                                }
                                if (domain.IndexOf("=") > -1)
                                {
                                    domain = domain.Replace("=", "");
                                    email = email.Replace("=", "");
                                }
                                if (domain.IndexOf("%") > -1)
                                {
                                    domain = domain.Replace("%", "");
                                    email = email.Replace("%", "");
                                }
                                if (domain.IndexOf("_") > -1)
                                {
                                    domain = domain.Replace("_", "-");
                                }

                            }

                            if (domain.IndexOf(".") > -1)
                            {
                                domain = domain.Substring(0, domain.IndexOf("."));
                            }

                            if (IsGoodDomain(domain) == false)
                            {
                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 8, " + slSuprreesionIDFieldName + " = 18," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                break;
                            }

                            bool bfixed = false;
                            if (bblnFixTyposMajorISP == true)
                            {
                                DataSet tds = new DataSet();
                                tds = DbDataSetDB("select id,replace_with  from supression where reason = 1 and email_or_string = '" + domain + "'", 1);
                                if (IsEmpty(tds) == true)
                                {
                                    tdomain = tds.Tables[0].Rows[0][1].ToString();
                                    string sretid = tds.Tables[0].Rows[0][0].ToString();
                                    if (tdomain.IndexOf(".") > 0)
                                    {
                                        suffix = tdomain.Substring(tdomain.IndexOf("."));
                                        domain = tdomain.Substring(0, tdomain.IndexOf("."));
                                        bfixed = true;
                                    }
                                    else
                                    {
                                       domain = tdomain;
                                       bfixed = true;
                                    }
                                }
                            }

                            bool bfixed2 = false;
                            if (bblnFixKnownTyposGeneral == true && bfixed == false)
                            {
                                DataSet tds = new DataSet();
                                tds = DbDataSetDB("select id,replace_with  from supression where reason = 2 and email_or_string = '" + domain + "'", 1);
                                if (IsEmpty(tds) == true)
                                {
                                    tdomain = tds.Tables[0].Rows[0][1].ToString();
                                    string sretid = tds.Tables[0].Rows[0][0].ToString();
                                    if (tdomain.IndexOf(".") > 0)
                                    {
                                        suffix = tdomain.Substring(tdomain.IndexOf("."));
                                        domain = tdomain.Substring(0, tdomain.IndexOf("."));
                                        bfixed2 = true;
                                    }
                                    else
                                    {
                                        domain = tdomain;
                                        bfixed2 = true;
                                    }
                                }
                            }

                            if((bfixed2 == false && bblnFixKnownTyposGeneral == true) && (bfixed == false && bblnFixTyposMajorISP == true))
                            {
                                if (IsGoodDomain(domain) == false)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 17, " + slSuprreesionIDFieldName + " = 9," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                            }

                            if (bblnDeleteFictitiousDomains == true)
                            {
                                tdomain = DbScalarDB("select id  from supression where reason = 3 and email_or_string = '" + domain + "'", 1);
                                if (tdomain == null && tdomain.Length > 0)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 3, " + slSuprreesionIDFieldName + " =" + tdomain.ToString() + "," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                            }

                            if (bblnDeleteSpamTrapDomains == true)
                            {
                                tdomain = DbScalarDB("select id  from supression where reason = 4 and email_or_string = '" + domain + suffix + "'", 1);
                                if (tdomain == null && tdomain.Length > 0)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 4, " + slSuprreesionIDFieldName + " = " + tdomain.ToString() + "," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                            }

                            if (bblnDeleteWirelessDomains == true)
                            {
                                tdomain = DbScalarDB("select id  from supression where reason = 6 and email_or_string = '" + domain + suffix + "'", 1);
                                if (tdomain == null && tdomain.Length > 0)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 6, " + slSuprreesionIDFieldName + " = " + tdomain.ToString() + "," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                            }

                            if (bblnDeleteWirelessDomains == true)
                            {
                                tdomain = DbScalarDB("select id  from supression where reason = 5 and email_or_string = '" + user + domain + suffix + "'", 1);                                                                                //Fix
                                if (tdomain == null && tdomain.Length > 0)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 5, " + slSuprreesionIDFieldName + " =" + tdomain.ToString() + "," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                            }

                            if (bblnDeleteBadFormatedMajorISP == true)
                            {
                                if (DomainIsMailable(domain, ssdns, false, keyfield) == false)
                                {
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 23, " + slSuprreesionIDFieldName + " =0," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                            }


                            if (IsValidEmail(user + domain + suffix) == true)
                            {
                                    #region ispcheck
                                    if (bblnDeleteEmailifMXcantVerifyMajorISP == true)
                                    {
                                        if (domain == "gmail")
                                        {
                                            try
                                            {
                                                string response = "";
                                                string message = "";
                                                TcpClient client = new TcpClient();
                                                client.Connect("173.194.70.27", 25);
                                                response = Response(client);
                                                message = "HELO me.com\r\n";
                                                Write(message, client);
                                                response = Response(client);
                                                message = "MAIL FROM:<"user + domain + suffix">\r\n";
                                                Write(message, client);
                                                response = Response(client);
                                                message = "RCPT TO:<" + user + domain + suffix + ">\r\n";
                                                Write(message, client);
                                                response = Response(client);
                                                if (response.Substring(0, 3) == "250")
                                                {
                                                    message = "quit\r\n";
                                                    Write(message, client);
                                                    client.Close();
                                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 18, " + slSuprreesionIDFieldName + " = 12," + slNewEmailFieldName + " = '" + user + domain + suffix + "' where " + slKeyField + " = " + keyfield, slConnectionType);
                                                    break;
                                                }
                                                else
                                                {

                                                        DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 102, " + slSuprreesionIDFieldName + " = 0," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                                    
                                                    break;
                                                }
                                            }
                                            catch 
                                            {
                                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 24, " + slSuprreesionIDFieldName + " = 0," + slNewEmailFieldName + " = '" + user + domain + suffix + "' where " + slKeyField + " = " + keyfield, slConnectionType);
                                            }
                                        }
                                    }




                                    
                                    #endregion
                                    if (stempEmail == user + domain + suffix)
                                    {
                                        DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 101, " + slSuprreesionIDFieldName + " = 0," + slNewEmailFieldName + " = '" + user + domain + suffix + "' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    }
                                    else
                                    {
                                        DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 100, " + slSuprreesionIDFieldName + " = 0," + slNewEmailFieldName + " = '" + user + domain + suffix + "' where " + slKeyField + " = " + keyfield, slConnectionType);
                                    }
                            }
                            else
                            {
                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 20, " + slSuprreesionIDFieldName + " = 0," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                                break;

                            }
                          break;
                        /////domain///////////////////////////////////////////////////////////////////////////
                        #endregion
                }//inner while for performance break
            }//end while


        }//end function

        public void VerifyMX(DataSet semails)
        {
            string email = "";
            int keyfield = 0;
            string sSuffix = "";
            string domain = "";
            string user = "";
            string suffix = "";
            int i = 0;

            DataTable retDT = new DataTable();
            retDT = semails.Tables[0];
            foreach (DataRow sEmail in retDT.Rows)
            {
                while (true)
                {

                        System.Threading.Thread.Sleep(30);
                        email = sEmail[1].ToString().Replace(" ", "").ToLower();
                        domain = email.Substring(email.IndexOf("@") + 1);
                        keyfield = Convert.ToInt32(sEmail[0].ToString());
                        try
                        {
                            domain = email.Substring(email.IndexOf("@") + 1);
                        }
                        catch
                        {
                            break;
                        }
                        if (DomainIsMailable(domain, ssdns, true,keyfield) == false)
                        {
                           
                            break;
                        }
                    }
                
            }
        }



        public void VerifyMX(DataSet semails)
        {
            string email = "";
            int keyfield = 0;
            string sSuffix = "";
            string domain = "";
            string user = "";
            string suffix = "";
            int i = 0;

            DataTable retDT = new DataTable();
            retDT = semails.Tables[0];
            foreach (DataRow sEmail in retDT.Rows)
            {
                while (true)
                {

                        System.Threading.Thread.Sleep(30);
                        email = sEmail[1].ToString().Replace(" ", "").ToLower();
                        domain = email.Substring(email.IndexOf("@") + 1);
                        keyfield = Convert.ToInt32(sEmail[0].ToString());
                        try
                        {
                            domain = email.Substring(email.IndexOf("@") + 1);
                        }
                        catch
                        {
                            break;
                        }
                        if (DomainIsMailable(domain, ssdns, true,keyfield) == false)
                        {
                           
                            break;
                        }
                    }
                
            }
        }


        //should be renamed to VerifyRCPTO, havent made a VerfyVRFY since most domains do not allow this
        public void VerifyVRFY(DataSet semails)
        {
            string email = "";
            int keyfield = 0;
            string sSuffix = "";
            string domain = "";
            string user = "";
            string suffix = "";
            int i = 0;

            DataTable retDT = new DataTable();
            retDT = semails.Tables[0];
            foreach (DataRow sEmail in retDT.Rows)
            {
                while (true)
                {
      
                        email = sEmail[1].ToString().Replace(" ", "").ToLower();
                        domain = email.Substring(email.IndexOf("@") + 1);
                        keyfield = Convert.ToInt32(sEmail[0].ToString());
                        if (domain == "gmail.com")
                        {
                            System.Threading.Thread.Sleep(20);
                            try
                            {
                                string response = "";
                                string message = "";
                                TcpClient client = new TcpClient();
                                client.Connect("173.194.70.27", 25);
                                response = Response(client);
                                message = "HELO me.com\r\n";
                                Write(message, client);
                                response = Response(client);
                                message = "MAIL FROM:<xgcmcbain@hotmail.com>\r\n";
                                Write(message, client);
                                response = Response(client);
                                message = "RCPT TO:<" + email + ">\r\n";
                                Write(message, client);
                                response = Response(client);
                                if (response.Substring(0, 3) == "250")
                                {
                                    message = "quit\r\n";
                                    Write(message, client);
                                    client.Close();
                                    DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 18, " + slSuprreesionIDFieldName + " = 12 where " + slKeyField + " = " + keyfield, slConnectionType);
                                    break;
                                }
                                else
                                {
                                   DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 102, " + slSuprreesionIDFieldName + " = 0 where " + slKeyField + " = " + keyfield, slConnectionType);
                                   break;
                                }
                            }
                            catch 
                            {
                                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 24, " + slSuprreesionIDFieldName + ", " + slNewEmailFieldName + " = 'invalid'= 0 where " + slKeyField + " = " + keyfield, slConnectionType);
                            }
                        }
                    
                }
            }
        }

        public void Write(string message, TcpClient c)
        {
            System.Text.ASCIIEncoding en = new System.Text.ASCIIEncoding();

            byte[] WriteBuffer = new byte[1024];
            WriteBuffer = en.GetBytes(message);

            NetworkStream stream = c.GetStream();
            stream.Write(WriteBuffer, 0, WriteBuffer.Length);
        }

        public string Response(TcpClient c)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            byte[] serverbuff = new Byte[1024];
            NetworkStream stream = c.GetStream();
            int count = stream.Read(serverbuff, 0, 1024);
            if (count == 0)
            {
                return "";
            }
            return enc.GetString(serverbuff, 0, count);
        }


        public bool DomainIsMailable(string domain, string dns,bool prechecked, int keyfield)
        {
            if (prechecked == false)
            {
                if (domain == "gmail.com" || domain == "comcast.net" || domain == "msn.com" || domain == "verizon.net" || domain == "sbcblogal.net" || domain == "bellsouth.net" || domain == "optonline.net" || domain == "lindt.com" || domain == "att.net" || domain == "cox.net" || domain == "live.net" || domain == "juno.com" || domain == "me.com" || domain == "invalid" || domain == "earthlink.net" || domain == "charter.net" || domain == "ymail.com" || domain == "aim.com" || domain == "myfairpoint.net" || domain == "nc.rr.com" || domain == "main.rr.com" || domain == "netzero.net" || domain == "metrocast.net" || domain == "embarqmail.com" || domain == "rocketmail.com" || domain == "rogers.com" || domain == "windstream.net" || domain == "netscape.net" || domain == "sympatico.ca" || domain == "frontiernet.net" || domain == "mindspring.com" || domain == "mail.com" || domain == "frontier.com" || domain == "excite.com" || domain == "email.com" || domain == "centurytel.net" || domain.IndexOf("yahoo") > -1 || domain.IndexOf("aol") > -1 || domain.IndexOf("hotmail") > -1)
                {
                    return  true;
                }
            }
            string qtype = "15"; //A=1  MX=15
            
            UdpClient udpc = new UdpClient(dns, 53);

            // SEND REQUEST--------------------
            List<byte> list = new List<byte>();
            list.AddRange(new byte[] { 88, 89, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0 });

            string[] tmp = domain.Split('.');
            foreach (string s in tmp)
            {
                list.Add(Convert.ToByte(s.Length));
                char[] chars = s.ToCharArray();
                foreach (char c in chars)
                    list.Add(Convert.ToByte(Convert.ToInt32(c)));
            }
            list.AddRange(new byte[] { 0, 0, Convert.ToByte(qtype), 0, 1 });

            byte[] req = new byte[list.Count];
            for (int i = 0; i < list.Count; i++) { req[i] = list[i]; }

            udpc.Send(req, req.Length);


            // RECEIVE RESPONSE--------------
            IPEndPoint ep = null;
            byte[] recv = udpc.Receive(ref ep);
            udpc.Close();

            resp = new int[recv.Length];
            for (int i = 0; i < resp.Length; i++)
                resp[i] = Convert.ToInt32(recv[i]);

            int status = resp[3];
            /*if (status == 128)
            {
             * //valid mailable domains are going here
                svaliddomain = "";
                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 33, " + slSuprreesionIDFieldName + " =0," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                return false;
            }*/

            int answers = resp[7];

            if (answers == 0)
            {
                svaliddomain = "";
                DbExecute("update " + slTableName + " set " + slReasonFieldName + " = 34, " + slSuprreesionIDFieldName + " =0," + slNewEmailFieldName + " = 'invalid' where " + slKeyField + " = " + keyfield, slConnectionType);
                return false;
            }

            int pos = domain.Length + 18;

            while (answers > 0)
            {
                return true;
                //doesnt seem to be working

                int preference = resp[pos + 13];
                pos += 14; //offset
                string str = GetMXRecord(pos, out pos);
                svaliddomain = str;
         
            }
            return false;
        }


        //------------------------------------------------------
        private string GetARecord(ref int start)
        {

            StringBuilder sb = new StringBuilder();

            int len = resp[start];
            for (int i = start; i < start + len; i++)
            {
                if (sb.Length > 0) sb.Append(".");
                sb.Append(resp[i + 1]);
            }
            start += len + 1;
            return sb.ToString();
        }
        private string GetMXRecord(int start, out int pos)
        {
            StringBuilder sb = new StringBuilder();
            int len = resp[start];
            while (len > 0)
            {
                if (len == 192)
                {
                    if (sb.Length > 0) sb.Append(".");
                    for (int i = start; i < start + len; i++)
                        sb.Append(Convert.ToChar(resp[i + 1]));
                    start += len + 1;
                    len = resp[start];
                }
                if (len == 192)
                {
                    int newpos = resp[start + 1];
                    if (sb.Length > 0) sb.Append(".");
                    sb.Append(GetMXRecord(newpos, out newpos));
                    start++;
                    break;
                }
            }
            pos = start + 1;
            return sb.ToString();

        }
        public bool IsReusable { get { return false; } }


        public bool IsValidEmail(string Email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            System.Text.RegularExpressions.Regex _Regex = new System.Text.RegularExpressions.Regex(strRegex);
            if (_Regex.IsMatch(Email))
                return (true);
            else
            return (false);
        }


        public bool IsAlphaNumericHyphenOrUnderscoreOrPERIOdString(string s)
        {
            Regex r = new Regex(@"[\w\-._]+");
            if (r.IsMatch(s))
            {
                return true ;             
            }
            else
            {
               return false;
            }
        }

        public bool IsGoodUser(string s)
        {
            Regex r = new Regex("^[a-z0-9_.-]*$");
            if (r.IsMatch(s))
            {
                return true ;             
            }
            else
            {
               return false;
            }
        }

        public bool IsValidSuffix(string s)
        {
            Regex r = new Regex("^[a-z.]*$");
            if (r.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsGoodDomain(string s)
        {
            Regex r = new Regex("^[a-z0-9.-]*$");
            if (r.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAlphaString(string s)
        {
            Regex r = new Regex("^[a-z]*$");
            if (r.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAlphaNumericString(string s)
        {
            Regex r = new Regex("^[a-z0-9]*$");
            if (r.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumericString(string s)
        {
            Regex r = new Regex("^[0-9]*$");
            if (r.IsMatch(s))
            {
                return true ;             
            }
            else
            {
               return false;
            }
        }


 
        //passes values to class
        public void SetSettings(string sKeyField,string sConnectionString, int sConnectionType,string sTableName, string sFieldFrom, string sNewEmailFieldName, string sReasonFieldName , string sSuprreesionIDFieldName, bool blnFixTyposMajorISP,bool blnFixKnownTyposGeneral,bool blnDeleteFictitiousDomains,bool blnDeleteSpamTrapDomains,bool blnDeleteSpamTrapAddresses,bool blnDeleteWirelessDomains,bool blnDeleteRoleUsernames,bool blnFixTypoSuffix,bool blnDeleteBadFormatedEmails,bool blnDeleteBadFormatedMajorISP,bool blnDeleteEmailsWithNoMXgeneral,bool blnDeleteEmailifMXcantVerifyMajorISP,bool blnDeleteEmailifMXcantVerifyGeneral,string sdns)
        {
             slKeyField = sKeyField;
             slConnectionString = sConnectionString;
             slConnectionType = sConnectionType;
             slTableName = sTableName;
             slFieldFrom = sFieldFrom;
             slNewEmailFieldName = sNewEmailFieldName;
             slReasonFieldName = sReasonFieldName;
             slSuprreesionIDFieldName = sSuprreesionIDFieldName;
             bblnFixTyposMajorISP = blnFixTyposMajorISP;
             bblnFixKnownTyposGeneral = blnFixKnownTyposGeneral;
             bblnDeleteFictitiousDomains = blnDeleteFictitiousDomains;
             bblnDeleteSpamTrapDomains = blnDeleteSpamTrapDomains;
             bblnDeleteSpamTrapAddresses = blnDeleteSpamTrapAddresses;
             bblnDeleteWirelessDomains = blnDeleteWirelessDomains;
             bblnDeleteRoleUsernames = blnDeleteRoleUsernames;
             bblnFixTypoSuffix = blnFixTypoSuffix;
             bblnDeleteBadFormatedEmails = blnDeleteBadFormatedEmails;
             bblnDeleteBadFormatedMajorISP = blnDeleteBadFormatedMajorISP;
             bblnDeleteEmailsWithNoMXgeneral = blnDeleteEmailsWithNoMXgeneral;
             bblnDeleteEmailifMXcantVerifyMajorISP = blnDeleteEmailifMXcantVerifyMajorISP;
             bblnDeleteEmailifMXcantVerifyGeneral = blnDeleteEmailifMXcantVerifyGeneral;
             ssdns = sdns;
        }
    }

