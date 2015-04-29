<%@ Page Language="VB" Debug="true" %>
<%@ Import Namespace="ASPItalia.Books.Web.Chapter20" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">


    Protected  Sub goButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim proxy As WeatherServiceProxy =  New WeatherServiceProxy() 
        proxy.Url = "http://localhost:21479/WeatherService.asmx"
        Try
            Dim temperature As Double =  proxy.GetTemperature(city.SelectedValue) 
            Temp.Text = Temp.Text & temperature
        Catch se As System.Web.Services.Protocols.SoapException
            Response.Write(se.Message)
        End Try
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>20.5</title>
</head>
<body>
    <form id="form1" runat="server">

    <div>
        <asp:Label ID="Temp" runat="server">Temperatura: </asp:Label>
        <asp:DropDownList ID="city" runat="Server">
            <asp:ListItem>Brescia</asp:ListItem>
            <asp:ListItem>Milano</asp:ListItem>
            <asp:ListItem>Roma</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="goButton" runat="server" Text="Che tempo fa?" OnClick="goButton_Click" />
    </div>
    </form>
</body>
</html>
