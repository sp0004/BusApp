@ModelType ContactList.ContactList.BusinessContactList
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>BusinessContactList</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FamilyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FamilyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.HomePhone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.HomePhone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WorkPhone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WorkPhone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.WorkEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.WorkEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OtherEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OtherEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CompanyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.JobTitle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.JobTitle)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
