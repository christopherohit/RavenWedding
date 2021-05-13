
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.InteropServices

'used code from https://code.msdn.microsoft.com/Fixing-Persian-Locale-for-6e66e044	  
Namespace Telerik.Examples.WinControls.Editors.DateTimePicker
    <Flags> _
    Public Enum FixCultureOptions
        ''' <summary>
        ''' If set Calendar property of culture will be set to PersianCalendar.
        ''' </summary>
        foptCalendarInCulture = 2
        ''' <summary>
        ''' If set Calendar of DateFormatInfo will be set to PersianCalendar
        ''' </summary>
        foptCalendarInDateFormatInfo = 4
        ''' <summary>
        ''' If set the first element of OptionalCalendars will be set to PersianCalendar
        ''' </summary>
        foptOptionalCalendars = 8
        ''' <summary>
        ''' All fix ups will applied.
        ''' </summary>
        foptAll = 16
    End Enum

    Public Class Helpers
        Private Shared ReadOnly m_List As New Dictionary(Of Object, InvokeHelper)()

        Public Shared Sub AddHelper(Instance As Object, helper As InvokeHelper)
            m_List.Add(Instance, helper)
        End Sub

        Public Shared Function find(Instance As Object) As InvokeHelper
            If m_List.ContainsKey(Instance) Then
                Return m_List(Instance)
            Else
                Return Nothing
            End If
        End Function
    End Class

    Public Class InvokeHelper
        Protected m_Instance As Object
        Private Shared ReadOnly Types As System.Collections.Generic.Dictionary(Of String, Type) = New Dictionary(Of String, Type)()
        Private ReadOnly m_Type As Type

        Public Sub New(Instance As Object)
            Me.m_Instance = Instance
            '            Helpers.AddHelper(Instance, this);
            Me.m_Type = Instance.[GetType]()
        End Sub

        Public Sub New(Instance As Object, type As Type)
            Me.m_Instance = Instance
            Me.m_Type = type
        End Sub

        Public ReadOnly Property Instance() As Object
            Get
                Return Me.m_Instance
            End Get
        End Property

        Public Shared Function FindType(TypeName As String) As Type
            If Types.ContainsKey(TypeName) Then
                Return Types(TypeName)
            End If
            Dim ret As Type = Nothing
            For Each assembly As Assembly In AppDomain.CurrentDomain.GetAssemblies()
                For Each [module] As [Module] In assembly.GetModules()
                    For Each type As Type In [module].GetTypes()
                        If type.FullName = TypeName Then
                            ret = type
                            Types.Add(TypeName, ret)
                            Return ret
                        End If
                    Next
                Next
            Next
            Types.Add(TypeName, ret)

            Return ret
        End Function

        Public Function HasField(FieldName As String) As Boolean
            For Each field As FieldInfo In Me.m_Type.GetFields(BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance)
                If field.Name = FieldName Then
                    Return True
                End If
            Next
            Return False
        End Function

        Public Function GetProperty(FieldName As String) As Object
            Return Me.m_Type.InvokeMember(FieldName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance Or BindingFlags.GetProperty, Nothing, Me.m_Instance, Nothing)
        End Function

        Public Function SetProperty(FieldName As String, Value As Object) As Object
            Return Me.m_Type.InvokeMember(FieldName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance Or BindingFlags.SetProperty, Nothing, Me.m_Instance, New Object() {Value})
        End Function

        Public Function GetField(FieldName As String, args As Object()) As Object
            Return Me.m_Type.InvokeMember(FieldName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance Or BindingFlags.GetField, Nothing, Me.m_Instance, args)
        End Function

        Public Function SetField(FieldName As String, args As Object()) As Object
            Return Me.m_Type.InvokeMember(FieldName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance Or BindingFlags.SetField, Nothing, Me.m_Instance, args)
        End Function

        Public Function SetField(FieldName As String, Value As Object) As Object
            Return Me.SetField(FieldName, New Object() {Value})
        End Function

        Public Function StaticGetProperty(PropertyName As String) As Object
            Return Me.m_Type.InvokeMember(PropertyName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.[Static] Or BindingFlags.GetProperty, Nothing, Nothing, Nothing)
        End Function

        Public Function CreateInstance(args As Object()) As Object
            Return Nothing
        End Function

        Public Function GetField(FieldName As String) As Object
            Return Me.GetField(FieldName, Nothing)
        End Function

        Public Function InvokeByRef(MethodName As String, ByRef args As Object(), modifiers As ParameterModifier) As Object
            Dim [mod] As ParameterModifier() = {modifiers}

            Return Me.m_Type.InvokeMember(MethodName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance Or BindingFlags.InvokeMethod, Nothing, Me.m_Instance, args, [mod], _
                Nothing, Nothing)
        End Function

        Public Function InvokeByOut(MethodName As String, args As Object(), modifiers As ParameterModifier) As Object
            Dim [mod] As ParameterModifier() = {modifiers}

            Return Me.m_Type.InvokeMember(MethodName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance Or BindingFlags.InvokeMethod, Nothing, Me.m_Instance, args, [mod], _
                Nothing, Nothing)
        End Function

        Public Function Invoke(MethodName As String, args As Object()) As Object
            Return Me.m_Type.InvokeMember(MethodName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance Or BindingFlags.InvokeMethod, Nothing, Me.m_Instance, args)
        End Function

        Public Function InvokeStatic(MethodName As String, args As Object()) As Object
            Return Me.m_Type.InvokeMember(MethodName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.[Static] Or BindingFlags.InvokeMethod, Nothing, Nothing, args)
        End Function

        Public Function InvokeStatic(MethodName As String, arg1 As Object, arg2 As Object) As Object
            Return Me.InvokeStatic(MethodName, New Object() {arg1, arg2})
        End Function

        Public Function InvokeStatic(MethodName As String, arg1 As Object) As Object
            Return Me.InvokeStatic(MethodName, New Object() {arg1})
        End Function

        Public Function InvokeStatic(MethodName As String) As Object
            Return Me.InvokeStatic(MethodName, Nothing)
        End Function

        'Public Function Invoke(MethodName As String) As Object
        '    Return Me.Invoke(MethodName, Nothing)
        'End Function

        Public Function Invoke(MethodName As String, arg1 As Object) As Object
            Return Me.Invoke(MethodName, New Object() {arg1})
        End Function

        Public Function Invoke(MethodName As String, arg1 As Integer) As Object
            Return Me.Invoke(MethodName, New Object() {arg1})
        End Function

        Public Function Invoke(MethodName As String, obj1 As Object, obj2 As Object) As Object
            Return Me.Invoke(MethodName, New Object() {obj1, obj2})
        End Function

        Public Function Invoke(MethodName As String, obj1 As Object, obj2 As Object, obj3 As Object) As Object
            Return Me.Invoke(MethodName, New Object() {obj1, obj2, obj3})
        End Function
    End Class

    ''' <summary>
    ''' Contains methods to fix the Persian culture for Persian calendar.
    ''' </summary>
    Friend Class PersianCultureHelper
        ''' <summary>
        ''' Fixes the DateTimeFormatInfo for Persian resources (months and week day names), and optionally sets the calendar to PersianCalendar.
        ''' </summary>
        ''' <param name="info">The DateTimeFormatInfo to be fixed.</param>
        ''' <param name="UsePersianCalendar">If set, the calendar will be set to PersianCalendar.</param>
        ''' <returns>The fixed DateTimeFormatInfo.</returns>
        Public Shared Function FixPersianDateTimeFormat(info As DateTimeFormatInfo, UsePersianCalendar As Boolean) As DateTimeFormatInfo
            Dim dateTimeFormatInfoReadOnly As FieldInfo = GetType(DateTimeFormatInfo).GetField("m_isReadOnly", BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance)
            Dim dateTimeFormatInfoCalendar As FieldInfo = GetType(DateTimeFormatInfo).GetField("calendar", BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance)

            If info Is Nothing Then
                info = New DateTimeFormatInfo()
            End If
            info.Calendar = New HijriCalendar()

            Dim [readOnly] As Boolean = CBool(dateTimeFormatInfoReadOnly.GetValue(info))
            If [readOnly] Then
                dateTimeFormatInfoReadOnly.SetValue(info, False)
            End If
            If UsePersianCalendar Then
                dateTimeFormatInfoCalendar.SetValue(info, New PersianCalendar())
            End If
            If (info.Calendar.GetType() Is GetType(PersianCalendar)) Then
                info.AbbreviatedDayNames = New String() {"ی", "د", "س", "چ", "پ", "ج", _
                    "ش"}
                info.ShortestDayNames = New String() {"ی", "د", "س", "چ", "پ", "ج", _
                    "ش"}
                info.DayNames = New String() {"یکشنبه", "دوشنبه", "ﺳﻪشنبه", "چهارشنبه", "پنجشنبه", "جمعه", _
                    "شنبه"}
                info.AbbreviatedMonthNames = New String() {"فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", _
                    "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", _
                    ""}
                info.MonthNames = New String() {"فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", _
                    "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", _
                    ""}
                info.AMDesignator = "ق.ظ"
                info.PMDesignator = "ب.ظ"
                info.FirstDayOfWeek = DayOfWeek.Saturday
                info.FullDateTimePattern = "yyyy MMMM dddd, dd HH:mm:ss"
                info.LongDatePattern = "yyyy MMMM dddd, dd"
                info.ShortDatePattern = "yyyy/MM/dd"
            End If
            If [readOnly] Then
                dateTimeFormatInfoReadOnly.SetValue(info, True)
            End If
            Return info
        End Function

        ''' <summary>
        ''' Fixes CultureInfo for Persian resoures (months and day names) and also PersianCalendar.
        ''' </summary>
        ''' <param name="culture">The CultureInfo instace to be fixed. If NULL, a new instance will be created and returned.</param>
        ''' <param name="options">Specifies what to be fixed.</param>
        ''' <returns>A new instance of fixed Persian CultureInfo.</returns>
        Public Shared Function FixPersianCulture(culture As CultureInfo, options As FixCultureOptions) As CultureInfo
            Dim calendarID As PropertyInfo = GetType(System.Globalization.Calendar).GetProperty("ID", BindingFlags.NonPublic Or BindingFlags.Instance)
            Dim cultureInfoReadOnly As FieldInfo = GetType(CultureInfo).GetField("m_isReadOnly", BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance)
            Dim cultureInfoCalendar As FieldInfo = GetType(CultureInfo).GetField("calendar", BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance)
            'FieldInfo cultureInfoReadOnly = typeof(CultureInfo).GetField("m_", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            If culture Is Nothing Then
                culture = New CultureInfo("fa-IR", False)
            End If
            If culture Is Nothing OrElse culture.LCID <> 1065 Then
                Return culture
            End If
            If (options And FixCultureOptions.foptAll) = FixCultureOptions.foptAll Then
                options = FixCultureOptions.foptCalendarInCulture Or FixCultureOptions.foptCalendarInDateFormatInfo Or FixCultureOptions.foptOptionalCalendars
            End If
            If (options And FixCultureOptions.foptOptionalCalendars) = FixCultureOptions.foptOptionalCalendars Then
                FixOptionalCalendars(culture, 4)
                culture = New CultureInfo("fa-IR", False)
            End If

            Dim [readOnly] As Boolean = CBool(cultureInfoReadOnly.GetValue(culture))
            If [readOnly] Then
                cultureInfoReadOnly.SetValue(culture, False)
            End If
            If (options And FixCultureOptions.foptCalendarInDateFormatInfo) = FixCultureOptions.foptCalendarInDateFormatInfo Then
                culture.DateTimeFormat = FixPersianDateTimeFormat(culture.DateTimeFormat, True)
            Else
                FixPersianDateTimeFormat(culture.DateTimeFormat, False)
            End If
            If (options And FixCultureOptions.foptCalendarInCulture) = FixCultureOptions.foptCalendarInCulture Then
                cultureInfoCalendar.SetValue(culture, New PersianCalendar())
            End If
            If [readOnly] Then
                cultureInfoReadOnly.SetValue(culture, True)
            End If
            Return culture
        End Function

        ''' <summary>
        ''' Creates, fixes and returns a new instance of Persian culture.
        ''' </summary>
        ''' <returns>A new instance of fixed Persian culture.</returns>
        Public Shared Function GetFixedPersianCulture() As CultureInfo
            Return FixPersianCulture(Nothing, FixCultureOptions.foptAll)
        End Function

        ''' <summary>
        ''' Set the CurrentCulture of current thread to a new fixed Persian culture.
        ''' </summary>
        ''' <returns>The fixed Persian cultreinfo.</returns>
        Public Shared Function FixAndSetCurrentCulture() As CultureInfo
            Dim culture As CultureInfo = FixPersianCulture(Nothing, FixCultureOptions.foptAll)
            Return culture
        End Function

        ''' <summary>
        ''' Sets the CalendarIndex element of OptionalCalendars of the passed caulture to PersianCalendar.
        ''' </summary>
        ''' <param name="culture">The CultureInfo instance to be fixed.</param>
        ''' <param name="CalenadrIndex">The index of element in optional calendars to be set to PersianCalendar. Note that this can not add a new element so that the idex should be les than the length of the OptionalCalendars array.</param>
        ''' <returns>The fixed culture.</returns>
        Public Shared Function FixOptionalCalendars(culture As CultureInfo, CalendarIndex As Integer) As CultureInfo
            Dim ivCultureInfo As New InvokeHelper(culture)
            If Not ivCultureInfo.HasField("m_cultureTableRecord") Then
                ' This is .Net 4. 
                Return _FixOptionalCalendars4(culture, CalendarIndex)
            End If

            Dim ivTableRecord As New InvokeHelper(ivCultureInfo.GetField("m_cultureTableRecord"))
            ' Get the m_pData pointer as *void
            Dim m_pData As System.Reflection.Pointer = DirectCast(ivTableRecord.GetField("m_pData"), System.Reflection.Pointer)
            Dim _intPtrCtor As ConstructorInfo = GetType(IntPtr).GetConstructor(New Type() {Type.[GetType]("System.Void*")})
            ' Construct a new IntPtr
            Dim DataIntPtr As IntPtr = DirectCast(_intPtrCtor.Invoke(New Object(0) {m_pData}), IntPtr)

            Dim TCultureTableData As Type = Type.[GetType]("System.Globalization.CultureTableData")
            ' Convert the Pointer class to object if type CultureTableData to work with
            ' reflection API.
            Dim oCultureTableData As [Object] = System.Runtime.InteropServices.Marshal.PtrToStructure(DataIntPtr, TCultureTableData)
            Dim ivCultureTableData As New InvokeHelper(oCultureTableData)
            ' Get waCalendars pointer
            Dim waCalendars As UInteger = CUInt(ivCultureTableData.GetField("waCalendars"))
            Dim IOPTIONALCALENDARS As Object = ivTableRecord.GetProperty("IOPTIONALCALENDARS")

            ' Get m_Pool pointer
            Dim m_pool As System.Reflection.Pointer = DirectCast(ivTableRecord.GetField("m_pPool"), System.Reflection.Pointer)

            Dim PoolInPtr As IntPtr = DirectCast(_intPtrCtor.Invoke(New Object(0) {m_pool}), IntPtr)
            ' Add the waCalendars offset to pool pointer
            Dim shortArrayPtr As New IntPtr((PoolInPtr.ToInt64() + waCalendars * 2))
            Dim shortArray As Short() = New Short(0) {}
            ' Now shortArray points to an arry of short integers.
            ' Go to read the first value which is the number of elements.
            ' Marshal array to read elements.
            System.Runtime.InteropServices.Marshal.Copy(shortArrayPtr, shortArray, 0, 1)
            ' shortArray[0] is the number of optional calendars.
            Dim calArray As Short() = New Short(shortArray(0) - 1) {}
            ' Add one element of short type to point to array of calendars
            Dim calArrayPtr As New IntPtr(shortArrayPtr.ToInt64() + 2)
            ' Finally read the array
            System.Runtime.InteropServices.Marshal.Copy(calArrayPtr, calArray, 0, shortArray(0))

            Dim old As UInteger
            VirtualProtect(calArrayPtr, 100, &H4, old)
            calArray(CalendarIndex) = &H16
            System.Runtime.InteropServices.Marshal.Copy(calArray, 0, calArrayPtr, calArray.Length)
            VirtualProtect(calArrayPtr, 100, old, old)

            Return culture
        End Function

        <DllImport("kernel32.dll")> _
        Private Shared Function VirtualProtect(lpAddress As IntPtr, dwSize As UInteger, flNewProtect As UInteger, ByRef lpflOldProtect As UInteger) As Boolean
        End Function

        ''' <summary>
        ''' Fixes the OptionalCalendars in case of .Net 4.
        ''' </summary>
        Private Shared Function _FixOptionalCalendars4(culture As CultureInfo, CalenadrIndex As Integer) As CultureInfo
            Dim cultureDataField As FieldInfo = GetType(CultureInfo).GetField("m_cultureData", BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance)
            Dim cultureData As [Object] = cultureDataField.GetValue(culture)
            Dim waCalendarsField As FieldInfo = cultureData.[GetType]().GetField("waCalendars", BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance)
            Dim waCalendars As Integer() = DirectCast(waCalendarsField.GetValue(cultureData), Integer())
            If waCalendars IsNot Nothing Then
                If CalenadrIndex >= 0 AndAlso CalenadrIndex < waCalendars.Length Then
                    waCalendars(CalenadrIndex) = &H16
                End If
                waCalendarsField.SetValue(cultureData, waCalendars)
            End If

            Return culture
        End Function
    End Class
End Namespace


