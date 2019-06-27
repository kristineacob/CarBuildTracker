using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuildTracker
{
    class Build
    {
#region Properties

        public int VinNumber { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Balance { get; set; }
        public DateTime BuildStartDate { get; set; }
        public DateTime BuildGoalDate { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Amount taken out from Balance
        /// </summary>
        /// <param name="amount">Amount to be taken out from balance</param>
        /// <returns></returns>
        public decimal Withdraw(decimal amount)
        {
            Balance += amount;
            return Balance;
        }
            #endregion
    }
}
