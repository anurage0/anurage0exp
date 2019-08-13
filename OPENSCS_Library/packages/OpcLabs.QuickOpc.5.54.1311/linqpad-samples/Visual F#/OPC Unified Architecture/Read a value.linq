<Query Kind="FSharpExpression">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>

(new EasyUAClient())
	.ReadValue(
		UAEndpointDescriptor.op_Implicit "http://opcua.demo-this.com:51211/UA/SampleServer",
		UANodeDescriptor.op_Implicit "nsu=http://test.org/UA/Data/;i=10853")