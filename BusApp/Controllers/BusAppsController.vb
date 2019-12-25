Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports BusApp.DAL
Imports BusApp.Models

Namespace Controllers
    Public Class BusAppsController
        Inherits System.Web.Mvc.Controller

        Private db As New BusApp.DAL.BusAppContext

        ' GET: BusApps
        Function Index() As ActionResult

            Return View(db.BusApps.ToList())
        End Function

        ' GET: BusApps/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim busApp As BusApp.Models.BusApp = db.BusApps.Find(id)
            If IsNothing(busApp) Then
                Return HttpNotFound()
            End If
            Return View(busApp)
        End Function

       
        ' GET: BusApps/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim busApp As BusApp.Models.BusApp = db.BusApps.Find(id)
            If IsNothing(busApp) Then
                Return HttpNotFound()
            End If
            Return View(busApp)
        End Function

        ' POST: BusApps/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Name,FamilyName,Address,HomePhone,WorkPhone,Email")> ByVal busApp As BusApp.Models.BusApp) As ActionResult
            If ModelState.IsValid Then
                db.Entry(busApp).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(busApp)
        End Function

        ' GET: BusApps/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim busApp As BusApp.Models.BusApp = db.BusApps.Find(id)
            If IsNothing(busApp) Then
                Return HttpNotFound()
            End If
            Return View(busApp)
        End Function

        ' POST: BusApps/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim busApp As BusApp.Models.BusApp = db.BusApps.Find(id)
            db.BusApps.Remove(busApp)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
