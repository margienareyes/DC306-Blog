<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="DashboardArticleView.aspx.cs" Inherits="Blog.DashboardArticleView" %>
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
                            <label for="cc-payment" class="control-label mb-1">Title</label>
                            <asp:TextBox runat="server" ID="textboxTitle" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Content</label>
                            <textarea cols="20" rows="10" runat="server" ID="textboxContent" class="form-control"></textarea>
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
                            <asp:Button runat="server" Text="Save" ID="buttonSave" CssClass="btn btn-success btn-block" OnClick="buttonSave_Click"></asp:Button>
                        </div>
                        <div class="mb-2">
                            <asp:Button runat="server" Text="Delete" ID="buttonDelete" CssClass="btn btn-outline-danger btn-block"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

