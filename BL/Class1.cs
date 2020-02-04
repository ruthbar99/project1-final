using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Project01_7735_5114_dotNet5780;

namespace BL
{
    public class BL_Impl : IBL
    {
        DAL.Dal_imp dal;

        public BL_Impl()
        {
            this.dal = new Dal_imp();
        }
        //add guest request 
        public void AddGuestRequest(GuestRequest guest)
        {
            if (guest.EntryDate >= guest.ReleaseDate) return;

            dal.AddGuestRequest(guest);
        }
        //add guest request
        public void AddHostingUnit(HostingUnit hostingUnit)
        {
            dal.AddHostingUnit(hostingUnit);
        }

        public HostingUnit returnor(int key)
        {
            foreach (var item in dal.GetAllHostingUnits())
            {
                if (item.HostingUnitKey == key)
                    return item;
            }
            return null;
        }

        public GuestRequest returngr(int key)
        {
            foreach (var item in dal.GetAllGuestRequests())
            {
                if (item.GuestRequestKey == key)
                    return item;
            }
            return null;
        }
        //add order
        public void AddOrder(Order order)
        {
            try
            {
                HostingUnit temp = returnor(order.HostingUnitKey);
                int days = countDaysBetween(order.GuestRequestKey.EntryDate, order.GuestRequestKey.ReleaseDate);
                if (temp.isAvailable(order.GuestRequestKey.EntryDate, days))
               
                    SendMail(order.GuestRequestKey);
                    dal.AddOrder(order);
                }
                catch (Exception)
                {
                   throw;
            }
        }
        //count days between two dates
        public int countDaysBetween(DateTime fromDate, Nullable<DateTime> endDate = null)
        {
            if (endDate == null) endDate = DateTime.Today;
            return (endDate.Value.Date - fromDate.Date).Days;
        }
        //count the days from today
        //public int countDaysBetween(DateTime Date)
        //{
        //    DateTime currentTime = DateTime.Now;

        //    return (Date.Date - currentTime.Date).Days;
        //}
        public List<Order> countOrders(int days)
        {
            Predicate<Order> predicate = delegate (Order order) { return ((((order.OrderDate - DateTime.Today).Days >= days) || ((order.CreateDate - DateTime.Today).Days >= days))); };
            return dal.GetAllOrders().FindAll(predicate);
        }

        public void DeleteHostingUnit(int key)
        {
            dal.DeleteHostingUnit(key);
        }

        public List<GuestRequest> GetAllGuestRequests()
        {
            return dal.GetAllGuestRequests();
        }

        public List<HostingUnit> GetAllHostingUnits()
        {
            return dal.GetAllHostingUnits();
        }

        public List<Order> GetAllOrders()
        {
            return dal.GetAllOrders();
        }

        public List<BankBranch> GetBankBranches()
        {
            return dal.GetBankBranches();
        }

        public IEnumerable<IGrouping<enum_s.Area, GuestRequest>> getGuestRequestByArea()
        {
            return from guestRequest in dal.GetAllGuestRequests() group guestRequest by guestRequest.Area;
        }

        public List<GuestRequest> GetGuestRequests(Predicate<GuestRequest> predicate)
        {
            return dal.GetAllGuestRequests().FindAll(predicate);
        }

        public IEnumerable<IGrouping<int, GuestRequest>> GetGuestRequestsByChildrensAndAdults()
        {
            return from guestRequest in dal.GetAllGuestRequests() group guestRequest by (guestRequest.Adults + guestRequest.Children);
        }

        public IEnumerable<IGrouping<enum_s.Area, HostingUnit>> GetHostingUnitsByArea()
        {
            return from hostingUnit in dal.GetAllHostingUnits() group hostingUnit by hostingUnit.Area;
        }

        public List<HostingUnit> GetHostingUnitsByDates(DateTime EntryDate, int Days)
        {
            List<HostingUnit> ret = new List<HostingUnit>();
            foreach (var item in dal.GetAllHostingUnits())
            {
                if (item.isAvailable(EntryDate, Days))
                    ret.Add(item);
            }
            return ret;
        }

        public IEnumerable<IGrouping<int, Host>> GetHostsByHostingUnits()
        {
            return from var in
                       (from hostingUnit in dal.GetAllHostingUnits() group hostingUnit by hostingUnit.Owner)
                   group var.Key by var.ToList().Count;
        }

        public int getOrdersByGuestRequest(GuestRequest request)
        {
            return (from order in dal.GetAllOrders() where order.GuestRequestKey.GuestRequestKey == request.GuestRequestKey select order).ToList().Count;
        }

        public int getOrdersByHostingUnit(HostingUnit hostingUnit)
        {
            return (from order in dal.GetAllOrders() where order.HostingUnitKey == hostingUnit.HostingUnitKey && (order.Status == enum_s.Status.sentMail || order.Status == enum_s.Status.closedForCustomerResponse) select order).ToList().Count;
        }

        public void UpdateGuestRequest(GuestRequest guest)
        {
            dal.UpdateGuestRequest(guest);
        }

        public void UpdateHostingUnit(HostingUnit hostingUnit)
        {
            dal.UpdateHostingUnit(hostingUnit);
        }

        public void UpdateOrder(Order order)
        {
            dal.UpdateOrder(order);
        }

        //send mail
        public void SendMail(GuestRequest g)
        {
            MailMessage mail = new MailMessage();
            SmtpClient Smtp = new SmtpClient();
            Smtp.Host = "Smtp.gmail.com";
            mail.From = new MailAddress("dreamvacation1000@gmail.com");
            mail.To.Add(g.MailAddress);

            mail.Subject = "הזמנה לחופשה";
            mail.Body = " !חופשה נעימה/n בקשתך התקבלה במערכת";
            mail.IsBodyHtml = true;
            //mail.Body = "This is for testing SMTP mail from GMAIL";

              Smtp.Credentials = new System.Net.NetworkCredential("dreamvacation1000@gmail.com", "ry1234567");
                Smtp.EnableSsl = true;
            try
 { 
                Smtp.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //send mail
        //public void SendEmail(Order ord)
        //{
        //    BL.BL_Impl dal;
        //    GuestRequest gr = dal.GetAllGuestRequests(x => x.GuestRequestKey == ord.GuestRequestKey).Find(x => x.GuestRequestKey == ord.GuestRequestKey);
        //    Host h = dal.getHostingUnits(hu => hu.HostingUnitKey == ord.HostingUnitKey).Find(hut => hut.HostingUnitKey == ord.HostingUnitKey).Owner;
        //    try
        //    {
        //        IsValidEmail(gr.MailAddress);
        //        IsValidEmail(h.MailAddress);
        //    }
        //    catch (InvalidOperationException a)
        //    {
        //        throw a;
        //    }
        //    new Thread(() =>
        //    {
        //        MailMessage mail = new MailMessage();
        //        mail.To.Add(gr.MailAddress);
        //        mail.From = new MailAddress("zimmersProCT@gmail.com");
        //        mail.Subject = "vacation offer";
        //        mail.Body = "Hello, I am a Host at 'Zimmers'.I have a proposition that suits your request perfectly.if you are interested in coninuing the process please contact me at " + h.MailAddress;
        //        mail.IsBodyHtml = true;
        //        SmtpClient smtp = new SmtpClient();
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.Credentials = new System.Net.NetworkCredential("zimmersProCT@gmail.com", "Prozimmers");
        //        smtp.EnableSsl = true;
        //        try
        //        {
        //            smtp.Send(mail);
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }).Start();
        //}


        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                throw new InvalidOperationException("invalid email address");
            }
        }

    }
}
