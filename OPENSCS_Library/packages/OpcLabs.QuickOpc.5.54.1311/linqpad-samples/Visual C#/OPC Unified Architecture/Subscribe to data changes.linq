<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>

new EasyUAClient()
	.SubscribeDataChange(
		"http://opcua.demo-this.com:51211/UA/SampleServer",
		"nsu=http://test.org/UA/Data/;i=10853",
		1000,
		(sender, eventArgs) => eventArgs.Dump(1));
Thread.Sleep(10*1000);