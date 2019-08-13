<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>

new EasyUAClient()
	.WriteValue(
		"http://opcua.demo-this.com:51211/UA/SampleServer",
		"nsu=http://test.org/UA/Data/;i=10221",
		12345);