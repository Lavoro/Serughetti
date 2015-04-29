Imports System
 
Namespace ASPItalia.Books.Web.Chapter20
	Public Class Customer
 
        Private _customerID As String
        Private _companyName As String
        Private _contactName As String
        Private _contactTitle As String
        Private _address As String
        Private _city As String
        Private _region As String
        Private _postalCode As String
        Private _counTry As String
        Private _phone As String
        Private _fax As String
 
        Public Property CustomerID() As String
        	Get 
            	 Return _customerID
        	End Get
        	Set (ByVal Value As String) 
            	 _customerID = value
        	End Set
        End Property
 
        Public Property CompanyName() As String
        	Get 
            	 Return _companyName
        	End Get
        	Set (ByVal Value As String) 
            	 _companyName = value
        	End Set
        End Property
 
        Public Property ContactName() As String
        	Get 
            	 Return _contactName
        	End Get
        	Set (ByVal Value As String) 
            	 _contactName = value
        	End Set
        End Property
 
        Public Property ContactTitle() As String
        	Get 
            	 Return _contactTitle
        	End Get
        	Set (ByVal Value As String) 
            	 _contactTitle = value
        	End Set
        End Property
 
        Public Property Address() As String
        	Get 
            	 Return _address
        	End Get
        	Set (ByVal Value As String) 
            	 _address = value
        	End Set
        End Property
 
        Public Property City() As String
        	Get 
            	 Return _city
        	End Get
        	Set (ByVal Value As String) 
            	 _city = value
        	End Set
        End Property
 
        Public Property Region() As String
        	Get 
            	 Return _region
        	End Get
        	Set (ByVal Value As String) 
            	 _region = value
        	End Set
        End Property
 
        Public Property PostalCode() As String
        	Get 
            	 Return _postalCode
        	End Get
        	Set (ByVal Value As String) 
            	 _postalCode = value
        	End Set
        End Property
 
        Public Property CounTry() As String
        	Get 
            	 Return _counTry
        	End Get
        	Set (ByVal Value As String) 
            	 _counTry = value
        	End Set
        End Property
 
        Public Property Phone() As String
        	Get 
            	 Return _phone
        	End Get
        	Set (ByVal Value As String) 
            	 _phone = value
        	End Set
        End Property
 
        Public Property Fax() As String
        	Get 
            	 Return _fax
        	End Get
        	Set (ByVal Value As String) 
            	 _fax = value
        	End Set
        End Property
	End Class
End Namespace
