using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE HostingUnit
namespace Project01_7735_5114_dotNet5780
{
    public class HostingUnit : IClonable
    {
        private int hostingUnitKey;
        public int HostingUnitKey { get => hostingUnitKey; set => hostingUnitKey = value; }
        private Host owner;
        public Host Owner { get => owner; set => owner = value; }
        private string hostingUnitName;
        public string HostingUnitName { get => hostingUnitName; set => hostingUnitName = value; }
        private enum_s.Area area;
        public enum_s.Area Area { get => area; set => area = value; }
        private enum_s.Type type;
        public enum_s.Type Type { get => type; set => type = value; }
        private int adults;
        public int Adults { get => adults; set => adults = value; }
        private int children;
        public int Children { get => children; set => children = value; }
        private bool pool;
        public bool Pool { get => pool; set => pool = value; }
        private bool jacuzzi;
        public bool Jacuzzi { get => jacuzzi; set => jacuzzi = value; }
        private bool garden;
        public bool Garden { get => garden; set => garden = value; }
        private bool childrensAttractions;
        public bool ChildrensAttractions { get => childrensAttractions; set => childrensAttractions = value; }
        private bool smokingArea;
        public bool SmokingArea { get => smokingArea; set => smokingArea = value; }
        private bool accessible;
        public bool Accessible { get => accessible; set => accessible = value; }//Accessibility for the disabled
        public bool[,] Diary = new bool[12, 31];
        public HostingUnit()
        {
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    Diary[i, j] = false;
                }
            }
        }

        public bool isAvailable(DateTime date, int days)
        {
            while ((days - 1) >= 0)
            {
                DateTime d = date.AddDays(days);
                if (Diary[d.Month - 1, d.Day - 1]) return false;
                days--;
            }
            return true;
        }
        public override string ToString()
        {
            return HostingUnitName + ", " + HostingUnitKey + "\n";
        }

    }
}
