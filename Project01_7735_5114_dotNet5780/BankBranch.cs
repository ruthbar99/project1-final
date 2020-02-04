using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE BankBranch
namespace Project01_7735_5114_dotNet5780
{
    public class BankBranch : IClonable
    {
        private int bankNumber;
        public int BankNumber { get => bankNumber; set => bankNumber = value; }
        private string bankName;
        public string BankName { get => bankName; set => bankName = value; }
        private int branchNumber;
        public int BranchNumber { get => branchNumber; set => branchNumber = value; }
        private string branchAddress;
        public string BranchAddress { get => branchAddress; set => branchAddress = value; }
        private string branchCity;
        public string BranchCity { get => branchCity; set => branchCity = value; }
        public override string ToString()
        {
            return "Bank Name: " + BankName.ToString() + " - " + BankNumber + ", BranchNumber:  " + BranchNumber
                + "\n BranchName: " + BranchAddress + ", " + BranchCity;
        }

    }
}
