
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System.ServiceModel


' NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
<ServiceContract()> _
Public Interface IService1

    <OperationContract()> _
    Function GetData() As String
End Interface