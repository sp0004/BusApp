Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return RedirectToAction("Index", "BusApps", New With {.area = "Admin"})
        'Return View()
    End Function


End Class
