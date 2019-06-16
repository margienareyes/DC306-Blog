<%@ Page Title="" Language="C#" MasterPageFile="~/Blog.Master" AutoEventWireup="true" CodeBehind="article.aspx.cs" Inherits="Blog.BlogArticleView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
	<div class="col-md-9 content">
		<div class="row row-pb-lg">
			<div class="col-md-12">
				<div class="blog-entry">
					<div class="blog-img blog-detail">
						<img src="<%Response.Write(imagePath); %>" class="img-responsive" alt="html5 bootstrap template">
					</div>
					<div class="desc">
						<p class="meta">
							<span class="date"><%Response.Write(date); %></span>
							<span class="pos">By <a href="#"><%Response.Write(author); %></a></span>
						</p>
						<h2><a href="blog.html"><%Response.Write(title); %></a></h2>
                        <asp:Literal runat="server" ID="contentLiteral"></asp:Literal>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
