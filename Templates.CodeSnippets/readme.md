# HolisticWare.SlideShow #

## 2 devs, 4 man-hours, 8 platforms with 2 Studios ##

## Urls References ##

*	[http://mono-aspnet-mvc4-aws.holisticware.org](http://mono-aspnet-mvc4-aws.holisticware.org)
*	[http://builtwith.com/mono-aspnet-mvc4-aws.holisticware.org](http://builtwith.com/mono-aspnet-mvc4-aws.holisticware.org)
*	[http://www.c-sharpcorner.com/UploadFile/scottlysle/UploadwithCSharpWS05032007121259PM/UploadwithCSharpWS.aspx](http://www.c-sharpcorner.com/UploadFile/scottlysle/UploadwithCSharpWS05032007121259PM/UploadwithCSharpWS.aspx)
*	[http://www.codeproject.com/Tips/569532/Submit-Images-to-Web-Service-and-Get-Them-Back](http://www.codeproject.com/Tips/569532/Submit-Images-to-Web-Service-and-Get-Them-Back)

## Steps ##

### MVC 4 ###

1.	Model
	1.	Slide
	2.	Slides
2. Controllers
	1.	SlideController
		cropper image
		cropper image - controller found - no View

	Server Error in '/' Application.

	The view 'Index' or its master was not found or no view engine supports the searched locations. The following locations were searched:
	~/Views/Slide/Index.aspx
	~/Views/Slide/Index.ascx
	~/Views/Shared/Index.aspx
	~/Views/Shared/Index.ascx
	~/Views/Slide/Index.cshtml
	~/Views/Slide/Index.vbhtml
	~/Views/Shared/Index.cshtml
	~/Views/Shared/Index.vbhtml

	Description: An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code. 

	Exception Details: System.InvalidOperationException: The view 'Index' or its master was not found or no view engine supports the searched locations. The following locations were searched:
	~/Views/Slide/Index.aspx
	~/Views/Slide/Index.ascx
	~/Views/Shared/Index.aspx
	~/Views/Shared/Index.ascx
	~/Views/Slide/Index.cshtml
	~/Views/Slide/Index.vbhtml
	~/Views/Shared/Index.cshtml
	~/Views/Shared/Index.vbhtml

	Source Error: 

	An unhandled exception was generated during the execution of the current web request. Information regarding the origin and location of the exception can be identified using the exception stack trace below.

	Stack Trace: 


	[InvalidOperationException: The view 'Index' or its master was not found or no view engine supports the searched locations. The following locations were searched:
	~/Views/Slide/Index.aspx
	~/Views/Slide/Index.ascx
	~/Views/Shared/Index.aspx
	~/Views/Shared/Index.ascx
	~/Views/Slide/Index.cshtml
	~/Views/Slide/Index.vbhtml
	~/Views/Shared/Index.cshtml
	~/Views/Shared/Index.vbhtml]
	   System.Web.Mvc.ViewResult.FindView(ControllerContext context) +508
	   System.Web.Mvc.ViewResultBase.ExecuteResult(ControllerContext context) +231
	   System.Web.Mvc.ControllerActionInvoker.InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult) +39
	   System.Web.Mvc.<>c__DisplayClass1a.<InvokeActionResultWithFilters>b__17() +74
	   System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilter(IResultFilter filter, ResultExecutingContext preContext, Func`1 continuation) +388
	   System.Web.Mvc.<>c__DisplayClass1c.<InvokeActionResultWithFilters>b__19() +72
	   System.Web.Mvc.ControllerActionInvoker.InvokeActionResultWithFilters(ControllerContext controllerContext, IList`1 filters, ActionResult actionResult) +303
	   System.Web.Mvc.Async.<>c__DisplayClass2a.<BeginInvokeAction>b__20() +155
	   System.Web.Mvc.Async.<>c__DisplayClass25.<BeginInvokeAction>b__22(IAsyncResult asyncResult) +184
	   System.Web.Mvc.Async.WrappedAsyncResult`1.End() +137
	   System.Web.Mvc.Async.AsyncResultWrapper.End(IAsyncResult asyncResult, Object tag) +56
	   System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeAction(IAsyncResult asyncResult) +66
	   System.Web.Mvc.<>c__DisplayClass1d.<BeginExecuteCore>b__18(IAsyncResult asyncResult) +40
	   System.Web.Mvc.Async.<>c__DisplayClass4.<MakeVoidDelegate>b__3(IAsyncResult ar) +47
	   System.Web.Mvc.Async.WrappedAsyncResult`1.End() +152
	   System.Web.Mvc.Async.AsyncResultWrapper.End(IAsyncResult asyncResult, Object tag) +59
	   System.Web.Mvc.Async.AsyncResultWrapper.End(IAsyncResult asyncResult, Object tag) +40
	   System.Web.Mvc.Controller.EndExecuteCore(IAsyncResult asyncResult) +68
	   System.Web.Mvc.Async.<>c__DisplayClass4.<MakeVoidDelegate>b__3(IAsyncResult ar) +47
	   System.Web.Mvc.Async.WrappedAsyncResult`1.End() +152
	   System.Web.Mvc.Async.AsyncResultWrapper.End(IAsyncResult asyncResult, Object tag) +59
	   System.Web.Mvc.Async.AsyncResultWrapper.End(IAsyncResult asyncResult, Object tag) +40
	   System.Web.Mvc.Controller.EndExecute(IAsyncResult asyncResult) +65
	   System.Web.Mvc.Controller.System.Web.Mvc.Async.IAsyncController.EndExecute(IAsyncResult asyncResult) +39
	   System.Web.Mvc.<>c__DisplayClass8.<BeginProcessRequest>b__3(IAsyncResult asyncResult) +45
	   System.Web.Mvc.Async.<>c__DisplayClass4.<MakeVoidDelegate>b__3(IAsyncResult ar) +47
	   System.Web.Mvc.Async.WrappedAsyncResult`1.End() +152
	   System.Web.Mvc.Async.AsyncResultWrapper.End(IAsyncResult asyncResult, Object tag) +59
	   System.Web.Mvc.Async.AsyncResultWrapper.End(IAsyncResult asyncResult, Object tag) +40
	   System.Web.Mvc.MvcHandler.EndProcessRequest(IAsyncResult asyncResult) +66
	   System.Web.Mvc.MvcHandler.System.Web.IHttpAsyncHandler.EndProcessRequest(IAsyncResult result) +38
	   System.Web.CallHandlerExecutionStep.System.Web.HttpApplication.IExecutionStep.Execute() +932
	   System.Web.HttpApplication.ExecuteStep(IExecutionStep step, Boolean& completedSynchronously) +188

3.	Views
	1.	add folder Slide/
	2.	add View Index.aspx
	3.  in folder Share/ edit Site.Master   
		insert/add:  

	<!-- 
		Action Link:
			Link text, Action, Controller name
	-->
	<li><%: Html.ActionLink("Slide", "Index", "Slide") %></li>


## MVC sample ##

*	[]()

## Hader 2 ##

*	li
*	li
*	li

	