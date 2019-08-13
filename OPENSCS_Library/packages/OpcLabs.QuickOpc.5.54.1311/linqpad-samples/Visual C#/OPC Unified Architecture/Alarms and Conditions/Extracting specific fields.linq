<Query Kind="Program">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.AddressSpace</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.AlarmsAndConditions</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.Filtering</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.OperationModel</Namespace>
</Query>

void Main()
{
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
			EventNotification,
			state:null);
	Thread.Sleep(30*1000);
}

void EventNotification(object sender, EasyUAEventNotificationEventArgs e)
{
	if (e.EventData == null)
		return;

	// Extracting a specific field using a standard operand symbol
	e.EventData.FieldResults[UABaseEventObject.Operands.SourceName].Dump("Source name");
	// Extracting a specific field using an event type ID and a simple relative path
	e.EventData.FieldResults[UAFilterElements.SimpleAttribute(UAObjectTypeIds.BaseEventType, "/Message")].Dump("Message");
}
