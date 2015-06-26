﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Paquetes.aspx.cs" Inherits="Proyecto.Aplicacion.Paquetes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <asp:Panel ID ="PCliente" runat="server" >
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li><a href ="Inicio.aspx">Inicio</a></li> 
                    <li><a href="Cotizar.aspx">Cotizar</a></li>
                    <li class="active"><a href="Paquetes.aspx">Ver casilla</a></li>
                    <li><a href="Perfil.aspx">Perfil</a></li>
                    <li><a href="Crear.aspx">Crear Pedido</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul>
        <asp:Label id="LabelNombre" runat="server" Text="Bienvenido"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <Columns>
                <asp:BoundField HeaderText="Numero" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </ul>
    <ul>
        <asp:Label ID="Label1" runat="server" Text="Número de casilla:"></asp:Label>
        <asp:Label ID="LabelCasilla" runat="server"></asp:Label>
    </ul>
</asp:Content>