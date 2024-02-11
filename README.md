Here's the documentation for adding your service installation, starting, stopping, and uninstallation commands to a readme file in Markdown format:

```markdown
# UpgradeData Service

This document provides instructions for managing the "UpgradeData" service using PowerShell commands.

## Installation

To install the "UpgradeData" service, run the following command in PowerShell as an administrator:

```powershell
New-Service -Name "UpgradeData" -BinaryPathName "D:\Prjs\UpgradeData\UpgradeData\bin\Release\UpgradeData.exe"
```

## Start Service

To start the "UpgradeData" service, run the following command in PowerShell:

```powershell
Start-Service -Name "UpgradeData"
```

## Stop Service

To stop the "UpgradeData" service, run the following command in PowerShell:

```powershell
Stop-Service -Name "UpgradeData"
```

## Uninstallation

To uninstall the "UpgradeData" service, run the following command in PowerShell as an administrator:

```powershell
sc.exe delete "UpgradeData"
```

Note: Make sure to replace `"D:\Prjs\UpgradeData\UpgradeData\bin\Release\UpgradeData.exe"` with the actual path to your service executable, and `"UpgradeData"` with your desired service name.


## Visual Studio 2022 Command
To upgrade the instructions for Visual Studio 2022 and .NET Framework 4.8, follow these steps:

### Adding Installer to Service

1. Open your `Service1.cs` file in Visual Studio 2022.

2. Right-click on the editor window and select "Add Installer". This will generate a new file called `ProjectInstaller.cs`.

3. Open `ProjectInstaller.cs`. You'll see two components: `serviceInstaller1` and `serviceProcessInstaller1`.

4. Set properties for `serviceInstaller1`:
   - Change `ServiceName` to "Test Windows Service" or your desired name.
   - Set `StartType` to "Manual" or "Automatic" as per your requirement.

5. Set properties for `serviceProcessInstaller1`:
   - Change `Account` to "LocalSystem".

6. Build the project. You'll find the `.exe` file in the output directory.

### Installing the Windows Service

1. Open "Visual Studio 2022".

2. Go to "Developer Command Prompt for VS2022".

3. Navigate to the directory where your `.exe` file is located using the `cd` command. For example:
   ```
   cd /d C:\Sandbox\WindowServices\TestWindowService\TestWindowService\bin\Debug
   ```

4. Install the service using the following command:
   ```
   installutil UpgradeData.exe
   ```

### Uninstalling the Windows Service

To uninstall the service, you can use the `installutil` with the `/u` parameter:
```
installutil /u UpgradeData.exe
```

These steps should help you upgrade the instructions for adding an installer to your Windows service in Visual Studio 2022 targeting .NET Framework 4.8.
