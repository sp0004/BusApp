@ModelType IEnumerable(Of ContactList.ContactList.BusinessContactList)
@Code
    ViewData("Title") = "Index"
End Code
    <div>
        <h2>Index of all Contacts</h2>
    </div>


<table class="table" style="border:double">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FamilyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WorkPhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WorkEmail)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.JobTitle)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FamilyName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.WorkPhone)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.WorkEmail)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CompanyName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.JobTitle)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.ID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
            </td>
        </tr>
    Next

</table>
<div>
    <div>
        <h3> Please upload your business card here </h3>
    </div>
    <div>

        @Using (Html.BeginForm("FileUpload", "BusinessContactLists", Nothing, FormMethod.Post, New With {.enctype = "multipart/form-data", .id = "UploadFile"}))

            @<div>
                @Html.TextBox("file", "", New With {.type = "file"})
                <br />
                <input id="FileUpload" type="submit" value="Save File" accept="image/vcf" />
            </div>
        End Using
    </div>
</div>
<style>
    #FileUpload {
        background-color: #4CAF50;
        border: none;
        color: white;
        padding: 12px 22px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        margin: 4px 2px;
        cursor: pointer;
    }
</style>