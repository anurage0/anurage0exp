<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.AddressSpace</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.AlarmsAndConditions</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.Filtering</Namespace>
</Query>

new EasyUAClient()
	.SubscribeEvent(
		"opc.tcp://opcua.demo-this.com:62544/Quickstarts/AlarmConditionServer",
		UAObjectIds.Server,
		1000,
		new UAAttributeFieldCollection
		{
			// Select specific fields using standard operand symbols
			UABaseEventObject.Operands.NodeId,
			UABaseEventObject.Operands.SourceNode,
			UABaseEventObject.Operands.SourceName,
			UABaseEventObject.Operands.Time,
	
			// Select specific fields using an event type ID and a simple relative path
			UAFilterElements.SimpleAttribute(UAObjectTypeIds.BaseEventType, "/Message"),
			UAFilterElements.SimpleAttribute(UAObjectTypeIds.BaseEventType, "/Severity"),
		},
		(sender, eventArgs) => eventArgs.Dump(1),
		state:null);
Thread.Sleep(30*1000);