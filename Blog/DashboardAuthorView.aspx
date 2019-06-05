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
                            <asp:Label runat="server" ID="labelStatus" ForeColor="Red"></asp:Label>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Username</label>
                            <asp:TextBox runat="server" ID="txtUser" class="form-control" required></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Password</label>
                            <asp:TextBox runat="server" ID="txtPass"  class="form-control" required></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Email</label>
                            <asp:TextBox runat="server" ID="txtEmail" class="form-control" required></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Name</label>
                            <asp:TextBox runat="server" ID="txtName" class="form-control" required></asp:TextBox>
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
                            <asp:Button runat="server" Text="Register" ID="btn1" CssClass="btn btn-success btn-block" OnClick="btn1_Click"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
