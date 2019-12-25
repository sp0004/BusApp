@Code
    ViewData("Title") = "Home Page"
End Code

    <div class="jumbotron">
        <div>
            <h2> Contact Directory List</h2>
        </div>
        <div>
            Add a Business Card
            @Using (Html.BeginForm("FileUpload", "Index", Nothing, FormMethod.Post, New With {.enctype = "multipart/form-data"}))

                @<div>
                    @Html.TextBox("file", "", New With {.type = "file"})
                    <input type="submit" value="Save File" />
                </div>
            End Using
        </div>

    </div>
