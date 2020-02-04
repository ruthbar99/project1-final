using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE GuestRequest
namespace Project01_7735_5114_dotNet5780
{
    public class GuestRequest : IClonable
    {
        private int guestRequestKey;
        public int GuestRequestKey { get => guestRequestKey; set => guestRequestKey = value; }
        private string privateName;
        public string PrivateName { get => privateName; set => privateName = value; }
        private string familyName;
        public string FamilyName { get => familyName; set => familyName = value; }
        private string mailAddress;
        public string MailAddress { get => mailAddress; set => mailAddress = value; }
        //public string PhoneNumber { get; set; }
        private enum_s.Status status;
        public enum_s.Status Status { get => status; set => status = value; }
        private DateTime registrationDate;
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
        private DateTime entryDate;
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
        private DateTime releaseDate;
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        private enum_s.Area area;
        public enum_s.Area Area { get => area; set => area = value; }
        private enum_s.Type type;
        public enum_s.Type Type { get => type; set => type = value; }
        private int adults;
        public int Adults { get => adults; set => adults = value; }
        private int children;
        public int Children { get => children; set => children = value; }
        //public int Rooms { get; set; }
        private enum_s.Answer pool;
        public enum_s.Answer Pool { get => pool; set => pool = value; }
        private enum_s.Answer jacuzzi;
        public enum_s.Answer Jacuzzi { get => jacuzzi; set => jacuzzi = value; }
        private enum_s.Answer garden;
        public enum_s.Answer Garden { get => garden; set => garden = value; }
        private enum_s.Answer childrensAttractions;
        public enum_s.Answer ChildrensAttractions { get => childrensAttractions; set => childrensAttractions = value; }
        private enum_s.Answer smokingArea;
        public enum_s.Answer SmokingArea { get => smokingArea; set => smokingArea = value; }
        private bool accessible;
        public bool Accessible { get => accessible; set => accessible = value; }//Accessibility for the disabled
        public override string ToString()
        {
            return ("מספר הזמנה: " + GuestRequestKey + ":\n" +
                   "סטטוס: " + Status + "\n" +
                   "שם מלא: " + PrivateName + " " + FamilyName + "\n" +
                    "מייל: " + MailAddress + "\n" +
                    "נוצר בתאריך: " + RegistrationDate.ToString("dd/MM/yyyy") + "\n" +
                    "תאריכים: " + EntryDate.ToString("dd/MM/yyyy") + "-" + ReleaseDate.ToString("dd/MM/yyyy") + "\n" +
                    "סוג: " + Type + "\n" +
                    "אזור: " + Area + "," +
                    "מבוגרים: " + Adults + "\n" +
                    "ילדים: " + children + "\n" +
                    "בריכה: " + pool + "\n" +
                    "ג'קוזי: " + Jacuzzi + "\n" +
                    "גינה: " + Garden + "\n" +
                    "פעילות: " + ChildrensAttractions + "\n"
                  );
        }



    }
}

