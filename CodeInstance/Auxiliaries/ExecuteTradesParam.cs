/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
 */

using System.Collections.Generic;
using CommonObjects;
using UserCode;

namespace Auxiliaries
{
    public class ExecuteTradesParam
    {
        public IDataProvider DataFeed { get; set; }
        public List<string> TradeableSymbols { get; set; }
        public int EvalCount { get; set; }
        public decimal OrderQuantity { get; set; }
        public TradeType OrderType { get; set; }
        public decimal BuyPriceOffset { get; set; }
        public decimal SellPriceOffset { get; set; }
        public decimal? SL { get; set; }
        public decimal? TP { get; set; }
        public TimeInForce TIF{ get; set; }
        public bool HideSL { get; internal set; }
        public bool HideTP { get; internal set; }
        public bool HideOrder { get; set; }
    }
}