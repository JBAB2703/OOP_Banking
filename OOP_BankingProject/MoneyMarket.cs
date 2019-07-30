using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_BankingProject {
    public class MoneyMarket : Account {

        public double MMIntRate { get; set; } = .03;

        public override string Print() {  //Example of Polymorphism
            return base.Print() + $" | {MMIntRate}";
        }
        public void PayInterest(int months) {
            double InterestToBePaid = this.MMIntRate / 12 * months * (double)this.GetBalance();
            decimal intToBePaidAsDecimal = (decimal)InterestToBePaid;
            this.Deposit(intToBePaidAsDecimal);
        }
    }
}
