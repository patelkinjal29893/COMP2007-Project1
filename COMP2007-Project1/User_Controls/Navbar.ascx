<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="COMP2007_Project1.Navbar" %>
<nav class="navbar navbar-inverse" role="navigation">
    <div class="container-fluid">
        
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="Default.aspx"><i class="fa fa-gamepad fa-lg"></i> Game Tracker</a>
        </div>
        
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li id="home" runat="server"><a href="Default.aspx"><i class="fa fa-home fa-lg"></i> Home</a></li>
                <li id="Games" runat="server"><a href="Games.aspx"><i class="fa fa-puzzle-piece fa-lg"></i> Games</a></li>
                <li id="about" runat="server"><a href="About.aspx"><i class="fa fa-bars fa-lg"></i> About Us</a></li>                
                <li id="contact" runat="server"><a href="Contact.aspx"><i class="fa fa-phone fa-lg"></i> Contact Us</a></li>
                <li id="login" runat="server"><a href="Login.aspx"><i class="fa fa-user fa-lg"></i> Login</a></li>
            </ul>
        </div>
    
    </div>
    
</nav>
