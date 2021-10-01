using System;
using System.Net;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace PoloniexToDatabase
{
    class Execution
    {
        public static void Exec (object obj)
        {
            MainForm.ParametersToExecut parametersfromMainForm = (MainForm.ParametersToExecut)obj;
            string connection = parametersfromMainForm.connection;
            decimal pause = parametersfromMainForm.pause;
            string lineread = loading();
            string[] ss = sellect(lineread);
            CreateDBTab(connection, ss);
            Thread.Sleep(15000);
            while (true)
            {
                if (MainForm.WorkFlag)
                {
                    string linerread = loading();
                    string[] sss = sellect(lineread);
                    UploadToDB(connection, sss);
                    Thread.Sleep((int)pause * 1000);
                }
            }
        }



        public static string  loading()
        {
            string linein;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://poloniex.com/public?command=returnTicker");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    linein = reader.ReadToEnd();
                }
            }
            MainForm.StringBuilder_message.Append(DateTime.Now + "  Данные получены" + "\r\n");
            return linein;
        }




        public static void CreateDBTab(string connection, string[] ins)
        {
            SqlConnection connectionSQL = new SqlConnection(connection);
            try
            {
                connectionSQL.Open();
                foreach (string s in ins)
                {
                    string DBCreate =   "IF NOT EXISTS " +
                                        "(SELECT name FROM master.dbo.sysdatabases WHERE name = N'RATE') " +
                                        "BEGIN CREATE DATABASE[RATE] END";
                    SqlCommand DBCre = new SqlCommand(DBCreate, connectionSQL);
                    DBCre.ExecuteNonQuery();
                    parse(s, out string pair, out string d_last, out string d_lowestAsk,
                    out string d_highestBid, out string d_percentChange, out string d_baseVolume,
                    out string d_quoteVolume, out string d_high24hr, out string d_low24hr);
                    string stCreate = "if not exists(select * from RATE.dbo.sysobjects where name = '" + pair + "') CREATE TABLE RATE.dbo." + pair +
                                        "(Id INT PRIMARY KEY IDENTITY, dat DATETIME, d_last  DECIMAL(38, 18), " +
                                        "d_lowestAsk  DECIMAL(38, 18), d_highestBid  DECIMAL(38, 18), " +
                                        "d_percentChange  DECIMAL(38, 18), d_baseVolume  DECIMAL(38, 18), " +
                                        "d_quoteVolume  DECIMAL(38, 18), d_high24hr  DECIMAL(38, 18), " +
                                        "d_low24hr  DECIMAL(38, 18))  ";
                    SqlCommand stCre = new SqlCommand(stCreate, connectionSQL);
                    stCre.ExecuteNonQuery();
                }
                connectionSQL.Close();
            }
            catch (SqlException ex)
            {
                MainForm.StringBuilder_message.Append(ex.ToString() + "\r\n");
            }
        }






        public static void UploadToDB(string connection, string[] ins)
        {
            SqlConnection connectionSQL = new SqlConnection(connection);
            try
            {
                connectionSQL.Open();
                foreach (string s in ins)
                {
                    parse(s, out string pair, out string d_last, out string d_lowestAsk,
                    out string d_highestBid, out string d_percentChange, out string d_baseVolume,
                    out string d_quoteVolume, out string d_high24hr, out string d_low24hr);
                    string stInst = " INSERT INTO RATE.dbo." + pair + " (dat, d_last, d_lowestAsk, " +
                                                    "d_highestBid, d_percentChange, d_baseVolume, d_quoteVolume, " +
                                                    "d_high24hr, d_low24hr) VALUES (GETDATE(), " + d_last + ", " +
                                                     d_lowestAsk + ", " + d_highestBid + ", " + d_percentChange +
                                                     ", " + d_baseVolume + ", " + d_quoteVolume + ", "
                                                     + d_high24hr + ", " + d_low24hr + ")";
                    SqlCommand Ins = new SqlCommand(stInst, connectionSQL);
                    Ins.ExecuteNonQuery();
                }
                connectionSQL.Close();
                MainForm.StringBuilder_message.Append(DateTime.Now + " Данные заружены в базу данных" + "\r\n");
            }
            catch (SqlException ex)
            {
                MainForm.StringBuilder_message.Append(ex.ToString() + "\r\n");
            }
        }


        public static void parse(string inst, out string pair, out string last, out string lowestAsk,
            out string highestBid, out string percentChange, out string baseVolume, out string quoteVolume,
            out string high24hr, out string low24hr)
        {
            pair = inst.Substring(1, inst.IndexOf(":") - 2);  
            last = inst.Substring(inst.IndexOf("last") + 7, inst.IndexOf("lowestAsk") - inst.IndexOf("last") - 10);
            lowestAsk = inst.Substring(inst.IndexOf("lowestAsk") + 12, inst.IndexOf("highestBid") - inst.IndexOf("lowestAsk") - 15);
            highestBid = inst.Substring(inst.IndexOf("highestBid") + 13, inst.IndexOf("percentChange") - inst.IndexOf("highestBid") - 16);
            percentChange = inst.Substring(inst.IndexOf("percentChange") + 16, inst.IndexOf("baseVolume") - inst.IndexOf("percentChange") - 19);
            baseVolume = inst.Substring(inst.IndexOf("baseVolume") + 13, inst.IndexOf("quoteVolume") - inst.IndexOf("baseVolume") - 16);
            quoteVolume = inst.Substring(inst.IndexOf("quoteVolume") + 14, inst.IndexOf("isFrozen") - inst.IndexOf("quoteVolume") - 17);
            high24hr = inst.Substring(inst.IndexOf("high24hr") + 11, inst.IndexOf("low24hr") - inst.IndexOf("high24hr") - 14);
            low24hr = inst.Substring(inst.IndexOf("low24hr") + 10, inst.IndexOf("}") - inst.IndexOf("low24hr") - 11);
        }


        public static string[] sellect(string st)
        {
            string[] stout = new string[] { };
            string st1 = st.TrimStart('{').TrimEnd('}');
            int n = 0, k = 0;
            for (int i = 0; i < st1.Length; i++)
            {
                if (st1[i].ToString() == "}")
                {
                    Array.Resize(ref stout, n + 1);
                    stout[n] = st1.Substring(k, i - k + 1);
                    k = i + 2;
                    n++;
                }
            }
            return stout;
        }
    }
}










