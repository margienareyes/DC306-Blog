<%@ Page Title="" Language="C#" MasterPageFile="~/Blog.Master" AutoEventWireup="true" CodeBehind="BlogArticleList.aspx.cs" Inherits="Blog.BlogArticleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><div class="row">
    <div class="col-md-10 col-md-offset-1">
        <div class="row row-pb-md">
            <asp:Repeater runat="server" ID="DataList1">
                <ItemTemplate>        
		                <div class="col-md-6">
			                <div class="blog-entry">
				                <div class="blog-img">
					                <a href="blog.html"><img src="<%# Eval("ImagePath") %>" class="img-responsive" alt="html5 bootstrap template"></a>
				                </div>
				                <div class="desc">
					                <p class="meta">
						                <span class="date"><%# Eval("Date") %></span>
						                <span class="pos">By <a href="#"><%# Eval("AuthorId") %></a></span>
					                </p>
					                <h2><a href="blog.html"><%# Eval("Title") %></a></h2>
				                </div>
			                </div>
		                </div>
                </ItemTemplate>  
            </asp:Repeater>
	    </div>
    </div>
</asp:Content>
