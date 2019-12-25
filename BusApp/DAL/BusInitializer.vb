Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.Entity
Imports BusApp.Models
Imports BusApp.Models.BusApp

Namespace DAL
    Public Class BusInitializer
        Inherits DropCreateDatabaseIfModelChanges(Of BusAppContext)
        Protected Overrides Sub Seed(ByVal context As BusAppContext)
            Dim CardDet = New List(Of BusApp.Models.BusApp)() From {
                New BusApp.Models.BusApp With {
                    .Name = "test",
                    .FamilyName = "Test",
                    .Address = "123 Abc Street",
                    .Email = "Email @phone.com",
                    .HomePhone = "839381202",
                    .WorkPhone = "None"
            }}
            CardDet.ForEach(Function(s) context.BusApps.Add(s))
            context.SaveChanges()


        End Sub
    End Class
End Namespace