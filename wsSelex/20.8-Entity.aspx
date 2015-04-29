<%@ Page Language="VB" ContentType="text/xml" %>
<%@ Import Namespace="System.Xml.Serialization" %>

<script runat="server">

        

    Private  Sub Page_Load()
        Dim mc As MiaClasse =  New MiaClasse() 
        mc.Campo1 = "valore1"
        mc.Proprieta1 = "valore2"
 
        Dim ser As XmlSerializer = New XmlSerializer(GetType(MiaClasse))
        ser.Serialize(Me.Response.OutputStream, mc)
    End Sub
 
    Public Class MiaClasse
        <XmlAttribute("AttrCampo1")> _ 
        Public Campo1 As String
 
        Private _proprieta1 As String
 
        <XmlText()> _ 
        Public Property Proprieta1() As String
        	Get 
            	 Return _proprieta1
        	End Get
        	Set (ByVal Value As String) 
            	 _proprieta1 = value
        	End Set
        End Property
    End Class


    
</script>