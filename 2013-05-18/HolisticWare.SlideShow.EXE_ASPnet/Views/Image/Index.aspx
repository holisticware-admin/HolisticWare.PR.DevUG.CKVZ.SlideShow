<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

	<h2>Index</h2>
   <% foreach (var image in ViewData.Model) 
	  { %>
		<span class="image">
			<a href="images/<%= image.Path %>">
			<img src="images/<%= image.Path %>" height="100" width="100" /></a> 
			<span class="description"><%= image.Description %></span>
	   </span>
	   <br />
	<% }%>
</asp:Content>
