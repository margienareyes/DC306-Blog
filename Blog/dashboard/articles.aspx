<%@ Page Title="" Language="C#" MasterPageFile="Dashboard.Master" AutoEventWireup="true" CodeBehind="articles.aspx.cs" Inherits="Blog.DashboardArticleList" %>
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
                                <span><%# Eval("Date") %> by <%# Eval("Author") %></span>
                            </div>
                            <div>
                                <asp:LinkButton ID="buttonEdit" runat="server" cssClass="btn btn-primary"  OnClick="buttonEdit_Click" CommandArgument='<%#Eval("Id") %>'>Edit</asp:LinkButton>
                                <asp:LinkButton ID="buttonDelete" runat="server" cssClass="btn btn-danger"  OnClick="buttonDelete_Click" CommandArgument='<%#Eval("Id") %>'>Delete</asp:LinkButton>
                            </div>
				        </div>
			        </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
