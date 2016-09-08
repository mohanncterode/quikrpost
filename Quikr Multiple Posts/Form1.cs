using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Gecko;
using Gecko.DOM;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace Quikr_Multiple_Posts
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize(@"D:\Mohan Drive\WordAddin\xulrunner-22.0.en-US.win32.sdk\xulrunner-sdk\bin");

        }


        
        private string pathinfo;
        public void valuefrom(string value)
        {
            lblfm12fm2.Text = value;
        }
        public void valuefrom1(string value1)
        {            lbl12lbl3.Text = value1;
        }
        public string loginotpcall { get; set; }
        private string excelcellpath;
        public string posturl;
        private void City_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog1 = new OpenFileDialog();
            Dialog1.Filter = "All Files (*.*)|*.*";
            if (Dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathinfo = Dialog1.FileName;
                Cith_Label.Text = pathinfo.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblfm12fm2.Visible = false;
            lbl12lbl3.Visible = false;
            //if (MessageBox.Show("Do you want to delete cookies?", "About to delete all cookies", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{   
                nsICookieManager CookieMan;
                CookieMan = Xpcom.GetService<nsICookieManager>("@mozilla.org/cookiemanager;1");
                CookieMan = Xpcom.QueryInterface<nsICookieManager>(CookieMan);
                CookieMan.RemoveAll();

                geckoWebBrowser1.Navigate("http://www.quikr.com/SignIn");
                
                while(geckoWebBrowser1.IsBusy)
                {
                    Application.DoEvents();
                }

                string redir1 = "http://www.quikr.com/SignIn?aj=1&for=login_popup&GreetingName=";
                //string redirmid = Uri.EscapeDataString(lblfm12fm2.Text);
                string redirmid = Uri.EscapeDataString("webrootech@gmail.com");
                string redir2 = "&Password=";
                //string redirmid2 = Uri.UnescapeDataString(lbl12lbl3.Text);
                string redirmid2 = Uri.UnescapeDataString("wRt*2014");
                string result = String.Concat(redir1 + redirmid + redir2 + redirmid2);

                geckoWebBrowser1.Navigate(result);
            //}
        }


        private void button_Load_Webpage_Click(object sender, EventArgs e)
        {
            //if (Cith_Label.Text.Trim() == String.Empty || Title_textBox1.Text.Trim() == String.Empty || Desc_textBox2.Text.Trim() == String.Empty || Name_textBox1.Text.Trim() == String.Empty || Email_textBox2.Text.Trim() == String.Empty || Mobile_textBox1.Text.Trim() == String.Empty)
            //{
            //    MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{

            try
            {
                //Declare the Excel Application
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                int rCnt = 0;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(pathinfo, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;

                for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
                {
                    excelcellpath = (string)(range.Cells[rCnt, 1] as Excel.Range).Value;
                    string url1 = "http://";
                    string url2 = ".quikr.com/post-classifieds-ads/";
                    string url = String.Concat(url1 + excelcellpath.ToLower() + url2);

                    geckoWebBrowser1.Navigate(url);

                    while (geckoWebBrowser1.IsBusy)
                    {
                        Application.DoEvents();
                    }

                    HtmlWeb hw = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = hw.Load(url);
                    HtmlNode node = doc.DocumentNode.SelectSingleNode("//div[@title='Services'] //div //ul //li[@title='Business Offers'] //a");

                    string imgSrc = node.Attributes["onclick"].Value;
                    var result = imgSrc.Substring(imgSrc.LastIndexOf('=') + 1);
                    var number = result.Replace(@"'", "");

                    string uri = String.Concat(url + "?postadcategoryid=" + number);

                    geckoWebBrowser1.Navigate(uri);

                    while (geckoWebBrowser1.IsBusy)
                    {
                        Application.DoEvents();
                    }

                    HtmlWeb hwcity = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument city = hwcity.Load(uri);
                    HtmlNode nodecity = city.DocumentNode.SelectSingleNode("//div[@class='formfield'] //div //div[@class='customSingleSelLoc_cont'] //span[1]");
                    string imgSrccity = nodecity.Attributes["locname"].Value;

                    //string title = Title_textBox1.Text;
                    //string contactname = Name_textBox1.Text;
                    //string emailid = Email_textBox2.Text;
                    //string mobile = Mobile_textBox1.Text;
                    //string textarea = Desc_textBox2.Text;

                    string title = "Non Voice Projects from Direct MNC Signup";
                    string contactname = "Mohan";
                    string emailid = "mohan@webrootech.com";
                    string mobile = "7418832519";
                    string textarea = "We Provide Genuine Projects which pay high amount and you can get better benefit. We are dealing in Voice, Non Voice, Inbound, Outbound, and Government - Non Government Projects, Online & Offline Processes with Legal Procedure. We also Provide Direct end-client Contact details as an Outsourcing Service Provider company. You have to pay just nominal Security Deposit.Currently we have more than 15 Processes to outsource and Direct MNC sign up. We update our site weekly basis and as per status of process vailability. Interested companies send their company profiles to mohan@webrootech.com / Skype id: mohanskype43(Mohan)";

                    geckoWebBrowser1.Document.GetElementById("title").SetAttribute("value", title);
                    geckoWebBrowser1.Document.GetElementById("adlocality").SetAttribute("value", imgSrccity);
                    geckoWebBrowser1.Document.GetElementById("contactName").SetAttribute("value", contactname);
                    geckoWebBrowser1.Document.GetElementById("emailid").SetAttribute("value", emailid);
                    geckoWebBrowser1.Document.GetElementById("mobile").SetAttribute("value", mobile);
                    geckoWebBrowser1.Document.GetElementsByTagName("textarea")[0].InnerHtml = textarea;

                    GeckoInputElement checkbox = new GeckoInputElement(geckoWebBrowser1.Document.GetElementsByName("usrprivacypostad")[0].DomObject);
                    checkbox.Click();

                    try
                    {
                        while(geckoWebBrowser1.IsBusy)
                        {
                            Application.DoEvents();
                        }
                        
                        GeckoElementCollection newadpost = geckoWebBrowser1.Document.GetElementsByTagName("button");
                        foreach (GeckoElement currentTag in newadpost)
                        {
                            if (currentTag.GetAttribute("onclick") == "quikrNewPostAd()")
                            {
                                ((GeckoHtmlElement)currentTag).Click();

                            }
                        }
                        while (geckoWebBrowser1.IsBusy)
                        {
                            Application.DoEvents();
                        }
                       
                    }
                    catch(Exception)
                    {
                        while(!geckoWebBrowser1.IsBusy)
                        {
                            Application.DoEvents();
                        }
                        while(geckoWebBrowser1.IsBusy)
                        {
                            Application.DoEvents();
                        }
                        
                    }
                      
                        try
                        {
                            while (geckoWebBrowser1.IsBusy)
                            {
                                Application.DoEvents();
                            }
                       
                            string nowurl = geckoWebBrowser1.Url.ToString();
                            if (uri == nowurl.ToString())
                            {
                               
                                GeckoElementCollection photoskip = geckoWebBrowser1.Document.GetElementsByTagName("a");
                                foreach (GeckoElement phototag in photoskip)
                                {
                                    if (phototag.GetAttribute("class") == "submit grey")
                                    {
                                        ((GeckoHtmlElement)phototag).Click();
                                    }
                                }
                                
                                while (!geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                                while (geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }

                                string latesturl = geckoWebBrowser1.Url.ToString();
                                HtmlWeb hwalinkweb = new HtmlWeb();
                                HtmlAgilityPack.HtmlDocument hwalinkdoc = hwalinkweb.Load(latesturl.ToString());
                                HtmlNode hwlinknode = hwalinkdoc.DocumentNode.SelectSingleNode("//div[@id='main_textarea'] //div //div //div //div[@id='skip-link'] //a");
                                string hwllinksource = hwlinknode.Attributes["href"].Value;

                                if (latesturl == geckoWebBrowser1.Url.ToString())
                                {
                                    GeckoElementCollection skippost = geckoWebBrowser1.Document.GetElementsByTagName("a");
                                    foreach (GeckoElement skiptag in skippost)
                                    {
                                        if (skiptag.GetAttribute("href") == hwllinksource.ToString())
                                        {
                                            ((GeckoHtmlElement)skiptag).Click();
                                        }
                                    }
                                }

                                while (geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                                while (!geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                                while (geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                            }
                            else if (uri != nowurl.ToString())
                            {

                                while (geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                                string latesturl = geckoWebBrowser1.Url.ToString();
                                HtmlWeb hwalinkweb = new HtmlWeb();
                                HtmlAgilityPack.HtmlDocument hwalinkdoc = hwalinkweb.Load(latesturl.ToString());
                                HtmlNode hwlinknode = hwalinkdoc.DocumentNode.SelectSingleNode("//div[@id='main_textarea'] //div //div //div //div[@id='skip-link'] //a");
                                string hwllinksource = hwlinknode.Attributes["href"].Value;

                                if (latesturl == geckoWebBrowser1.Url.ToString())
                                {
                                    GeckoElementCollection skippost = geckoWebBrowser1.Document.GetElementsByTagName("a");
                                    foreach (GeckoElement skiptag in skippost)
                                    {
                                        if (skiptag.GetAttribute("href") == hwllinksource.ToString())
                                        {
                                            ((GeckoHtmlElement)skiptag).Click();
                                        }
                                    }
                                }

                                while (geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                                while (!geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                                while (geckoWebBrowser1.IsBusy)
                                {
                                    Application.DoEvents();
                                }
                            }

                        }
                    catch(Exception)
                        {

                        }
                    geckoWebBrowser1.Navigate("http://www.quikr.com/");
                        while (geckoWebBrowser1.IsBusy)
                        {
                            Application.DoEvents();
                        }
                }
                        
            }

            catch (Exception ex)
            {
                MessageBox.Show("All Cities Posted Successfully");

            }
        }
    //}
        

        private void Email_textBox2_TextChanged(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(Email_textBox2.Text, pattern))
            {
                Email_Noti.Text = "Valid email address";
                Email_Noti.ForeColor = Color.Green;
            }
            else
            {
                Email_Noti.Text = "Not a valid email address";
                Email_Noti.ForeColor = Color.Red;
            }
        }

        private void Mobile_textBox1_TextChanged(object sender, EventArgs e)
        {
            string mobile = null;
            mobile = "^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$";

            if (Regex.IsMatch(Mobile_textBox1.Text, mobile))
            {
                mobile_label.Text = "Valid mobile address";
                mobile_label.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                mobile_label.Text = "Not a valid mobile address";
                mobile_label.ForeColor = System.Drawing.Color.Red;
            }
        }
       

    }
}
