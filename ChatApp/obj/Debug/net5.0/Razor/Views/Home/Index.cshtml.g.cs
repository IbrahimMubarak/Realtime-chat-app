#pragma checksum "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8db3a460761e128f176d5e75e85932fbb0b8379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\_ViewImports.cshtml"
using ChatApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\_ViewImports.cshtml"
using ChatApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8db3a460761e128f176d5e75e85932fbb0b8379", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf30333ff74047b044a1c577267f3d6907496f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr.js/jquery.signalR.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:40px;width:40px;object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/no-image-icon-Copy.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"d-flex justify-content-center div1\" >\r\n    <div ><h1 class=\"h\">Welcome To Chat<span style=\"border-color:white;color: #0E86D4\">ROOM</span></h1></div>\r\n</div>\r\n");
#nullable restore
#line 13 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8db3a460761e128f176d5e75e85932fbb0b83797099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\" />\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8db3a460761e128f176d5e75e85932fbb0b83798368", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8db3a460761e128f176d5e75e85932fbb0b83799411", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row clearfix\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"card chat-app\">\r\n                    <div id=\"plist\" class=\"people-list\">\r\n");
            WriteLiteral("                        <h3 style=\"text-align: center; color:#0E86D4\">All Users</h3>\r\n                        <hr />\r\n                        <ul id=\"users\" class=\"list-unstyled chat-list mt-2 mb-0\">\r\n");
#nullable restore
#line 30 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                             foreach (var item in ViewBag.users)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"clearfix\">\r\n");
#nullable restore
#line 33 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                     if (item.ProfilePicture != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img class=\"rounded-circle\" style=\"height:40px;width:40px;object-fit:cover\"");
            BeginWriteAttribute("src", " src=\"", 1528, "\"", 1600, 2);
            WriteAttributeValue("", 1534, "data:image/*;base64,", 1534, 20, true);
#nullable restore
#line 35 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1554, Convert.ToBase64String(item.ProfilePicture), 1554, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 36 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b8db3a460761e128f176d5e75e85932fbb0b837912464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"about\">\r\n                                        <div class=\"name\">");
#nullable restore
#line 42 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                     Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <div class=\"status\"> ");
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 46 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </ul>
                    </div>

                    <div class=""chat"">
                        <div class=""chat-header clearfix"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <a href=""javascript:void(0);"" data-toggle=""modal"" data-target=""#view_info"">
");
#nullable restore
#line 57 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                         if (UserManager.GetUserAsync(User).Result.ProfilePicture != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img class=\"rounded-circle\" style=\"height:40px;width:40px;object-fit:cover\"");
            BeginWriteAttribute("src", " src=\"", 2930, "\"", 3035, 2);
            WriteAttributeValue("", 2936, "data:image/*;base64,", 2936, 20, true);
#nullable restore
#line 59 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2956, Convert.ToBase64String(UserManager.GetUserAsync(User).Result.ProfilePicture), 2956, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\">\r\n");
#nullable restore
#line 60 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b8db3a460761e128f176d5e75e85932fbb0b837916376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </a>\r\n                                    <div class=\"chat-about\">\r\n                                        <h6 class=\"m-b-0\">");
#nullable restore
#line 67 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>

                                    </div>
                                </div>

                            </div>
                        </div>




                        <div class=""chat-history"" id=""data"" style=""overflow-y:scroll;height:400px"">

                            <ul class=""m-b-0"" id=""messagesList"">

");
#nullable restore
#line 82 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.user.UserName == User.Identity.Name)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"clearfix\">\r\n                                            <div class=\"message-data text-right\">\r\n");
#nullable restore
#line 88 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                 if (item.time == DateTime.Today)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"message-data-time\">");
#nullable restore
#line 90 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                                               Write(item.time.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 91 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"message-data-time\">");
#nullable restore
#line 94 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                                               Write(item.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 95 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                            <div class=\"message  float-right \" style=\"color:white;background-color: #0E86D4\">");
#nullable restore
#line 97 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                                                                                        Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </li>\r\n");
#nullable restore
#line 99 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"clearfix\">\r\n\r\n                                            <div class=\"message-data\">\r\n");
#nullable restore
#line 105 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                 if (item.time == DateTime.Today)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"message-data-time\">");
#nullable restore
#line 107 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                                               Write(item.time.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 108 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"message-data-time\">");
#nullable restore
#line 111 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                                               Write(item.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 112 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n\r\n                                            <div class=\"message\" style=\"background-color:#e8f1f3\"><h5 class=\"text-left\" style=\"color:#0E86D4\">");
#nullable restore
#line 115 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                                                                                                         Write(item.SenderUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
#nullable restore
#line 115 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
                                                                                                                                                                  Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </li>\r\n");
#nullable restore
#line 117 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"

                                    }


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                            </ul>
                        </div>

                        <div class=""chat-message clearfix"">
                            <div class=""input-group mb-0"">
                                <div class=""col-4""><input type=""text"" id=""userInput""");
            BeginWriteAttribute("value", " value=\"", 6554, "\"", 6581, 1);
#nullable restore
#line 130 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 6562, User.Identity.Name, 6562, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden /></div>
                                <div class=""input-group-prepend"">

                                    <input type=""button"" id=""sendButton"" class=""input-group-text"" hidden />
                                </div>
                                <input id=""messageInput"" type=""text"" class=""form-control"" placeholder="" Message..."" style=""height: 50px; width: 100%; border-color: #0E86D4; border-radius: 20px;"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8db3a460761e128f176d5e75e85932fbb0b837925941", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8db3a460761e128f176d5e75e85932fbb0b837926985", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 146 "C:\Users\Mubarak\Desktop\ChatApp\ChatApp\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
