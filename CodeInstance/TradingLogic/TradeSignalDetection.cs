/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonObjects;
using UserCode;
using System.Threading.Tasks;

namespace TradingLogic
{
    public static class TradeSignalDetection
    {
        /// <summary>
        /// User, Please Describe In Short What The Signal Is Doing ...
        /// This signal sends alternatly Buy/Sell orders each time its called depending on its start event.
        /// </summary>
        /// 
        /// <param name="signalBase"> Passed base class of signal usercode engine. </param>
        /// 
        /// <param name="historicMarketData"> All marked data of all instrument in signals scope up to latest quotes.
        ///                                   ### Use this parameter if your Signal should process historical market data from all provided instruments. ### </param>
        ///                          
        /// <param name="tradeParams"> Contains all parameters needed to trade the signal.
        ///                            ### Use this parameter to change/override Signal Properties from "InternelGet-/SetParameter()" method. ### </param>
        ///                            
        /// <param name="trigInstrData"> When start event is NewBar or NewQuote, the instruments market data triggered the event.
        ///                              ### Use this parameter if your Signal should process the updated instument only. ### </param>
        ///                              
        /// <param name="queuedTicks"> During NewQuote start event, it happens that ticks are missed during calculation. 
        ///                            This missed ticks are queued and passed in 'queuedTicks' for next start event. 
        ///                            The most recent tick from "Trigger Instrument" is added as LAST element so all recent unprocessed ticks are passed
        ///                            within "queuedTicks" parameter.
        ///                            ### Use this parameter if your Signal works on tick level and you don't want to miss any tick. ### </param>
        /// 
        /// <returns> Returns a list of trade signals for execution market or backtest. </returns>

        public static List<TradeSignal> DetectSignals(SignalBase signalBase, Dictionary<Selection, IEnumerable<Bar>> historicMarketData,
                                                    Auxiliaries.ExecuteTradesParam tradeParams,
                                                    Dictionary<Selection, IEnumerable<Bar>> trigInstrData = null,
                                                    IEnumerable<Tick> queuedTicks = null)
        {
            tradeParams.EvalCount++;
            var trades = new List<TradeSignal>();
            Side side = Side.Sell;

            foreach (var item in historicMarketData)
            {
                if (tradeParams.EvalCount % 2 == 0) { side = Side.Buy; }
                else { side = Side.Sell; }

                trades.Add(new TradeSignal
                {
                    Instrument = item.Key,
                    Time = item.Value.Last().Date,
                    Price = item.Value.Last().MeanClose,
                    Side = side
                });
            }
            return trades;
        }
    }
}