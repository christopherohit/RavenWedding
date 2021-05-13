Public Class WarsData

    Private m_wars As DataTable

    Public ReadOnly Property Wars() As DataTable
        Get
            If Me.m_wars Is Nothing Then
                Me.m_wars = Me.LoadWarData()
            End If

            Return m_wars
        End Get
    End Property

    Private Function LoadWarData() As DataTable
        Dim result As New DataTable()

        result.Columns.Add("Title", GetType(String))
        result.Columns.Add("Start", GetType(DateTime))
        result.Columns.Add("End", GetType(DateTime))
        result.Columns.Add("Casualties", GetType(Integer))

        result.Rows.Add("The War of a Thousand Days", New DateTime(1899, 10, 17), New DateTime(1902, 11, 22), 100000)
        result.Rows.Add("Russo-Japanese war", New DateTime(1904, 2, 8), New DateTime(1905, 9, 6), 151831)
        result.Rows.Add("Mexican Revolution", New DateTime(1910, 10, 20), New DateTime(1920, 10, 20), 125000)
        result.Rows.Add("World War I", New DateTime(1914, 7, 28), New DateTime(1918, 11, 11), 10670868)
        result.Rows.Add("Russian Revolution and Civil War", New DateTime(1917, 10, 25), New DateTime(1922, 10, 25), 802225)
        result.Rows.Add("Polish-Soviet War", New DateTime(1919, 2, 14), New DateTime(1922, 3, 18), 100000)
        result.Rows.Add("Northern Expedition", New DateTime(1926, 7, 9), New DateTime(1928, 12, 31), 126500)
        result.Rows.Add("Communists vs Kuomintang", New DateTime(1930, 4, 12), New DateTime(1935, 12, 31), 500000)
        result.Rows.Add("Spanish Civil War", New DateTime(1936, 7, 17), New DateTime(1939, 4, 1), 466300)
        result.Rows.Add("Second Sino-Japanese War", New DateTime(1937, 7, 7), New DateTime(1945, 9, 9), 1000000)
        result.Rows.Add("The Winter War in Finland", New DateTime(1939, 11, 30), New DateTime(1940, 3, 13), 151798)
        result.Rows.Add("World War II", New DateTime(1939, 9, 1), New DateTime(1945, 9, 2), 50000000)
        result.Rows.Add("Chinese Civil War", New DateTime(1946, 3, 31), New DateTime(1950, 5, 1), 1200000)
        result.Rows.Add("First Indochina War Comm. vs France", New DateTime(1946, 12, 19), New DateTime(1954, 8, 1), 269500)
        result.Rows.Add("Indian Partition Communal Violence", New DateTime(1947, 8, 14), New DateTime(1948, 2, 4), 200000)
        result.Rows.Add("Korean War", New DateTime(1950, 6, 25), New DateTime(1953, 7, 27), 995000)
        result.Rows.Add("Algerian War of Independence", New DateTime(1954, 11, 1), New DateTime(1962, 3, 19), 182526)
        result.Rows.Add("Vietnam Civil War", New DateTime(1959, 4, 1), New DateTime(1963, 11, 1), 164923)
        result.Rows.Add("Vietnam War", New DateTime(1955, 11, 1), New DateTime(1975, 4, 30), 2048050)
        result.Rows.Add("Cambodian Civil War", New DateTime(1967, 3, 11), New DateTime(1975, 4, 17), 246204)
        result.Rows.Add("Chinese Cultural Revolution", New DateTime(1967, 1, 3), New DateTime(1976, 9, 9), 2050000)
        result.Rows.Add("Lebanese Civil War", New DateTime(1975, 4, 13), New DateTime(1990, 10, 13), 144000)
        result.Rows.Add("Angolan Gvt vs UNITA Guerilla", New DateTime(1975, 11, 11), New DateTime(2002, 4, 4), 157400)
        result.Rows.Add("Afghanistan Civil War", New DateTime(1978, 4, 27), New DateTime(2001, 10, 7), 121536)
        result.Rows.Add("Mozambique Govt vs Guerilla", New DateTime(1977, 5, 30), New DateTime(1992, 10, 4), 115600)
        result.Rows.Add("Iran vs Iraq", New DateTime(1980, 9, 22), New DateTime(1988, 8, 20), 644500)
        result.Rows.Add("Uganda Civil War", New DateTime(1981, 1, 11), New DateTime(1986, 12, 31), 116044)
        result.Rows.Add("Rwanda Civil War", New DateTime(1990, 10, 1), New DateTime(1994, 7, 4), 527145)
        result.Rows.Add("First and Second Congo Wars", New DateTime(1996, 8, 31), New DateTime(2003, 7, 18), 208367)

        Return result
    End Function
End Class
