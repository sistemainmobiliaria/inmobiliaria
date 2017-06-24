<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaInmueble.aspx.cs" Inherits="Inmobiliaria.AltaInmueble" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <asp:Panel ID="PanelSuperior" CssClass="panel panel-success" runat="server">
            <div class="panel-heading">
                <h3>Formulario ALTA Inmueble</h3>
            </div>
            <!-- TITULO DEL INMUEBLE -->
            <div class="form-group">
                <br />
                <asp:Label ID="lblTitulo" runat="server" Text="TITULO" CssClass="col-md-2 col-xs-6 control-label"> </asp:Label>
                <div class="col-md-6 col-xs-12 ">
                    <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="1"></asp:TextBox><br />
                </div>
            </div>

            <!-- DESCRIPCION DEL INMUEBLE -->
            <div class="form-group">
                <asp:Label ID="lblDescripcion" runat="server" Text="DESCRIPCION" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-6 ">
                    <asp:TextBox ID="txtDecripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="2"></asp:TextBox><br />
                </div>
            </div>

            <!-- TIPO DE INMUEBLE -->
            <div class="form-group">
                <asp:Label ID="lblTipoInmueble" runat="server" Text="TIPO INMUEBLE" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="ddlTipoInmueble" runat="server"
                        Width="280"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        Font-Bold="false"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        DataTextField="nombre"
                        AutoPostBack="false"
                        AppendDataBoundItems="true">
                    </asp:DropDownList>
                </div>

                <%--AGREGAR ACA EL MODAL PARA NUEVO TIPO DE INMUEBLE--%>
                <div class="form-group">
                    <div class="col-md-2">
                        <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalTipoInmueble">Nuevo Tipo Inmueble</button>
                    </div>
                    <!-- MODAL TIPO INMUEBLE  -->
                    <div class="modal fade" id="modalTipoInmueble" tabindex="-1" role="dialog" aria-labelledby="modalLabelTipoInmueble" aria-hidden="true">
                        <div class="modal-dialog modal-md">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                    <h4 class="modal-title" id="modalLabelTipoInmueble">Nuevo Tipo Inmueble</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtTipoInmuebleModal" runat="server" CssClass="form-control"></asp:TextBox><br />
                                    </div>
                                    <br />
                                </div>
                                <div class="modal-footer">
                                    <asp:Button runat="server" ID="btnModalTipoInmuebleSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                    <asp:Button runat="server" ID="btnModalTipoInmuebleGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalTipoInmuebleGuardar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

            <!-- BOTON GUARDAR -->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnGuardarInmueble" runat="server" Text="Guardar Inmueble" CssClass="btn btn-success form-control" OnClick="btnGuardarInmueble_Click" />
                </div>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
