Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.NullValues
	Class ExampleData
        Private _data As List(Of FootballTeam)

        Public Property AccumulatedData() As List(Of FootballTeam)
            Get
                Return Me._data
            End Get
            Set(value As List(Of FootballTeam))
                Me._data = value
            End Set
        End Property

        Public Sub New()
            Me.GetData("..\ChartView\NullValues\Premierleaguedata.csv")
        End Sub

        Private Sub GetData(fileName As String)
            Using fileReader As New StreamReader(fileName)
                Me.GetDataCompleted(Me.ParseData(fileReader))
            End Using
        End Sub

        Protected Sub GetDataCompleted(data As IEnumerable)
            Dim footballTeamStats As List(Of FootballTeamStats) = TryCast(data, List(Of FootballTeamStats))

            Dim teamStats As New Dictionary(Of String, FootballTeam)()

            For Each entry As FootballTeamStats In footballTeamStats
                If Not teamStats.ContainsKey(entry.Name) Then
                    Dim team As New FootballTeam()
                    team.Name = entry.Name
                    team.LogoPath = entry.LogoPath
                    team.Stats = New List(Of FootballTeamStats)()
                    team.TotalWins = If(entry.Wins Is Nothing, 0, entry.Wins)
                    team.TotalDraws = If(entry.Draws Is Nothing, 0, entry.Draws)
                    team.TotalLosses = If(entry.Losses Is Nothing, 0, entry.Losses)
                    teamStats.Add(entry.Name, team)
                Else
                    Dim team As FootballTeam = teamStats(entry.Name)
                    team.Stats.Add(entry)
                    team.TotalWins += If(entry.Wins Is Nothing, 0, entry.Wins)
                    team.TotalDraws += If(entry.Draws Is Nothing, 0, entry.Draws)
                    team.TotalLosses += If(entry.Losses Is Nothing, 0, entry.Losses)
                End If
            Next

            Dim items As New List(Of FootballTeam)()
            items.AddRange(teamStats.Values)
            _data = items
        End Sub

        Protected Function ParseData(dataReader As TextReader) As IEnumerable(Of FootballTeamStats)
            Dim line As String
            Dim dataList As New List(Of FootballTeamStats)()

            line = dataReader.ReadLine()

            While line IsNot Nothing

                If String.IsNullOrEmpty(line) Then
                    Continue While
                End If

                Dim data As String() = line.Split(","c)

                Dim stat As New FootballTeamStats()
                stat.Name = data(0).Trim()
                stat.Season = data(1).Trim()
                If Not String.IsNullOrEmpty(data(2)) Then
                    stat.Wins = Integer.Parse(data(2), CultureInfo.InvariantCulture)
                End If
                If Not String.IsNullOrEmpty(data(3)) Then
                    stat.Draws = Integer.Parse(data(3), CultureInfo.InvariantCulture)
                End If
                If Not String.IsNullOrEmpty(data(4)) Then
                    stat.Losses = Integer.Parse(data(4), CultureInfo.InvariantCulture)
                End If
                If Not String.IsNullOrEmpty(data(5)) Then
                    stat.GoalDifference = Integer.Parse(data(5), CultureInfo.InvariantCulture)
                End If
                If Not String.IsNullOrEmpty(data(6)) Then
                    stat.Points = Integer.Parse(data(6), CultureInfo.InvariantCulture)
                End If
                If Not String.IsNullOrEmpty(data(7)) Then
                    stat.Position = Integer.Parse(data(7), CultureInfo.InvariantCulture)
                End If
                stat.LogoPath = String.Format("..\Resources\SoccerTeamsLogos\{0}", data(8).Trim())

                dataList.Add(stat)

                line = dataReader.ReadLine()
            End While

            Return dataList
        End Function
    End Class

End Namespace
