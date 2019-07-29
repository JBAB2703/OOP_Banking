﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_BankingProject {
    public class Savings : Account {

        public double IntRate { get; set; } = 0.03;

        public bool ChangeRate(double chgRate) {
            if((this.IntRate + chgRate) < 0) {
                return false;
            }
            this.IntRate += chgRate;
            return true;
        }

        public override string Print() {
            return base.Print() + $" | {IntRate}";
        }

        public void PayInterest(decimal amountOfInterest) {
            this.Deposit(amountOfInterest);
        }
        public decimal CalcInterest(int months) {
            double interestToBePaid = this.IntRate / 12 * months * (double)this.GetBalance();
            return (decimal)interestToBePaid;
        }
    }
}
