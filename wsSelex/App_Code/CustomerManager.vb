Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic

Namespace ASPItalia.Books.Web.Chapter20

    Public Class CustomerManager
        Inherits EntityManager(Of Customer)

        Public Sub New()
            If Me.GetTotalEntities() > 0 Then
                Return
            End If

            ' Popolo per demo
            Dim c As Customer
            c = New Customer()
            c.CustomerID = "ALFKI"
            c.CompanyName = "Alfreds Futterkiste"
            c.ContactName = "Maria Anders"
            c.ContactTitle = "Sales Representative"
            c.Address = "Obere Str. 57"
            c.City = "Berlin"
            c.PostalCode = "12209"
            c.CounTry = "Germany"
            c.Phone = "030-0074321"
            c.Fax = "030-0076545"
            Me.Add(c)

            c = New Customer()
            c.CustomerID = "ANATR"
            c.CompanyName = "Ana Trujillo Emparedados y helados"
            c.ContactName = "Ana Trujillo"
            c.ContactTitle = "Owner"
            c.Address = "Avda. de la Constituci?n 2222"
            c.City = "M?xico D.F."
            c.PostalCode = "05021"
            c.CounTry = "Mexico"
            c.Phone = "(5) 555-4729"
            c.Fax = "(5) 555-3745"
            Me.Add(c)

            c = New Customer()
            c.CustomerID = "ANTON"
            c.CompanyName = "Antonio Moreno Taquer?a"
            c.ContactName = "Antonio Moreno"
            c.ContactTitle = "Owner"
            c.Address = "Mataderos  2312"
            c.City = "M?xico D.F."
            c.PostalCode = "05023"
            c.CounTry = "Mexico"
            c.Phone = "(5) 555-3932"
            c.Fax = Nothing
            Me.Add(c)

            c = New Customer()
            c.CustomerID = "FRANS"
            c.CompanyName = "Franchi S.p.A."
            c.ContactName = "Paolo Accorti"
            c.ContactTitle = "Sales Representative"
            c.Address = "Via Monte Bianco 34"
            c.City = "Torino"
            c.PostalCode = "10100"
            c.CounTry = "Italy"
            c.Phone = "011-4988260"
            c.Fax = "011-4988261"
            Me.Add(c)

            c = New Customer()
            c.CustomerID = "GREAL"
            c.CompanyName = "Great Lakes Food Market"
            c.ContactName = "Howard Snyder"
            c.ContactTitle = "Marketing Manager"
            c.Address = "2732 Baker Blvd."
            c.City = "Eugene"
            c.Region = "OR"
            c.PostalCode = "97403"
            c.CounTry = "USA"
            c.Phone = "(503) 555-7555"
            c.Fax = Nothing
            Me.Add(c)
        End Sub

        Protected Overrides Function FindEntity(ByVal cache As List(Of Customer), ByVal entity As Customer) As Customer
            Dim c As Customer
            For Each c In cache
                If c.CustomerID = entity.CustomerID Then
                    Return c
                End If
            Next

            Return Nothing
        End Function

        Public Overloads Function GetSingle(ByVal customerID As String) As Customer
            Dim c As Customer = New Customer()
            c.CustomerID = customerID
            Return Me.GetSingle(c)
        End Function
    End Class

End Namespace