<%@ Page Title="" Language="C#" MasterPageFile="~/Blog.Master" AutoEventWireup="true" CodeBehind="BlogArticleList.aspx.cs" Inherits="Blog.BlogArticleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row row-pb-md">
		<div class="col-md-4">
			<div class="blog-entry">
				<div class="blog-img">
					<a href="blog.html"><img src="images/blog-1.jpg" class="img-responsive" alt="html5 bootstrap template"></a>
				</div>
				<div class="desc">
					<p class="meta">
						<span class="cat"><a href="#">Events</a></span>
						<span class="date">20 March 2018</span>
						<span class="pos">By <a href="#">Rich</a></span>
					</p>
					<h2><a href="blog.html">Recipe for your site</a></h2>
					<p>A small river named Duden flows by their place and supplies it with the necessary </p>
				</div>
			</div>
		</div>
		<div class="col-md-4">
			<div class="blog-entry">
				<div class="blog-img">
					<a href="blog.html"><img src="images/blog-2.jpg" class="img-responsive" alt="html5 bootstrap template"></a>
				</div>
				<div class="desc">
					<p class="meta">
						<span class="cat"><a href="#">Read</a></span>
						<span class="date">20 March 2018</span>
						<span class="pos">By <a href="#">Rich</a></span>
					</p>
					<h2><a href="blog.html">Recipe for your site</a></h2>
					<p>A small river named Duden flows by their place and supplies it with the necessary </p>
				</div>
			</div>
		</div>
		<div class="col-md-4">
			<div class="blog-entry">
				<div class="blog-slider">
					<div class="owl-carousel">
						<div class="item">
							<a href="blog.html" class="image-popup-link"><img src="images/blog-3.jpg" class="img-responsive" alt="html5 bootstrap template"></a>
						</div>
						<div class="item">
							<a href="blog.html" class="image-popup-link"><img src="images/blog-4.jpg" class="img-responsive" alt="html5 bootstrap template"></a>
						</div>
					</div>
				</div>
				<div class="desc">
					<p class="meta">
						<span class="cat"><a href="#">Travel</a></span>
						<span class="date">20 March 2018</span>
						<span class="pos">By <a href="#">Rich</a></span>
					</p>
					<h2><a href="blog.html">Recipe for your site</a></h2>
					<p>A small river named Duden flows by their place and supplies it with the necessary </p>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
