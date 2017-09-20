using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo
{
    class Compact : Vehicle
    {

        public void Drive(IDrive driver)
        {
            driver.StartCar();
        }

    }
}
