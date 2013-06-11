<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
	Home Page - My ASP.NET MVC Application
</asp:Content>

<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
	<section class="featured">
		<div class="content-wrapper">
			<hgroup class="title">
				<h1>Home Page.</h1>
				<h2><%: ViewBag.Message %></h2>
			</hgroup>

			<table style="width:100%">
				<caption> Features </caption>
				<thead>
					<tr>
						<th>Features</th>
						<th>Availablity</th>
						<th>Description</th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td>Multiplatform</td>
						<td>yes (conditionally)</td>
						<td>
							<ul>
						<li>
							Windows (IIS)
							<br />
							<a href="http://riz-content-server-2013.ironfoundry.me/">
								Iron Foundry (.net IIS)
							</a>				
							<br />
							<a href="http://builtwith.com/riz-content-server-2013.ironfoundry.me">
								Test on BuiltWith.com: deployment data
							</a>
						</li>
						<li>
							Linux
							<br />
							<a href="http://riz-content-server-2013.holisticwarez.net/">
								Linux, Ubuntu server, Mono
							</a>
							<br />
							<a href="http://builtwith.com/riz-content-server-2013.holisticwarez.net">
								Test on BuiltWith.com: deployment data
							</a>
						</li>
					</ul>
						</td>
					</tr>
					<tr>
						<td>Cloud deployment PAAS</td>
						<td>yes</td>
						<td>
							<ul>
						<li>
							<a href="http://riz-content-server-2013.ironfoundry.me/">
								Iron Foundry (.net IIS)
							</a>				
							<br />
							<a href="http://builtwith.com/riz-content-server-2013.ironfoundry.me">
								Test on BuiltWith.com: deployment data
							</a>
						</li>
						<li>
							<a href="http://riz-content-server-2013.holisticwarez.net/">
								Linux, Ubuntu server, Mono
							</a>
							<br />
							<a href="http://builtwith.com/riz-content-server-2013.holisticwarez.net">
								Test on BuiltWith.com: deployment data
							</a>
						</li>
						<li>
							AppHarbor (upcoming)
						</li>
						<li>
							Azure (upcoming)
						</li>
					</ul>
						</td>
					</tr>
					<tr>
						<td>Modern Design</td>
						<td>yes</td>
						<td>
							<ul>
						<li>
							ASP.net MVC 2 (MVC 4 pre-alpha)
						</li>
						<li>
							mobile ready web (adaptive/responsive)
							<br />
							Twitter Bootstrap
						</li>
					</ul>
						</td>
					</tr>
					<tr>
						<td>Remote API</td>
						<td>yes</td>
						<td>
							<ul>
						<li>
							Web Services SOAP
							<ul>
								<li>
									<a href="RemoteAPI/SOAP/TextMessage.asmx">
									RemoteAPI/SOAP/TextMessage.asmx
									</a>
								</li>
								<li>
									<a href="RemoteAPI/SOAP/Journaline.asmx">
									RemoteAPI/SOAP/Journaline.asmx
									</a>
								</li>
								<li>
									<a href="RemoteAPI/SOAP/SlideShow.asmx">
									RemoteAPI/SOAP/SlideShow.asmx
									</a>
								</li>
								<li>
									<a href="RemoteAPI/SOAP/BroadcastWebsite.asmx">
									RemoteAPI/SOAP/BroadcastWebsite.asmx
									</a>
								</li>
								<li>
									<a href="RemoteAPI/SOAP/ElectronicProgramGuide.asmx">
									RemoteAPI/SOAP/ElectronicProgramGuide.asmx
									</a>
								</li>
							</ul>
						</li>
						<li>
							RESTfull services (pre-alpha)
						</li>
						<li>
							OData Services (pre-alpha) (Windows only)
						</li>
						<li>
							SignalR (prepared)
						</li>
						<li>
							WebSockets
						</li>
						<li>
							WebRTC
						</li>
					</ul>
						</td>
					</tr>
					<tr>
						<td>Client availability (desktop and mobile)</td>
						<td>yes</td>
						<td>
							Desktop - Windows - Windows Forms
							<br />
							Desktop - Windows - Windows Presentation Foundation
							<br />
							Desktop - MacOSX - Windows Forms (pre-alpha)
							<br />
							Desktop - Linux - Windows Forms (pre-alpha)
							<br />
							Desktop - MacOSX - MonoMac (coming soon)
							<br />
							Desktop - Linux - Windows Forms (coming soon)
							<br />
							Mobile - iOS
							<br />
							Mobile - Android
							<br />
							Mobile - Windows Phone
						</td>
					</tr>
				</tbody>
			</table>

			<p>
				To learn more about ASP.NET MVC visit
				<a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
				The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET MVC.
				If you have any questions about ASP.NET MVC visit
				<a href="http://forums.asp.net/1146.aspx/1?MVC" title="ASP.NET MVC Forum">our forums</a>.
			</p>
		</div>
	</section>
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
	<h3>We suggest the following:</h3>
	<ol class="round">
		<li class="one">
			<h5>Getting Started</h5>
			ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that
			enables a clean separation of concerns and that gives you full control over markup
			for enjoyable, agile development. ASP.NET MVC includes many features that enable
			fast, TDD-friendly development for creating sophisticated applications that use
			the latest web standards.
			<a href="http://go.microsoft.com/fwlink/?LinkId=245151">Learn more…</a>
		</li>

		<li class="two">
			<h5>Add NuGet packages and jump-start your coding</h5>
			NuGet makes it easy to install and update free libraries and tools.
			<a href="http://go.microsoft.com/fwlink/?LinkId=245153">Learn more…</a>
		</li>

		<li class="three">
			<h5>Find Web Hosting</h5>
			You can easily find a web hosting company that offers the right mix of features
			and price for your applications.
			<a href="http://go.microsoft.com/fwlink/?LinkId=245157">Learn more…</a>
		</li>
	</ol>
</asp:Content>
