#pragma checksum "C:\Users\FHY\Desktop\FDS\软件开发实训\asp.net core\second\second\Views\Home\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2c204b20eb256522b9b2f6fec62c34412eaa9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_register), @"mvc.1.0.view", @"/Views/Home/register.cshtml")]
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
#line 1 "C:\Users\FHY\Desktop\FDS\软件开发实训\asp.net core\second\second\Views\_ViewImports.cshtml"
using second;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FHY\Desktop\FDS\软件开发实训\asp.net core\second\second\Views\_ViewImports.cshtml"
using second.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da2c204b20eb256522b9b2f6fec62c34412eaa9c", @"/Views/Home/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b28c44c549eea7c01c9ff09bc76b599c34a4ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\FHY\Desktop\FDS\软件开发实训\asp.net core\second\second\Views\Home\register.cshtml"
  
    Layout = null;
    ViewData["Tittle"] = "注册";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da2c204b20eb256522b9b2f6fec62c34412eaa9c3490", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>注册页面</title>\r\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da2c204b20eb256522b9b2f6fec62c34412eaa9c4612", async() => {
                WriteLiteral(@"
    <el-container id=""fhy"" style=""width:31.25rem;height:50rem"">
        <el-main>
            <el-form v-model=""user"">
                <el-form-item label=""姓名"" placeholder=""请输入姓名"">
                    <el-input v-model=""user.userName""></el-input>
                </el-form-item>
                <el-form-item label=""Email"">
                    <el-input v-model=""user.userName"" placeholder=""请输入Email""></el-input>
                </el-form-item>
                <el-form-item label=""性别"">
                    <el-radio v-model=""user.radio"" label=""boy"">男</el-radio>
                    <el-radio v-model=""user.radio"" label=""gril"">女</el-radio>
                </el-form-item>
                <el-form-item label=""所在城市"">
                    <el-select v-model=""user.sity"">
                        <el-option label=""北京""></el-option>
                        <el-option label=""上海""></el-option>
                        <el-option label=""浙江""></el-option>
                        <el-option label=""武汉""></el-option>");
                WriteLiteral(@"
                    </el-select>
                </el-form-item>
                <el-form-item label=""出生日期"">
                    <el-date-picker v-model=""user.date"">
                    </el-date-picker>
                </el-form-item>
                <el-form-item label=""爱好:"">
                    <el-checkbox label=""篮球"" checked=""true""></el-checkbox>
                    <el-checkbox label=""足球""></el-checkbox>
                    <el-checkbox label=""网球""></el-checkbox>
                    <el-checkbox label=""乒乓球""></el-checkbox>
                </el-form-item>
                <el-row>
                    <el-col style=""text-align: center"">
                        <el-button type=""primary"">注册</el-button>
                        <el-button>取消</el-button>
                    </el-col>
                </el-row>
            </el-form>
        </el-main>
    </el-container>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/vue/dist/vue.js""></script>
<!-- 引入组件库 -->
<script src=""https://unpkg.com/element-ui/lib/index.js""></script>
<script>
    const zhuce = new Vue({
        el: '#fhy',
        data: {
            user: {
                userName: """",
                email: """",
                radio:1,
                sity:"""",
                date:"""",
                hobby:""""
            }
        }

    })
</script>
</html>");
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
