Namespace Telerik.Examples.WinControls.Scheduler.FirstLook
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing


#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim dateTimeInterval2 As New Telerik.WinControls.UI.DateTimeInterval()
            Dim schedulerDailyPrintStyle2 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
            Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
            Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9 = New Telerik.WinControls.RootRadElement()
            Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
            Me.radSchedulerDemo = New Telerik.WinControls.UI.RadScheduler()
            Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
            Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radDesktopAlert1 = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
            Me.radSchedulerReminder1 = New Telerik.WinControls.UI.RadSchedulerReminder(Me.components)
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageView1.SuspendLayout()
            Me.radPageViewPage1.SuspendLayout()
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radCheckBox1)
            Me.settingsPanel.Controls.Add(Me.radLabel1)
            Me.settingsPanel.Controls.Add(Me.radDropDownList1)
            Me.settingsPanel.Location = New System.Drawing.Point(1283, 105)
            Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
            ' 
            ' radCalendar1
            ' 
            Me.radCalendar1.AllowMultipleView = True
            Me.radCalendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.radCalendar1.Location = New System.Drawing.Point(0, 0)
            Me.radCalendar1.Margin = New System.Windows.Forms.Padding(0)
            Me.radCalendar1.MultiViewRows = 3
            Me.radCalendar1.Name = "radCalendar1"
            Me.radCalendar1.SelectedDates.AddRange(New System.DateTime() {New System.DateTime(1900, 1, 1, 0, 0, 0, _
                0)})
            Me.radCalendar1.Size = New System.Drawing.Size(252, 530)
            Me.radCalendar1.TabIndex = 1
            Me.radCalendar1.Text = "radCalendar1"
            Me.radCalendar1.ZoomFactor = 1.2F
            ' 
            ' object_a65e45d6_6d0c_4754_ac40_31a6d96432e9
            ' 
            Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.MinSize = New System.Drawing.Size(400, 74)
            Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.Name = "object_a65e45d6_6d0c_4754_ac40_31a6d96432e9"
            Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchHorizontally = True
            Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchVertically = True
            Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radSchedulerNavigator1
            ' 
            Me.radSchedulerNavigator1.AssociatedScheduler = Me.radSchedulerDemo
            Me.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy"
            Me.radSchedulerNavigator1.Location = New System.Drawing.Point(272, 43)
            Me.radSchedulerNavigator1.MinimumSize = New System.Drawing.Size(400, 74)
            Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
            Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
            ' 
            ' 
            ' 
            Me.radSchedulerNavigator1.RootElement.MinSize = New System.Drawing.Size(400, 74)
            Me.radSchedulerNavigator1.RootElement.StretchVertically = False
            Me.radSchedulerNavigator1.Size = New System.Drawing.Size(723, 77)
            Me.radSchedulerNavigator1.TabIndex = 8
            DirectCast(Me.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            DirectCast(Me.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.RadLabelElement).Text = "11/02/2009 - 11/04/2009"
            ' 
            ' radSchedulerDemo
            ' 
            dateTimeInterval2.[End] = New System.DateTime(CLng(0))
            dateTimeInterval2.Start = New System.DateTime(CLng(0))
            Me.radSchedulerDemo.AccessibleInterval = dateTimeInterval2
            Me.radSchedulerDemo.AppointmentTitleFormat = Nothing
            Me.radSchedulerDemo.Culture = New System.Globalization.CultureInfo("en-US")
            Me.radSchedulerDemo.DataSource = Nothing
            Me.radSchedulerDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.radSchedulerDemo.HeaderFormat = "dd (ddd)"
            Me.radSchedulerDemo.Location = New System.Drawing.Point(272, 137)
            Me.radSchedulerDemo.Name = "radSchedulerDemo"
            schedulerDailyPrintStyle2.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            schedulerDailyPrintStyle2.DateEndRange = New System.DateTime(2013, 3, 17, 0, 0, 0, _
                0)
            schedulerDailyPrintStyle2.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
            schedulerDailyPrintStyle2.DateStartRange = New System.DateTime(2013, 3, 12, 0, 0, 0, _
                0)
            schedulerDailyPrintStyle2.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0F, System.Drawing.FontStyle.Bold)
            Me.radSchedulerDemo.PrintStyle = schedulerDailyPrintStyle2
            Me.radSchedulerDemo.Size = New System.Drawing.Size(723, 502)
            Me.radSchedulerDemo.TabIndex = 0
            ' 
            ' radPageView1
            ' 
            Me.radPageView1.Controls.Add(Me.radPageViewPage1)
            Me.radPageView1.Controls.Add(Me.radPageViewPage2)
            Me.radPageView1.Controls.Add(Me.radPageViewPage3)
            Me.radPageView1.Controls.Add(Me.radPageViewPage4)
            Me.radPageView1.Controls.Add(Me.radPageViewPage5)
            Me.radPageView1.ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
            Me.radPageView1.Location = New System.Drawing.Point(4, 43)
            Me.radPageView1.Name = "radPageView1"
            Me.radPageView1.SelectedPage = Me.radPageViewPage1
            Me.radPageView1.Size = New System.Drawing.Size(280, 596)
            Me.radPageView1.TabIndex = 11
            Me.radPageView1.Text = "radPageView1"
            Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Outlook
            ' 
            ' radPageViewPage1
            ' 
            Me.radPageViewPage1.Controls.Add(Me.radCalendar1)
            Me.radPageViewPage1.Image = My.Resources.OutlookViewCalendar
            Me.radPageViewPage1.ItemSize = New System.Drawing.SizeF(264.0F, 38.0F)
            Me.radPageViewPage1.Location = New System.Drawing.Point(5, 31)
            Me.radPageViewPage1.Name = "radPageViewPage1"
            Me.radPageViewPage1.Size = New System.Drawing.Size(252, 331)
            Me.radPageViewPage1.Text = "Calendar"
            ' 
            ' radPageViewPage2
            ' 
            Me.radPageViewPage2.BackgroundImage = My.Resources.Notes
            Me.radPageViewPage2.Image = My.Resources.OutlookViewNotes
            Me.radPageViewPage2.ItemSize = New System.Drawing.SizeF(264.0F, 38.0F)
            Me.radPageViewPage2.Location = New System.Drawing.Point(5, 31)
            Me.radPageViewPage2.Name = "radPageViewPage2"
            Me.radPageViewPage2.Size = New System.Drawing.Size(252, 331)
            Me.radPageViewPage2.Text = "Notes"
            ' 
            ' radPageViewPage3
            ' 
            Me.radPageViewPage3.BackgroundImage = My.Resources.Tasks
            Me.radPageViewPage3.Image = My.Resources.OutlookViewTasks
            Me.radPageViewPage3.ItemSize = New System.Drawing.SizeF(264.0F, 38.0F)
            Me.radPageViewPage3.Location = New System.Drawing.Point(5, 31)
            Me.radPageViewPage3.Name = "radPageViewPage3"
            Me.radPageViewPage3.Size = New System.Drawing.Size(252, 331)
            Me.radPageViewPage3.Text = "Tasks"
            ' 
            ' radPageViewPage4
            ' 
            Me.radPageViewPage4.BackgroundImage = My.Resources.Contacts
            Me.radPageViewPage4.Image = My.Resources.OutlookViewContacts
            Me.radPageViewPage4.ItemSize = New System.Drawing.SizeF(264.0F, 38.0F)
            Me.radPageViewPage4.Location = New System.Drawing.Point(5, 31)
            Me.radPageViewPage4.Name = "radPageViewPage4"
            Me.radPageViewPage4.Size = New System.Drawing.Size(252, 331)
            Me.radPageViewPage4.Text = "Contacts"
            ' 
            ' radPageViewPage5
            ' 
            Me.radPageViewPage5.BackgroundImage = My.Resources.Mail
            Me.radPageViewPage5.Image = My.Resources.OutlookViewMail
            Me.radPageViewPage5.ItemSize = New System.Drawing.SizeF(264.0F, 38.0F)
            Me.radPageViewPage5.Location = New System.Drawing.Point(5, 31)
            Me.radPageViewPage5.Name = "radPageViewPage5"
            Me.radPageViewPage5.Size = New System.Drawing.Size(252, 331)
            Me.radPageViewPage5.Text = "Mail"
            ' 
            ' radSchedulerReminder1
            ' 
            Me.radSchedulerReminder1.AssociatedScheduler = Nothing
            Me.radSchedulerReminder1.ThemeName = Nothing
            Me.radSchedulerReminder1.TimeInterval = 60000
            ' 
            ' radDropDownList1
            ' 
            Me.radDropDownList1.AllowShowFocusCues = False
            Me.radDropDownList1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radDropDownList1.AutoSize = False
            Me.radDropDownList1.Location = New System.Drawing.Point(10, 49)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(210, 20)
            Me.radDropDownList1.TabIndex = 1
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel1.Location = New System.Drawing.Point(10, 25)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(71, 18)
            Me.radLabel1.TabIndex = 14
            Me.radLabel1.Text = "Active editor:"
            ' 
            ' radCheckBox1
            ' 
            Me.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBox1.Location = New System.Drawing.Point(10, 87)
            Me.radCheckBox1.Name = "radCheckBox1"
            Me.radCheckBox1.Size = New System.Drawing.Size(184, 18)
            Me.radCheckBox1.TabIndex = 15
            Me.radCheckBox1.Text = "Allow Appointments Multi Select"
            ' 
            ' Form1
            ' 
            Me.Controls.Add(Me.radPageView1)
            Me.Controls.Add(Me.radSchedulerNavigator1)
            Me.Controls.Add(Me.radSchedulerDemo)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
            Me.Size = New System.Drawing.Size(1856, 894)
            Me.Controls.SetChildIndex(Me.radSchedulerDemo, 0)
            Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
            Me.Controls.SetChildIndex(Me.radPageView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageView1.ResumeLayout(False)
            Me.radPageViewPage1.ResumeLayout(False)
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radSchedulerDemo As Telerik.WinControls.UI.RadScheduler
        Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
        Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
        Private object_a65e45d6_6d0c_4754_ac40_31a6d96432e9 As Telerik.WinControls.RootRadElement
        Private radPageView1 As Telerik.WinControls.UI.RadPageView
        Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
        Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
        Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
        Private radPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
        Private radPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
        Private radDesktopAlert1 As Telerik.WinControls.UI.RadDesktopAlert
        Private radSchedulerReminder1 As Telerik.WinControls.UI.RadSchedulerReminder
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace