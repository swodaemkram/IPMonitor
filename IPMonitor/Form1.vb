Imports System.Net.Mail
Imports System.IO
Imports System.Text
Imports System.Net

Public Class Form1
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Dim RETURN_VALUE As Integer = MsgBox("Previouse saved settings will be over writen !", 49, )
        If RETURN_VALUE = 2 Then Exit Sub
        '********************************************* Save Current Settings *********************************************************
        Using sw As System.IO.StreamWriter = New System.IO.StreamWriter(Application.StartupPath & "\IPMonitor.cfg")
            sw.Write(TextBox1.Text & vbLf)
            sw.Write(TextBox2.Text & vbLf)
            sw.Write(TextBox3.Text & vbLf)
            sw.Write(TextBox4.Text & vbLf)
            sw.Write(TextBox5.Text & vbLf)
            sw.Write(TextBox6.Text & vbLf)
            sw.Write(TextBox8.Text & vbLf)
            If CheckBox3.Checked = True Then sw.Write("T" & vbLf)
            If CheckBox3.Checked = False Then sw.Write("F" & vbLf)
            If CheckBox1.Checked = True Then sw.Write("T" & vbLf)
            If CheckBox1.Checked = False Then sw.Write("F" & vbLf)
            If CheckBox2.Checked = True Then sw.Write("T" & vbLf)
            If CheckBox2.Checked = False Then sw.Write("F" & vbLf)
            sw.Write(TextBox7.Text & vbLf)
            sw.Write(TextBox9.Text & vbLf)
            sw.Write(TextBox10.Text & vbLf)
            sw.Write(TextBox11.Text & vbLf)

            '************************************************ End of Program Settings ***************************************************
            '************************************************ Save Program Data *****************************************************

            For t = 0 To 256

                If DataGridView1.Rows.Item(t).Cells(0).Value = "" Then GoTo CLOSEIT
                sw.Write(DataGridView1.Rows.Item(t).Cells(0).Value & "," & DataGridView1.Rows.Item(t).Cells(1).Value & vbLf)

            Next

CLOSEIT:

            sw.Close()

        End Using


        MsgBox("Setup Saved")
        '********************************************* End Of Save Current Settings **************************************************
    End Sub

    Private Sub StartTestingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartTestingToolStripMenuItem.Click
        Timer1.Enabled = True
        StopTestingToolStripMenuItem.Enabled = True
        StartTestingToolStripMenuItem.Enabled = False
    End Sub

    Private Sub StopTestingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopTestingToolStripMenuItem.Click
        Timer1.Enabled = False
        StartTestingToolStripMenuItem.Enabled = True
        StopTestingToolStripMenuItem.Enabled = False
    End Sub

    Public TOTAL_PING_COUNTS As Integer = 0
    Public LINE_COUNT As Integer = 1
    Public CONFIG_LINE_COUNT As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FILE_NAME As String = Application.StartupPath & "\IPMonitor.cfg"

        'Dim FILE_NAME As String = "C:\Test\IPMonitor.cfg"
        Dim TextLine As String = ""

        ' MsgBox(FILE_NAME)

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            '****************************************************** Load Configuration *********************************************************
            TextLine = TextLine & objReader.ReadLine() : TextBox1.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox2.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox3.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox4.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox5.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox6.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox8.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : If TextLine = "T" Then CheckBox3.Checked = True Else CheckBox3.Checked = False
            TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : If TextLine = "T" Then CheckBox1.Checked = True Else CheckBox1.Checked = False
            TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : If TextLine = "T" Then CheckBox2.Checked = True Else CheckBox2.Checked = False
            TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox7.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox9.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox10.Text = TextLine : TextLine = ""
            TextLine = TextLine & objReader.ReadLine() : TextBox11.Text = TextLine : TextLine = ""
            '**************************************************** End Load Configuration ********************************************************

            '**************************************************** Load Data Grid     ************************************************************
            Do While objReader.Peek() <> -1

                TextLine = objReader.ReadLine()
                ' Fill Grid with Data
                LINE_COUNT = DataGridView1.Rows.Add()

                Dim HOST_NAME As String = ""
                Dim IP_ADDRESS As String = ""
                Dim The_DATA As String() = TextLine.Split(",")

                DataGridView1.Rows.Item(LINE_COUNT).Cells(0).Value = The_DATA(0)
                DataGridView1.Rows.Item(LINE_COUNT).Cells(3).Value = "0"
                On Error Resume Next

                DataGridView1.Rows.Item(LINE_COUNT).Cells(1).Value = The_DATA(1)
                DataGridView1.Rows.Item(LINE_COUNT).Cells(3).Value = "0"

                LINE_COUNT = LINE_COUNT + 1
            Loop
            '****************************************************** End Load Data Grid  *********************************************************


            objReader.Close()

        Else


            MessageBox.Show("Config File Does Not Exist")
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        TOTAL_PING_COUNTS = TOTAL_PING_COUNTS + 1
        Dim TEST_LINE_COUNT As Integer = 0

        For TEST_LINE_COUNT = 0 To LINE_COUNT - 1

            Label2.Text = DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(1).Value.ToString
            Label2.Text = Label2.Text.Replace(ControlChars.CrLf.ToCharArray(), "") '* Hiden Label to put clean I.P. Address in
            'MsgBox(DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(1).Value.ToString)
            'if My.Computer.Network.Ping(DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(1).Value.ToString) Then

            If My.Computer.Network.Ping(Label2.Text) Then

                ' MsgBox(DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(1).Value.ToString & "pinged successfully.")
                DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(2).Value = TOTAL_PING_COUNTS
                DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(4).Value = DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(3).Value.ToString * 100 \ DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(2).Value.ToString
                'MsgBox(Now)
            Else

                DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(2).Value = TOTAL_PING_COUNTS
                DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(3).Value = DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(3).Value.ToString + 1
                DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(4).Value = DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(3).Value.ToString * 100 \ DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(2).Value.ToString
                ' MsgBox("Ping request timed out.")

                '******************************** Log Failure **********************************************************************

                Dim HAS_THIS_HOST_FAILED_IN_THE_LAST_HOUR As Boolean
                Dim LOG_NAME As String = DateTime.Now.ToString("dHHyyyy")
                Dim FILE_NAME As String = TextBox1.Text & LOG_NAME & ".log"
                Dim TextLine As String = ""
                Dim THE_HOST_NAME As String = DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(0).Value.ToString
                Dim THE_IP_ADDRESS As String = DataGridView1.Rows.Item(TEST_LINE_COUNT).Cells(1).Value.ToString

                'MsgBox(FILE_NAME)

                If System.IO.File.Exists(FILE_NAME) = True Then

                    Dim objReader As New System.IO.StreamReader(FILE_NAME)
                    Do While objReader.Peek() <> -1

                        TextLine = objReader.ReadLine()

                        Dim COMPARE_RESULTS As Integer
                        COMPARE_RESULTS = InStr(THE_IP_ADDRESS, TextLine, CompareMethod.Text)

                        If COMPARE_RESULTS = 0 Then objReader.Close() : HAS_THIS_HOST_FAILED_IN_THE_LAST_HOUR = True : GoTo LOGIT

                    Loop

                    objReader.Close()
                    HAS_THIS_HOST_FAILED_IN_THE_LAST_HOUR = False
                End If

LOGIT:

                TextBox1.Text = TextBox1.Text.Replace(ControlChars.CrLf.ToCharArray(), "")
                My.Computer.FileSystem.WriteAllText(TextBox1.Text & LOG_NAME & ".log", Now & " " & THE_HOST_NAME & " " & THE_IP_ADDRESS & " Has Failed!" & vbLf, True)
                '**********************************End of Log Failure ***************************************************************

                '********************************** Do We Send Email  ***************************************************************
                If CheckBox3.Checked = True And HAS_THIS_HOST_FAILED_IN_THE_LAST_HOUR = False Then

                    Send_Email(THE_HOST_NAME & " " & THE_IP_ADDRESS & " Has failed!")

                End If

                '********************************** end of Sending Email  ***********************************************************

                '*********************************** Do We Send To Webhook **********************************************************
                If CheckBox2.Checked = True And HAS_THIS_HOST_FAILED_IN_THE_LAST_HOUR = False Then

                    Dim MESSAGE_TO_POST As String = TextBox8.Text & " " & THE_HOST_NAME & " " & THE_IP_ADDRESS & " Has Failed!" & vbLf

                    Dim res As String = mattermost._post2Mattermost(New Uri(TextBox7.Text),
                                    MESSAGE_TO_POST, TextBox10.Text, TextBox11.Text)

                End If
                '*********************************** End of sending to webhook ******************************************************
            End If
        Next
        Timer1.Enabled = True

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub QuitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem1.Click
        End

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        TextBox2.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        TextBox2.BackColor = Color.White
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        TextBox3.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        TextBox3.BackColor = Color.White
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        TextBox4.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        TextBox4.BackColor = Color.White
    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        TextBox5.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        TextBox5.BackColor = Color.White
    End Sub

    Private Sub TextBox6_GotFocus(sender As Object, e As EventArgs) Handles TextBox6.GotFocus
        TextBox6.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox6_LostFocus(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        TextBox6.BackColor = Color.White
    End Sub

    Private Sub TextBox7_GotFocus(sender As Object, e As EventArgs) Handles TextBox7.GotFocus
        TextBox7.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        TextBox7.BackColor = Color.White
    End Sub

    Private Sub TextBox8_GotFocus(sender As Object, e As EventArgs) Handles TextBox8.GotFocus
        TextBox8.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        TextBox8.BackColor = Color.White
    End Sub



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Send_Email(message)

        Dim MyMailMessage As New MailMessage()
        Try
            MyMailMessage.From = New MailAddress(TextBox6.Text)
            MyMailMessage.To.Add(TextBox9.Text)
            MyMailMessage.Subject = TextBox8.Text
            MyMailMessage.Body = message
            Dim SMTP As New SmtpClient(TextBox2.Text)
            SMTP.Port = TextBox3.Text
            If CheckBox1.Checked = True Then SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(TextBox4.Text, TextBox5.Text)
            SMTP.Send(MyMailMessage)

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyMailMessage As New MailMessage()
        Try
            MyMailMessage.From = New MailAddress(TextBox6.Text)
            MyMailMessage.To.Add(TextBox9.Text)
            MyMailMessage.Subject = TextBox8.Text
            MyMailMessage.Body = "This is a Test E-mail from IPMonitor ..."
            Dim SMTP As New SmtpClient(TextBox2.Text)
            SMTP.Port = TextBox3.Text
            If CheckBox1.Checked = True Then SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(TextBox4.Text, TextBox5.Text)
            SMTP.Send(MyMailMessage)
            MsgBox("Your Mail has been Successfully sent")

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles TextBox9.GotFocus
        TextBox9.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        TextBox9.BackColor = Color.White
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub TextBox10_GotFocus(sender As Object, e As EventArgs) Handles TextBox10.GotFocus
        TextBox10.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox10_LostFocus(sender As Object, e As EventArgs) Handles TextBox10.LostFocus
        TextBox8.BackColor = Color.White
    End Sub

    Private Sub TextBox11_GotFocus(sender As Object, e As EventArgs) Handles TextBox11.GotFocus
        TextBox11.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox11_LostFocus(sender As Object, e As EventArgs) Handles TextBox11.LostFocus
        TextBox11.BackColor = Color.White
    End Sub
End Class



Public Class mattermost
    ''' <summary>
    ''' Posts Text to a defined Mattermost webhook
    ''' </summary>
    ''' <param name="sWebhookURL"></param>
    ''' <param name="sText"></param>
    ''' <param name="sUser"></param>
    ''' <param name="sChannel"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function _post2Mattermost(ByVal sWebhookURL As Uri, ByVal sText As String,
                                            ByVal sUser As String, ByVal sChannel As String) As String
        Dim jsonString As String = String.Format("{{""username"": ""{0}"", ""text"": ""{1}"", " +
                                                 """channel"": ""{2}""}}", sUser, sText, sChannel)
        ServicePointManager.ServerCertificateValidationCallback = Function() True

        Dim data = Encoding.UTF8.GetBytes(jsonString)
        Dim req As WebRequest = WebRequest.Create(sWebhookURL)
        req.ContentType = "application/json"
        req.Method = "POST"
        req.ContentLength = data.Length

        Using requestWriter As StreamWriter = New StreamWriter(req.GetRequestStream())
            requestWriter.Write(jsonString)
        End Using

        Dim response = req.GetResponse().GetResponseStream()

        Dim reader As New StreamReader(response)
        Dim res = reader.ReadToEnd()
        reader.Close()
        response.Close()
        Return res
    End Function






End Class