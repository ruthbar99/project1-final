using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project01_7735_5114_dotNet5780;

namespace DAL
{
    public static class Cloning
    {
        public static HostingUnit Clone(this HostingUnit original)
        {
            HostingUnit target = new HostingUnit();
            target.HostingUnitKey = original.HostingUnitKey;
            target.Owner = original.Owner;
            target.HostingUnitName = original.HostingUnitName;
            target.Area = original.Area;
            target.Type = original.Type;
            target.Adults = original.Adults;
            target.Children = original.Children;
            target.Pool = original.Pool;
            target.Jacuzzi = original.Jacuzzi;
            target.Garden = original.Garden;
            target.ChildrensAttractions = original.ChildrensAttractions;
            target.SmokingArea = original.SmokingArea;
            target.Accessible = original.Accessible;
            target.Diary = original.Diary;
            return target;
        }
        public static GuestRequest Clone(this GuestRequest original)
        {
            GuestRequest target = new GuestRequest();
            target.GuestRequestKey = original.GuestRequestKey;
            target.PrivateName = original.PrivateName;
            target.FamilyName = original.FamilyName;
            target.MailAddress = original.MailAddress;
            target.Status = original.Status;
            target.RegistrationDate = original.RegistrationDate;
            target.EntryDate = original.EntryDate;
            target.ReleaseDate = original.ReleaseDate;
            target.Area = original.Area;
            target.Type = original.Type;
            target.Adults = original.Adults;
            target.Children = original.Children;
            target.Pool = original.Pool;
            target.Jacuzzi = original.Jacuzzi;
            target.Garden = original.Garden;
            target.ChildrensAttractions = original.ChildrensAttractions;
            target.SmokingArea = original.SmokingArea;
            target.Accessible = original.Accessible;
            return target;
        }
        public static Host Clone(this Host original)
        {
            Host target = new Host();
            target.HostKey = original.HostKey;
            target.BankBranchDetails = original.BankBranchDetails;
            target.BankAccountNumber = original.BankAccountNumber;
            target.CollectionCearance = original.CollectionCearance;
            target.FamilyName = original.FamilyName;
            target.PhoneNumber = original.PhoneNumber;
            target.MailAddress = original.MailAddress;
            target.PrivateName = original.PrivateName;
            return target;
        }
        //public static SiteOwner1 Clone(this SiteOwner1 original)
        //{
        //    SiteOwner1 target = new SiteOwner1();
        //    target.Passwords = original.Passwords;
        //   // target.Commission = original.Commission;

        //    return target;
        //}
        public static BankBranch Clone(this BankBranch original)
        {
            BankBranch target = new BankBranch();
            target.BankName = original.BankName;
            target.BankNumber = original.BankNumber;
            target.BranchAddress = original.BranchAddress;
            target.BranchCity = original.BranchCity;
            target.BranchNumber = original.BranchNumber;
            return target;
        }
        public static Order Clone(this Order original)
        {
            Order target = new Order();
            target.CreateDate = original.CreateDate;
            target.GuestRequestKey = original.GuestRequestKey;
            target.HostingUnitKey = original.HostingUnitKey;
            target.OrderDate = original.OrderDate;
            target.OrderKey = original.OrderKey;
            target.Status = original.Status;
            return target;
        }
    }
}