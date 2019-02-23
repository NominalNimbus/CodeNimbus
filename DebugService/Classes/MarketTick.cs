/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
 */

using System;

namespace DebugService.Classes
{
    public class MarketTick : ICloneable
    {
        public int Level { get; set; }
        public decimal BidPrice { get; set; }
        public long BidSize { get; set; }
        public decimal AskPrice { get; set; }
        public long AskSize { get; set; }
        public DateTime Time { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}