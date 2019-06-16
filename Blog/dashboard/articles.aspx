<%@ Page Title="" Language="C#" MasterPageFile="./Dashboard.Master" AutoEventWireup="true" CodeBehind="articles.aspx.cs" Inherits="Blog.DashboardArticleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <asp:Repeater runat="server" ID="DataList1">
            <ItemTemplate>
                <div class="col-lg-8">
			        <div class="card">
				        <div class="card-header d-flex align-items-end">
                            <div class="mr-auto">
					            <h2><%# Eval("Title") %></h2> 
                                <span><%# Eval("Author") %> - <%# Eval("Date") %></span>
                            </div>
                            <div>
                                <button class="btn btn-primary" type="button">Edit</button>
                                <button class="btn btn-danger" type="button">Delete</button>
                            </div>
				        </div>
			        </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
