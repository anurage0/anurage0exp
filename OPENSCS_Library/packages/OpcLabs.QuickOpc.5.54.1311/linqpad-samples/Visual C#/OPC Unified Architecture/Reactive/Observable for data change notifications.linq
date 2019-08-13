<Query Kind="Expression">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
  <Namespace>OpcLabs.EasyOpc.UA.Reactive</Namespace>
</Query>

UADataChangeNotificationObservable.Create<int>(
	"http://opcua.demo-this.com:51211/UA/SampleServer",
	"nsu=http://test.org/UA/Data/;i=11017",
	100)