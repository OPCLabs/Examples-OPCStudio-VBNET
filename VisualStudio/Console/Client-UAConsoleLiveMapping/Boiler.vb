
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.BaseLib.LiveMapping
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.LiveMapping


' The Boiler and its constituents are described in our application domain terms, the way we want to work with them.
' Attributes are used to describe the correspondence between our types and members, and OPC nodes.

' This is how the boiler looks in OPC address space:
'  - Boiler #1
'      - CC1001                    (CustomController)
'          - ControlOut
'          - Description
'          - Input1
'          - Input2
'          - Input3
'      - Drum1001                  (BoilerDrum)
'          - LIX001                (LevelIndicator)
'              - Output
'      - FC1001                    (FlowController)
'          - ControlOut
'          - Measurement
'          - SetPoint
'      - LC1001                    (LevelController)
'          - ControlOut
'          - Measurement
'          - SetPoint
'      - Pipe1001                  (BoilerInputPipe)
'          - FTX001                (FlowTransmitter)
'              - Output
'      - Pipe1002                  (BoilerOutputPipe)
'          - FTX002                (FlowTransmitter)
'              - Output

<UANamespace("http://opcfoundation.org/UA/Boiler/"), UAType()> _
Friend Class Boiler
    ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

    <UANode(BrowsePath:="/PipeX001")> _
    Public InputPipe As New BoilerInputPipe()

    <UANode(BrowsePath:="/DrumX001")> _
    Public Drum As New BoilerDrum()

    <UANode(BrowsePath:="/PipeX002")> _
    Public OutputPipe As New BoilerOutputPipe()

    <UANode(BrowsePath:="/FCX001")> _
    Public FlowController As New FlowController()

    <UANode(BrowsePath:="/LCX001")> _
    Public LevelController As New LevelController()

    <UANode(BrowsePath:="/CCX001")> _
    Public CustomController As New CustomController()
End Class

<UAType()> _
Friend Class BoilerInputPipe
    ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

    <UANode(BrowsePath:="/FTX001")> _
    Public FlowTransmitter1 As New FlowTransmitter()

    <UANode(BrowsePath:="/ValveX001")> _
    Public Valve As New Valve()
End Class

<UAType()> _
Friend Class BoilerDrum
    ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

    <UANode(BrowsePath:="/LIX001")> _
    Public LevelIndicator As New LevelIndicator()
End Class

<UAType()> _
Friend Class BoilerOutputPipe
    ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

    <UANode(BrowsePath:="/FTX002")> _
    Public FlowTransmitter2 As New FlowTransmitter()
End Class

<UAType()> _
Friend Class FlowController
    Inherits GenericController

End Class

<UAType()> _
Friend Class LevelController
    Inherits GenericController

End Class

<UAType()> _
Friend Class CustomController
    <UANode(), UAData(Operations:=UADataMappingOperations.Write)>
    Public Property Input1 As Double

    <UANode(), UAData(Operations:=UADataMappingOperations.Write)>
    Public Property Input2 As Double

    <UANode(), UAData(Operations:=UADataMappingOperations.Write)>
    Public Property Input3 As Double

    <UANode(), UAData(Operations:=UADataMappingOperations.ReadAndSubscribe)>
    Public Property ControlOut As Double

    <UANode(), UAData()>
    Public Property Description As String
End Class

<UAType()> _
Friend Class FlowTransmitter
    Inherits GenericSensor

End Class

<UAType()> _
Friend Class Valve
    Inherits GenericActuator

End Class

<UAType()> _
Friend Class LevelIndicator
    Inherits GenericSensor

End Class

<UAType()> _
Friend Class GenericController
    <UANode(), UAData(Operations := UADataMappingOperations.ReadAndSubscribe)>
    Public Property Measurement As Double

    <UANode(), UAData()>
    Public Property SetPoint As Double

    <UANode(), UAData(Operations:=UADataMappingOperations.ReadAndSubscribe)>
    Public Property ControlOut As Double
End Class

<UAType()> _
Friend Class GenericSensor
    ' Meta-members are filled in by information collected during mapping, and allow access to it later from your code.
    ' Alternatively, you can derive your class from UAMappedNode, which will bring in many meta-members automatically.
    <MetaMember("NodeDescriptor")>
    Public Property NodeDescriptor As UANodeDescriptor

    <UANode(), UAData(Operations:=UADataMappingOperations.ReadAndSubscribe)>
    Public Property Output() As Double ' no OPC writing
        Get
            Return _output
        End Get
        Set(ByVal value As Double)
            _output = value
            Console.WriteLine("Sensor ""{0}"" output is now {1}.", NodeDescriptor, value)
        End Set
    End Property

    Private _output As Double
End Class

<UAType()> _
Friend Class GenericActuator
    <UANode(), UAData(Operations := UADataMappingOperations.Write)>
    Public Property Input As Double
End Class