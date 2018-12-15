Public Class StandingStatus
    Public Property EstimateNum As Integer
    Private strStanding As String


    Public ReadOnly Property _standing As String
        Get
            Return strStanding
        End Get
    End Property

    Public Sub New()
        EstimateNum = 0
        strStanding = String.Empty
    End Sub

    Public Sub DetermineStanding()
        Select Case EstimateNum
            Case Is >= 20
                strStanding = "VERY BAD"
            Case Is >= 15
                strStanding = "NOT GREAT"
            Case Is >= 10
                strStanding = "NOT GOOD"
            Case Is >= 5
                strStanding = "OKAY.."
            Case Is < 5
                strStanding = "PRETTY GOOD"
            Case Is <= 0
                strStanding = "GREAT JOB!"
        End Select
    End Sub

End Class
