<%@ Page Title="" ValidateRequest="false" Language="C#" MasterPageFile="./Dashboard.Master" AutoEventWireup="true" CodeBehind="article.aspx.cs" Inherits="Blog.DashboardArticleView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link rel="stylesheet" type="text/css" href="/assets/css/trix.css">
  <script type="text/javascript" src="/assets//js/trix.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-9">
            <div class="card">
                <div class="card-body">
                    <form action="" method="post" novalidate="novalidate">
                        <div class="form-group">
                            <asp:Label runat="server" Text="Label" ID="labelStatus"></asp:Label>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Title</label>
                            <asp:TextBox runat="server" ID="textboxTitle" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                          <label for="cc-payment" class="control-label mb-1">Image</label>
                          <asp:FileUpload runat="server" ID="fileUploadImage"></asp:FileUpload>
                        </div>
                        <div class="form-group">
                          <label class="control-label mb-1">Content</label>
                          <asp:TextBox runat="server" type="hidden"  ID="textboxContent" class="form-control"></asp:TextBox>
                          <trix-editor input="ContentPlaceHolder1_textboxContent"></trix-editor>
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
                            <asp:Button runat="server" Text="Save" ID="buttonSave" CssClass="btn btn-success btn-block" OnClick="buttonSave_Click" ></asp:Button>
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

