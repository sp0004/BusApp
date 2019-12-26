Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ContactList.ContactList
Imports Thought.vCards

Namespace Controllers
    Public Class BusinessContactListsController
        Inherits System.Web.Mvc.Controller

        Private db As New BusinessCardDBEntities

        ' GET: BusinessContactLists
        Function Index() As ActionResult

            Return View(db.BusinessContactLists.ToList())
        End Function


        Function FileUpload(file As HttpPostedFileBase) As ActionResult

            If file.ContentLength > 0 Then
                Dim fileName = IO.Path.GetFileName(file.FileName)
                Dim path = IO.Path.Combine(Server.MapPath("~/Uploads"), fileName)
                file.SaveAs(path)
                Dim card As New vCard(path)
                Dim HomePhone, WorkPhone As Int64
                Dim  Address, WorkEmail, OtherEmail As String
                For Each Phone In card.Phones
                    If (Phone.IsHome = True) Then
                        HomePhone = Phone.FullNumber
                    ElseIf (Phone.IsWork = True) Then
                        WorkPhone = Phone.FullNumber
                    End If
                Next
                WorkEmail = card.EmailAddresses(0).ToString
                OtherEmail = card.EmailAddresses(1).ToString
                Address = card.DeliveryAddresses.ToString
                Dim AddValToDB As New BusinessContactList
                AddValToDB.Name = card.FamilyName.ToString
                AddValToDB.FamilyName = card.FamilyName.ToString
                AddValToDB.Address = card.DeliveryAddresses.ToString
                AddValToDB.WorkEmail = WorkEmail
                AddValToDB.OtherEmail = OtherEmail
                AddValToDB.CompanyName = card.Organization.ToString
                AddValToDB.JobTitle = card.Role.ToString
                AddValToDB.WorkPhone = WorkPhone
                AddValToDB.HomePhone = HomePhone

                db.BusinessContactLists.Add(AddValToDB)
                db.SaveChanges()


            End If
            Return RedirectToAction("Index")
        End Function






        ' GET: BusinessContactLists/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim businessContactList As BusinessContactList = db.BusinessContactLists.Find(id)
            If IsNothing(businessContactList) Then
                Return HttpNotFound()
            End If
            Return View(businessContactList)
        End Function


        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: BusinessContactLists/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Name,FamilyName,Address,HomePhone,WorkPhone,WorkEmail,OtherEmail,CompanyName,JobTitle")> ByVal businessContactList As BusinessContactList) As ActionResult
            If ModelState.IsValid Then
                db.BusinessContactLists.Add(businessContactList)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(businessContactList)
        End Function

        ' GET: BusinessContactLists/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim businessContactList As BusinessContactList = db.BusinessContactLists.Find(id)
            If IsNothing(businessContactList) Then
                Return HttpNotFound()
            End If
            Return View(businessContactList)
        End Function

        ' POST: BusinessContactLists/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Name,FamilyName,Address,HomePhone,WorkPhone,WorkEmail,OtherEmail,CompanyName,JobTitle")> ByVal businessContactList As BusinessContactList) As ActionResult
            If ModelState.IsValid Then
                db.Entry(businessContactList).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(businessContactList)
        End Function

        ' GET: BusinessContactLists/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim businessContactList As BusinessContactList = db.BusinessContactLists.Find(id)
            If IsNothing(businessContactList) Then
                Return HttpNotFound()
            End If
            Return View(businessContactList)
        End Function

        ' POST: BusinessContactLists/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim businessContactList As BusinessContactList = db.BusinessContactLists.Find(id)
            db.BusinessContactLists.Remove(businessContactList)
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
