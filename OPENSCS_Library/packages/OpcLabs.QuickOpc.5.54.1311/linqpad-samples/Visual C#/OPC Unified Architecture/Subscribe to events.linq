<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.AddressSpace</Namespace>
</Query>

new EasyUAClient()
	.SubscribeEvent(
		"opc.tcp://opcua.demo-this.com:62544/Quickstarts/AlarmConditionServer",
		UAObjectIds.Server,
		1000,
		(sender, eventArgs) => eventArgs.Dump(1));
Thread.Sleep(10*1000);