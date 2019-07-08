using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuildTracker
{

    enum Type
    {
        Car,
        Truck,
        Cycle

    }
    class CustomerBuild
    {
        private static int lastBuildNumber = 0;

#region Properties

        public int BuildNumber { get; set; }
        public string CustomerName { get; set; }
        public long VinNumber { get; set; }
        public Type VehicleType { get; set; }
        public int YearMakeModel { get; set; }
        public decimal Balance { get; set; }
        public DateTime BuildStartDate { get; set; }
        public DateTime BuildGoalDate { get; set; }
        #endregion

        #region Constructors

        public CustomerBuild()
        {
            BuildNumber = ++lastBuildNumber;
            BuildStartDate = DateTime.Now;
        }
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
