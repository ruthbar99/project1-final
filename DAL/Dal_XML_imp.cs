using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Reflection;
using System.ComponentModel;
using System.Net;
using Project01_7735_5114_dotNet5780;
using System.Data;

namespace DAL
{
    public class Dal_XML_imp
    {
        public XElement Config;
        public XElement Orders;
        public XElement HostingUnits;
        public XElement GuestRequests;
        public static volatile bool bankDownloaded = false;

        public Dal_XML_imp()
        {
            if (!File.Exists("Config.xml"))
            {
                Config = new XElement("Config.xml");
            }

            if (!File.Exists("Orders.xml"))
            {
                Orders = new XElement("Orders.xml");
            }

            if (!File.Exists("HostingUnits.xml"))
            {
                HostingUnits = new XElement("HostingUnits.xml");
            }

            if (!File.Exists("GuestRequests.xml"))
            {
                GuestRequests = new XElement("GuestRequests.xml");
            }
        }

        public static List<Order> LoadOrdersFromXML()
        {
            FileStream file = new FileStream("Orders.xml", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> res = (List<Order>)xmlSerializer.Deserialize(file);
            file.Close();
            return res;
        }

        public static void SaveOrdersToXML<Order>(Order list, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSer = new XmlSerializer(list.GetType());
            xmlSer.Serialize(file, list);
            file.Close();
        }

        public static List<HostingUnit> LoadHostingUnitsFromXML()
        {
            FileStream file = new FileStream("HostingUnits.xml", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<HostingUnit>));
            List<HostingUnit> res = (List<HostingUnit>)xmlSerializer.Deserialize(file);
            file.Close();
            return res;
        }

        public static void SaveHostingUnitsToXML<HostingUnit>(HostingUnit list, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSer = new XmlSerializer(list.GetType());
            xmlSer.Serialize(file, list);
            file.Close();
        }

        public static List<GuestRequest> LoadGuestRequestsFromXML()
        {
            FileStream file = new FileStream("GuestRequests.xml", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<GuestRequest>));
            List<GuestRequest> res = (List<GuestRequest>)xmlSerializer.Deserialize(file);
            file.Close();
            return res;
        }

        public static void SaveGuestRequestsToXML<GuestRequest>(GuestRequest list, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSer = new XmlSerializer(list.GetType());
            xmlSer.Serialize(file, list);
            file.Close();
        }

        private List<BankBranch> banks = null;

        public List<BankBranch> GetBankBranchesList()
        {
            if (bankDownloaded)
            {
                if (banks == null)
                {
                    banks = new List<BankBranch>();
                    XmlDocument doc = new XmlDocument();
                    doc.Load(@"atm.xml");
                    XmlNode rootNode = doc.DocumentElement;
                    XmlNodeList children = rootNode.ChildNodes;
                    foreach (XmlNode child in children)
                    {
                        BankBranch b = GetBranchByXmlNode(child);
                        if (b != null)
                        {
                            banks.Add(b);
                        }
                    }
                }
                return banks;
            }
            else
                throw new DataException("bank didn't download");
        }

        private static BankBranch GetBranchByXmlNode(XmlNode node)
        {
            if (node.Name != "BRANCH") return null;
            BankBranch branch = new BankBranch();
            branch.BankNumber = -1;

            XmlNodeList children = node.ChildNodes;

            foreach (XmlNode child in children)
            {
                switch (child.Name)
                {
                    case "Bank_Code":
                        branch.BankNumber = int.Parse(child.InnerText);
                        break;
                    case "Bank_Name":
                        branch.BankName = child.InnerText;
                        break;
                    case "Branch_Code":
                        branch.BranchNumber = int.Parse(child.InnerText);
                        break;
                    case "Branch_Address":
                        branch.BranchAddress = child.InnerText;
                        break;
                    case "City":
                        branch.BranchCity = child.InnerText;
                        break;
                }

            }

            if (branch.BranchNumber > 0)
                return branch;

            return null;

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {

            object ob = e.Argument;
            while (bankDownloaded == false)//continues until it downloads
            {
                try
                {
                    DownloadBank();
                    Thread.Sleep(2000);//sleeps before trying
                }
                catch
                { }
            }
            GetBankBranchesList();//saves branches to ds
        }

        private void DownloadBank()
        {
            #region downloadBank
            string xmlLocalPath = @"atm.xml";
            WebClient wc = new WebClient();
            try
            {
                string xmlServerPath =
               @"https://www.boi.org.il/en/BankingSupervision/BanksAndBranchLocations/Lists/BoiBankBranchesDocs/snifim_en.xml";
                wc.DownloadFile(xmlServerPath, xmlLocalPath);
                bankDownloaded = true;
            }
            catch
            {

                string xmlServerPath = @"http://www.jct.ac.il/~coshri/atm.xml";
                wc.DownloadFile(xmlServerPath, xmlLocalPath);
                bankDownloaded = true;

            }
            finally
            {
                wc.Dispose();
            }
            #endregion
        }
    }
}
