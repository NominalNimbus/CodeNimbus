/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
 */

namespace DebugService.Classes
{
    public class SimulatedDataParameters
    {
        public string Symbol;
        public int SecurityId;
        public string DataFeed;
        public Periodicity Periodicity;
        public int Interval;
        public int BarsCount;
        public int TicksCount;
        public int MarketLevels;
        public double PriceMax;
        public double PriceMin;
        public int Slot;
    }
}
