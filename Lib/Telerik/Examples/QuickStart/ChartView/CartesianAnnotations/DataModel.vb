Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
    Public Class DataModel
        Private dataSet As DataSet

        Public Function GetGoogleEventData() As IEnumerable(Of CompanyEvent)
            Dim result As New List(Of CompanyEvent)

            result.Add(New CompanyEvent(New DateTime(2007, 11, 1), String.Format("Nov 01, 2007{0}Android is announced", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2008, 9, 1), String.Format("Sep 01, 2008{0}Google introduced new{0}open source browser -{0}Chrome", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2009, 6, 1), String.Format("Jun, 2009{0}The Google Translator{0}Toolkit is released", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2009, 12, 1), String.Format("Dec, 2009{0}New real-time search{0}feature is added", Environment.NewLine), New SizeF(0, 50)))
            result.Add(New CompanyEvent(New DateTime(2010, 3, 1), String.Format("Mar, 2010{0}The Google Apps Market-{0}place is live", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2011, 2, 1), String.Format("Feb, 2011{0}A new search algorithm is{0}implemented", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2011, 6, 1), String.Format("Jun, 2011{0}The Google+ project is{0}launched", Environment.NewLine), New SizeF(0, 50)))

            Return result
        End Function

        Public Function GetMicrosoftEventData() As IEnumerable(Of CompanyEvent)
            Dim result As New List(Of CompanyEvent)

            result.Add(New CompanyEvent(New DateTime(2007, 1, 30), String.Format("Jan 30, 2007{0}Microsoft releases Windows{0}Vista and Office 2007 to the{0}general public", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2008, 10, 27), String.Format("Oct 27, 2008{0}Microsoft launched Azure{0}Services Platform", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2009, 10, 22), String.Format("Oct 22, 2009{0}Microsoft officially released{0}Windows 7", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2011, 2, 11), String.Format("Feb 11, 2011{0}Microsoft in partnership{0}with Nokia", Environment.NewLine), SizeF.Empty))

            Return result
        End Function

        Public Function GetAppleEventData() As IEnumerable(Of CompanyEvent)
            Dim result As New List(Of CompanyEvent)

            result.Add(New CompanyEvent(New DateTime(2007, 6, 29), String.Format("Jun 29, 2007{0}The first Iphone{0}was released", Environment.NewLine), New SizeF(0, 50)))
            result.Add(New CompanyEvent(New DateTime(2007, 9, 1), String.Format("Sep, 2007{0}iPod touch was released", Environment.NewLine), New SizeF(0, 100)))
            result.Add(New CompanyEvent(New DateTime(2008, 1, 1), String.Format("Jan, 2008{0}MacBook Air - the thinnest{0}Apple laptop was{0}announced", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2010, 1, 27), String.Format("Jan 27, 2010{0}Apple announced a large{0}screen, table-like media{0}device known as the iPad", Environment.NewLine), New SizeF(0, 50)))
            result.Add(New CompanyEvent(New DateTime(2010, 6, 1), String.Format("Jun, 2010{0}Apple introduced iPhone 4", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2011, 3, 1), String.Format("Mar, 2011{0}iPad2 was introduced", Environment.NewLine), New SizeF(0, 100)))
            result.Add(New CompanyEvent(New DateTime(2011, 6, 1), String.Format("Jun, 2011{0}Steve Jobs Unveiled iCloud", Environment.NewLine), New SizeF(0, 50)))
            result.Add(New CompanyEvent(New DateTime(2011, 8, 24), String.Format("Aug 24, 2011{0}Steve Jobs resigned{0}his position as CEO", Environment.NewLine), SizeF.Empty))

            Return result
        End Function

        Public Function GetAdobeEventData() As IEnumerable(Of CompanyEvent)
            Dim result As New List(Of CompanyEvent)

            result.Add(New CompanyEvent(New DateTime(2007, 3, 27), String.Format("Mar 27, 2007{0}Adobe announced CS3", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2008, 2, 25), String.Format("Feb 25, 2008{0}Adobe AIR was launched", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2008, 10, 15), String.Format("Oct 15, 2008{0}Adobe CS4 was officially{0}released", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2009, 9, 15), String.Format("Sep 15, 2009{0}Adobe acquires Omniture", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2010, 4, 30), String.Format("Apr 30, 2010{0}Adobe CS5 was released", Environment.NewLine), SizeF.Empty))
            result.Add(New CompanyEvent(New DateTime(2011, 11, 9), String.Format("Nov 09, 2011{0}The development of flash{0}for mobile devices will stop{0}and the focus will be on{0}HTML 5", Environment.NewLine), SizeF.Empty))

            Return result
        End Function

        Public Function GetData() As DataSet
            Return Me.dataSet
        End Function

        Public Sub New()
            Me.dataSet = New DataSet()
            Me.dataSet.Tables.Add("Google Inc.")
            Me.dataSet.Tables.Add("Microsoft Corporation")
            Me.dataSet.Tables.Add("Apple Inc.")
            Me.dataSet.Tables.Add("Adobe Systems Inc.")

            For Each table As DataTable In Me.dataSet.Tables
                table.Columns.Add("Date", GetType(DateTime))
                table.Columns.Add("Value", GetType(Double))
            Next table

            Me.GetData("..\ChartView\CartesianAnnotations\USRecessionCompanyData.csv")
        End Sub

        Private Sub GetData(ByVal fileName As String)
            Using fileReader As StreamReader = New StreamReader(fileName)
                Me.GetDataCompleted(Me.ParseData(fileReader))
            End Using
        End Sub

        Protected Sub GetDataCompleted(ByVal data As IEnumerable(Of CompanyStats))
            For Each entry As CompanyStats In data
                Me.dataSet.Tables(entry.Name).Rows.Add(entry.Date, entry.Value)
            Next entry
        End Sub

        Protected Function ParseData(ByVal dataReader As TextReader) As IEnumerable(Of CompanyStats)

            Dim result As New List(Of CompanyStats)
            Dim line As String = dataReader.ReadLine()

            While line IsNot Nothing
                If String.IsNullOrEmpty(line) Then
                    Continue While
                End If

                Dim data As String() = line.Split(","c)

                Dim stat As CompanyStats = New CompanyStats()
                stat.Name = data(0).Trim()
                stat.Date = DateTime.Parse(data(1), CultureInfo.InvariantCulture)
                stat.Value = Double.Parse(data(2), CultureInfo.InvariantCulture)
                result.Add(stat)

                line = dataReader.ReadLine()
            End While

            Return result
        End Function
    End Class
End Namespace
