<Query Kind="Expression">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>

new EasyUAClient()
	.Read(
		"http://opcua.demo-this.com:51211/UA/SampleServer",
		"nsu=http://test.org/UA/Data/;i=10853")
