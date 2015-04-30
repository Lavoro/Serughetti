<%@ WebService Language="VB" Class="Selex" %>

 
Imports System
Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
 
<WebService(Namespace:="http://localhost:21479/Selex")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
Public Class Selex
    Inherits System.Web.Services.WebService
 
    <WebMethod()> _
    Public Function GetSelex(ByVal richiesta As String, ByVal ean As String, ByVal ListFoto As String) As String
        
        Select Case richiesta
            Case "File XML"
                Return "xml"
            Case "File PDF"
                Return "PDF"
            Case "Foto"
                Return "Foto"
            Case "Richiesta codifica nuovo EAN"
                Return "NuovoEAN"
            Case "File XML completo"
                Return "XMLCompleto"
            Case Else
               ' Throw New ArgumentException("richiesta")
                'Throw New ArgumentException("EAN")

        End Select

    End Function
 
End Class


