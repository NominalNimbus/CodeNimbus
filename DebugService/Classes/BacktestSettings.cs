/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
 */

namespace DebugService.Classes
{
    public class BacktestSettings
    {
        public System.DateTime StartDate { get; set; }

        public System.DateTime EndDate { get; set; }

        public int BarsBack { get; set; }

        public decimal InitialBalance { get; set; }

        public decimal Risk { get; set; }

        public decimal TransactionCosts { get; set; }

        public BacktestSettings()
        {

        }
    }
}