<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HolisticWare.SlideShow.EXE.Models.Slides>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

   <% foreach (var image in ViewData.Model) 
	  { %>
		<span class="image">
			<a href="Slides/<%= image.Path %>">
			<img src="Slides/<%= image.Path %>" height="100" width="100" /></a> 
			<span class="description"><%= image.Description %></span>
	   </span>
	   <br />
	<% }%>
	
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
