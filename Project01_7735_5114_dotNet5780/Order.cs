using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE Order
//Connects the client to a hosting unit
namespace Project01_7735_5114_dotNet5780
{
    public class Order : IClonable
    {
        private int hostingUnitKey;
        public int HostingUnitKey { get => hostingUnitKey; set => hostingUnitKey = value; }
        private GuestRequest guestRequestKey;
        public GuestRequest GuestRequestKey { get => guestRequestKey; set => guestRequestKey = value; }
        private int orderKey;
        public int OrderKey { get => orderKey; set => orderKey = value; }
        private enum_s.Status status;
        public enum_s.Status Status { get => status; set => status = value; }
        private DateTime createDate;
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        private DateTime orderDate;
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public override string ToString()
        {
            return (HostingUnitKey + "\n" + GuestRequestKey + "\n" + OrderKey
                + "\n" + Status + "\nCreateDate: " + CreateDate + "\nOrderKey: " + OrderKey);
        }

    }
}
