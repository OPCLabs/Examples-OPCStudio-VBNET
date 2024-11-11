﻿
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.BaseLib.LiveMapping
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.LiveMapping

' ReSharper disable CheckNamespace
Namespace ConsoleLiveMapping
    ' ReSharper restore CheckNamespace

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

    <DAType()> _
    Friend Class Boiler
        ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

        <DANode(BrowsePath:="Pipe1001")> _
        Public InputPipe As New BoilerInputPipe()

        <DANode(BrowsePath:="Drum1001")> _
        Public Drum As New BoilerDrum()

        <DANode(BrowsePath:="Pipe1002")> _
        Public OutputPipe As New BoilerOutputPipe()

        <DANode(BrowsePath:="FC1001")> _
        Public FlowController As New FlowController()

        <DANode(BrowsePath:="LC1001")> _
        Public LevelController As New LevelController()

        <DANode(BrowsePath:="CC1001")> _
        Public CustomController As New CustomController()
    End Class

    <DAType()> _
    Friend Class BoilerInputPipe
        ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

        <DANode(BrowsePath:="FTX001")> _
        Public FlowTransmitter1 As New FlowTransmitter()

        <DANode(BrowsePath:="ValveX001")> _
        Public Valve As New Valve()
    End Class

    <DAType()> _
    Friend Class BoilerDrum
        ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

        <DANode(BrowsePath:="LIX001")> _
        Public LevelIndicator As New LevelIndicator()
    End Class

    <DAType()> _
    Friend Class BoilerOutputPipe
        ' Specifying BrowsePath-s here only because we have named the class members differently from OPC node names.

        <DANode(BrowsePath:="FTX002")> _
        Public FlowTransmitter2 As New FlowTransmitter()
    End Class

    <DAType()> _
    Friend Class FlowController
        Inherits GenericController

    End Class

    <DAType()> _
    Friend Class LevelController
        Inherits GenericController

    End Class

    <DAType()> _
    Friend Class CustomController
        <DANode(), DAItem()> _
        Public Property Input1 As Double

        <DANode(), DAItem()> _
        Public Property Input2 As Double

        <DANode(), DAItem()> _
        Public Property Input3 As Double

        <DANode(), DAItem(Operations:=DAItemMappingOperations.ReadAndSubscribe)> _
        Public Property ControlOut As Double

        <DANode(), DAItem()> _
        Public Property Description As String
    End Class

    <DAType()> _
    Friend Class FlowTransmitter
        Inherits GenericSensor

    End Class

    <DAType()> _
    Friend Class Valve
        Inherits GenericActuator

    End Class

    <DAType()> _
    Friend Class LevelIndicator
        Inherits GenericSensor

    End Class

    <DAType()> _
    Friend Class GenericController
        <DANode(), DAItem(Operations:=DAItemMappingOperations.ReadAndSubscribe)> _
        Public Property Measurement As Double

        <DANode(), DAItem()> _
        Public Property SetPoint As Double

        <DANode(), DAItem(Operations:=DAItemMappingOperations.ReadAndSubscribe)> _
        Public Property ControlOut As Double
    End Class

    <DAType()> _
    Friend Class GenericSensor
        ' Meta-members are filled in by information collected during mapping, and allow access to it later from your code.
        ' Alternatively, you can derive your class from DAMappedNode, which will bring in many meta-members automatically.
        <MetaMember("NodeDescriptor")> _
        Public Property NodeDescriptor As DANodeDescriptor

        <DANode(), DAItem(Operations:=DAItemMappingOperations.ReadAndSubscribe)> _
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

    <DAType()> _
    Friend Class GenericActuator
        <DANode(), DAItem()> _
        Public Property Input As Double
    End Class
End Namespace
