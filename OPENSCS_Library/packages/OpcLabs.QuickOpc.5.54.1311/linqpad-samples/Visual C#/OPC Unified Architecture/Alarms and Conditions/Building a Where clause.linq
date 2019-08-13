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
		new UAEventFilterBuilder(
			// Either the severity is >= 500, or the event comes from a specified source node
			UAFilterElements.Or(
				UAFilterElements.GreaterThanOrEqual(UABaseEventObject.Operands.Severity, 500),
				UAFilterElements.Equals(
					UABaseEventObject.Operands.SourceNode, 
					new UANodeId("nsu=http://opcfoundation.org/Quickstarts/AlarmCondition;ns=2;s=1:Metals/SouthMotor"))),
			UABaseEventObject.AllFields),
		(sender, eventArgs) => eventArgs.Dump(1),
		state:null);
Thread.Sleep(30*1000);