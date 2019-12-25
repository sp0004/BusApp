Imports BusApp.Models
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace DAL
    Public Class BusAppContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("BusApplicationContext")
        End Sub

        Public Property BusApps As DbSet(Of BusApp.Models.BusApp)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
        End Sub
    End Class
End Namespace
