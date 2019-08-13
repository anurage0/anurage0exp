QuickOPC
========

QuickOPC is a suite of OPC Client Development Components for COM and .NET. These components are for OPC "Classic" 
(COM/DCOM-based), OPC XML-DA, and OPC Unified Architecture (Web service-based) specifications.

QuickOPC is a commercially licensed product. Without a license, it runs in a trial mode. The trial provides valid data to a 
client application for 30 minutes; after that period, the component (your app) needs to be re-started, and so on. You must 
also comply with licensing terms for 3rd-party material redistributed with QuickOPC. For details, see the documentation.

Remember that NuGet is primarily a tool for resolving build-time dependencies. The amount of functionality that you get 
through QuickOPC NuGet packages is smaller than what QuickOPC can actually do for you. If you want a full coverage of the 
features, you would be better off downloading the Setup program from http://www.opclabs.com. Further below you will find a 
list of differences between the two distribution forms.

QuickOPC requires .NET Framework 4.6.2 or .NET Core 2.0.5 as a minimum. Under .NET Core, it is supported on Linux and 
Microsoft Windows. 


List of available NuGet packages
--------------------------------
- OpcLabs.QuickOpc: OPC client components for all environments and project types.
- OpcLabs.QuickOpc.Forms: Components that are specific for Windows Forms (can be partially used from WPF as well).

- OpcLabs.QuickOpc.Sample.CS: Console-based QuickOPC examples in C# (source code).
- OpcLabs.QuickOpc.Sample.VB: Console-based QuickOPC examples in VB.NET (source code).
  

What is included in the NuGet packages
--------------------------------------
- Runtime assemblies for all OPC specifications and programming models.
- OPC browsing dialogs and browsing controls for Windows Forms.
- IntelliSense support (XML comments).
- LINQPad examples.


What is only available from the Setup program
---------------------------------------------
- Support for COM development (VB6, PHP, Excel, Delphi and similar tools).
- Documentation and Help.
- Visual Studio integration, including Live Binding design-time support (codeless creation of OPC applications).
- Complete set of Examples and Demo applications, bonus material.
- OPC Data Access simulation server, test tools.

What is only available from the Setup program or http://www.opclabs.com/products/quickopc/downloads/281-additional-files
------------------------------------------------------------------------------------------------------------------------
- Tools: Connectivity Explorer, Launcher.
- License Manager (GUI or console-based) utility.


How to start
------------
If you do not mind reading the Getting Started in the documentation: 
http://opclabs.doc-that.com/files/onlinedocs/QuickOpc/Latest/User%27s%20Guide%20and%20Reference-QuickOPC/webframe.html#Getting%20Started.html
Or, the whole User's Guide: http://www.opclabs.com/resources/documentation .

Otherwise, just instantiate one of the following objects (depending on the OPC specification), and explore its methods:

- OpcLabs.EasyOpc.DataAccess.EasyDAClient (for OPC DA, OPC XML-DA)
- OpcLabs.EasyOpc.AlarmsAndEvents.EasyAEClient (for OPC A&E)
- OpcLabs.EasyOpc.UA.EasyUAClient (for OPC Unified Architecture)


Example code
------------
using OpcLabs.EasyOpc.UA;
...

var client = new EasyUAClient();
object value = client.ReadValue(
    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer",
    "nsu=http://test.org/UA/Data/;i=10853");


Using the example packages
--------------------------
In order to run the code from console-based example packages, you need to call it from your project. The examples are 
organized by the OPC specification, and each example is a static method that you can directly invoke. For easier 
exploration, there are also methods that provide the user with a menu of methods to choose from.

For OPC Alarms&Events examples, call method:            DocExamples.AlarmsAndEvents.AEExamplesMenu.Main1
For OPC Data Access and XML-DA examples, call method:   DocExamples.DataAccess.DAExamplesMenu.Main1
For OPC Unified Architecture examples, call method:     UADocExamples.UAExamplesMenu.Main1

Alternatively, you can call just a single selected example, e.g. for reading an OPC UA node, call the
UADocExamples._EasyUAClient.Read.Main1 method.


***
