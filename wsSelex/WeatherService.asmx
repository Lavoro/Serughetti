<%@ WebService Language="VB" Class="WeatherService" %>

 
Imports System
Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
 
<WebService(Namespace:="http://webservices.aspitalia.com/WeatherService")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
Public Class WeatherService
    Inherits System.Web.Services.WebService
 
    <WebMethod()> _
    Public Function GetTemperature(ByVal cityName As String) As Double
        Select Case cityName
            Case "Brescia"
                Return 30.5D
            Case "Milano"
                Return 35.5D
            Case Else
                Throw New ArgumentException("cityName")
                Throw New ArgumentException("cityName")
        End Select
    End Function
 
End Class


