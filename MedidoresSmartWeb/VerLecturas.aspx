<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="MedidoresSmartWeb.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                    <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="No hay Lecturas" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField Datafield="TipoMedidor.Nombre" HeaderText="Medidor" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField DataField="Hora" HeaderText="Hora" />
                            <asp:BoundField DataField="Consumo" HeaderText="Consumo" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
</asp:Content>
