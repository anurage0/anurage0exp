<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>

// Note that this only works once in each application domain. 
// Re-running the query in LINQPad results in no dump, until the appdomain is unloaded.

EasyUAClient.SharedParameters.EngineParameters.ApplicationParameters.ApplicationName = "My Application";
EasyUAClient.SharedParameters.EngineParameters.ApplicationParameters.ApplicationUriString = "http://opcua.demo-this.com/MyApplication";	// optional

// Dump the loggable entry containing client certificate parameters.
EasyUAClient.LogEntry += (sender, e) => { if (e.EventId == 161/*UAEngineEventIds.ClientInstanceCertificateParameters*/) e.Dump(); };

// Do something - invoke an OPC read, to trigger loggable entries.
new EasyUAClient().ReadValue("http://opcua.demo-this.com:51211/UA/SampleServer", "nsu=http://test.org/UA/Data/;i=10853");

// The certificate will be located or created in a directory similar to:
// C:\ProgramData\OPC Foundation\CertificateStores\MachineDefault\certs
// or
// C:\Users\All Users\OPC Foundation\CertificateStores\UA Applications\certs\
// and its subject will be as given by the application name.