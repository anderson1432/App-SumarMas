﻿Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

'
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class WebService
     Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function

    <WebMethod()> Public Function WebAdd(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

    <WebMethod()> Public Function WebMultiply(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x * y
    End Function

End Class