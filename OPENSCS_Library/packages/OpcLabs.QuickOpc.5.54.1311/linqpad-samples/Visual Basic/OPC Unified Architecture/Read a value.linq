<Query Kind="VBExpression">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>

New EasyUAClient() _
	.ReadValue(
		"http://opcua.demo-this.com:51211/UA/SampleServer",
		"nsu=http://test.org/UA/Data/;i=10853")