﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable AssignNullToNotNullAttribute
' ReSharper disable CheckNamespace
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' Shows how to obtain data type description object for complex data node with OPC UA Complex Data plug-in, and the actual
' content of the data type dictionary.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System
Imports System.Text
Imports Microsoft.Extensions.DependencyInjection
Imports OpcLabs.BaseLib.OperationModel.Generic
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace
Imports OpcLabs.EasyOpc.UA.AddressSpace.Standard
Imports OpcLabs.EasyOpc.UA.DataTypeModel
Imports OpcLabs.EasyOpc.UA.DataTypeModel.Extensions
Imports OpcLabs.EasyOpc.UA.InformationModel
Imports OpcLabs.EasyOpc.UA.Plugins.ComplexData

Namespace ComplexData._IUADataTypeDictionaryProvider

    Friend Class ResolveDataTypeDescriptorFromDataTypeEncodingId

        Public Shared Sub Main1()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object.
            Dim client = New EasyUAClient

            ' Obtain the data type ID.
            '
            ' In many cases, you would be able to obtain the data type ID of a particular node by reading its DataType
            ' attribute, or easier, by calling the extension method ReadDataType on the IEasyUAClient interface. The sample
            ' server, however, shows a more advanced approach in which the data type ID refers to an abstract data type,
            ' and the actual values are then sub-types of this base data type. This abstract data type does not have any
            ' encodings associated with it and it is therefore not possible to extract its description from the server.
            ' We therefore use a hard-coded data type ID for one of the sub-types in this example.
            '
            ' The code to obtain the data type ID for given node would normally look like this:
            '    UANodeId dataTypeId = client.ReadDataType(
            '        endpointUriString,
            '        "nsu=http://test.org/UA/Data/ ;i=10239");    // [ObjectsFolder]/Data.Static.Scalar.StructureValue
            '
            Dim dataTypeId As UANodeId = "nsu=http://test.org/UA/Data/ ;i=9440"  ' ScalarValueDataType

            ' Get the IEasyUAClientComplexData service from the client. This is needed for advanced complex data 
            ' operations.
            Dim complexData As IEasyUAClientComplexData = client.GetService(Of IEasyUAClientComplexData)

            ' Get the data type model provider. Provides methods to access data types in OPC UA model.
            Dim dataTypeModelProvider As IUADataTypeModelProvider = complexData.DataTypeModelProvider

            ' Resolve the data type ID from our data type ID, for encoding name "Default Binary".
            Dim encodingIdResult As ValueResult(Of UAModelNodeDescriptor) = dataTypeModelProvider.ResolveEncodingIdFromDataTypeId(
                New UAModelNodeDescriptor(endpointDescriptor, dataTypeId),
                UABrowseNames.DefaultBinary)
            ' Check if the operation succeeded. Use the ThrowIfFailed method instead if you want exception be thrown.
            If Not encodingIdResult.Succeeded Then
                Console.WriteLine("*** Failure: {0}", encodingIdResult.ErrorMessageBrief)
                Exit Sub
            End If
            Dim encodingId As UAModelNodeDescriptor = encodingIdResult.Value

            ' Get the data type dictionary provider. Provides methods to access data type dictionaries in OPC UA model.
            Dim dataTypeDictionaryProvider As IUADataTypeDictionaryProvider = complexData.DataTypeDictionaryProvider

            ' Resolve the data type descriptor from the encoding ID.
            Dim dataTypeDescriptorResult As ValueResult(Of UADataTypeDescriptor) =
                    dataTypeDictionaryProvider.ResolveDataTypeDescriptorFromDataTypeEncodingId(encodingId)
            ' Check if the operation succeeded. Use the ThrowIfFailed method instead if you want exception be thrown.
            If Not dataTypeDescriptorResult.Succeeded Then
                Console.WriteLine("*** Failure: {0}", dataTypeDescriptorResult.ErrorMessageBrief)
                Exit Sub
            End If
            Dim dataTypeDescriptor As UADataTypeDescriptor = dataTypeDescriptorResult.Value

            ' The data type descriptor contains two pieces of information:
            ' The data type dictionary ID: This determines the dictionary where the data type is defined.
            Console.WriteLine(dataTypeDescriptor.DataTypeDictionaryId)
            ' And the data type description: It is a "pointer" into the data type dictionary itself, selecting a specific 
            ' type definition inside the data type dictionary. The format of it depends on the data type system;
            ' in our case, it is a string that is the name of one of the type elements in the XML document of the data type
            ' dictionary.
            Console.WriteLine(dataTypeDescriptor.DataTypeDescription)

            ' Obtain the actual content of the data type dictionary.
            Dim dataTypeDictionaryResult As ValueResult(Of Byte()) =
                    dataTypeDictionaryProvider.GetDataTypeDictionaryFromDataTypeDictionaryId(dataTypeDescriptor.DataTypeDictionaryId)
            ' Check if the operation succeeded. Use the ThrowIfFailed method instead if you want exception be thrown.
            If Not dataTypeDictionaryResult.Succeeded Then
                Console.WriteLine("*** Failure: {0}", dataTypeDictionaryResult.ErrorMessageBrief)
                Exit Sub
            End If
            Dim dataTypeDictionary() As Byte = dataTypeDictionaryResult.Value

            ' The data type dictionary returned is an array of bytes; its syntax and semantics depends on the data type 
            ' system. In our case, we know that the data type dictionary is actually a string encoded in UTF-8.
            Dim text As String = Encoding.UTF8.GetString(dataTypeDictionary)
            Console.WriteLine()
            Console.WriteLine(text)


            ' Example output (truncated):
            '
            'http://opcua.demo-this.com:51211/UA/SampleServer; NodeId="nsu=http://test.org/UA/Data/ ;ns=2;i=11422"
            'ScalarValueDataType
            '
            '<opc:TypeDictionary
            '  xmlns:opc="http://opcfoundation.org/BinarySchema/"
            '  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
            '  xmlns:ua="http://opcfoundation.org/UA/"
            '  xmlns:tns="http://test.org/UA/Data/"
            '  DefaultByteOrder="LittleEndian"
            '  TargetNamespace="http://test.org/UA/Data/"
            '>
            '  <!-- This File was generated on 2013-01-22 and supports the specifications supported by version 1.1.334.0 of the OPC UA deliverables. -->
            '  <opc:Import Namespace="http://opcfoundation.org/UA/" Location="Opc.Ua.BinarySchema.bsd"/>
            '
            '  <opc:StructuredType Name="ScalarValueDataType" BaseType="ua:ExtensionObject">
            '    <opc:Field Name="BooleanValue" TypeName="opc:Boolean" />
            '    <opc:Field Name="SByteValue" TypeName="opc:SByte" />
            '    <opc:Field Name="ByteValue" TypeName="opc:Byte" />
            '    <opc:Field Name="Int16Value" TypeName="opc:Int16" />
            '    <opc:Field Name="UInt16Value" TypeName="opc:UInt16" />
            '    <opc:Field Name="Int32Value" TypeName="opc:Int32" />
            '    <opc:Field Name="UInt32Value" TypeName="opc:UInt32" />
            '    <opc:Field Name="Int64Value" TypeName="opc:Int64" />
            '    <opc:Field Name="UInt64Value" TypeName="opc:UInt64" />
            '    <opc:Field Name="FloatValue" TypeName="opc:Float" />
            '    <opc:Field Name="DoubleValue" TypeName="opc:Double" />
            '    <opc:Field Name="StringValue" TypeName="opc:String" />
            '    <opc:Field Name="DateTimeValue" TypeName="opc:DateTime" />
            '    <opc:Field Name="GuidValue" TypeName="opc:Guid" />
            '    <opc:Field Name="ByteStringValue" TypeName="opc:ByteString" />
            '    <opc:Field Name="XmlElementValue" TypeName="ua:XmlElement" />
            '    <opc:Field Name="NodeIdValue" TypeName="ua:NodeId" />
            '    <opc:Field Name="ExpandedNodeIdValue" TypeName="ua:ExpandedNodeId" />
            '    <opc:Field Name="QualifiedNameValue" TypeName="ua:QualifiedName" />
            '    <opc:Field Name="LocalizedTextValue" TypeName="ua:LocalizedText" />
            '    <opc:Field Name="StatusCodeValue" TypeName="ua:StatusCode" />
            '    <opc:Field Name="VariantValue" TypeName="ua:Variant" />
            '    <opc:Field Name="EnumerationValue" TypeName="ua:Int32" />
            '    <opc:Field Name="StructureValue" TypeName="ua:ExtensionObject" />
            '    <opc:Field Name="Number" TypeName="ua:Variant" />
            '    <opc:Field Name="Integer" TypeName="ua:Variant" />
            '    <opc:Field Name="UInteger" TypeName="ua:Variant" />
            '  </opc:StructuredType>
            '
            '  <opc:StructuredType Name="ArrayValueDataType" BaseType="ua:ExtensionObject">
            '    <opc:Field Name="NoOfBooleanValue" TypeName="opc:Int32" />
            '    <opc:Field Name="BooleanValue" TypeName="opc:Boolean" LengthField="NoOfBooleanValue" />
            '    <opc:Field Name="NoOfSByteValue" TypeName="opc:Int32" />
        End Sub
    End Class
End Namespace

#End Region
