Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Optimization
Imports System.Web.Routing
Imports System.Web.Security
Imports System.Web.SessionState
Imports System.Data.Entity

Imports LoserPool1.JoinPools.Models
Imports LoserPool1.PlayoffPool.Models
Imports LoserPool1.PlayoffPool
Imports LoserPool1.LosersPool.Models

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' Fires when the application is started
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)



        'InitalizePoolDatabase

        'Dim _db As New LosersPoolContext

        'Dim userChoices1 As New UserChoices

        'userChoices1.UserID = "lh4uhotmailcom"
        '_db.UserChoicesList.Add(userChoices1)

        '_db.SaveChanges()

        Dim dummy = "dummy"

        'Dim teams As New List(Of Team)
        'teams = GetTeams()
        'For Each team1 In teams
        '_db.Teams.Add(team1)
        'Next

        '_db.SaveChanges()


        'Database.SetInitializer(New PoolDbInitializer)


    End Sub

    Public Shared Function GetTeams() As List(Of Team)

        Dim teams As New List(Of Team)
        Dim t As New Team

        t.TeamId = "team1"
        t.TeamName = "seahawks"
        teams.Add(t)

        t = New Team
        t.TeamId = "team2"
        t.TeamName = "packers"
        teams.Add(t)

        t = New Team
        t.TeamId = "team3"
        t.TeamName = "falcons"
        teams.Add(t)

        t = New Team
        t.TeamId = "team4"
        t.TeamName = "saints"
        teams.Add(t)

        t = New Team
        t.TeamId = "team5"
        t.TeamName = "chargers"
        teams.Add(t)

        t = New Team
        t.TeamId = "team6"
        t.TeamName = "cardinals"
        teams.Add(t)

        t = New Team
        t.TeamId = "team7"
        t.TeamName = "lions"
        teams.Add(t)

        t = New Team
        t.TeamId = "team8"
        t.TeamName = "giants"
        teams.Add(t)

        Return teams

    End Function



End Class