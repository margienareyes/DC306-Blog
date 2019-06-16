<%@ Page Title="" Language="C#" MasterPageFile="~/Blog.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Blog.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-10 col-md-offset-1">
        <div class="row row-pb-md">
            <asp:Repeater runat="server" ID="DataList1">
                <ItemTemplate>        
		                <div class="col-md-6">
			                <div class="blog-entry">
				                <div class="blog-img" style=" height: 300px; width: 100%;">
					                <a href="article.aspx?id=<%# Eval("ArticleId") %>">
                                        <img src="<%# Eval("ImagePath") %>" style=" height: 100%; width: 100%; object-fit: cover;" class="img-responsive" alt="html5 bootstrap template">
					                </a>
				                </div>
				                <div class="desc">
					                <p class="meta">
						                <span class="date"><%# Eval("Date") %></span>
						                <span class="pos">By <a href="#"><%# Eval("Author") %></a></span>
					                </p>
					                <h2><a href="article.aspx?id=<%# Eval("ArticleId") %>"><%# Eval("Title") %></a></h2>
                                    <p><%# Eval("Excerpt") %></p>
				                </div>
			                </div>
		                </div>
                </ItemTemplate>  
            </asp:Repeater>
	    </div>
    </div>
</asp:Content>

