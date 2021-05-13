Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.FontDropDownList
    Class FontDropDownListCommandBarItem
        Inherits RadCommandBarBaseItem

        Private fontDropDownList1 As RadFontPopupEditorElement

        Public ReadOnly Property FontDropDownList As RadFontPopupEditorElement
            Get
                Return Me.fontDropDownList1
            End Get
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            Me.DrawText = False
            Me.fontDropDownList1 = New RadFontPopupEditorElement()
            Me.fontDropDownList1.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize
            Me.fontDropDownList1.AutoSize = True
            Me.StretchHorizontally = CSharpImpl.__Assign(Me.StretchVertically, False)
            Me.MinSize = New System.Drawing.Size(170, 22)
            Me.Children.Add(Me.fontDropDownList)
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
