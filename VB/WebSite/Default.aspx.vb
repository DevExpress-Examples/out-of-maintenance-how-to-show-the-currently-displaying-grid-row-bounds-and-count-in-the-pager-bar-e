Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub lbCaption_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim label As ASPxLabel = TryCast(sender, ASPxLabel)
		Dim container As GridViewPagerBarTemplateContainer = TryCast(label.NamingContainer, GridViewPagerBarTemplateContainer)

		Dim firstItem As Integer = container.Grid.VisibleStartIndex + 1
		Dim lastItem As Integer
		If (container.Grid.PageIndex = -1) Then
			lastItem = container.Grid.VisibleRowCount
		Else
			lastItem = Math.Min(firstItem + container.Grid.SettingsPager.PageSize - 1, container.Grid.VisibleRowCount)
		End If

		label.Text = String.Format("Displaying items {0} - {1} of {2}", firstItem, lastItem, container.Grid.VisibleRowCount)
	End Sub
End Class