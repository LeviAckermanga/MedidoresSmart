<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidoresSmartWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    
                    <div class="form-group">
                        <label for="NumeroSerieTxt"> Numero de serie </label>
                        <asp:TextBox ID="NumeroSerie" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="medidorDAL">Tipo: </label>
                        <asp:DropDownList runat="server" ID="tipoDdl" CssClass="form-control">
                       
                        </asp:DropDownList>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
