#pragma checksum "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f472deb5e3553e946ce66d079531f20016874a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oprator_Index), @"mvc.1.0.view", @"/Views/Oprator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Oprator/Index.cshtml", typeof(AspNetCore.Views_Oprator_Index))]
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
#line 1 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\_ViewImports.cshtml"
using Ghasedak;

#line default
#line hidden
#line 2 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\_ViewImports.cshtml"
using Ghasedak.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f472deb5e3553e946ce66d079531f20016874a4", @"/Views/Oprator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a3adc42566847921abf5afd6f81e3a1773c1a92", @"/Views/_ViewImports.cshtml")]
    public class Views_Oprator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<Ghasedak.Models.Oprator>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 226, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-xs-12\">\r\n        <div class=\"box\">\r\n            <div class=\"box-header\">\r\n                <h3 class=\"box-title\">متصدیان</h3>\r\n                <br />\r\n                <p style=\"color:red\">");
            EndContext();
            BeginContext(286, 15, false);
#line 8 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
                                Write(ViewBag.success);

#line default
#line hidden
            EndContext();
            BeginContext(301, 73, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(374, 875, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c4bbe6058e84a3a8194c3c0c67ab6d2", async() => {
                BeginContext(380, 862, true);
                WriteLiteral(@"
                    <div class=""box-body"">
                        <div class=""col-md-4 form-group"">
                            <input type=""text"" id=""filteruserName"" name=""filteruserName"" class=""form-control"" placeholder=""نام کاربری"" />
                        </div>
                        <div class=""col-md-1 form-group"">
                            <button type=""submit"" class=""btn btn-default"">جستجو</button>
                        </div>
                        <div class=""col-md-4 form-group"">
                            <a href=""/User/Index"" class=""btn btn-default"">مشاهده همه</a>
                        </div>
                        <div class=""col-md-2 form-group"">

                            <div class=""btn btn-default"" id=""export"">خروجی اکسل</div>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1249, 989, true);
            WriteLiteral(@"

            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <a class=""btn btn-success openmodal"" style=""margin-right: 10px;"" href=""#""  data-toggle=""modal"" data-target=""#myModal""> متصدی جدید</a>

                    <a class=""btn btn-default deleteAll"">حذف موارد انتخابی</a>
                </div>
            </div>
            <!-- /.box-header -->
            <div class=""box-body table-responsive"">
                <table id=""example2"" class=""table table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>
                                <div class=""checkbox"">
                                    <label>
                                        <input type=""checkbox"" id=""checkbox1"">
                                    </label>
                                </div>
                            </th>
                            <th>نام کاربری</th>
");
            EndContext();
            BeginContext(2286, 136, true);
            WriteLiteral("                            <th>امکانات</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 55 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2503, 229, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <div class=\"chkRow\">\r\n                                        <label>\r\n                                            <input");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2732, "\"", 2748, 1);
#line 61 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
WriteAttributeValue("", 2740, item.id, 2740, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2749, 188, true);
            WriteLiteral(" type=\"checkbox\">\r\n                                        </label>\r\n                                    </div>\r\n                                </td>\r\n                                <td>");
            EndContext();
            BeginContext(2938, 13, false);
#line 65 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
                               Write(item.userName);

#line default
#line hidden
            EndContext();
            BeginContext(2951, 171, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <button type=\"button\" class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"#EditModal\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3122, "\"", 3135, 1);
#line 67 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
WriteAttributeValue("", 3127, item.id, 3127, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3136, 186, true);
            WriteLiteral("> ویرایش</button>\r\n\r\n                                    <a class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#QuestionModal\" onclick=\"AssignButtonClicked(this)\" data-assigned-id=\"");
            EndContext();
            BeginContext(3323, 7, false);
#line 69 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
                                                                                                                                                                Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(3330, 26, true);
            WriteLiteral("\" data-assigned-username=\"");
            EndContext();
            BeginContext(3357, 13, false);
#line 69 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
                                                                                                                                                                                                  Write(item.userName);

#line default
#line hidden
            EndContext();
            BeginContext(3370, 14, true);
            WriteLiteral("\"> حذف</a>\r\n\r\n");
            EndContext();
            BeginContext(3670, 74, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 82 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3771, 458, true);
            WriteLiteral(@"

                    </tbody>
                    <tfoot>

                    </tfoot>
                </table>
            </div>
            <!-- /.box-body -->
            <div class=""row"">
                <div class=""col-sm-5"">
                </div>
                <div class=""col-sm-7"">
                    <div class=""dataTables_paginate paging_simple_numbers"" id=""example1_paginate"">
                        <ul class=""pagination"">
");
            EndContext();
            BeginContext(4659, 66, true);
            WriteLiteral("                            <li>\r\n                                ");
            EndContext();
            BeginContext(4725, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d065ef985f9c446f8992265984d4392e", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
#line 105 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4789, 665, true);
            WriteLiteral(@"
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- /.col -->
</div>

<div class=""modal fade"" id=""myModal"" role=""dialog"" style=""height:auto;overflow-y:visible"">
    <div class=""modal-dialog modal-sm"" style=""width:400px"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">متصدی</h4>
            </div>
            <div class=""modal-body"" style=""height:auto"">

");
            EndContext();
            BeginContext(5859, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(5877, 3751, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcfb4a38145248aaad3a9a1322d84f78", async() => {
                BeginContext(5898, 3723, true);
                WriteLiteral(@"
                    <div class=""box-body"">
                        <input type=""hidden"" id=""OpratorId"" name=""OpratorId"" />
                        <input type=""hidden"" id=""password"" name=""password"" />
                        <input type=""hidden"" id=""token"" name=""token"" />
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label class=""control-label"">نام و نام خانوادگی</label>
                                <input class=""form-control valid"" type=""text"" data-val=""true"" data-val-maxlength=""نام و نام خانوادگی نمی تواند بیشتر از 100 کاراکتر باشد ."" data-val-maxlength-max=""100"" id=""fullName"" name=""fullName"" aria-describedby=""fullName-error"" aria-invalid=""false"">
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""fullName"" data-valmsg-replace=""true""></span>

                            </div>
                        </div>

                        <div class=""col-md-12"">
");
                WriteLiteral(@"                            <div class=""form-group"">
                                <label class=""control-label"">شماره همراه</label>
                                <input class=""form-control valid"" type=""text"" data-val=""true"" data-val-maxlength=""شماره همراه نمی تواند بیشتر از 11 کاراکتر باشد ."" data-val-maxlength-max=""11"" data-val-minlengt-min=""11"" id=""mobile"" name=""mobile"" aria-describedby=""mobile-error"" aria-invalid=""false"">
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""mobile"" data-valmsg-replace=""true""></span>
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label class=""control-label"">کد</label>
                                <input class=""form-control valid"" type=""text"" data-val=""true"" data-val-maxlength=""کد نمی تواند بیشتر از 6 کاراکتر باشد ."" data-val-maxlength-max=""6"" id=""code"" name=""code""");
                WriteLiteral(@" aria-describedby=""code-error"" aria-invalid=""false"">
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""code"" data-valmsg-replace=""true""></span>
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label class=""control-label"">رمز عبور</label>

                                <input class=""form-control valid"" type=""text"" data-val=""true"" data-val-maxlength=""پسورد نمی تواند بیشتر از 20 کاراکتر باشد ."" data-val-maxlength-max=""20"" id=""passwordShow"" name=""passwordShow"" aria-describedby=""passwordShow-error"" aria-invalid=""false"">
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""passwordShow"" data-valmsg-replace=""true""></span>

                            </div>
                        </div>
                        <div class=""col-md-12"">
                          ");
                WriteLiteral(@"  <div class=""form-group"">
                                <label class=""control-label"">نام کاربری</label>
                                <input class=""form-control valid"" type=""text"" data-val=""true"" data-val-maxlength=""نام کاربری نمی تواند بیشتر از 100 کاراکتر باشد ."" data-val-maxlength-max=""100"" id=""userName"" name=""userName"" aria-describedby=""userName-error"" aria-invalid=""false"">
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""userName"" data-valmsg-replace=""true""></span>

                            </div>
                        </div>


                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9628, 402, true);
            WriteLiteral(@"

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">انصراف</button>
                <button type=""button"" class=""btn btn-success"" onclick=""Save();"">ثبت</button>
            </div>
        </div>
    </div>
</div>
<div id=""Error"">

</div>
<div id=""Success"">

</div>
<div id=""Question"">

</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(10053, 3124, true);
                WriteLiteral(@"
    <script>
        $('#checkbox1').change(function () {
            if (this.checked) {
                var isChecked = $(this).prop(""checked"");
                $('#example2 tr:has(td)').find('input[type=""checkbox""]').prop('checked', isChecked);
            }
        });
        $('.deleteAll').on('click', function () {
            var array = [];
            $('#example2 tr:has(td)').find(""input[type='checkbox']:checked"").each(function () {
                array.push(parseInt($(this).val()));
            });

            swal({
                title: ' مطمئن هستید؟',
                text: 'آیا از حذف رکورد انتخابی اطمینان دارید؟!',
                type: 'warning',
                showCancelButton: true,
                buttonsStyling: false,
                confirmButtonClass: 'btn btn-danger',
                confirmButtonText: '! بله ',
                cancelButtonClass: 'btn btn-light',
                background: 'rgba(0, 0, 0, 0.96)'
            }).then(function () {

      ");
                WriteLiteral(@"          $.ajax({
                    type: ""POST"",
                    url: ""/User/DeleteAll"",
                    data: { ids: array },
                    success: function (response) {
                        if (response == ""Success"")
                            window.location.href = ""/Oprator/Index"";
                        else
                            window.location.href = ""/Oprator/Index?isSuccess=true"";

                    }
                });
            });
        })
        $(""#export"").on('click', function () {
            var filteruserName = $(""#filteruserName"").val();
            window.location.href = '/Oprator/ExportToExcel?filteruserName=' + filteruserName;
        });
    </script>
    
    <script>
        window.onload = Load;
        function Load() {
            CreateAllModals();
            $("".openmodal"").click(function () {
                clear('register', [""input""]);

            });
            $("".btn-warning"").click(function () {
        ");
                WriteLiteral(@"        EditAjax(""../Oprator/OpratorInfo"", this.id);
                var bodyStyle = document.body.style;
                bodyStyle.removeProperty('padding-right');
            });
        }
        function Save() {
            if (checkvalidity('register') === 0) {
                return;
            }
            else {
                $(""#myModal"").modal('toggle');
                var Parameters = [{ id: ""id"", htmlname: ""OpratorId"", special: """" },
                    { id: ""password"", htmlname: ""password"", special: """" },
                    { id: ""token"", htmlname: ""token"", special: """" },
                    { id: ""code"", htmlname: ""code"", special: """" },
                    { id: ""mobile"", htmlname: ""mobile"", special: """" },
                    { id: ""passwordShow"", htmlname: ""passwordShow"", special: """" },
                    { id: ""userName"", htmlname: ""userName"", special: """" },
                    { id: ""fullName"", htmlname: ""fullName"", special: """" }];
                PostAjax('../Opra");
                WriteLiteral("tor/Register\', Parameters, \"../Oprator/Index?page=\"+");
                EndContext();
                BeginContext(13178, 16, false);
#line 276 "E:\Atrin\GhasedakFromGit2\Ghasedak\Ghasedak\Ghasedak\Views\Oprator\Index.cshtml"
                                                                                Write(Model.PageNumber);

#line default
#line hidden
                EndContext();
                BeginContext(13194, 493, true);
                WriteLiteral(@"+"""");
            }
        }
        function AssignButtonClicked(elem) {
            $('#OpratorId').val($(elem).data('assigned-id'));
            var username = $(elem).data('assigned-username');
            $('#QuestionModal').find(""h4"").html(username);
        }
        function Remove() {
            var Parameters = [{ id: ""id"", htmlname: ""OpratorId"", special: """" }];
            PostAjax('../Oprator/Delete', Parameters, ""../Oprator/Index"");
        }


    </script>
");
                EndContext();
            }
            );
            BeginContext(13690, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<Ghasedak.Models.Oprator>> Html { get; private set; }
    }
}
#pragma warning restore 1591
