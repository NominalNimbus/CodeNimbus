  
########################################################################  
 This project is subject to the terms of the Mozilla Public  
 License, v. 2.0. If a copy of the MPL was not distributed with this  
 file, You can obtain one at http://mozilla.org/MPL/2.0/  
 Any copyright is dedicated to the NominalNimbus.  
 https://github.com/NominalNimbus  
########################################################################
  
**_NominalNimbus_ project is a client <=> server Trading Platform with stron focus on Algorithmic Trading with build in features like:**  
**+ .net Scripting Library on client side**  
**+ Server Side headless deployment of trading algos**  
**+ Backtesting Engine**  
**+ Periodically Backtest your Trading Algo during runtime to adjust its parameters on actual market situations**  
**+ Marging Broker and Non-Marging Broker Simulation**  
**+ Combine real market datafeed with Broker-Account Simulation to test your trading ideas**  
**+ LMAX API for Demo & Live Trading**  
**+ Poloniex API for Live Trading**    
  
  
# CodeNimbus
.net User Code environment with integrated debuging to create and debug custom Signals.  
This is the entire scripting engine for creating trading rules (Signals) or any possible dataevaluation scropts or Portfolio watch dogs... 
It contains a Service and Client mockup to make it possible to debug custom code as it would run in production environment.  
Just start the app in "Debug Mode" inside Visual Studio to use the sipmle GUI as data input mochup to cal you break points...

Important Note:  
ClientNimbus creates new signals from an *.zip folder* of this project.
Please make sure that you replace this zip file with yours to make your modification available inside ClientNimbus.

Important Note:  
Please make **Backtest.dll , CommonObjects.dll , UserCode.dll** from Servicenimbus available.  
Normally they are downloaded automatically during first successfull ClientNimbus connection.
.  
.  
### Donation to keep this up and running:
IOTA: FKD9BYAHVBMDDW9DQBBTOFJEHFWZNTYB9UBHPBMABACHFMGGQIBVBLLDLEWYXOGAGGVZVCPVVXHUFTJU9YGNADFNGW  
ETH:  0x88920B317625fDfe27A8a2353A1173D3097083D2
