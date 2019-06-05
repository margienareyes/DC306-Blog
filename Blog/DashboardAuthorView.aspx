﻿ <%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="DashboardAuthorView.aspx.cs" Inherits="Blog.DashboardAuthorView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-9">
            <div class="card">
                <div class="card-body">
                    <form action="" method="post" novalidate="novalidate">
                        <div class="form-group">
                            <asp:Label runat="server" ID="labelStatus" ForeColor="Red"></asp:Label>
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </div>
                          <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Firstname<asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstname" runat="server" ErrorMessage="*Firstname Required" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
                        
                            </label>
                            &nbsp;<asp:TextBox runat="server" ID="txtName" class="form-control" Width="200px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Lastname<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Lastname Required" ControlToValidate="txtLastName" ForeColor="Red"></asp:RequiredFieldValidator>
                            </label>
                            &nbsp;<asp:TextBox runat="server" ID="txtLastName" class="form-control" Width="200px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Email<asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="*Email Required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                        
                            </label>
                            &nbsp;<asp:TextBox runat="server" ID="txtEmail" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Username</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUser" runat="server" ErrorMessage="*Username Required" ControlToValidate="txtUser" ForeColor="Red"></asp:RequiredFieldValidator>
                        
                        &nbsp;<asp:TextBox runat="server" ID="txtUser" class="form-control"></asp:TextBox>
                        
                        </div>
                        <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Password
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass" runat="server" ErrorMessage="*Password Required" ControlToValidate="txtPass" ForeColor="Red"></asp:RequiredFieldValidator>
                            </label>
                            &nbsp;<asp:TextBox runat="server" ID="txtPass" TextMode="Password"  class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group">
                            <label for="cc-payment" class="control-label mb-1">Confirm Password&nbsp;&nbsp;&nbsp; 
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPass" ControlToValidate="txtConPass" ErrorMessage="*Password Mismatch" ForeColor="Red"></asp:CompareValidator>
                                </label>
                            <asp:TextBox runat="server" ID="txtConPass" TextMode="Password"  class="form-control"></asp:TextBox>
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
                            <asp:Button runat="server" Text="Register" ID="btn1" CssClass="btn btn-success btn-block" OnClick="btn1_Click"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
