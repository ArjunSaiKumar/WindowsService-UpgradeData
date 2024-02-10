# UpgradeData

Now return to the Service1.cs [Design] and **right-click** on the editor window then click **"Add Installer".**
Then you can see that there will be a new file called "ProjectInstaller.cs" as shown in the following.
Right-click on the "serviceInstaller1" and click "Properties".
Change the ServiceName to "Test Windows Service" (or your own name) and StartType to "Manual" (or you can choose "Automatic" if you need this service to be automatic).
Right-click the serviceProcessInstaller1, go to the properties window and change "Account" to "LocalSystem".
Build the project to see the .exe file at the location where you created the solution.


Installing the Windows Service
Go to "Start" >> "All Programs" >> "Microsoft Visual Studio 2012" >> "Visual Studio Tools" then click "Developer Command Prompt for VS2012".

Type the following command:

cd <physical location of your TestWindowService.exe file>
in my case it is :
cd C:\Sandbox\WindowServices\TestWindowService\TestWindowService\bin\Debug

Next type the following command:
**installutil UpgradeData.exe
and press Enter.**

To uninstall
**installutil /u UpgradeData.exe**

