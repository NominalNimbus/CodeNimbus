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
