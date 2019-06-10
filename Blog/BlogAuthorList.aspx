<%@ Page Title="" Language="C#" MasterPageFile="~/Blog.Master" AutoEventWireup="true" CodeBehind="BlogAuthorList.aspx.cs" Inherits="Blog.BlogAuthorList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:Repeater runat="server" ID="DataList1">
                <ItemTemplate>        
		                <div class="col-md-6">
			                <div class="blog-entry">
				                <div class="blog-img">
					               <a href="blog.html"><img src="<%# Eval("AuthorID") %>" class="img-responsive" alt="html5 bootstrap template"></a>
				                </div>
				                <div class="desc">
					               <p class="meta">
						             <span class="date"><%# Eval("Name") %></span>
						             <span class="pos">By <a href="#"><%# Eval("AuthorId") %></a></span>
					        </p>
					           <h2><a href="blog.html"><%# Eval("Email") %></a></h2>
				           </div>
			            </div>
		           </div>
           </ItemTemplate>  
        </asp:Repeater>
    </form>
</asp:Content>
