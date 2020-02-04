using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE Host
namespace Project01_7735_5114_dotNet5780
{
    public class Host:IClonable
    {
        private int hostKey;
        public int HostKey { get => hostKey; set => hostKey = value; }//id
        private string privateName;
        public string PrivateName { get => privateName; set => privateName = value; }
        private string familyName;
        public string FamilyName { get => familyName; set => familyName = value; }
        private string phoneNumber;
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        private string mailAddress;
        public string MailAddress { get => mailAddress; set => mailAddress = value; }
        private BankBranch bankBranchDetails;
        public BankBranch BankBranchDetails { get => bankBranchDetails; set => bankBranchDetails = value; }
        private int bankAccountNumber;
        public int BankAccountNumber { get => bankAccountNumber; set => bankAccountNumber = value; }
        private bool collectionCearance;
        public bool CollectionCearance { get => collectionCearance; set => collectionCearance = value; }
        public override string ToString()
        {
            return (HostKey + ", " + PrivateName + " " + FamilyName + "\n" + MailAddress
                + "\n" + BankAccountNumber.ToString() + "\nCollectionClearance: " + CollectionCearance);
        }

    }
}
