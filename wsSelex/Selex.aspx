<%@ Page Language="VB" Debug="true" %>

<%@ Import Namespace="WSSelex.Selex" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    Protected  Sub goButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim proxy As SelexProxy =  New SelexProxy() 
        proxy.Url = "http://localhost:21479/Selex.asmx"
        Try
            'Dim Richiesta As String = proxy.GetSelex(ListRichiesta.SelectedValue)
            Dim RichiestaSelex As String = proxy.GetSelex(richiesta.SelectedValue)
            lblRichiesta.Text = lblRichiesta.Text & RichiestaSelex
        Catch se As System.Web.Services.Protocols.SoapException
            Response.Write(se.Message)
        End Try
    End Sub

    Protected Sub richiesta_SelectedIndexChanged(sender As Object, e As EventArgs)

        If richiesta.SelectedValue = "Foto" Then
            LabelTipoFoto.Visible = True
            ListFoto.Visible = True
        Else
            LabelTipoFoto.Visible = False
            ListFoto.Visible = False
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        LabelTipoFoto.Visible = False
        ListFoto.Visible = False
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Selex WS</title>
</head>
<body>
    <form id="form1" runat="server">

    <div>
        <asp:Label ID="LabelEAN" runat="server">Inserisci EAN: </asp:Label>
        <asp:TextBox ID="ean" runat="server"></asp:TextBox>
        <br />
      
        <br />
        <asp:Label ID="LabelRichiesta" runat="server">Richiesta: </asp:Label>
        &nbsp;
        <asp:DropDownList ID="richiesta" runat="Server" AutoPostBack="true" OnSelectedIndexChanged="richiesta_SelectedIndexChanged">
            <asp:ListItem>File XML</asp:ListItem>
            <asp:ListItem>File PDF</asp:ListItem>
            <asp:ListItem>Foto</asp:ListItem>
            <asp:ListItem>Richiesta codifica nuovo EAN</asp:ListItem>
            <asp:ListItem>File XML completo</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />
        <asp:Label ID="LabelTipoFoto" runat="server">Tipo foto:</asp:Label>
        &nbsp;
        <asp:DropDownList ID="ListFoto" runat="Server">
            <asp:ListItem>TIFF</asp:ListItem>
            <asp:ListItem>JPEG</asp:ListItem>
            <asp:ListItem>BMP</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="goButton" runat="server" Text="Invia" OnClick="goButton_Click" />
        <br />
        <br />
        <asp:Label ID="lblRichiesta" runat="server">File richiesto: </asp:Label>
    </div>
    </form>
</body>
</html>
