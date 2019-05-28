<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="DashboardAuthorView.aspx.cs" Inherits="Blog.DashboardAuthorView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-9">
            <div class="card">
                <div class="card-body">
                    <form action="" method="post" novalidate="novalidate">
                        <div class="form-group">
                            <asp:Label runat="server" Text="" ID="labelStatus"></asp:Label>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Username</label>
                            <asp:TextBox runat="server" ID="textboxUsername" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Password</label>
                            <asp:TextBox runat="server" ID="textboxPassword" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Name</label>
                            <asp:TextBox runat="server" ID="textboxName" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Description</label>
                            <asp:TextBox runat="server" ID="textboxDescription" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Email</label>
                            <asp:TextBox runat="server" ID="textboxEmail" class="form-control"></asp:TextBox>
                        </div>
                        
                    </form>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="card">
                <div class="card-body">
                    <div action="" method="post" novalidate="novalidate">
                        <div class="mb-2">
                            <asp:Button runat="server" Text="Register" ID="buttonSave" CssClass="btn btn-success btn-block"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
