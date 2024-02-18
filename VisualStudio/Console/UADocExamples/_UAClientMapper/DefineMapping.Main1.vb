' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example for OPC UA type-less mapping shows how to define a mapping and perform a read operation.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System.Linq
Imports OpcLabs.BaseLib.ComponentModel.Linking
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.LiveMapping

Namespace _UAClientMapper
    Friend Class DefineMapping
        Class MyClass2
            Public Property Value As Object
        End Class

#Region "Example-DefineAndRead"
        Public Shared Sub Main1()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            Dim mapper = New UAClientMapper()
            Dim target = New MyClass2()

            ' Define a type-less mapping.

            Dim memberInfo = target.GetType().GetMember("Value").SingleOrDefault()
            Debug.Assert(memberInfo IsNot Nothing)

            mapper.DefineMapping( _
                New UAClientDataMappingSource( _
                    endpointDescriptor, _
                    "nsu=http://test.org/UA/Data/ ;i=10389", _
                    UAAttributeId.Value, _
                    UAIndexRangeList.Empty, _
                    UAReadParameters.CacheMaximumAge), _
                New UAClientDataMapping(GetType(Int32)), _
                New ObjectMemberLinkingTarget(target.GetType(), target, memberInfo))

            ' Perform a read operation.
            mapper.Read()

            ' Display results
            Console.WriteLine(target.Value)
        End Sub
#End Region
    End Class
End Namespace

#End Region
