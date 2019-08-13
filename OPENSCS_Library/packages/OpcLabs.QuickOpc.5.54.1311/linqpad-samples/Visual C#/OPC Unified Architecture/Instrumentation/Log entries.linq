<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>


// Dump the loggable entries originating in the OPC-UA client engine and the EasyUAClient component.
EasyUAClient.LogEntry += (sender, e) => e.Dump();

// Do something - invoke an OPC read, to trigger some loggable entries.
new EasyUAClient().ReadValue("http://opcua.demo-this.com:51211/UA/SampleServer", "nsu=http://test.org/UA/Data/;i=10853");
		
Thread.Sleep(10*1000);