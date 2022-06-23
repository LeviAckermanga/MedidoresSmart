<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLecturas.aspx.cs" Inherits="MedidoresSmartWeb.AgregarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">
                    
                    <div class="form-group">
                        <label for="tipoRbl">Tipo de Medidor</label>
                        <asp:DropDownList runat="server" ID="tipoDdl" CssClass="form-control">
                       
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="lecturaDAL">Fecha: </label>
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" Width="327px">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                        <br />
                    </div>

                    <div class="form-group">
                        <label for="rutTxt"> Hora: </label>
                        <asp:TextBox ID="Hora" CssClass="form-control" runat="server" Width="200px"></asp:TextBox> <asp:TextBox ID="Minutos" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="rutTxt"> Consumo: </label>
                        <asp:TextBox ID="Consumo" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                        <br />
                    </div>

                    <div class="form-group">
                        <asp:Button runat="server" ID="Button1" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
