#pragma checksum "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4206115056b17a373972f37ac14fac761876648a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shinda_Index), @"mvc.1.0.view", @"/Views/Shinda/Index.cshtml")]
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
#line 1 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\_ViewImports.cshtml"
using ShindaTest2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\_ViewImports.cshtml"
using ShindaTest2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
using ShindaTest2.Models.Shinda;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4206115056b17a373972f37ac14fac761876648a", @"/Views/Shinda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c103ba68dcc3457b4c01cafade846ce19137eaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shinda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-6 m-2"" style=""font-size:20px;padding-left:20%"">新達訂單</div>
    <div class=""col-6""></div>
</div>

<div class=""row"">
    <div class=""col-4 border-right border-dark"" style=""height:500px;padding-left:10%"">
        <div id=""test"">
            <div class=""m-2"">姓名</div>
            <div class=""m-2"">
                <input type=""text"" name=""name"" id=""name"" />
                <br />
            </div>
            <div class=""m-2"">商品項目</div>
");
#nullable restore
#line 17 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
             foreach (var item in @ViewBag.list as List<TblProduct>)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"m-2\">\r\n                    <input style=\"width:50px\" type=\"text\" name=\"qty\" />\r\n                    &nbsp; ");
#nullable restore
#line 21 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
                      Write(item.CProdcutName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
                                         Write(item.CPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 元\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <br />
            <button id=""buy"" style=""display:inline-block"">購買</button>
        </div>
    </div>
    <div class=""col-8 pl-5 pr-5"" style=""height:500px;"">
        <div class=""row mb-4"">
            <div class=""col-4"">
                <input type=""text"" class=""form-control"" placeholder=""訂單號碼"" />
            </div>
            <div class=""col-4"">
                <input type=""text"" class=""form-control"" placeholder=""姓名"" />
            </div>
            <div class=""col-4"">
                <select class=""form-control"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4206115056b17a373972f37ac14fac761876648a5858", async() => {
                WriteLiteral("請選擇...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
                     foreach (var item in ViewBag.list as List<TblProduct>)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4206115056b17a373972f37ac14fac761876648a7336", async() => {
#nullable restore
#line 42 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
                                                    Write(item.CProdcutName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
                           WriteLiteral(item.CProdcutId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\YowaneHaku\source\repos\ShindaTest2\ShindaTest2\Views\Shinda\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
        </div>
        <div>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>編號</th>
                        <th>日期</th>
                        <th>姓名</th>
                        <th>金額</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>

    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

<script>

    window.onload = function(){
        var req = new XMLHttpRequest();
        req.open('GET','https://localhost:44366/Shinda/Get',true);
        req.setRequestHeader(""Content-type"", ""application/json"");
        req.setRequestHeader(""Accept"",""json"")

        req.send();

        req.onreadystatechange = function(){
            if(req.status == 200 && req.readyState == 4){

                var res = JSON.parse(req.response);

               

                    for(i = 0;i<res.length;i++){
                        $('tbody').append(`<tr><td>${res[i].cID}</td><td>${res[i].showDt}</td><td>${res[i].cName}</td><td>${res[i].showTot}</td><td><a href=""javascript:void(0)"" onclick=""ttt(${res[i].items})"">查看訂單</a></td></tr>`)
                    }
                
            }
        }
    }


    function ttt(value){
        // 使用get呼叫controller船指定資料過來alert


        alert(value);
    }

    document.getElementById('buy').addEventListener('click',function(){

        v");
                WriteLiteral(@"ar Sign = {
            cID:'',
            cName:'',
            cDT:null,
            cSubTotal:0,
            items:''
        };

        Sign.cName = document.getElementsByName('name')[0].value;

        var qty = document.querySelectorAll('input[name=qty]');

        var i = 0;

        var arr = [];
        debugger;

        for(i = 0; i < qty.length; i++ ){
            if(qty[i].value != ''){
                arr.push(qty[i].value);
            }
            else{
                arr.push(0);
            }
        }

        debugger

        Sign.items = arr.join(',');




        var data = JSON.stringify(Sign);

        //alert(data);

        console.log(data);

        var req = new XMLHttpRequest();
        req.open('POST','https://localhost:44366/Shinda/Post',true);
        req.setRequestHeader(""Content-type"", ""application/json"");
        req.setRequestHeader(""Accept"",""json"")

        req.send(data);

        req.onreadystatechange = function(){
  ");
                WriteLiteral(@"          if(req.status == 200 && req.readyState == 4){

                var res = JSON.parse(req.response);

                if(res.Msg != undefined){
                    alert(res.Msg);
                }
                else{



                alert('訂單已送出');

                var inps = $(':input[name=qty]');

                for (i = 0; i < inps.length; i++){
                    inps[i].value = '';
                    inps[i].checked = false;
                }

                document.getElementById('name').value = '';

                $('tbody').html('');

                    for(i = 0;i<res.length;i++){
                        $('tbody').append(`<tr><td>${res[i].cID}</td><td>${res[i].showDt}</td><td>${res[i].cName}</td><td>${res[i].showTot}</td><td><a href=""javascript:void(0)"" onclick=""Get()"">查看訂單</a></td></tr>`)
                    }
                }
            }
        }
    })
</script>
");
            }
            );
            WriteLiteral(" ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591