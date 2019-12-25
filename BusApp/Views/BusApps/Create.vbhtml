@ModelType BusApp.Models.BusApp
@Code
    ViewData("Title") = "Create"
End Code


<div>
    
    @Using (Html.BeginForm("FileUpload", "Index", Nothing, FormMethod.Post, New With {.enctype = "multipart/form-data"}))

        @<div>
            @Html.TextBox("file", "", New With {.type = "file"})
            <input id="FileUpload" type="submit" value="Save File" accept="image/vcf"/>
        </div>
    End Using
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
