<Query Kind="Statements">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>

// Parameters that are always shared by all instances of the component.
EasyUAClient.SharedParameters
	.Dump("SharedParameters");

// Adaptable parameters for non-isolated client objects.
// When the <see cref="Isolated"/> property of the <see cref="EasyUAClient"/> is <c>false</c> (the default), these 
// adaptable parameters are used. When the <see cref="Isolated"/> property is <c>true</c>, each such instance has 
// its own set of adaptable parameters, taken from the <see cref="IsolatedParameters"/> property instead.
EasyUAClient.AdaptableParameters
	.Dump("AdaptableParameters");
