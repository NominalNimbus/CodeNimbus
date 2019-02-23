/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
 */

using System.Collections.Generic;
using System.Xml.Serialization;

namespace DebugService.Classes
{
    public class Workspace
    {
        public double Bid { get; set; }

        public double Ask { get; set; }

        public System.DateTime Date { get; set; }

        public double AskSize { get; set; }

        public double BidSize { get; set; }

        [XmlArray("Accounts"), XmlArrayItem("Account", typeof(AccountInfo))]
        public List<AccountInfo> Accounts { get; set; }

        [XmlArray("HistoricalDataCollections"), XmlArrayItem("HistoricalData", typeof(HistoricalData))]
        public List<HistoricalData> HistoricalDataCollections { get; set; }

        public Workspace()
        {
            Accounts = new List<AccountInfo>();
            HistoricalDataCollections = new List<HistoricalData>();
        }
    }
}
