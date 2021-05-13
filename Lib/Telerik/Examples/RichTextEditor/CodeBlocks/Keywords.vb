
Imports System.Collections.Generic

Namespace RichTextEditor.CodeBlocks
    Public NotInheritable Class Keywords
        Private Sub New()
        End Sub
#Region "VB keywords"

        Private Shared m_vb As New List(Of String)() From { _
            "AddHandler", _
            "AddressOf", _
            "AndAlso", _
            "Alias", _
            "And", _
            "Ansi", _
            "As", _
            "Assembly", _
            "Auto", _
            "Boolean", _
            "ByRef", _
            "Byte", _
            "ByVal", _
            "Call", _
            "Case", _
            "Catch", _
            "CBool", _
            "CByte", _
            "CChar", _
            "CDate", _
            "CDec", _
            "CDbl", _
            "Char", _
            "CInt", _
            "Class", _
            "CLng", _
            "CObj", _
            "Const", _
            "CShort", _
            "CSng", _
            "CStr", _
            "CType", _
            "Date", _
            "Decimal", _
            "Declare", _
            "Default", _
            "Delegate", _
            "Dim", _
            "DirectCast", _
            "Do", _
            "Double", _
            "Each", _
            "Else", _
            "ElseIf", _
            "End", _
            "Enum", _
            "Erase", _
            "Error", _
            "Event", _
            "Exit", _
            "False", _
            "Finally", _
            "For", _
            "Friend", _
            "Function", _
            "Get", _
            "GetType", _
            "GoSub", _
            "GoTo", _
            "Handles", _
            "If", _
            "Implements", _
            "Imports", _
            "In", _
            "Inherits", _
            "Integer", _
            "Interface", _
            "Is", _
            "Let", _
            "Lib", _
            "Like", _
            "Long", _
            "Loop", _
            "Me", _
            "Mod", _
            "Module", _
            "MustInherit", _
            "MustOverride", _
            "MyBase", _
            "MyClass", _
            "Namespace", _
            "New", _
            "Next", _
            "Not", _
            "Nothing", _
            "NotInheritable", _
            "NotOverridable", _
            "Object", _
            "On", _
            "Option", _
            "Optional", _
            "Or", _
            "OrElse", _
            "Overloads", _
            "Overridable", _
            "Overrides", _
            "ParamArray", _
            "Preserve", _
            "Private", _
            "Property", _
            "Protected", _
            "Public", _
            "RaiseEvent", _
            "ReadOnly", _
            "ReDim", _
            "REM", _
            "RemoveHandler", _
            "Resume", _
            "Return", _
            "Select", _
            "Set", _
            "Shadows", _
            "Shared", _
            "Short", _
            "Single", _
            "Static", _
            "Step", _
            "Stop", _
            "String", _
            "Structure", _
            "Sub", _
            "SyncLock", _
            "Then", _
            "Throw", _
            "To", _
            "True", _
            "Try", _
            "TypeOf", _
            "Unicode", _
            "Until", _
            "Variant", _
            "When", _
            "While", _
            "With", _
            "WithEvents", _
            "WriteOnly", _
            "Xor" _
        }

#End Region

        Public Shared ReadOnly Property Vb() As List(Of String)
            Get
                Return m_vb
            End Get
        End Property

    End Class
End Namespace
