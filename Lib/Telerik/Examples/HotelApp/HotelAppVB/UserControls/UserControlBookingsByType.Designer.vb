Namespace HotelApp
	Partial Public Class UserControlBookingsByType
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
			Dim cartesianArea2 As New Telerik.WinControls.UI.CartesianArea()
			Dim cartesianArea3 As New Telerik.WinControls.UI.CartesianArea()
			Dim cartesianArea4 As New Telerik.WinControls.UI.CartesianArea()
			Me.bookingsByTypeChartView = New Telerik.WinControls.UI.RadChartView()
			Me.bookingsByRoomTypeChartView = New Telerik.WinControls.UI.RadChartView()
			Me.availabilityChartView = New Telerik.WinControls.UI.RadChartView()
			Me.averageChartView = New Telerik.WinControls.UI.RadChartView()
			CType(Me.bookingsByTypeChartView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingsByRoomTypeChartView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.availabilityChartView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.averageChartView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' bookingsByTypeChartView
			' 
			Me.bookingsByTypeChartView.AreaDesign = cartesianArea1
			Me.bookingsByTypeChartView.Dock = DockStyle.Left
			Me.bookingsByTypeChartView.Location = New Point(0, 0)
			Me.bookingsByTypeChartView.Name = "bookingsByTypeChartView"
			Me.bookingsByTypeChartView.ShowGrid = False
			Me.bookingsByTypeChartView.Size = New Size(300, 300)
			Me.bookingsByTypeChartView.TabIndex = 0
			Me.bookingsByTypeChartView.Text = "radChartView1"
			' 
			' bookingsByRoomTypeChartView
			' 
			Me.bookingsByRoomTypeChartView.AreaDesign = cartesianArea2
			Me.bookingsByRoomTypeChartView.Dock = DockStyle.Left
			Me.bookingsByRoomTypeChartView.Location = New Point(300, 0)
			Me.bookingsByRoomTypeChartView.Name = "bookingsByRoomTypeChartView"
			Me.bookingsByRoomTypeChartView.ShowGrid = False
			Me.bookingsByRoomTypeChartView.Size = New Size(300, 300)
			Me.bookingsByRoomTypeChartView.TabIndex = 1
			Me.bookingsByRoomTypeChartView.Text = "radChartView1"
			' 
			' availabilityChartView
			' 
			Me.availabilityChartView.AreaDesign = cartesianArea3
			Me.availabilityChartView.Dock = DockStyle.Left
			Me.availabilityChartView.Location = New Point(600, 0)
			Me.availabilityChartView.Name = "availabilityChartView"
			Me.availabilityChartView.ShowGrid = False
			Me.availabilityChartView.Size = New Size(300, 300)
			Me.availabilityChartView.TabIndex = 2
			Me.availabilityChartView.Text = "radChartView1"
			' 
			' averageChartView
			' 
			Me.averageChartView.AreaDesign = cartesianArea4
			Me.averageChartView.Dock = DockStyle.Fill
			Me.averageChartView.Location = New Point(900, 0)
			Me.averageChartView.Name = "averageChartView"
			Me.averageChartView.ShowGrid = False
			Me.averageChartView.Size = New Size(420, 300)
			Me.averageChartView.TabIndex = 3
			Me.averageChartView.Text = "averageStayChartView"
			' 
			' UserControlBookingsByType
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.averageChartView)
			Me.Controls.Add(Me.availabilityChartView)
			Me.Controls.Add(Me.bookingsByRoomTypeChartView)
			Me.Controls.Add(Me.bookingsByTypeChartView)
			Me.Name = "UserControlBookingsByType"
			Me.Size = New Size(1320, 300)
			CType(Me.bookingsByTypeChartView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingsByRoomTypeChartView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.availabilityChartView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.averageChartView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private bookingsByTypeChartView As Telerik.WinControls.UI.RadChartView
		Private bookingsByRoomTypeChartView As Telerik.WinControls.UI.RadChartView
		Private averageChartView As Telerik.WinControls.UI.RadChartView
		Private availabilityChartView As Telerik.WinControls.UI.RadChartView

	End Class
End Namespace
