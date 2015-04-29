Imports System
Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Collections.Generic
Imports System.Data

Namespace ASPItalia.Books.Web.Chapter20

    <WebService(Namespace:="http://webservices.aspitalia.com/NorthwindService")> _
    <WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
    Public Class NorthwindService
        Inherits System.Web.Services.WebService

        <WebMethod()> _
        Public Function ListCustomers() As List(Of Customer)
            Return New CustomerManager().ListAll()
        End Function

    End Class

End Namespace
