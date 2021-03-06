﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarAssociado.aspx.cs" Inherits="Paginas_AlterarAssociado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Alterar Associado</title>
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
        <h2>Alterar Associado</h2>
    <form id="form1" runat="server">
        <div>
            
        <br />
        <br />
        <asp:Label ID="nome" runat="server" Text="Nome:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNome" runat="server"  ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="senha" runat="server" Text="Senha:"></asp:Label>
        <br />
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="cpf" runat="server" Text="CPF:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="nascimento" runat="server" Text="Nascimento:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNascimento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="dataadm" runat="server" Text="Data de Admissão"></asp:Label>
        <br />
        <asp:TextBox ID="txtDataadm" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="endereco" runat="server" Text="Endereço:"></asp:Label>
        <br />
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="email" runat="server" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="contato" runat="server" Text="Celular:"></asp:Label>
        <br />
        <asp:TextBox ID="txtContato" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="cnpj" runat="server" Text="CNPJ:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCnpj" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="ie" runat="server" Text="Inscrição Estadual:"></asp:Label>
        <br />
        <asp:TextBox ID="txtIe" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="caepf" runat="server" Text="CAEPF:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCaepf" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSindicato" runat="server" Text="Sindicato"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlSindicato" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
             <br />
             <br />
            <asp:LinkButton ID="hlLista" runat="server" OnClick="hlLista_Click">Voltar a lista</asp:LinkButton>
        </div>
    </form>
        </div>
</body>
</html>
