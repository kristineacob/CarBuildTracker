using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuildTracker
{
   static class Tracker
    {
        /// <summary>
        /// Creates a new build
        /// </summary>
        /// <param name="customerName">Customer Name of build</param>
        /// <param name="vehicleType">Type of vehicle</param>
        /// <param name="initialWithdrawl">Initial Withdrawal</param>
        /// <returns>Newly created account</returns>
        public static CustomerBuild CreateCustomerBuild (string customerName, Type vehicleType =Type.Car, decimal initialWithdrawl = 0)
        {
            var customerBuild = new CustomerBuild
            {
                CustomerName = customerName,
                VehicleType = vehicleType
            };
            if (initialWithdrawl > 0)
            {
                customerBuild.Withdraw(initialWithdrawl);
            }
            return customerBuild;
        }
    }
}
