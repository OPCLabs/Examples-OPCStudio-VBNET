﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5456
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), System.ServiceModel.ServiceContractAttribute(ConfigurationName:="IService1")> _
Public Interface IService1

	<System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/GetData", ReplyAction:="http://tempuri.org/IService1/GetDataResponse")> _
	Function GetData() As String
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface IService1Channel
	Inherits IService1, System.ServiceModel.IClientChannel

End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class Service1Client
	Inherits System.ServiceModel.ClientBase(Of IService1)
	Implements IService1

	Public Sub New()
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String)
		MyBase.New(endpointConfigurationName)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(binding, remoteAddress)
	End Sub

	Public Function GetData() As String Implements IService1.GetData
		Return MyBase.Channel.GetData()
	End Function
End Class
