@ModelType IEnumerable(Of BusApp.Models.BusApp)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<div>
    <h2> Contact Directory List 1</h2>
</div>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FamilyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.HomePhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WorkPhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
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
            @Html.DisplayFor(Function(modelItem) item.Address)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.HomePhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.WorkPhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID })
        </td>
    </tr>
Next

</table>
