﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Blog.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags-->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="au theme template">
    <meta name="author" content="Hau Nguyen">
    <meta name="keywords" content="au theme template">

    <!-- Title Page-->
    <title>Register</title>

    <!-- Fontfaces CSS-->
    <link href="css/font-face.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-5/css/fontawesome-all.min.css" rel="stylesheet" media="all">
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">

    <!-- Bootstrap CSS-->
    <link href="vendor/bootstrap-4.1/bootstrap.min.css" rel="stylesheet" media="all">

    <!-- Vendor CSS-->
    <link href="vendor/animsition/animsition.min.css" rel="stylesheet" media="all">
    <link href="vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet" media="all">
    <link href="vendor/wow/animate.css" rel="stylesheet" media="all">
    <link href="vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" media="all">
    <link href="vendor/slick/slick.css" rel="stylesheet" media="all">
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="vendor/perfect-scrollbar/perfect-scrollbar.css" rel="stylesheet" media="all">

    <!-- Main CSS-->
    <link href="css/theme.css" rel="stylesheet" media="all">
</head>
<body class="animsition">
    <div class="page-wrapper">
        <div class="page-content--bge5">
            <div class="container">
                <div class="login-wrap">
                    <div class="login-content">
                        <div class="login-logo">
                            <a href="#">
                                <img src="images/logo.png" alt="CoolAdmin">
                            </a>
                        </div>
                        <div class="login-form">
                             <form id="form1" runat="server">
                              <div class="form-group">
                                    <asp:Label runat="server" ID="labelStatus" ForeColor="Red"></asp:Label>
                                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                                  &nbsp
                                 <asp:LinkButton ID="lnkLogin" runat="server" OnClick="lnkLogin_Click">Login Here</asp:LinkButton>
                               </div>
                                <div class="form-group">
                                    <label>Name</label>
                                    <asp:TextBox ID="txtName" Cssclass="au-input au-input--full" name="Name" placeholder="Name" runat="server" required>
                                    </asp:TextBox>
                                </div>
                                 <div class="form-group">
                                    <label>Email</label>
                                    <asp:TextBox ID="txtEmail" Cssclass="au-input au-input--full" name="Email" type="email" placeholder="Email" runat="server" required>
                                  </asp:TextBox>
                                </div>
                                <div class="form-group">
                                  <label>Username</label>
                                   <asp:TextBox ID="txtUsername" Cssclass="au-input au-input--full" type="Username" name="Username" placeholder="Username"  runat="server" required>
                                   </asp:TextBox>
                                 <div class="form-group">
                                      <label>Password</label>
                                    <asp:TextBox ID="txtPassword" Cssclass="au-input au-input--full" name="Password" placeholder="Password" type="password" runat="server" required>
                                  </asp:TextBox>
                                </div>
                                      <label for="cc-payment" class="control-label mb-1">Image</label>
                                      <asp:FileUpload runat="server" ID="fileUploadImage"></asp:FileUpload>

                                <asp:Button ID="btnRegister" Text="Register" CssClass="au-btn au-btn--block au-btn--green m-b-20" runat="server" OnClick="btnRegister_Click"/>
                                 </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <!-- Jquery JS-->
    <script src="vendor/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap JS-->
    <script src="vendor/bootstrap-4.1/popper.min.js"></script>
    <script src="vendor/bootstrap-4.1/bootstrap.min.js"></script>
    <!-- Vendor JS       -->
    <script src="vendor/slick/slick.min.js">
    </script>
    <script src="vendor/wow/wow.min.js"></script>
    <script src="vendor/animsition/animsition.min.js"></script>
    <script src="vendor/bootstrap-progressbar/bootstrap-progressbar.min.js">
    </script>
    <script src="vendor/counter-up/jquery.waypoints.min.js"></script>
    <script src="vendor/counter-up/jquery.counterup.min.js">
    </script>
    <script src="vendor/circle-progress/circle-progress.min.js"></script>
    <script src="vendor/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="vendor/chartjs/Chart.bundle.min.js"></script>
    <script src="vendor/select2/select2.min.js">
    </script>

    <!-- Main JS-->
    <script src="js/main-dashboard.js"></script>
</body>
</html>
