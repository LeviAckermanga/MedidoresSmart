<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresSmartWeb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for ="tipoDb1"> Filtrar por Tipo: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="tipoDb1_SelectedIndexChanged" runat="server" ID="tipoDb1">
                            <asp:ListItem Value="1" Text="Tipo 1"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Tipo 2"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Tipo 3"></asp:ListItem>
                            <asp:ListItem Value="4" Text="Tipo 4"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        OnRowCommand="grillaMedidores_RowCommand"
                        EmptyDataText="No hay Medidores" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField Datafield="NumeroSerie" HeaderText="Numero de Serie" />
                            <asp:BoundField DataField="TipoMedidor.Nombre" HeaderText="Tipo de Medidor" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="eliminar" 
                                        CommandArgument='<%# Eval("NumeroSerie") %>'
                                        runat="server" 
                                        CssClass="btn btn-danger" Text="Eliminar"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
