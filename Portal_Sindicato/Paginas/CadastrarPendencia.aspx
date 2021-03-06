﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarPendencia.aspx.cs" Inherits="Paginas_CadastrarPendencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Cadastrar Pendencias</title>
      <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
        #hlLista{
            
            background-color:cornflowerblue;
            text-decoration: none;
            color: snow;
            padding: 1em 1.5em;
            text-transform: uppercase;
        }

    </style>
</head>
<body>
    <br />
    <div id="top" class="form-style-8 ">
        <h2>Cadastro de Pendências</h2>
    <form id="form1" runat="server">
        <div>
            
            <br />
            <br />
            <asp:Label ID="lblSelecionar" runat="server" Text="Selecionar Associado"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlAssociado" runat="server">
            </asp:DropDownList>
            <br />
            <br />
        </div>
        <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label>
        <br />
        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDocumento" runat="server" Text="Documento"></asp:Label>
        <br />
        <br />
        <asp:FileUpload ID="fuDocumento" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        <br />
             <br />
        <asp:HyperLink ID="hlLista" runat="server" NavigateUrl="~/Paginas/ListarPendenciaFuncionario.aspx">Voltar a lista</asp:HyperLink>
    </form>
        </div>
</body>
</html>
