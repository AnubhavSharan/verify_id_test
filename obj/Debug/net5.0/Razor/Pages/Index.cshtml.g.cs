#pragma checksum "C:\Users\anubh\OneDrive\Desktop\verified id\active-directory-verifiable-credentials-dotnet\2-asp-net-core-api-user-signin\Pages\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bff10e7caccdc89cefc319cb004b3ace0ad4cbca6b5507fa7c397c00d5f4648c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreVerifiableCredentials.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCoreVerifiableCredentials.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\anubh\OneDrive\Desktop\verified id\active-directory-verifiable-credentials-dotnet\2-asp-net-core-api-user-signin\Pages\_ViewImports.cshtml"
using AspNetCoreVerifiableCredentials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bff10e7caccdc89cefc319cb004b3ace0ad4cbca6b5507fa7c397c00d5f4648c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f52a5d6c9bd82abada10682f8d3452885ce4d996eb92a2218cdf2245c15d05c3", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\anubh\OneDrive\Desktop\verified id\active-directory-verifiable-credentials-dotnet\2-asp-net-core-api-user-signin\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div style=""text-align: center;"">
                <img src=""VerifiedCredentialExpert-icon.png"" height=200px; />
                <h1>Verifiable Credential Expert Issuance and Verifier Sample</h1>
        
                <button type=""button"" id=""idIssue"" class=""button"">GET CREDENTIAL</button>
                <button type=""button"" id=""idVerify"" class=""button"">VERIFY CREDENTIAL</button>
                <script>
                        var idIssue = document.getElementById('idIssue');
                        var idVerify = document.getElementById('idVerify');

                        idIssue.addEventListener('click', () => {
                            window.location = ""issuer"";
                        })
                        idVerify.addEventListener('click', () => {
                            window.location = ""verifier"";
                        })
                    </script>
            </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
