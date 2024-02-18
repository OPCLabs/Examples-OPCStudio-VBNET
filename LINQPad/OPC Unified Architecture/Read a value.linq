<Query Kind="VBExpression">
  <NuGetReference>OpcLabs.QuickOpc</NuGetReference>
  <Namespace>OpcLabs.EasyOpc.UA</Namespace>
</Query>
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

New EasyUAClient() _
	.ReadValue(
		"opc.tcp://opcua.demo-this.com:51210/UA/SampleServer",
		"nsu=http://test.org/UA/Data/;i=10853")