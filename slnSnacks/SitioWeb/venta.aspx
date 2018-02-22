<%@ Page Title="" Language="C#" MasterPageFile="~/SitioWeb/Principal.Master" AutoEventWireup="true" CodeBehind="venta.aspx.cs" Inherits="slnSnacks.SitioWeb.venta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row center-align">
        <h4>Agregar Producto</h4>
    </div>

    <div class="row center-align">
        <div class=" col s7 center-align">
            <h6>Seleccione el Producto a Agregar</h6>
            <asp:ListBox CssClass="browser-default input-field " ID="lstProductos" runat="server" Height="30%" Width="60%" Rows="5">
                <asp:ListItem Text="selecciona" Value="0"> </asp:ListItem>
                <asp:ListItem Text="producto1" Value="1"> </asp:ListItem>
                <asp:ListItem Text="producto2" Value="2"> </asp:ListItem>


            </asp:ListBox>
        </div>


        <div class="col s5">
            <div class="row center-align">
                <h6>Ingrese la Cantidad</h6>

                <div class="row center-align">
                    <div class="row center-align">
                        <button type="button" id="mas" class="waves-effect waves-light btn" value="+">+</button>
                    </div>
                    <div class="row center-align">
                        <asp:TextBox ID="txtCantidad"  Style="text-align: center" Text="0" TextMode="Number" Font-Bold="true" runat="server"></asp:TextBox>
                        
                    </div>
                    <div class="row center-align">
                        <button id="menos" type="button" class="waves-effect waves-light btn">-</button>

                    </div>
                </div>

            </div>
            <div class="row center-align">
                <asp:Button runat="server" ID="btnAgregar" CssClass="btn waves-effect waves-light" Text="Agregar" />
            </div>
        </div>
    </div>


    <div class="row center-align">
        <h4>Detalle Compra</h4>


    </div>


    <script src="../js/funciones.js"></script>
</asp:Content>
