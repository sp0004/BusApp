@ModelType BusApp.Models.BusApp
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>BusApp</h4>
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
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
