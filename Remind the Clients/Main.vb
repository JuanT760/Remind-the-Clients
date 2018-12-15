Imports System
Imports System.IO

Public Class frmRemind

    Private strMonths() As String = {"July", "August", "September", "October", "November", "December", "January", "Febuary", "March", "April", "May", "June"}
    Private outFileEmp As IO.StreamWriter
    Private _standing As String

    'Counter
    'Private user As Integer

    'Inputboxs
    'Gets current user
    Private message1, title1, defaultValue1 As String
    Private promptCurrentUser As Object

    'Gets current Day
    Private message, title, defaultValue As String
    Private promptCurrentDay As Object

    Private Users() As String = {"Juan", "Adrian"}

    'Counts estimates
    Private counter() As Integer = {0, 0}

    Private Sub frmRemind_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblError.Visible = False
        'Variable & Class
        Dim status As New StandingStatus
        Dim inFileEmp As IO.StreamReader

        'TODO: This line of code loads data into the 'ReminderDataDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.ReminderDataDataSet.Customers)

        message = "Please enter the current day: "
        title = "Date | Reminder"
        defaultValue = "(Todays Day)"

        promptCurrentDay = InputBox(message, title, defaultValue)

        If promptCurrentDay = "(Todays Day)" Then
            'Forgot to add day, prompt user with warning.
            lblError.Visible = True
        End If

        message1 = "Please enter your name: "
        title1 = "Current | User"
        defaultValue1 = "(Current user)"

        promptCurrentUser = InputBox(message1, title1, defaultValue1)

        If promptCurrentUser = "(Curremt User)" Then
            'Forgot to add day, prompt user with warning.
            lblError.Visible = True
        End If

        cboMonthSelection.Items.Add("January")
        cboMonthSelection.Items.Add("Febuary")
        cboMonthSelection.Items.Add("March")
        cboMonthSelection.Items.Add("April")
        cboMonthSelection.Items.Add("May")
        cboMonthSelection.Items.Add("June")
        cboMonthSelection.Items.Add("July")
        cboMonthSelection.Items.Add("August")
        cboMonthSelection.Items.Add("September")
        cboMonthSelection.Items.Add("October")
        cboMonthSelection.Items.Add("November")
        cboMonthSelection.Items.Add("December")
        cboMonthSelection.SelectedIndex = 0
        radSixMonths.Select()

        lblLogin.Text = promptCurrentUser

        If (promptCurrentUser = Users(0)) Then
            If IO.File.Exists("employee0.txt") Then
                Dim lineCount As Integer = System.IO.File.ReadAllLines("employee0.txt").Length.ToString()
                'Open file.
                inFileEmp = IO.File.OpenText("employee0.txt")
                'Displays line
                lblEstimates.Text = lineCount
                inFileEmp.Close()
                'Use class.
                status.EstimateNum = lineCount
                status.DetermineStanding()
                lblStatus.Text = status._standing

            End If
            'Copy for second user.
        ElseIf (promptCurrentUser = Users(1)) Then
            inFileEmp = IO.File.OpenText("employee1.txt")
            Dim lineCount As Integer = System.IO.File.ReadAllLines("employee1.txt").Length.ToString()
            lblEstimates.Text = lineCount
            inFileEmp.Close()
            status.EstimateNum = lineCount
            status.DetermineStanding()
            lblStatus.Text = status._standing
        End If
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReminderDataDataSet)
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        frmCustomers.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Displays the month that has been saved.
        If radSixMonths.Checked Then
            lblDisplay.Text = strMonths(cboMonthSelection.SelectedIndex)
        Else
            lblDisplay.Text = cboMonthSelection.SelectedItem
        End If

        'Sub call.
        Exsist()
        Write()
    End Sub
    Private Sub Write()

        'Checks user, and opens corrosponding file.
        If (promptCurrentUser = Users(0)) Then

            outFileEmp = IO.File.AppendText("employee0.txt")
        End If

        If (promptCurrentUser = Users(1)) Then
            outFileEmp = IO.File.AppendText("employee1.txt")
        End If

        'Month selection
        If radSixMonths.Checked Then
            outFileEmp.Write(strMonths(cboMonthSelection.SelectedIndex))
        Else
            outFileEmp.Write(cboMonthSelection.SelectedItem)
        End If


        outFileEmp.Write(" ")
        outFileEmp.Write(promptCurrentDay)
        outFileEmp.Write(" ")

        'changes YEAR
        If radSixMonths.Checked Then
            outFileEmp.Write(stripTxtBoxCurrentYear.Text)
        Else
            outFileEmp.Write(striptxtBoxNextYear.Text)
        End If

        outFileEmp.Write(" ")
        outFileEmp.Write(PhoneTextBox.Text)
        outFileEmp.Write(" ")
        outFileEmp.Write(Trim(Last_NameTextBox.Text.ToUpper))
        outFileEmp.Write(", ")
        outFileEmp.WriteLine(Trim(First_NameTextBox.Text.ToUpper))
        outFileEmp.Close()

    End Sub

    Private Sub Exsist()

        'Makes sure appropriate files exsist, & creates them.
        If IO.File.Exists("employee0.txt") = False Then
            MessageBox.Show("Creating... employee0.txt.", "Cannot find the file.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            outFileEmp = IO.File.CreateText("employee0.txt")
        End If

        If IO.File.Exists("employee1.txt") = False Then
            MessageBox.Show("Creating... employee1.txt.", "Cannot find the file.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            outFileEmp = IO.File.CreateText("employee1.txt")
        End If
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        frmCustomers.Visible = True
    End Sub
End Class
