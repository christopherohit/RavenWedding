Namespace Telerik.Examples.WinControls.Chat.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radChat1 = New Telerik.WinControls.UI.RadChat()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.doubleBufferedTableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radButtonSuggestedActions = New Telerik.WinControls.UI.RadButton()
            Me.radCheckBoxShowAvatars = New Telerik.WinControls.UI.RadCheckBox()
            Me.radButtonMediaMessages = New Telerik.WinControls.UI.RadButton()
            Me.radCheckBoxOneSidedMessages = New Telerik.WinControls.UI.RadCheckBox()
            Me.radButtonTextMessages = New Telerik.WinControls.UI.RadButton()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.doubleBufferedTableLayoutPanel4 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radRadioButtonShowAsOverlay = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonShowAsPopup = New Telerik.WinControls.UI.RadRadioButton()
            Me.radButtonTimeOverlay = New Telerik.WinControls.UI.RadButton()
            Me.radButtonListOverlay = New Telerik.WinControls.UI.RadButton()
            Me.radButtonDateTimeOverlay = New Telerik.WinControls.UI.RadButton()
            Me.radButtonCalendarOverlay = New Telerik.WinControls.UI.RadButton()
            Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.doubleBufferedTableLayoutPanel3 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radButtonCarousel = New Telerik.WinControls.UI.RadButton()
            Me.radButtonImageCard = New Telerik.WinControls.UI.RadButton()
            Me.radButtonWeatherCard = New Telerik.WinControls.UI.RadButton()
            Me.radButtonFlightCard = New Telerik.WinControls.UI.RadButton()
            Me.radButtonProductCard = New Telerik.WinControls.UI.RadButton()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radChat1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel2.SuspendLayout()
            CType(Me.radButtonSuggestedActions, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxShowAvatars, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonMediaMessages, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxOneSidedMessages, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonTextMessages, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel4.SuspendLayout()
            CType(Me.radRadioButtonShowAsOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonShowAsPopup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonTimeOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonListOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonDateTimeOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonCalendarOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox3.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel3.SuspendLayout()
            CType(Me.radButtonCarousel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonImageCard, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonWeatherCard, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonFlightCard, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonProductCard, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(995, 25)
            Me.settingsPanel.Margin = New System.Windows.Forms.Padding(8)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.settingsPanel.PanelContainer.Margin = New System.Windows.Forms.Padding(8)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(478, 839)
            Me.settingsPanel.Size = New System.Drawing.Size(478, 839)
            Me.optionsLabel.Location = New System.Drawing.Point(10, 10)
            Me.optionsLabel.Margin = New System.Windows.Forms.Padding(8)
            Me.radChat1.AvatarSize = New System.Drawing.SizeF(72.91669F, 67.3077F)
            Me.radChat1.Location = New System.Drawing.Point(1, 1)
            Me.radChat1.Margin = New System.Windows.Forms.Padding(8)
            Me.radChat1.Name = "radChat1"
            Me.radChat1.Size = New System.Drawing.Size(428, 761)
            Me.radChat1.TabIndex = 0
            Me.radChat1.Text = "radChat1"
            Me.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00")
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox1.Controls.Add(Me.doubleBufferedTableLayoutPanel2)
            Me.radGroupBox1.HeaderText = "Main"
            Me.radGroupBox1.Location = New System.Drawing.Point(8, 8)
            Me.radGroupBox1.Margin = New System.Windows.Forms.Padding(8)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(6, 44, 6, 2)
            Me.radGroupBox1.Size = New System.Drawing.Size(434, 250)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Main"
            Me.doubleBufferedTableLayoutPanel2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.doubleBufferedTableLayoutPanel2.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radButtonSuggestedActions, 0, 4)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radCheckBoxShowAvatars, 0, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radButtonMediaMessages, 0, 3)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radCheckBoxOneSidedMessages, 0, 1)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radButtonTextMessages, 0, 2)
            Me.doubleBufferedTableLayoutPanel2.Location = New System.Drawing.Point(18, 24)
            Me.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2"
            Me.doubleBufferedTableLayoutPanel2.RowCount = 5
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel2.Size = New System.Drawing.Size(397, 216)
            Me.doubleBufferedTableLayoutPanel2.TabIndex = 5
            Me.radButtonSuggestedActions.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonSuggestedActions.Location = New System.Drawing.Point(8, 180)
            Me.radButtonSuggestedActions.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonSuggestedActions.Name = "radButtonSuggestedActions"
            Me.radButtonSuggestedActions.Size = New System.Drawing.Size(381, 28)
            Me.radButtonSuggestedActions.TabIndex = 1
            Me.radButtonSuggestedActions.Text = "Suggested Actions"
            Me.radCheckBoxShowAvatars.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowAvatars.Location = New System.Drawing.Point(8, 8)
            Me.radCheckBoxShowAvatars.Margin = New System.Windows.Forms.Padding(8)
            Me.radCheckBoxShowAvatars.Name = "radCheckBoxShowAvatars"
            Me.radCheckBoxShowAvatars.Size = New System.Drawing.Size(86, 18)
            Me.radCheckBoxShowAvatars.TabIndex = 0
            Me.radCheckBoxShowAvatars.Text = "Show avatars"
            Me.radCheckBoxShowAvatars.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radButtonMediaMessages.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonMediaMessages.Location = New System.Drawing.Point(8, 137)
            Me.radButtonMediaMessages.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonMediaMessages.Name = "radButtonMediaMessages"
            Me.radButtonMediaMessages.Size = New System.Drawing.Size(381, 27)
            Me.radButtonMediaMessages.TabIndex = 1
            Me.radButtonMediaMessages.Text = "Media Messages"
            Me.radCheckBoxOneSidedMessages.Location = New System.Drawing.Point(8, 51)
            Me.radCheckBoxOneSidedMessages.Margin = New System.Windows.Forms.Padding(8)
            Me.radCheckBoxOneSidedMessages.Name = "radCheckBoxOneSidedMessages"
            Me.radCheckBoxOneSidedMessages.Size = New System.Drawing.Size(160, 18)
            Me.radCheckBoxOneSidedMessages.TabIndex = 0
            Me.radCheckBoxOneSidedMessages.Text = "Show messages on one side"
            Me.radButtonTextMessages.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonTextMessages.Location = New System.Drawing.Point(8, 94)
            Me.radButtonTextMessages.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonTextMessages.Name = "radButtonTextMessages"
            Me.radButtonTextMessages.Size = New System.Drawing.Size(381, 27)
            Me.radButtonTextMessages.TabIndex = 1
            Me.radButtonTextMessages.Text = "Text Messages"
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox2.Controls.Add(Me.doubleBufferedTableLayoutPanel4)
            Me.radGroupBox2.Controls.Add(Me.radButtonDateTimeOverlay)
            Me.radGroupBox2.Controls.Add(Me.radButtonCalendarOverlay)
            Me.radGroupBox2.HeaderText = "Overlays"
            Me.radGroupBox2.Location = New System.Drawing.Point(8, 528)
            Me.radGroupBox2.Margin = New System.Windows.Forms.Padding(8)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(6, 44, 6, 2)
            Me.radGroupBox2.Size = New System.Drawing.Size(434, 214)
            Me.radGroupBox2.TabIndex = 2
            Me.radGroupBox2.Text = "Overlays"
            Me.doubleBufferedTableLayoutPanel4.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.doubleBufferedTableLayoutPanel4.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel4.Controls.Add(Me.radRadioButtonShowAsOverlay, 0, 1)
            Me.doubleBufferedTableLayoutPanel4.Controls.Add(Me.radRadioButtonShowAsPopup, 0, 0)
            Me.doubleBufferedTableLayoutPanel4.Controls.Add(Me.radButtonTimeOverlay, 0, 3)
            Me.doubleBufferedTableLayoutPanel4.Controls.Add(Me.radButtonListOverlay, 0, 2)
            Me.doubleBufferedTableLayoutPanel4.Location = New System.Drawing.Point(9, 27)
            Me.doubleBufferedTableLayoutPanel4.Name = "doubleBufferedTableLayoutPanel4"
            Me.doubleBufferedTableLayoutPanel4.RowCount = 4
            Me.doubleBufferedTableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel4.Size = New System.Drawing.Size(406, 169)
            Me.doubleBufferedTableLayoutPanel4.TabIndex = 5
            Me.radRadioButtonShowAsOverlay.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRadioButtonShowAsOverlay.Location = New System.Drawing.Point(8, 50)
            Me.radRadioButtonShowAsOverlay.Margin = New System.Windows.Forms.Padding(8)
            Me.radRadioButtonShowAsOverlay.Name = "radRadioButtonShowAsOverlay"
            Me.radRadioButtonShowAsOverlay.Size = New System.Drawing.Size(100, 18)
            Me.radRadioButtonShowAsOverlay.TabIndex = 2
            Me.radRadioButtonShowAsOverlay.Text = "Show as overlay"
            Me.radRadioButtonShowAsOverlay.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.radRadioButtonShowAsPopup.Location = New System.Drawing.Point(8, 8)
            Me.radRadioButtonShowAsPopup.Margin = New System.Windows.Forms.Padding(8)
            Me.radRadioButtonShowAsPopup.Name = "radRadioButtonShowAsPopup"
            Me.radRadioButtonShowAsPopup.Size = New System.Drawing.Size(97, 18)
            Me.radRadioButtonShowAsPopup.TabIndex = 2
            Me.radRadioButtonShowAsPopup.TabStop = False
            Me.radRadioButtonShowAsPopup.Text = "Show as popup"
            Me.radButtonTimeOverlay.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonTimeOverlay.Location = New System.Drawing.Point(8, 134)
            Me.radButtonTimeOverlay.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonTimeOverlay.Name = "radButtonTimeOverlay"
            Me.radButtonTimeOverlay.Size = New System.Drawing.Size(390, 27)
            Me.radButtonTimeOverlay.TabIndex = 1
            Me.radButtonTimeOverlay.Text = "Show Time Overlay"
            Me.radButtonListOverlay.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonListOverlay.Location = New System.Drawing.Point(8, 92)
            Me.radButtonListOverlay.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonListOverlay.Name = "radButtonListOverlay"
            Me.radButtonListOverlay.Size = New System.Drawing.Size(390, 26)
            Me.radButtonListOverlay.TabIndex = 1
            Me.radButtonListOverlay.Text = "Show List Overlay"
            Me.radButtonDateTimeOverlay.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonDateTimeOverlay.Location = New System.Drawing.Point(32, 385)
            Me.radButtonDateTimeOverlay.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonDateTimeOverlay.Name = "radButtonDateTimeOverlay"
            Me.radButtonDateTimeOverlay.Size = New System.Drawing.Size(370, 60)
            Me.radButtonDateTimeOverlay.TabIndex = 1
            Me.radButtonDateTimeOverlay.Text = "Show Date Time Overlay"
            Me.radButtonCalendarOverlay.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonCalendarOverlay.Location = New System.Drawing.Point(32, 312)
            Me.radButtonCalendarOverlay.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonCalendarOverlay.Name = "radButtonCalendarOverlay"
            Me.radButtonCalendarOverlay.Size = New System.Drawing.Size(370, 60)
            Me.radButtonCalendarOverlay.TabIndex = 1
            Me.radButtonCalendarOverlay.Text = "Show Calendar Overlay"
            Me.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox3.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radGroupBox3.Controls.Add(Me.doubleBufferedTableLayoutPanel3)
            Me.radGroupBox3.HeaderText = "Cards"
            Me.radGroupBox3.Location = New System.Drawing.Point(8, 274)
            Me.radGroupBox3.Margin = New System.Windows.Forms.Padding(8)
            Me.radGroupBox3.Name = "radGroupBox3"
            Me.radGroupBox3.Padding = New System.Windows.Forms.Padding(6, 44, 6, 2)
            Me.radGroupBox3.Size = New System.Drawing.Size(434, 238)
            Me.radGroupBox3.TabIndex = 3
            Me.radGroupBox3.Text = "Cards"
            Me.doubleBufferedTableLayoutPanel3.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.doubleBufferedTableLayoutPanel3.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel3.Controls.Add(Me.radButtonCarousel, 0, 4)
            Me.doubleBufferedTableLayoutPanel3.Controls.Add(Me.radButtonImageCard, 0, 0)
            Me.doubleBufferedTableLayoutPanel3.Controls.Add(Me.radButtonWeatherCard, 0, 3)
            Me.doubleBufferedTableLayoutPanel3.Controls.Add(Me.radButtonFlightCard, 0, 1)
            Me.doubleBufferedTableLayoutPanel3.Controls.Add(Me.radButtonProductCard, 0, 2)
            Me.doubleBufferedTableLayoutPanel3.Location = New System.Drawing.Point(9, 24)
            Me.doubleBufferedTableLayoutPanel3.Name = "doubleBufferedTableLayoutPanel3"
            Me.doubleBufferedTableLayoutPanel3.RowCount = 5
            Me.doubleBufferedTableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel3.Size = New System.Drawing.Size(406, 206)
            Me.doubleBufferedTableLayoutPanel3.TabIndex = 5
            Me.radButtonCarousel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonCarousel.Location = New System.Drawing.Point(8, 172)
            Me.radButtonCarousel.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonCarousel.Name = "radButtonCarousel"
            Me.radButtonCarousel.Size = New System.Drawing.Size(390, 26)
            Me.radButtonCarousel.TabIndex = 1
            Me.radButtonCarousel.Text = "Show Carousel"
            Me.radButtonImageCard.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonImageCard.Location = New System.Drawing.Point(8, 8)
            Me.radButtonImageCard.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonImageCard.Name = "radButtonImageCard"
            Me.radButtonImageCard.Size = New System.Drawing.Size(390, 25)
            Me.radButtonImageCard.TabIndex = 1
            Me.radButtonImageCard.Text = "Show Image Card"
            Me.radButtonWeatherCard.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonWeatherCard.Location = New System.Drawing.Point(8, 131)
            Me.radButtonWeatherCard.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonWeatherCard.Name = "radButtonWeatherCard"
            Me.radButtonWeatherCard.Size = New System.Drawing.Size(390, 25)
            Me.radButtonWeatherCard.TabIndex = 1
            Me.radButtonWeatherCard.Text = "Show Weather Card"
            Me.radButtonFlightCard.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonFlightCard.Location = New System.Drawing.Point(8, 49)
            Me.radButtonFlightCard.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonFlightCard.Name = "radButtonFlightCard"
            Me.radButtonFlightCard.Size = New System.Drawing.Size(390, 25)
            Me.radButtonFlightCard.TabIndex = 1
            Me.radButtonFlightCard.Text = "Show Flight Card"
            Me.radButtonProductCard.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonProductCard.Location = New System.Drawing.Point(8, 90)
            Me.radButtonProductCard.Margin = New System.Windows.Forms.Padding(8)
            Me.radButtonProductCard.Name = "radButtonProductCard"
            Me.radButtonProductCard.Size = New System.Drawing.Size(390, 25)
            Me.radButtonProductCard.TabIndex = 1
            Me.radButtonProductCard.Text = "Show Product Card"
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radGroupBox1, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radGroupBox2, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radGroupBox3, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
            Me.doubleBufferedTableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 3
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.46667F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.86666F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.53333F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(450, 750)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 4
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radChat1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2103, 1156)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radChat1, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radChat1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel2.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel2.PerformLayout()
            CType(Me.radButtonSuggestedActions, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxShowAvatars, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonMediaMessages, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxOneSidedMessages, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonTextMessages, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel4.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel4.PerformLayout()
            CType(Me.radRadioButtonShowAsOverlay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonShowAsPopup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonTimeOverlay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonListOverlay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonDateTimeOverlay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonCalendarOverlay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox3.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel3.ResumeLayout(False)
            CType(Me.radButtonCarousel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonImageCard, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonWeatherCard, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonFlightCard, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonProductCard, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private radChat1 As Telerik.WinControls.UI.RadChat
        Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radCheckBoxShowAvatars As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxOneSidedMessages As Telerik.WinControls.UI.RadCheckBox
        Private radButtonWeatherCard As Telerik.WinControls.UI.RadButton
        Private radButtonProductCard As Telerik.WinControls.UI.RadButton
        Private radButtonFlightCard As Telerik.WinControls.UI.RadButton
        Private radButtonImageCard As Telerik.WinControls.UI.RadButton
        Private radRadioButtonShowAsOverlay As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonShowAsPopup As Telerik.WinControls.UI.RadRadioButton
        Private radButtonDateTimeOverlay As Telerik.WinControls.UI.RadButton
        Private radButtonCalendarOverlay As Telerik.WinControls.UI.RadButton
        Private radButtonTimeOverlay As Telerik.WinControls.UI.RadButton
        Private radButtonListOverlay As Telerik.WinControls.UI.RadButton
        Private radButtonCarousel As Telerik.WinControls.UI.RadButton
        Private radButtonSuggestedActions As Telerik.WinControls.UI.RadButton
        Private radButtonMediaMessages As Telerik.WinControls.UI.RadButton
        Private radButtonTextMessages As Telerik.WinControls.UI.RadButton
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedTableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedTableLayoutPanel4 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedTableLayoutPanel3 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
