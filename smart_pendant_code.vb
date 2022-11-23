Login Form Code


Imports MySql.Data.MySqlClient
Public Class loginfrm
    Dim un, ps As String
    Dim msg As String
    Private Sub loginfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtpassword1.isPassword = True

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Try

            If My.Computer.Network.IsAvailable Then
                If txtemail.Text <> "" And txtpassword.Text <> "" Then

                    login_data()

                ElseIf txtemail.Text = "" Then

                    MsgBox("Enter Email", MsgBoxStyle.OkCancel + MsgBoxStyle.Question)


                ElseIf txtpassword.Text = "" Then
                    MsgBox("Enter Password", MsgBoxStyle.OkCancel + MsgBoxStyle.Question)


                Else



                    MsgBox("Enter Email Id and Password", MsgBoxStyle.OkCancel + MsgBoxStyle.Question)

                End If


            Else

                MsgBox("internet Not Connected,  please connect Internet", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical)


            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        End

    End Sub

    Private Sub txtpassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtpassword1.OnValueChanged

    End Sub

    Public Sub login_data()

        ' TRUE LOGIC
        Dim a As Integer
        Dim i As Integer
        'Dim un, ps As String
        un = txtemail.Text
        ps = txtpassword.Text
        Dim st As String = ""
        st = 1

        mycon.Open()

        'sql = "Select * from addcompanyuser_table where email ='" & un & "'and password ='" & ps & "'"
        sql = "Select * from addcompanyuser_table where email ='" & un & "'and password ='" & ps & "'and status='" & st & "'"

        cmd = New MySqlCommand(sql, mycon)
        reader2 = cmd.ExecuteReader()

        While reader2.Read()
            a = 1
            cu_cid = reader2.GetString("cid")
            cu_uid = reader2.GetString("uid")
            cu_un = reader2.GetString("username")
            cu_mobile = reader2.GetString("mobile")
            cu_email = reader2.GetString("email")

            MsgBox("Dear User " & cu_un & " Your Login Success", MsgBoxStyle.Information)





        End While
        mycon.Close()
        If a = 1 Then
            Dim rst As String

            rst = MsgBox("Login Success.", MsgBoxStyle.Information + MsgBoxStyle.OkCancel)
            If rst = MsgBoxResult.Ok Then
                Dim obj As New Form1
                obj.Show()
                Me.Hide()

            End If
        Else
            MsgBox("Invalid Email Id or Password Enter", MsgBoxStyle.Critical)

        End If

    End Sub
End Class



 
Main Form Code
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Ports
Public Class Form1

    Dim index As Integer = 0
    Dim index1 As Integer = 1
    Dim index2 As Integer = 2
    Dim index3 As Integer = 3
    Dim index4 As Integer = 4
    Dim index5 As Integer = 5
    Dim index6 As Integer = 6
    Dim index7 As Integer = 7
    Dim index8 As Integer = 8
    Dim index9 As Integer = 9

    Dim table As New DataTable()

    Public na1 As String = ""

    Public Cid As String = ""
    Public sn As String = ""
    Public dist As String = ""
    Public batt As String = ""
    Public VoSIGS As String = ""

    ' for command
    Public gd As String = ""
    Public gc As String = ""
    Public sd As String = ""
    Public cd As String = ""


    Public d1 As String = ""
    Public d2 As String = ""
    Public t1 As String = ""
    Public t2 As String = ""

    'for button command
    Public b1 As String = ""
    Public b2 As String = ""
    Public b3 As String = ""
    Public b4 As String = ""



    Public WithEvents com As New IO.Ports.SerialPort
    Public s As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        control_manage()

        For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            ComboBox1.Items.Add(My.Computer.Ports.SerialPortNames(i).ToString)

        Next

        deviceId2.Text = ""




        cards_data()


    End Sub

    Public Sub cards_data()

        get_total_device()
        lbltotaldevice.Text = total_device


        get_total_users()
        lbltotaluser.Text = total_user


        get_total_issue_device()
        lblissuedevice.Text = issue_device


        get_total_return_device()
        lblreturndevice.Text = return_device

    End Sub
    Private Sub com_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles com.DataReceived

        s = s & com.ReadExisting()
    End Sub
    Public Sub control_manage()
        Panel12.Visible = False
        Panel13.Visible = False
        Panel14.Visible = False
        Panel15.Visible = False
        Panel35.Visible = False
        Panel36.Visible = False
        Panel38.Visible = False


        Pnlheader.Size = New Point(1001, 33)
        Panel28.Size = New Point(1040, 43)


        TextBox1.Visible = False



        firstname1.Text = ""
        firstname2.Text = ""
        firstname3.Text = ""
        firstname4.Text = ""
        firstname5.Text = ""
        firstname6.Text = ""
        firstname7.Text = ""
        firstname8.Text = ""
        firstname9.Text = ""
        firstname10.Text = ""



        contact1.Text = ""
        contact2.Text = ""
        contact3.Text = ""
        contact4.Text = ""
        contact5.Text = ""
        contact6.Text = ""
        contact7.Text = ""
        contact8.Text = ""
        contact9.Text = ""
        contact10.Text = ""


        deviceId1.BorderStyle = BorderStyle.None
        deviceId2.BorderStyle = BorderStyle.None
        deviceId3.BorderStyle = BorderStyle.None
        deviceId4.BorderStyle = BorderStyle.None
        deviceId5.BorderStyle = BorderStyle.None
        deviceId6.BorderStyle = BorderStyle.None
        deviceId7.BorderStyle = BorderStyle.None
        deviceId8.BorderStyle = BorderStyle.None
        deviceId9.BorderStyle = BorderStyle.None
        deviceId10.BorderStyle = BorderStyle.None






    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If Panel13.Visible = False Then
            Panel13.Visible = True
            Panel14.Visible = False
            Panel15.Visible = False

            Panel35.Visible = False
            Panel36.Visible = False

        End If
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        If Panel14.Visible = False Then
            Panel14.Visible = True
            Panel13.Visible = False
            Panel15.Visible = False

            Panel35.Visible = False
            Panel36.Visible = False

        End If
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        If Panel15.Visible = False Then
            Panel15.Visible = True
            Panel13.Visible = False
            Panel14.Visible = False
            Panel35.Visible = False
            Panel36.Visible = False


        End If
        'Panel12.Visible = False
        'Panel13.Visible = False
        'Panel14.Visible = False
        'Panel15.Visible = False
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Panel12.Visible = False
        Panel13.Visible = False
        Panel14.Visible = False
        Panel15.Visible = False
        Panel35.Visible = False
        Panel36.Visible = False
        TabControl1.SelectedTab = TabPage1

        cards_data()






    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs)
        Panel12.Visible = False
        Panel13.Visible = False
        Panel14.Visible = False
        Panel15.Visible = False
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        TabControl1.SelectedTab = TabPage2

    End Sub

    Private Sub BunifuFlatButton19_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton19.Click
        Try
            com.PortName = ComboBox1.Text
            com.BaudRate = "115200"
            com.DataBits = "8"
            com.StopBits = "1"
            com.Open()
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If gc.Contains("GC") Then
            If s <> "" And s.Length > 66 Then
                calc(s)
                s = ""
            End If

        End If


        If gd.Contains("GD") Then
            If s <> "" And s.Length > 20 Then
                calcGD(s)
                s = ""
            End If

        End If
    End Sub

    Private Sub BunifuFlatButton18_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton18.Click
        Try
            com.Close()
            com.Dispose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    'function

    Public Sub calc(ByVal s As String)

        '    s = "COMP--00001234SRNO--00000022DIST--1.0MtBATT--4.0VoSIGS--94 dB"

        Dim i As Integer = s.IndexOf("COMP--")
        Dim sr As Integer = s.IndexOf("SRNO--")

        '  MsgBox(i & "   " & sr & "   " & sr - i)

        Dim ins As Integer = sr - 1

        Dim ss() As Char = s.ToArray()

        Dim d As String = ""

        For iq As Integer = 0 To ins
            d = d & ss(iq)
        Next
        'MsgBox(d)

        Cid = d


        Dim di As Integer = s.IndexOf("DIST--")


        Dim dissss As String = ""
        For q As Integer = sr To di - 1

            dissss = dissss & ss(q)
        Next

        'MsgBox(dissss)

        sn = dissss






        Dim bi As Integer = s.IndexOf("BATT--")

        Dim bmm As String = ""
        Dim bssss As String = ""
        For q As Integer = di To bi - 1

            bmm = bmm & ss(q)
        Next

        'MsgBox(mmm)

        dist = bmm



        Dim bi1 As Integer = s.IndexOf("SIGS--")

        Dim dis1 As String = ""
        Dim bssss1 As String = ""
        For q As Integer = bi To bi1 - 1

            dis1 = dis1 & ss(q)
        Next

        'MsgBox(mmm)

        batt = dis1




        Dim bat1 As Integer = s.IndexOf("SIGS--")

        Dim mmm As String = ""
        Dim mssss As String = ""
        For q As Integer = bat1 To s.Length - 1
            mmm = mmm & ss(q)
        Next

        'MsgBox(mmm)

        VoSIGS = mmm






        Dim temp() As String = Cid.Split("--")
        Cid = temp(temp.Length - 1)
        Dim temp1() As String = sn.Split("--")
        sn = temp1(temp1.Length - 1)

        Dim temp2() As String = dist.Split("--")
        dist = temp2(temp2.Length - 1)


        Dim temp3() As String = batt.Split("--")
        batt = temp3(temp3.Length - 1)

        Dim temp4() As String = VoSIGS.Split("--")
        VoSIGS = temp4(temp4.Length - 1)


        ' for replace code
        VoSIGS = VoSIGS.Replace(":", "")
        dist = dist.Replace("Mt", "")
        batt = batt.Replace("Vo", "")




        TextBox1.Text = TextBox1.Text & (Cid & "  " & sn & " " & dist & "  " & batt & "  " & VoSIGS)

        If b1 = "b1" Then
            txtcomid.Text = Cid
            txtsrno.Text = sn
            txtbatt.Text = batt
            txtdist.Text = dist
            txtsign.Text = VoSIGS


        ElseIf b2 = "b2" Then
            txtcomid1.Text = Cid
            txtsrno1.Text = sn
            txtdist1.Text = dist
            txtbatt1.Text = batt
            txtsign1.Text = VoSIGS

        ElseIf b3 = "b3" Then

            txtcomid2.Text = Cid
            txtsrno2.Text = sn
            txtbatt2.Text = batt
            txtdist2.Text = dist
            txtsign2.Text = VoSIGS


        ElseIf b4 = "b4" Then

            txtcomid31.Text = Cid
            txtsrno31.Text = sn
            txtbatt31.Text = batt
            txtdist31.Text = dist
            txtsign31.Text = VoSIGS

            access_userdata_data12(sn)


        End If





    End Sub


    'Public Sub calcGD(ByVal s As String)



    '    Dim data() As String = s.Split(";")

    '    If data.Length >= 2 Then
    '        Dim temp() As String = data(0).Split(",")
    '        d1 = data(0)
    '        t1 = data(1)

    '        'Dim temp1() As String = data(1).Split(",")
    '        'd2 = temp1(0)
    '        't2 = temp1(1)

    '    End If
    '    TextBox1.Text = "d1 " & d1 & " T1 " & t1

    '    txtdeviceid.Text = d1
    '    txttime.Text = t1



    'End Sub

    ' get contact list code

    Public Sub calcGD(ByVal s As String)
        Dim s1 As String = "00000000,00942;00000017,00004;00000000,00942;00000018,00004;00000000,00942;00000019,00004;00000000,00942;00000020,00004;00000021,00004;00000022,00004;00000023,00004;00000024,00004;00000025,00004;00000026,00004;00000027,00004;00000028,00004;00000029,00004;00000030,00004;00000031,00004;00000032,00004;00000033,00004;00000034,00004;00000035,00004;00000036,00004;00000037,00004;00000038,00004;00000039,00004;00000040,00004;00000041,00004;"



        'Dim d1 As String = ""
        'Dim d2 As String = ""
        'Dim t1 As String = ""
        'Dim t2 As String = ""

        Dim data() As String = s1.Split(";")

        For i As Integer = 0 To data.Length - 1
            If data(i).Length > 10 Then
                Dim temp() As String = data(i).Split(",")
                'If temp.Lengt
                d1 = temp(0)

                t1 = temp(1)

                If Val(d1) <> 0 Then

                    'TextBox2.Text = TextBox2.Text & "d " & i & "  " & d1 & " T " & i & " " & t1
                    ListBox1.Items.Add(d1)

                    AddNewTextBox()

                    AddNewTextBox1()
                    list__Device(d1, cu_cid)


                End If



            End If

        Next

        'get_Contactlist()




        'If data.Length >= 2 Then
        '    Dim temp() As String = data(0).Split(",")
        '    d1 = data(0)
        '    t1 = data(1)

        '    Dim temp1() As String = data(1).Split(",")
        '    d2 = temp1(0)
        '    t2 = temp1(1)

        'End If
        'TextBox2.Text = "d1 " & d1 & " T1 " & t1 & "d2 " & d2 & " T2 " & t2



    End Sub

    Dim cleft As Integer = 0

    Public Function AddNewTextBox() As System.Windows.Forms.TextBox
        Dim lbl As New System.Windows.Forms.TextBox()

        ' lbl.Top = cleft * 25
        lbl.Top = cleft * 25
        lbl.Left = 10
        lbl.Text = d1 '& Me.cleft.ToString
        cleft = cleft + 1
        Panel33.Controls.Add(lbl)
        'delete_device()
        sample()
        Access_deviceid()



        Return lbl
    End Function
    Dim dleft As Integer = 0
    Public Function AddNewTextBox1() As System.Windows.Forms.TextBox
        Dim lbl As New System.Windows.Forms.TextBox()

        ' lbl.Top = cleft * 25
        lbl.Top = dleft * 25
        lbl.Left = 10
        lbl.Text = na1 '& Me.cleft.ToString
        dleft = dleft + 1
        Panel34.Controls.Add(lbl)

        Return lbl
    End Function
    ' for device access


    Public Sub list__Device(ByVal dd1 As String, ByVal ccid As String)

        'txtidevice_id.Items.Clear()

        Dim reader As MySqlDataReader
        Try
            mycon.Open()
            Dim query As String
            query = "Select * from issue_device_table where device_id='" & dd1 & "' and company_id='" & cu_cid & "'"

            'query = "select * from user_register_table where cid='" & cu_cid & "'"

            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim name = reader.GetString("username")
                'cid = reader.GetString("cid")
                Dim r As String

                na1 = name


            End While
            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try


    End Sub
    'access device in from list box and put into the label
    Public Sub get_Contactlist()
        Try
            deviceId1.Text = ListBox1.Items(0)
            deviceId2.Text = ListBox1.Items(1)
            deviceId3.Text = ListBox1.Items(2)
            deviceId4.Text = ListBox1.Items(3)
            deviceId5.Text = ListBox1.Items(4)
            deviceId6.Text = ListBox1.Items(5)
            deviceId7.Text = ListBox1.Items(6)
            deviceId8.Text = ListBox1.Items(7)
            deviceId9.Text = ListBox1.Items(8)



        Catch ex As Exception

        End Try


    End Sub

    Private Sub BunifuFlatButton17_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton17.Click
        Try
            gc = "AT+GC"
            com.Write(gc)

            com.Write(Chr(13))
            b1 = "b1"
            b2 = ""
            b3 = ""
        Catch ex As Exception
            MessageBox.Show("Device is not connected", "Alert")
        End Try
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        TabControl1.SelectedTab = TabPage3

    End Sub

    Private Sub BunifuFlatButton14_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton14.Click
        Try
            com.Close()
            com.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuFlatButton21_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton21.Click
        ComboBox1.Items.Clear()

        For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            ComboBox1.Items.Add(My.Computer.Ports.SerialPortNames(i).ToString)

        Next

    End Sub

    Private Sub Pnlheader_Paint(sender As Object, e As PaintEventArgs) Handles Pnlheader.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        TabControl1.SelectedTab = TabPage4



    End Sub

    Private Sub BunifuFlatButton25_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton25.Click


        'TabControl1.SelectedTab = TabPage5

        returnDevice.ShowDialog()



    End Sub

    Private Sub BunifuFlatButton28_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton28.Click
        Try
            gc = "AT+GC"
            com.Write(gc)

            com.Write(Chr(13))
            b1 = ""
            b2 = "b2"
            b3 = ""
        Catch ex As Exception
            MessageBox.Show("Device is not connected", "Alert")

        End Try

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        TabControl1.SelectedTab = TabPage5

    End Sub

    Private Sub BunifuFlatButton31_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton31.Click
        Try
            gc = "AT+GC"
            com.Write(gc)

            com.Write(Chr(13))
            b1 = ""
            b2 = ""
            b3 = "b3"

        Catch ex As Exception
            MessageBox.Show("Device is not connected", "Alert")

        End Try


    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        TabControl1.SelectedTab = TabPage15

    End Sub

    Private Sub BunifuFlatButton30_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton30.Click
        Dim dist As String = ""
        dist = Trim(txtdist2.Text)


        Try
            sd = "AT+SD" & dist
            com.Write(sd)

            com.Write(Chr(13))

        Catch ex As Exception
            MessageBox.Show("Device is not connected", "Alert")

        End Try


    End Sub

    Private Sub BunifuFlatButton34_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton34.Click
        Try
            gd = "AT+GD"
            com.Write(gd)

            com.Write(Chr(13))
            'Access_deviceid()
            delete_device()

        Catch ex As Exception
            MessageBox.Show("Device is not connected", "Alert")

        End Try



    End Sub

    Private Sub BunifuFlatButton33_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton33.Click
        Try
            gc = "AT+GC"
            com.Write(gc)

            com.Write(Chr(13))
            b1 = ""
            b2 = ""
            b3 = ""
            b4 = "b4"


        Catch ex As Exception
            MessageBox.Show("Device is not connected", "Alert")

        End Try

    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        TabControl1.SelectedTab = TabPage19
        TabControl2.SelectedTab = TabPage10
    End Sub

    Private Sub BunifuFlatButton16_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton16.Click
        ' TRUE LOGIC
        Dim a, rid As Integer
        Dim i As Integer
        Dim did, cid, ddist, dbat, dsig, dels, devs, un, dt, tm, c_id As String
        Dim dt1 As Date
        un = cu_un
        c_id = cu_cid

        Dim format As String = "dd/MM/yyyy"
        dt = Now.ToString(format)

        did = txtsrno.Text
        cid = txtcomid.Text
        ddist = txtdist.Text
        dbat = txtbatt.Text
        dsig = txtsign.Text
        dels = "0"  ' dels is delete status, (1 is delete,  0 is not delete)
        devs = "1"  'devs is device status,(1 is active device, 0 is deactive device)
        'un = "gaurang" ' un is username who is login and register devices
        ' c_id is company id whose company use this software, (ex: 1 is company id, 2 is company id)

        ' dt = dt1.ToShortDateString
        tm = dt1.ToShortTimeString


        mycon.Open()



        sql = "Select * from device_table where device_id='" & did & "' and c_id='" & c_id & "'"
        cmd = New MySqlCommand(sql, mycon)
        reader2 = cmd.ExecuteReader()

        While reader2.Read()
            a = 1
        End While
        mycon.Close()
        If a = 1 Then
            MsgBox(" Device Already exist.", MsgBoxStyle.Critical)

        Else
            mycon.Open()

            Dim rs As New MySqlCommand("insert into `device_table`(`id`, `device_id`, `company_id`, `device_ distance`, `device_battery`, `device_signal`, `delete_status`, `device_status`, `username`, `date`, `time`, `c_id`) Values('" & Trim(rid) & "','" &
                                            Trim(did) & "','" &
                                            Trim(cid) & "','" &
                                            Trim(ddist) & "','" &
                                            Trim(dbat) & "','" &
                                            Trim(dsig) & "','" &
                                            Trim(dels) & "','" &
                                            Trim(devs) & "','" &
                                            Trim(un) & "','" &
                                            Trim(dt) & "','" &
                                            Trim(tm) & "','" &
                                            Trim(c_id) & "')", mycon)

            'Dim rs As New OleDb.OleDbCommand("insert into Tutorial_Micro Values('" & txtid.Text & "','" & txtfna.Text & " ','" & txtlna.Text & " ',' " & txtadd.Text & " ',' " & txtemail.Text & "','" & txtcno.Text & "','" & txtclgna.Text & "','" & txtbranch.Text & "','" & txtsem.Text & "','" & txtgender.Text & "','" & comboCourse.Text & "','" & DateTimePicker1.Text & "','" & txttotalfee.Text & "','" & txtfirstinstall.Text & "','" & txtsecondinstall.Text & "','" & txtthirdinstall.Text & "','" & txtbalance.Text & "')", con1)


            i = rs.ExecuteNonQuery()




            If i > 0 Then
                MessageBox.Show("Product  is updated.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            mycon.Close()
        End If

        SearchDevice1.Display_device_List()




    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        issuedevicefrm.ShowDialog()

    End Sub

    Private Sub Registeruser1_Load(sender As Object, e As EventArgs) Handles Registeruser1.Load

    End Sub

    Private Sub DeivceId2_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub sample()
        '''''''''''''''new'''''''''''

        ' TRUE LOGIC
        Dim a, did As Integer
        Dim i As Integer




        mycon.Open()



        sql = "Select * from sample_table where id='" & did & "'"
        cmd = New MySqlCommand(sql, mycon)
        reader2 = cmd.ExecuteReader()

        While reader2.Read()
            a = 1
        End While
        mycon.Close()
        If a = 1 Then
            'MsgBox(" Device Already exist.", MsgBoxStyle.Critical)

        Else
            mycon.Open()


            Dim rs As New MySqlCommand("insert into `sample_table`(`id`, `device_id`,`c_id`) Values('" & Trim(did) & "','" &
                                                                        Trim(d1) & "','" &
                                                                        Trim(cu_cid) & "')", mycon)


            i = rs.ExecuteNonQuery()

            If i > 0 Then
                'MessageBox.Show("Product  is updated.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


            mycon.Close()
        End If

        '''''''''''''''''''new''''''''''''''''''''


    End Sub


    Public Sub sample1()

        'Try
        '    Dim ins As String = "insert into ProdInfo (Prod_Name, Prod_Pri) values (@Prod_Name, @Prod_Pri)"
        '    Dim cm As New SqlCommand(ins, mycon)
        '    cm.CommandType = CommandType.Text
        '    daSql.InsertCommand = cm

        '    cnSql.Open()
        '    Dim i As Integer

        '    For i = 0 To (dt.Rows.Count - 1)

        '        cm.Parameters.Add("@Prod_Name", SqlDbType.VarChar).Value = dt.Rows(i).Item("ProdName")
        '        cm.Parameters.Add("@Prod_Pri", SqlDbType.VarChar).Value = dt.Rows(i).Item("ProdPrice")

        '        cm.ExecuteNonQuery()
        '    Next
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        'cnSql.Close()

    End Sub


    ' access data

    Public Sub Access_deviceid()

        Dim id As Integer
        id = 1

        Try


            Dim table As New DataTable("sample_table")

            Dim rs As New MySqlDataAdapter("SELECT  * FROM sample_table WHERE c_id='2' ORDER BY id  ASC LIMIT 10", mycon)
            rs.Fill(table)


            'first
            deviceId1.Text = table.Rows(0)(1).ToString()
            deviceId2.Text = table.Rows(1)(1).ToString()
            deviceId3.Text = table.Rows(2)(1).ToString()
            deviceId4.Text = table.Rows(3)(1).ToString()
            deviceId5.Text = table.Rows(4)(1).ToString()
            deviceId6.Text = table.Rows(5)(1).ToString()
            deviceId7.Text = table.Rows(6)(1).ToString()
            deviceId8.Text = table.Rows(7)(1).ToString()
            deviceId9.Text = table.Rows(8)(1).ToString()
            deviceId10.Text = table.Rows(9)(1).ToString()

            'lblsub1.Text = table.Rows(0)(4).ToString()
            'lblcom1.Text = table.Rows(0)(5).ToString()
            'ed1.Text = table.Rows(0)(4).ToString()

            'second

            'lblsub2.Text = table.Rows(1)(4).ToString()
            'lblcom2.Text = table.Rows(1)(5).ToString()


            'third

            'lblsub3.Text = table.Rows(2)(4).ToString()
            'lblcom3.Text = table.Rows(2)(5).ToString()

            'fourth

            'lblsub4.Text = table.Rows(3)(4).ToString()
            'lblcom4.Text = table.Rows(3)(5).ToString()

            'fifth
            'lblname5.Text = table.Rows(4)(2).ToString()
            'lblsub5.Text = table.Rows(4)(4).ToString()
            'lblcom5.Text = table.Rows(4)(5).ToString()


        Catch ex As Exception

        End Try

    End Sub



    'delete all device list from database
    Public Sub delete_device()

        Dim adap As New MySqlDataAdapter("select * from sample_table where c_id='" & cu_cid & "'", mycon)
        If cu_cid <> "" Then
            Dim r As Integer
            'r = MsgBox("do you want to delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            'If r = MsgBoxResult.Yes Then
            mycon.Open()
            adap.SelectCommand = New MySqlCommand

            adap.SelectCommand.Connection = mycon
            'adap.SelectCommand.CommandText = "delete from AccountMaster1 ('" & txtacno.Text & "','" & txtna.Text & "','" & txtdoj.Text & "','" & txtadd.Text & "','" & txtcno.Text & "')"
            adap.SelectCommand.CommandText = "delete from sample_table where c_id= ('" & cu_cid & "')"
            adap.SelectCommand.CommandType = CommandType.Text

            mycon.Close()

            adap.Fill(ds, "sample_table")


            'End If

            'Else


        End If

    End Sub

    Private Sub BunifuFlatButton35_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton35.Click
        index += 10
        index1 += 10
        index2 += 10
        index3 += 10
        index4 += 10
        index5 += 10
        index6 += 10
        index7 += 10
        index8 += 10
        index9 += 10


        showdata(index, index1, index2, index3, index4, index5, index6, index7, index8, index9)
    End Sub
    Public Sub showdata(position As Integer, position1 As Integer, position2 As Integer, position3 As Integer, position4 As Integer, position5 As Integer, position6 As Integer, position7 As Integer, position8 As Integer, position9 As Integer)
        ' "SELECT  * FROM sample_table WHERE c_id='2' ORDER BY id  ASC LIMIT 10"
        'Dim cmd As New MySqlCommand("select * from sample_table where c_id='" & cu_cid & "'", mycon)
        Dim cmd As New MySqlCommand("SELECT  * FROM sample_table WHERE c_id='" & cu_cid & "'", mycon)
        Dim adap As New MySqlDataAdapter(cmd)

        adap.Fill(table)
        Try

            deviceId1.Text = table.Rows(position)(1).ToString()
            deviceId2.Text = table.Rows(position1)(1).ToString()
            deviceId3.Text = table.Rows(position2)(1).ToString()
            deviceId4.Text = table.Rows(position3)(1).ToString()
            deviceId5.Text = table.Rows(position4)(1).ToString()
            deviceId6.Text = table.Rows(position5)(1).ToString()

            deviceId7.Text = table.Rows(position6)(1).ToString()
            deviceId8.Text = table.Rows(position7)(1).ToString()
            deviceId9.Text = table.Rows(position8)(1).ToString()
            deviceId10.Text = table.Rows(position9)(1).ToString()
            'deviceId10.Text = table.Rows(position)(10).ToString()
            'deviceId10.Text = table.Rows(position)(11).ToString()
            'lbldate.Text = table.Rows(position)(12).ToString()




        Catch ex As Exception

            ' MessageBox.Show(ex.Message)


        End Try



    End Sub

    Private Sub BunifuFlatButton36_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton36.Click
        index -= 10
        index1 -= 10
        index2 -= 10
        index3 -= 10
        index4 -= 10
        index5 -= 10

        index6 -= 10
        index7 -= 10
        index8 -= 10
        index9 -= 10

        showdata(index, index1, index2, index3, index4, index5, index6, index7, index8, index9)
    End Sub




    Public Sub access_deviceId_data1(dName As String)

        Dim reader As MySqlDataReader
        Try
            mycon.Open()
            Dim query As String
            'sql = "Select * from device_table where device_id='" & did & "' and c_id='" & c_id & "'"
            query = "select * from issue_device_table where company_id='" & cu_cid & "'and device_id='" & dName & "'"

            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim name1 = reader.GetString("username")

                'cid = reader.GetString("cid")
                Dim r As String

                firstname1.Text = name1


            End While
            mycon.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try


    End Sub
    Public Sub access_deviceId_data(dname As String)

        Dim reader As MySqlDataReader

        Dim id1 As Integer
        id1 = 3

        Try
            mycon.Open()
            Dim query As String
            'sql = "Select * from device_table where device_id='" & did & "' and c_id='" & c_id & "'"
            sql = "select * from issue_device_table where company_id='" & cu_cid & "'and device_id=" & Trim(dname) & ""
            'sql = "select * from issue_device_table where id='" & deviceId1.Text & "'"
            cmd = New MySqlCommand(sql, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim name1 = reader.GetString("username")
                Dim contact = reader.GetString("mobile_no")


                'cid = reader.GetString("cid")
                Dim r As String

                If deviceId1.Text = dname Then
                    firstname1.Text = name1
                    contact1.Text = contact


                End If
                If deviceId2.Text = dname Then
                    firstname2.Text = name1
                    contact2.Text = contact

                End If

                If deviceId3.Text = dname Then
                    firstname3.Text = name1
                    contact3.Text = contact

                End If
                If deviceId4.Text = dname Then
                    firstname4.Text = name1
                    contact4.Text = contact

                End If

                If deviceId5.Text = dname Then
                    firstname5.Text = name1
                    contact5.Text = contact
                End If

                If deviceId6.Text = dname Then
                    firstname6.Text = name1
                    contact6.Text = contact

                End If

                If deviceId7.Text = dname Then
                    firstname7.Text = name1
                    contact7.Text = contact

                End If

                If deviceId8.Text = dname Then
                    firstname8.Text = name1
                    contact8.Text = contact

                End If

                If deviceId9.Text = dname Then
                    firstname9.Text = name1
                    contact9.Text = contact
                End If

                If deviceId10.Text = dname Then
                    firstname10.Text = name1
                    contact10.Text = contact

                End If





            End While
            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try
        'MsgBox("hii")

    End Sub




    'Private Sub deviceId2_TextChanged(sender As Object, e As EventArgs)
    '    'Dim id As String = ""
    '    'id = deviceId2.Text
    '    'access_deviceId_data2(id)

    '    'If deviceId2.Text = "Deivce Id" Then


    '    'ElseIf deviceId2.Text <> "Device Id" Then

    '    '    access_deviceId_data2()


    '    'ElseIf deviceId2.Text = "" Then

    '    '    access_deviceId_data2()


    '    'End If

    '    'access_deviceId_data2()
    'End Sub

    'Private Sub deviceId4_TextChanged(sender As Object, e As EventArgs)
    '    'access_deviceId_data(deviceId3.Text)
    '    'access_deviceId_data(deviceId4.Text)
    '    'access_deviceId_data(deviceId5.Text)
    '    'access_deviceId_data(deviceId6.Text)
    '    'access_deviceId_data(deviceId7.Text)
    '    'access_deviceId_data(deviceId8.Text)
    '    'access_deviceId_data(deviceId9.Text)
    '    'access_deviceId_data(deviceId10.Text)


    'End Sub

    'Private Sub deviceId3_Click(sender As Object, e As EventArgs)

    'End Sub

    Private Sub BunifuFlatButton37_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton37.Click
        'access_deviceId_data1(deviceId1.Text)



    End Sub

    Private Sub Panel30_Paint(sender As Object, e As PaintEventArgs) Handles Panel30.Paint

    End Sub

    Private Sub deviceId1_TextChanged(sender As Object, e As EventArgs) Handles deviceId1.TextChanged
        'Dim reader As MySqlDataReader

        'Dim id1 As Integer
        'id1 = 3

        'Try
        '    mycon.Open()
        '    Dim query As String
        '    'sql = "Select * from device_table where device_id='" & did & "' and c_id='" & c_id & "'"
        '    sql = "select * from issue_device_table where company_id='" & cu_cid & "'and device_id=" & Trim(deviceId1.Text) & ""
        '    'sql = "select * from issue_device_table where id='" & deviceId1.Text & "'"
        '    cmd = New MySqlCommand(sql, mycon)
        '    reader = cmd.ExecuteReader
        '    While reader.Read
        '        Dim name1 = reader.GetString("username")

        '        'cid = reader.GetString("cid")
        '        Dim r As String

        '        firstname1.Text = name1


        '    End While
        '    mycon.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)


        'Finally
        '    mycon.Dispose()

        'End Try
        'MsgBox("hii")
        access_deviceId_data(deviceId1.Text)


    End Sub

    Private Sub deviceId2_TextChanged(sender As Object, e As EventArgs) Handles deviceId2.TextChanged
        access_deviceId_data(deviceId2.Text)


        'Dim reader As MySqlDataReader
        'Try
        '    mycon.Open()
        '    Dim query As String
        '    'sql = "Select * from device_table where device_id='" & did & "' and c_id='" & c_id & "'"
        '    query = "select * from issue_device_table where company_id='" & cu_cid & "'and device_id='" & Trim(deviceId2.Text) & "'"

        '    cmd = New MySqlCommand(query, mycon)
        '    reader = cmd.ExecuteReader
        '    While reader.Read
        '        Dim name1 = reader.GetString("username")

        '        'cid = reader.GetString("cid")
        '        Dim r As String

        '        firstname2.Text = name1


        '    End While
        '    mycon.Close()

        'Catch ex As Exception
        '    'MessageBox.Show(ex.Message)


        'Finally
        '    mycon.Dispose()

        'End Try
    End Sub

    Private Sub deviceId3_TextChanged(sender As Object, e As EventArgs) Handles deviceId3.TextChanged
        access_deviceId_data(deviceId3.Text)
    End Sub

    Private Sub deviceId4_TextChanged(sender As Object, e As EventArgs) Handles deviceId4.TextChanged
        access_deviceId_data(deviceId4.Text)
    End Sub

    Private Sub deviceId5_TextChanged(sender As Object, e As EventArgs) Handles deviceId5.TextChanged
        access_deviceId_data(deviceId5.Text)
    End Sub

    Private Sub deviceId6_TextChanged(sender As Object, e As EventArgs) Handles deviceId6.TextChanged
        access_deviceId_data(deviceId6.Text)
    End Sub

    Private Sub deviceId7_TextChanged(sender As Object, e As EventArgs) Handles deviceId7.TextChanged
        access_deviceId_data(deviceId7.Text)
    End Sub

    Private Sub deviceId8_TextChanged(sender As Object, e As EventArgs) Handles deviceId8.TextChanged
        access_deviceId_data(deviceId8.Text)
    End Sub

    Private Sub deviceId9_TextChanged(sender As Object, e As EventArgs) Handles deviceId9.TextChanged
        access_deviceId_data(deviceId9.Text)
    End Sub

    Private Sub deviceId10_TextChanged(sender As Object, e As EventArgs) Handles deviceId10.TextChanged
        access_deviceId_data(deviceId10.Text)

    End Sub

    Private Sub SearchDevice1_Load(sender As Object, e As EventArgs) Handles SearchDevice1.Load

    End Sub


    ' userlist from device id


    Public Sub access_userdata_data12(dname As String)
        Dim isss As String = ""
        Dim reader As MySqlDataReader

        Dim id1 As Integer
        id1 = 3

        Try
            mycon.Open()
            Dim query As String
            'sql = "Select * from device_table where device_id='" & did & "' and c_id='" & c_id & "'"
            sql = "select * from issue_device_table where company_id='" & cu_cid & "'and device_id=" & Trim(dname) & ""
            'sql = "select * from issue_device_table where id='" & deviceId1.Text & "'"
            cmd = New MySqlCommand(sql, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim name1 = reader.GetString("username")
                Dim mb = reader.GetString("mobile_no")
                Dim st = reader.GetString("issue_status")


                'cid = reader.GetString("cid")
                Dim r As String

                If deviceId1.Text = dname Then
                    firstname1.Text = name1


                End If
                If deviceId2.Text = dname Then
                    firstname2.Text = name1


                End If

                If deviceId3.Text = dname Then
                    firstname3.Text = name1


                End If
                If deviceId4.Text = dname Then
                    firstname4.Text = name1


                End If

                If deviceId5.Text = dname Then
                    firstname5.Text = name1

                End If

                If deviceId6.Text = dname Then
                    firstname6.Text = name1


                End If

                If deviceId7.Text = dname Then
                    firstname7.Text = name1


                End If

                If deviceId8.Text = dname Then
                    firstname8.Text = name1


                End If

                If deviceId9.Text = dname Then
                    firstname9.Text = name1

                End If

                If deviceId10.Text = dname Then
                    firstname10.Text = name1


                End If



                If sn = dname Then

                    username55.Text = name1
                    txtmobile55.Text = mb

                    'txtstatus55.Text = st
                    If st = "1" Then
                        txtstatus55.Text = "Issued"

                    ElseIf st = "0"
                        txtstatus55.Text = "Returned"


                    End If

                End If


            End While
            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try
        'MsgBox("hii")

    End Sub

    Private Sub Label87_Click(sender As Object, e As EventArgs) Handles contact9.Click

    End Sub




    Private Sub BunifuFlatButton40_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton40.Click
        If Panel35.Visible = False Then
            Panel15.Visible = False
            Panel13.Visible = False
            Panel14.Visible = False
            Panel35.Visible = True

            Panel36.Visible = False

        End If
    End Sub

    Private Sub BunifuFlatButton12_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        If Panel36.Visible = False Then
            Panel15.Visible = False
            Panel13.Visible = False
            Panel14.Visible = False
            Panel35.Visible = False
            Panel36.Visible = True
            Panel38.Visible = False

        End If








    End Sub

    Private Sub BunifuFlatButton39_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton39.Click
        TabControl1.SelectedTab = TabPage6

    End Sub

    Private Sub BunifuFlatButton47_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton47.Click

        Dim r As String
        'If Panel36.Visible = False Then
        '    Panel15.Visible = False
        '    Panel13.Visible = False
        '    Panel14.Visible = False
        '    Panel35.Visible = False
        '    Panel36.Visible = True

        'End If



        r = MsgBox("Want to sign out", MsgBoxStyle.Question + MsgBoxStyle.YesNo)



        Try
            If r = MsgBoxResult.Yes Then
                com.Close()
                com.Dispose()

                Me.Hide()
                loginfrm.Show()
                loginfrm.txtemail.Text = ""
                loginfrm.txtpassword.Text = ""
                loginfrm.txtemail.Focus()

            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub firstname1_Click(sender As Object, e As EventArgs) Handles firstname1.Click
        access_device_user(firstname1.Text)
        MsgBox(ad_uid)

        userDetails.ShowDialog()


    End Sub


    'sample


    Public Sub access_device_user(uname As String)

        Dim reader As MySqlDataReader

        Dim id1 As Integer
        id1 = 3

        Try
            mycon.Open()
            Dim query As String
            'sql = "Select * from device_table where device_id='" & did & "' and c_id='" & c_id & "'"
            sql = "select * from issue_device_table where company_id='" & cu_cid & "'and username='" & Trim(uname) & "'"
            'sql = "select * from issue_device_table where id='" & deviceId1.Text & "'"
            cmd = New MySqlCommand(sql, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                ad_uid = reader.GetString("user_id")

            End While
            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try
        'MsgBox("hii")

    End Sub

    Private Sub firstname2_Click(sender As Object, e As EventArgs) Handles firstname2.Click
        access_device_user(firstname2.Text)
        MsgBox(ad_uid)
    End Sub

    Private Sub BunifuFlatButton13_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton13.Click

    End Sub

    Private Sub txtsrno31_OnValueChanged(sender As Object, e As EventArgs) Handles txtsrno31.OnValueChanged
        'access_userdata_data12(txtsrno31.Text)

    End Sub

    Private Sub BunifuFlatButton32_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton32.Click
        deviceId1.Clear()
        deviceId2.Clear()
        deviceId3.Clear()
        deviceId4.Clear()
        deviceId5.Clear()
        deviceId6.Clear()
        deviceId7.Clear()
        deviceId8.Clear()
        deviceId9.Clear()
        deviceId10.Clear()

        contact1.Text = ""
        contact2.Text = ""
        contact3.Text = ""
        contact4.Text = ""
        contact5.Text = ""
        contact6.Text = ""
        contact7.Text = ""
        contact8.Text = ""
        contact9.Text = ""
        contact10.Text = ""


        firstname1.Text = ""
        firstname2.Text = ""
        firstname3.Text = ""
        firstname4.Text = ""
        firstname5.Text = ""
        firstname6.Text = ""
        firstname7.Text = ""
        firstname8.Text = ""
        firstname9.Text = ""
        firstname10.Text = " "

    End Sub

    Private Sub BunifuFlatButton46_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton46.Click

    End Sub
End Class


 
Qr Image Scanner Code


Imports MySql.Data.MySqlClient
Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Public Class qrscanner
    Private dispositivos As FilterInfoCollection
    Private fuentevideo As VideoCaptureDevice
    Private Sub qrscanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In dispositivos
            ComboBox1.Items.Add(x.Name)

        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
        fuentevideo = New VideoCaptureDevice(dispositivos(ComboBox1.SelectedIndex).MonikerString)
        VideoSourcePlayer1.VideoSource = fuentevideo
        VideoSourcePlayer1.Start()

    End Sub
End Class



 
Device Registration Code

Imports MySql.Data.MySqlClient
Public Class registeruser
    Private Sub Panel24_Paint(sender As Object, e As PaintEventArgs) Handles Panel24.Paint

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        'Dim frm As Form1 = New Form1
        'frm.TabPage5.Show()

        userTabControl1.SelectedTab = TabPage2


    End Sub

    Private Sub registeruser_Load(sender As Object, e As EventArgs) Handles Me.Load
        BunifuSeparator2.Visible = False
        BunifuSeparator3.Visible = False
        BunifuSeparator5.Visible = False

        Display_Users_List()
        design_controls()

        'datagrid()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If ru_id <> "" Then
            Dim obj As New UserEditfrm
            obj.ShowDialog()
            BunifuSeparator2.Visible = True
            BunifuSeparator3.Visible = False
            BunifuSeparator5.Visible = False

        Else
            MsgBox("Please Select Record For Delete Entry", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical)



        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BunifuSeparator2.Visible = False
        BunifuSeparator3.Visible = True
        BunifuSeparator5.Visible = False


        '''''
        Dim dlt_status As String = "1"
        Dim r As String = ""
        If ru_id <> "" Then

            Try

                Dim com As MySqlCommand = New MySqlCommand("update user_register_table set  delete_status=@1  where uid=" & Trim(ru_id) & " and cid='" & cu_cid & "'", mycon)

                com.Parameters.AddWithValue("@1", dlt_status)


                mycon.Open()
                com.ExecuteNonQuery()

                mycon.Close()

                MsgBox("Record has been deleted successfully", MsgBoxStyle.OkCancel + MsgBoxStyle.Information)


                Display_Users_List()
                ru_id = ""
            Catch ex As Exception

            End Try



        Else

            'MsgBox("Record Not Deleted", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical)
            MsgBox("Select Record for delete entry", MsgBoxStyle.OkCancel + MsgBoxStyle.Question)



        End If




    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        userTabControl1.SelectedTab = TabPage1

    End Sub

    Private Sub txtRU_email_OnValueChanged(sender As Object, e As EventArgs) Handles txtRU_email.OnValueChanged

    End Sub

    Private Sub BunifuFlatButton17_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton17.Click
        ' TRUE LOGIC


        Dim fullname As String = ""

        Dim a, uid As Integer
        Dim i As Integer
        Dim cid As Integer
        Dim dt, tm As String
        Dim dt1 As Date
        Dim dstatus As String = "0"
        Dim empstatus As String = "0"
        Dim log_user As String = "1"



        log_user = cu_uid
        cid = cu_cid
        fullname = txtRU_fname.Text & " " & txtRU_lname.Text




        Dim format As String = "dd/MM/yyyy"
        dt = Now.ToString(format)
        Dim format1 As String = "HH:mm"
        tm = Now.ToString(format1)



        'dels = "0"  ' dels is delete status, (1 is delete,  0 is not delete)
        'devs = "1"  'devs is device status,(1 is active device, 0 is deactive device)
        'un = "gaurang" ' un is username who is login and register devices
        'c_id = "1" ' c_id is company id whose company use this software, (ex: 1 is company id, 2 is company id)

        ' dt = dt1.ToShortDateString
        tm = dt1.ToShortTimeString


        mycon.Open()



        sql = "Select * from user_register_table where uid='" & uid & "' or employee_code='" & txtRU_empcode.Text & "'"
        cmd = New MySqlCommand(sql, mycon)
        reader2 = cmd.ExecuteReader()

        While reader2.Read()
            a = 1
        End While
        mycon.Close()
        If a = 1 Then
            MsgBox(" User already exist.", MsgBoxStyle.Critical)

        Else
            mycon.Open()

            Dim rs As New MySqlCommand("insert into  `user_register_table`(`uid`, `cid`, `first_name`, `last_name`, `username`, `mobile`, `email`, `company_name`, `address`, `city`, `employee_code`, `emp_status`, `delete_status`,`loguser`, `date`, `time`) Values('" & Trim(uid) & "','" &
                                            Trim(cid) & "','" &
                                            Trim(txtRU_fname.Text) & "','" &
                                            Trim(txtRU_lname.Text) & "','" &
                                            Trim(fullname) & "','" &
                                            Trim(txtRU_mobile.Text) & "','" &
                                            Trim(txtRU_email.Text) & "','" &
                                            Trim(txtRU_comp.Text) & "','" &
                                            Trim(txtRU_address.Text) & "','" &
                                            Trim(txtRU_city.Text) & "','" &
                                            Trim(txtRU_empcode.Text) & "','" &
                                            Trim(empstatus) & "','" &
                                            Trim(dstatus) & "','" &
                                            Trim(log_user) & "','" &
                                            Trim(dt) & "','" &
                                            Trim(tm) & "')", mycon)



            'Dim rs As New OleDb.OleDbCommand("insert into Tutorial_Micro Values('" & txtid.Text & "','" & txtfna.Text & " ','" & txtlna.Text & " ',' " & txtadd.Text & " ',' " & txtemail.Text & "','" & txtcno.Text & "','" & txtclgna.Text & "','" & txtbranch.Text & "','" & txtsem.Text & "','" & txtgender.Text & "','" & comboCourse.Text & "','" & DateTimePicker1.Text & "','" & txttotalfee.Text & "','" & txtfirstinstall.Text & "','" & txtsecondinstall.Text & "','" & txtthirdinstall.Text & "','" & txtbalance.Text & "')", con1)


            i = rs.ExecuteNonQuery()


            If i > 0 Then
                MessageBox.Show("Data has been submitted.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            mycon.Close()
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        mycon.Open()

        Try

            Dim dt As New DataTable("user_register_table")
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            'Dim rs As New MySqlDataAdapter("Select `device_id`, `username`,  `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
            Dim rs As New MySqlDataAdapter("select `uid`, `cid`, `first_name`, `last_name`, `username`, `mobile`, `email`, `company_name`, `address`, `city`, `employee_code`, `emp_status`, `delete_status`, `loguser`, `date`, `time` From user_register_table Where delete_status='0' and concat(first_name,last_name) like '%" & Trim(txtsearch.Text) & "%' and cid='" & cu_cid & "'", mycon)
            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()


        Catch ex As Exception


            MessageBox.Show(ex.Message)

        End Try

        mycon.Close()
    End Sub

    Public Sub Display_Users_List()
        mycon.Open()

        Try


            Dim dt As New DataTable("user_register_table")
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            Dim rs As New MySqlDataAdapter("select  `first_name`, `last_name`, `username`, `mobile`, `email`, `company_name`, `address`, `city`, `employee_code`,  `date`, `time` from  user_register_table where delete_status='0' and cid='" & cu_cid & "'", mycon)
            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()

            DataGridView1.Columns("first_name").HeaderText = "First Name"
            DataGridView1.Columns("last_name").HeaderText = "Last Name"
            DataGridView1.Columns("username").HeaderText = "Full Name"
            DataGridView1.Columns("mobile").HeaderText = "Mobile"
            DataGridView1.Columns("email").HeaderText = "Email"
            DataGridView1.Columns("company_name").HeaderText = "Company"
            DataGridView1.Columns("address").HeaderText = "Address"
            DataGridView1.Columns("city").HeaderText = "City"
            DataGridView1.Columns("employee_code").HeaderText = "Employee Code"
            'DataGridView1.Columns("emp_status").HeaderText = "Emp Status"
            DataGridView1.Columns("date").HeaderText = "Date"
            DataGridView1.Columns("time").HeaderText = "Time"

        Catch ex As Exception

        End Try
        mycon.Close()


    End Sub

    Private Sub txtsearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtsearch.OnValueChanged

    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            mycon.Open()

            Try

                Dim dt As New DataTable("user_register_table")
                ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
                'Dim rs As New MySqlDataAdapter("Select `device_id`, `username`,  `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
                Dim rs As New MySqlDataAdapter("select `uid`, `cid`, `first_name`, `last_name`, `username`, `mobile`, `email`, `company_name`, `address`, `city`, `employee_code`, `emp_status`, `delete_status`, `loguser`, `date`, `time` From user_register_table Where delete_status='0' and concat(first_name,last_name) like '%" & Trim(txtsearch.Text) & "%' and cid='" & cu_cid & "'", mycon)
                rs.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
                rs.Dispose()


            Catch ex As Exception


                MessageBox.Show(ex.Message)

            End Try

            mycon.Close()


            e.Handled = True
        End If
    End Sub

    Private Sub txtsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyUp
        If txtsearch.Text = "" Then
            Display_Users_List()

        End If
    End Sub

    Public Sub design_controls()
        Panel22.Width = 1037
        Panel22.Height = 45


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            'ru_id = DataGridView1.Item(1, e.RowIndex).Value
            ru_un = DataGridView1.Item(0, e.RowIndex).Value

            get_RU_ID()
            MsgBox(ru_id)


        Catch ex As Exception

        End Try



    End Sub


    Public Sub get_RU_ID()


        mycon.Open()
        Dim reader As MySqlDataReader
        Try

            Dim query As String
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            query = "select * from user_register_table where first_name='" & ru_un & "'and cid='" & Trim(cu_cid) & "'"
            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                ru_id = reader.GetString("uid")



            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try

        mycon.Close()


    End Sub


    Public Sub datagrid()

        Try


            DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 9)
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)


            Dim columnwidth1 As DataGridViewColumn = DataGridView1.Columns(0)
            columnwidth1.Width = 150


            Dim columnwidth2 As DataGridViewColumn = DataGridView1.Columns(1)
            columnwidth2.Width = 150

            Dim columnwidth3 As DataGridViewColumn = DataGridView1.Columns(2)
            columnwidth3.Width = 200


            Dim columnwidth4 As DataGridViewColumn = DataGridView1.Columns(3)
            columnwidth4.Width = 100

            Dim columnwidth5 As DataGridViewColumn = DataGridView1.Columns(4)
            columnwidth5.Width = 170


            Dim columnwidth6 As DataGridViewColumn = DataGridView1.Columns(5)
            columnwidth6.Width = 130

            Dim columnwidth7 As DataGridViewColumn = DataGridView1.Columns(6)
            columnwidth7.Width = 170

            Dim columnwidth8 As DataGridViewColumn = DataGridView1.Columns(7)
            columnwidth8.Width = 120

            Dim columnwidth9 As DataGridViewColumn = DataGridView1.Columns(8)
            columnwidth9.Width = 100

            Dim columnwidth10 As DataGridViewColumn = DataGridView1.Columns(9)
            columnwidth10.Width = 100

            Dim columnwidth11 As DataGridViewColumn = DataGridView1.Columns(10)
            columnwidth11.Width = 100

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Display_Users_List()

        BunifuSeparator2.Visible = False
        BunifuSeparator3.Visible = False
        BunifuSeparator5.Visible = True

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        userTabControl1.SelectedTab = TabPage2


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        userTabControl1.SelectedTab = TabPage2

    End Sub

    Private Sub BunifuFlatButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        txtRU_address.Text = ""
        txtRU_city.Text = ""
        txtRU_comp.Text = ""
        txtRU_email.Text = ""
        txtRU_empcode.Text = ""
        txtRU_fname.Text = ""
        txtRU_lname.Text = ""
        txtRU_mobile.Text = ""
        txtRU_fname.Focus()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class



 
Employee Data update

Imports MySql.Data.MySqlClient
Public Class UserEditfrm
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        ru_id = ""
        Me.Close()
        Dim obj As registeruser = New registeruser()

        obj.Display_Users_List()

        obj.DataGridView1.Refresh()


    End Sub

    Private Sub BunifuFlatButton17_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton17.Click
        mycon.Close()

        If txtuid.Text <> "" Then

            Try

                Dim com As MySqlCommand = New MySqlCommand("update user_register_table set  first_name=@1,last_name=@2,username=@3,mobile=@4,email=@5,company_name=@6,address=@7,city=@8,employee_code=@9  where uid=" & Trim(txtuid.Text) & " and cid='" & cu_cid & "'", mycon)

                com.Parameters.AddWithValue("@1", txtfname.Text)
                com.Parameters.AddWithValue("@2", txtlname.Text)
                com.Parameters.AddWithValue("@3", txtusername.Text)
                com.Parameters.AddWithValue("@4", txtmobile.Text)
                com.Parameters.AddWithValue("@5", txtemail.Text)
                com.Parameters.AddWithValue("@6", txtcompany.Text)
                com.Parameters.AddWithValue("@7", txtaddress.Text)
                com.Parameters.AddWithValue("@8", txtcity.Text)
                com.Parameters.AddWithValue("@9", txtempcode.Text)


                mycon.Open()
                com.ExecuteNonQuery()

                mycon.Close()

                MsgBox("Record has been updated successfully", MsgBoxStyle.OkCancel + MsgBoxStyle.Information)

            Catch ex As Exception

            End Try

        Else

            MsgBox("Record Not Updated", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical)
        End If





    End Sub

    Public Sub get_register_user_details()
        mycon.Close()



        mycon.Open()
        Dim reader As MySqlDataReader
        Try

            Dim query As String
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            query = "select * from user_register_table where uid='" & ru_id & "'and cid='" & Trim(cu_cid) & "'"
            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim fn, ln, un, email, addr, ct, mb, comp, ecode As String
                fn = reader.GetString("first_name")
                ln = reader.GetString("last_name")
                un = reader.GetString("username")
                email = reader.GetString("email")
                mb = reader.GetString("mobile")
                comp = reader.GetString("company_name")
                addr = reader.GetString("address")
                ct = reader.GetString("city")
                ecode = reader.GetString("employee_code")
                txtuid.Text = ru_id

                txtfname.Text = fn
                txtlname.Text = ln
                txtusername.Text = un
                txtemail.Text = email
                txtmobile.Text = mb
                txtcompany.Text = comp
                txtaddress.Text = addr
                txtcity.Text = ct
                txtempcode.Text = ecode






            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try

        mycon.Close()
    End Sub

    Private Sub UserEditfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        get_register_user_details()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class


 
Device issue Code

Imports MySql.Data.MySqlClient
Public Class issuedevicefrm
    Dim istatus As String = ""
    Dim uid As String = ""
    Private Sub BunifuFlatButton34_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton34.Click


        ' TRUE LOGIC
        Dim a, rid As Integer
        Dim i As Integer
        Dim did, c_id, un, u_id As String
        Dim dt1 As Date
        Dim dt, tm As String
        un = cu_un
        c_id = cu_cid
        u_id = cu_uid


        Dim format As String = "dd/MM/yyyy"


        dt = Now.ToString(format)
        tm = dt1.ToShortTimeString

        If txtiissue_status.SelectedText = "Active" Then

            istatus = "1"

        ElseIf txtiissue_status.SelectedText = "Deactive" Then

            istatus = "0"

        End If

        ' dels is delete status, (1 is delete,  0 is not delete)
        'devs is device status,(1 is active device, 0 is deactive device)
        'un = "gaurang" ' un is username who is login and register devices
        ' c_id is company id whose company use this software, (ex: 1 is company id, 2 is company id)

        ' dt = dt1.ToShortDateString



        mycon.Open()
        Dim reader3 As MySqlDataReader
        Dim sql1 As String
        Dim cmd1 As MySqlCommand
        ' 1st command
        sql = "Select * from issue_device_table where device_id='" & txtidevice_id.Text & "' and user_id='" & uid & "'and issue_status='" & istatus & "'and company_id='" & c_id & "'"
        'sql = "Select * from  addcompanyuser_table where username='" & txtCU_username.Text & "' and uid='" & uid & "' and issue_status='" & istatus & "'"
        cmd = New MySqlCommand(sql, mycon)
        reader2 = cmd.ExecuteReader()


        While reader2.Read()
            a = 1
        End While

        reader2.Dispose()


        ' 2nd command
        sql1 = "Select * from issue_device_table where issue_status='1' and user_id='" & uid & "'"
        'sql = "Select * from  addcompanyuser_table where username='" & txtCU_username.Text & "' and uid='" & uid & "' and issue_status='" & istatus & "'"
        cmd1 = New MySqlCommand(sql1, mycon)
        reader3 = cmd1.ExecuteReader()


        While reader3.Read()
            a = 2
        End While
        reader3.Dispose()


        mycon.Close()
        If a = 1 Then
            MsgBox(" Device Already Issue.", MsgBoxStyle.Critical)

        ElseIf a = 2
            MsgBox(" Device Already Issue 11.", MsgBoxStyle.Critical)

        Else
            mycon.Open()

            Dim rs As New MySqlCommand("insert into `issue_device_table`(`id`, `device_id`, `username`, `user_id`, `mobile_no`, `issue_status`, `company_id`,`log_user`, `date`, `time`) Values('" & Trim(rid) & "','" &
                                            Trim(txtidevice_id.Text) & "','" &
                                            Trim(txtiusername.Text) & "','" &
                                            Trim(uid) & "','" &
                                            Trim(txtimobile.Text) & "','" &
                                            Trim(istatus) & "','" &
                                            Trim(c_id) & "','" &
                                            Trim(u_id) & "','" &
                                            Trim(dt) & "','" &
                                            Trim(tm) & "')", mycon)

            'Dim rs As New OleDb.OleDbCommand("insert into Tutorial_Micro Values('" & txtid.Text & "','" & txtfna.Text & " ','" & txtlna.Text & " ',' " & txtadd.Text & " ',' " & txtemail.Text & "','" & txtcno.Text & "','" & txtclgna.Text & "','" & txtbranch.Text & "','" & txtsem.Text & "','" & txtgender.Text & "','" & comboCourse.Text & "','" & DateTimePicker1.Text & "','" & txttotalfee.Text & "','" & txtfirstinstall.Text & "','" & txtsecondinstall.Text & "','" & txtthirdinstall.Text & "','" & txtbalance.Text & "')", con1)


            i = rs.ExecuteNonQuery()




            If i > 0 Then
                MessageBox.Show("Device Issued is updated.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            mycon.Close()
        End If

    End Sub

    ' device list for issue device to the visitor, this function will call from load event


    Public Sub list__Device_id()
        mycon.Close()

        txtidevice_id.Items.Clear()

        Dim reader As MySqlDataReader
        'Try
        mycon.Open()
            Dim query As String
            query = "select * from device_table where c_id='" & cu_cid & "'"

            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim did = reader.GetString("device_id")
                'cid = reader.GetString("cid")
                Dim r As String

                txtidevice_id.Items.Add(did)

            End While
        mycon.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)


        'Finally
        mycon.Dispose()

        'End Try


    End Sub

    ' this function for get user list from there company id wise and call from load evennt
    ' access user list from user_register_table

    Public Sub list__username()
        mycon.Close()

        txtiusername.Items.Clear()

        Dim reader As MySqlDataReader
        'Try
        mycon.Open()
            Dim query As String
            query = "select * from user_register_table where cid='" & cu_cid & "'"

            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                'Dim name = reader.GetString("first_name")
                Dim name = reader.GetString("first_name")
            Dim name1 = reader.GetString("last_name")
            Dim fullname = reader.GetString("username")




            ' uid = reader.GetString("uid")
            'cid = reader.GetString("cid")
            Dim r As String

            txtiusername.Items.Add(fullname)



        End While
            mycon.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)


        'Finally
        mycon.Dispose()

        'End Try


    End Sub


    Public Sub get_user_details()

        Dim reader As MySqlDataReader
        'Try
        mycon.Close()

        mycon.Open()
        Dim query As String
        'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
        'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
        query = "select * from user_register_table where username='" & txtiusername.Text & "'and cid='" & Trim(cu_cid) & "'"
        cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim mobile = reader.GetString("mobile")
                Dim address = reader.GetString("address")
                'cid = reader.GetString("cid")
                Dim r As String
                uid = reader.GetString("uid")
                txtiaddress.Text = address
                txtimobile.Text = mobile
            'MsgBox(uid)

        End While
        mycon.Close()

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)


        'Finally
        'mycon.Dispose()

        'End Try


    End Sub

    Private Sub issuedevicefrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        list__Device_id()
        list__username()
        Display_users()

    End Sub

    Private Sub txtiusername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtiusername.SelectedIndexChanged
        get_user_details()

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        txtiaddress.Text = ""
        txtidevice_id.Text = ""
        txtimobile.Text = ""
        txtiusername.Text = ""
        list__Device_id()
        list__username()
    End Sub
    Public Sub Display_users()
        mycon.Close()

        Try


            mycon.Open()

            Dim dt As New DataTable("user_register_table")
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            Dim rs As New MySqlDataAdapter("select `uid`,  `first_name`, `last_name`, `username`, `mobile`, `email`, `company_name`, `address`, `city`, `employee_code`, `date`, `time` from user_register_table where cid='" & cu_cid & "'", mycon)
            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()
            mycon.Close()



            DataGridView1.Columns("uid").HeaderText = "User ID"
            DataGridView1.Columns("first_name").HeaderText = "First Name"
            DataGridView1.Columns("last_name").HeaderText = "Last Name"
            DataGridView1.Columns("username").HeaderText = "Full Name"
            DataGridView1.Columns("mobile").HeaderText = "Mobile"
            DataGridView1.Columns("email").HeaderText = "Email ID"
            DataGridView1.Columns("company_name").HeaderText = "Company Name"
            DataGridView1.Columns("address").HeaderText = "Address"
            DataGridView1.Columns("city").HeaderText = "City"
            DataGridView1.Columns("date").HeaderText = "Date"
            DataGridView1.Columns("time").HeaderText = "Time"
            'DataGridView1.Columns("issue_status").HeaderText = "Issue Device"




        Catch ex As Exception


        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        txtiaddress.Text = ""
        txtidevice_id.Text = ""
        txtimobile.Text = ""
        txtiusername.Text = ""

        list__Device_id()
        list__username()

    End Sub

    Private Sub txtidevice_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtidevice_id.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        Me.Close()

    End Sub

    'Dim id As Integer = ""
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            uid = DataGridView1.Item(0, e.RowIndex).Value
            'txtiusername.Text = DataGridView1.Item(1, e.RowIndex).Value
            'txtcat.Text = DataGridView1.Item(2, e.RowIndex).Value
            txtiusername.Text = DataGridView1.Item(3, e.RowIndex).Value
            txtimobile.Text = DataGridView1.Item(4, e.RowIndex).Value
            'txt.Text = DataGridView1.Item(4, e.RowIndex).Value
            'txtqty.Text = DataGridView1.Item(5, e.RowIndex).Value
            txtiaddress.Text = DataGridView1.Item(7, e.RowIndex).Value
            'txtgst.Text = DataGridView1.Item(7, e.RowIndex).Value
            'txtfinalamt.Text = DataGridView1.Item(8, e.RowIndex).Value
            'txtdesc.Text = DataGridView1.Item(9, e.RowIndex).Value
            'txtdesc.Text = DataGridView1.Item(9, e.RowIndex).Value






        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        issuedeviceList.ShowDialog()

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        mycon.Close()

        Try
            mycon.Open()

            Dim dt As New DataTable("user_register_table")
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            Dim rs As New MySqlDataAdapter("Select `uid`, `first_name`, `last_name`, `username`, `mobile`, `email`, `company_name`, `address`, `city`, `employee_code`, `date`, `time`  From user_register_table Where concat(first_name,last_name) Like '%" & Trim(txtsearch.Text) & "%' and cid='" & cu_cid & "'", mycon)
            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()
            mycon.Close()

        Catch ex As Exception


            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txtsearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtsearch.OnValueChanged

    End Sub

    Private Sub txtsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyUp
        If txtsearch.Text = "" Then
            Display_users()


        End If

    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            Try
                mycon.Open()

                Dim dt As New DataTable("user_register_table")
                ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
                Dim rs As New MySqlDataAdapter("Select `uid`, `first_name`, `last_name`, `username`, `mobile`, `email`, `company_name`, `address`, `city`, `employee_code`, `date`, `time` From user_register_table Where first_name Like '%" & Trim(txtsearch.Text) & "%' and cid='" & cu_cid & "'", mycon)
                rs.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
                rs.Dispose()
                mycon.Close()

            Catch ex As Exception


                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub
End Class


 
Device Issue List Code
Imports MySql.Data.MySqlClient
Public Class issuedeviceList
    Private Sub issuedeviceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_issue_device_List()

    End Sub

    Public Sub Display_issue_device_List()

        Dim I_status As String = "1"

        Try

            mycon.Open()

            Dim dt As New DataTable("issue_device_table")
            Dim rs As New MySqlDataAdapter("select `device_id`,  `username`, `mobile_no`, `date`, `time`, `issue_status` from  issue_device_table where issue_status = " & Trim(I_status) & " And company_id ='" & cu_cid & "'", mycon)
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            'Dim rs As New MySqlDataAdapter("select `device_id`,  `username`, `mobile_no`, `date`, `time` from  issue_device_table where company_id='" & cu_cid & "'", mycon)
            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()
            mycon.Close()

            DataGridView1.Columns("device_id").HeaderText = "Device Id"
            DataGridView1.Columns("username").HeaderText = "Username"
            DataGridView1.Columns("mobile_no").HeaderText = "Mobile No"
            DataGridView1.Columns("date").HeaderText = "Date"
            DataGridView1.Columns("time").HeaderText = "Time"
            DataGridView1.Columns("issue_status").HeaderText = "Issue Device"

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BunifuFlatButton20_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton20.Click

        mycon.Close()

        Try
            mycon.Open()

            Dim dt As New DataTable("issue_device_table")
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            'Dim rs As New MySqlDataAdapter("Select `device_id`, `username`,  `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
            Dim rs As New MySqlDataAdapter("select `device_id`,  `username`, `mobile_no`, `date`, `time` From issue_device_table Where issue_status='1' and device_id like '%" & Trim(txtsearch.Text) & "%' and company_id='" & cu_cid & "'", mycon)
            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()
            mycon.Close()

        Catch ex As Exception


            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub txtsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyUp
        If txtsearch.Text = "" Then
            Display_issue_device_List()
        End If

    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            Try
                mycon.Open()

                Dim dt As New DataTable("issue_device_table")
                ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
                'Dim rs As New MySqlDataAdapter("Select `device_id`, `username`,  `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
                Dim rs As New MySqlDataAdapter("select `device_id`,  `username`, `mobile_no`, `date`, `time` From issue_device_table Where issue_status='1' and device_id like '%" & Trim(txtsearch.Text) & "%' and company_id='" & cu_cid & "'", mycon)
                rs.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
                rs.Dispose()
                mycon.Close()

            Catch ex As Exception


                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub
End Class
 
Device Return code
Imports MySql.Data.MySqlClient
Public Class returnDevice

    ' R-Status is the variable of return status(0 is return, 1 is issue device)
    Dim R_status As String = ""
    Public Sub Display_issue_device_List()

        mycon.Open()

        Dim dt As New DataTable("issue_device_table")
        ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
        Dim rs As New MySqlDataAdapter("select `device_id`,  `username`, `mobile_no`, `issue_status`,`date`, `time` from  issue_device_table where company_id='" & cu_cid & "'", mycon)
        rs.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        rs.Dispose()
        mycon.Close()

        DataGridView1.Columns("device_id").HeaderText = "Device Id"
        DataGridView1.Columns("username").HeaderText = "Username"
        DataGridView1.Columns("mobile_no").HeaderText = "Mobile No"
        DataGridView1.Columns("issue_status").HeaderText = "Return Status"
        DataGridView1.Columns("date").HeaderText = "Date"
        DataGridView1.Columns("time").HeaderText = "Time"


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        txtRdeviceid.Text = ""
        txtRissue_status.Text = "Select Return Status"
        txtRmobile.Text = ""
        txtRusername.Text = ""
        txtRdeviceid.Focus()


    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.BackColor = Color.Red

    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.BackColor = Color.Transparent
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        'issue_status='1'
        mycon.Close()

        Try
            mycon.Open()

            Dim dt As New DataTable("issue_device_table")
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            'Dim rs As New MySqlDataAdapter("Select `device_id`, `username`,  `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
            Dim rs As New MySqlDataAdapter("select `device_id`,  `username`, `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where  device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        mycon.Close()
    End Sub

    Private Sub returnDevice_Load(sender As Object, e As EventArgs) Handles Me.Load
        Display_issue_device_List()

        datagrid()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            txtRdeviceid.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtRusername.Text = DataGridView1.Item(1, e.RowIndex).Value
            txtRmobile.Text = DataGridView1.Item(2, e.RowIndex).Value
            'txtRissue_status.Text = DataGridView1.Item(4, e.RowIndex).Value
            'txtpri.Text = DataGridView1.Item(5, e.RowIndex).Value
            'txtqty.Text = DataGridView1.Item(6, e.RowIndex).Value
            'txtunit.Text = DataGridView1.Item(7, e.RowIndex).Value
            'txtgst.Text = DataGridView1.Item(8, e.RowIndex).Value
            'txtfinalamt.Text = DataGridView1.Item(9, e.RowIndex).Value
            'txtdesc.Text = DataGridView1.Item(11, e.RowIndex).Value



        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuFlatButton34_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton34.Click
        Try
            ' deactive means  return device and active means issue device 
            If txtRissue_status.Text = "Active" Then

                R_status = "1"

            ElseIf txtRissue_status.Text = "Deactive"

                R_status = "0"



            End If


            If txtRdeviceid.Text <> "" And R_status <> "" And R_status = "0" Then
                Dim com As MySqlCommand = New MySqlCommand("update issue_device_table set  issue_status=@1  where device_id=" & Trim(txtRdeviceid.Text) & " and company_id='" & cu_cid & "'", mycon)


                com.Parameters.AddWithValue("@1", R_status)

                mycon.Open()
                com.ExecuteNonQuery()

                mycon.Close()


                MsgBox("Device Is Returned", MsgBoxStyle.Information + MsgBoxStyle.OkCancel)
                Display_issue_device_List()

            Else
                If txtRissue_status.Text = "Active" And R_status = "1" Then

                    MsgBox("Device Already Issued", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)


                Else
                    MsgBox("Please Select Device ID for return device", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)


                End If


            End If

        Catch ex As Exception


        End Try


    End Sub

    Public Sub datagrid()
        'catagory
        'Dim columnwidth1 As DataGridViewColumn = DataGridView1.Columns(1)
        'columnwidth1.Width = 500

        'Return device form

        DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 10)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)


        Dim columnwidth1 As DataGridViewColumn = DataGridView1.Columns(0)
        columnwidth1.Width = 100


        Dim columnwidth2 As DataGridViewColumn = DataGridView1.Columns(1)
        columnwidth2.Width = 200

        Dim columnwidth3 As DataGridViewColumn = DataGridView1.Columns(2)
        columnwidth3.Width = 120


        Dim columnwidth4 As DataGridViewColumn = DataGridView1.Columns(3)
        columnwidth4.Width = 120

        Dim columnwidth5 As DataGridViewColumn = DataGridView1.Columns(4)
        columnwidth5.Width = 100


        Dim columnwidth6 As DataGridViewColumn = DataGridView1.Columns(4)
        columnwidth6.Width = 100




    End Sub

    Private Sub txtsearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtsearch.OnValueChanged

    End Sub

    Private Sub txtsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyUp
        If txtsearch.Text.ToString = "" Then

            Display_issue_device_List()

        End If


    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Try
                mycon.Open()

                Dim dt As New DataTable("issue_device_table")
                'Dim rs As New MySqlDataAdapter("Select `device_id`, `username`,  `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
                Dim rs As New MySqlDataAdapter("select `device_id`,  `username`, `mobile_no`, `issue_status`, `date`, `time` From issue_device_table Where  device_id=" & Trim(txtsearch.Text) & " and company_id='" & cu_cid & "'", mycon)
                rs.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
                rs.Dispose()


            Catch ex As Exception


                MessageBox.Show(ex.Message)

            End Try

            mycon.Close()


            e.Handled = True
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        txtRdeviceid.Text = ""
        txtRissue_status.Text = ""

        txtRusername.Text = ""
        txtRmobile.Text = ""


        txtRdeviceid.Focus()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

 
Device Search Code
Imports MySql.Data.MySqlClient
Public Class searchDevice
    Private Sub searchDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_device_List()

        'datagrid_setting()

    End Sub

    '
    Public Sub Display_device_List()

        mycon.Open()

        Dim dt As New DataTable("device_table")
        ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
        Dim rs As New MySqlDataAdapter("select  `device_id`, `company_id`, `device_ distance`, `device_battery`, `device_signal`, `device_status`, `date`, `time` From device_table where c_id='" & cu_cid & "'", mycon)

        rs.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        rs.Dispose()
        mycon.Close()



        'DataGridView1.Columns("id").DisplayIndex = 0

        DataGridView1.Columns("device_id").HeaderText = "Device Id"
        DataGridView1.Columns("company_id").HeaderText = "Company Id"
        DataGridView1.Columns("device_ distance").HeaderText = "Device Distance"
        DataGridView1.Columns("device_battery").HeaderText = "Device Battery"
        DataGridView1.Columns("device_signal").HeaderText = "Device Signal"
        DataGridView1.Columns("device_status").HeaderText = "Device Status"
        DataGridView1.Columns("date").HeaderText = "Date"
        DataGridView1.Columns("time").HeaderText = "Time"




    End Sub

    Private Sub BunifuFlatButton20_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton20.Click
        mycon.Open()
        Try


            Dim dt As New DataTable("device_table")
            ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
            Dim rs As New MySqlDataAdapter("Select `device_id`, `company_id`, `device_ distance`, `device_battery`, `device_signal`, `device_status`, `date`, `time` From device_table Where device_id like '%" & Trim(txtsearch.Text) & "%' and c_id='" & cu_cid & "'", mycon)

            rs.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            rs.Dispose()


        Catch ex As Exception


            MessageBox.Show(ex.Message)

        End Try

        mycon.Close()

    End Sub

    ' datagrid view header text setting

    Dim table As New DataTable()

    Public Sub datagrid_setting()
        Try
            DataGridView1.DataSource = ds.Tables("device_table")
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "DeviceId"
                .Columns(1).HeaderText = "CompanyId"
                .Columns(2).HeaderText = "DeviceDistance"
                .Columns(3).HeaderText = "DeviceBattery"
                .Columns(4).HeaderText = "DeviceSignal"
                .Columns(5).HeaderText = "DeviceStatus"
                .Columns(6).HeaderText = "Date"
                .Columns(7).HeaderText = "Time"
                .Refresh()

            End With
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        'DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)



        'table.Columns.Add("device Id", Type.GetType("System.String"))

        ''table.Columns.Add()
        Display_device_List()
        DataGridView1.DataSource = table


    End Sub

    Private Sub txtsearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtsearch.OnValueChanged

    End Sub

    Private Sub txtsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyUp
        If txtsearch.Text = "" Then

            Display_device_List()


        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            mycon.Open()

            Try

                Dim dt As New DataTable("device_table")
                ' Dim rs As New MySqlDataAdapter("select Officer_Id,First_Name,Middle_Name,Last_Name,Gender,Birth_Date,Address1,Address2,City,State,Area,Email,Mobile ,Designation,Aadhar_No,Date1 from tblofficerregistration ", mycon)
                Dim rs As New MySqlDataAdapter("Select `device_id`, `company_id`, `device_ distance`, `device_battery`, `device_signal`, `device_status`, `date`, `time` From device_table Where device_id like '%" & Trim(txtsearch.Text) & "%' and c_id='" & cu_cid & "'", mycon)

                rs.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
                rs.Dispose()


            Catch ex As Exception


                MessageBox.Show(ex.Message)

            End Try

            mycon.Close()


        End If
    End Sub
End Class
 
Total user and device monitoring code Device
Imports MySql.Data.MySqlClient

Module cardclass

    Public total_device As String
    Public total_user As String
    Public issue_device As String
    Public return_device As String


    ' total device count function

    Public Sub get_total_device()
        Dim reader As MySqlDataReader

        mycon.Open()
        Try

            Dim query As String
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            query = "select count(device_id) as total_dev from device_table where c_id='" & Trim(cu_cid) & "'"
            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                total_device = reader.GetString("total_dev")

            End While
            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try
        mycon.Close()

    End Sub



    ' total user funcion

    Public Sub get_total_users()
        Dim reader As MySqlDataReader
        mycon.Open()

        Try
            Dim query As String
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            query = "select count(uid) as user from user_register_table where cid='" & Trim(cu_cid) & "'"
            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read

                total_user = reader.GetString("user")

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            mycon.Dispose()
        End Try
        mycon.Close()

    End Sub



    Public Sub get_total_issue_device()
        Dim reader As MySqlDataReader
        mycon.Open()
        Try

            Dim query As String
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            query = "select count(device_id) as issued from issue_device_table where company_id='" & Trim(cu_cid) & "'and issue_status='1'"
            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read

                issue_device = reader.GetString("issued")

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            mycon.Dispose()
        End Try

        mycon.Close()

    End Sub



    Public Sub get_total_return_device()
        Dim reader As MySqlDataReader
        mycon.Open()

        Try
            Dim query As String

            query = "select count(device_id) as returned from issue_device_table where company_id='" & Trim(cu_cid) & "'and issue_status='0'"
            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read

                return_device = reader.GetString("returned")

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            mycon.Dispose()
        End Try
        mycon.Close()

    End Sub
End Module

 
QR Code Image Generate Code
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class generateQR
    Dim did1 As Integer

    Public Sub list__Device_id()

        ComboBox1.Items.Clear()

        Dim reader As MySqlDataReader
        Try
            mycon.Open()
            Dim query As String
            query = "select * from device_table where c_id='" & cu_cid & "'"

            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim did = reader.GetString("device_id")
                'cid = reader.GetString("cid")
                Dim r As String

                ComboBox1.Items.Add((did))

            End While
            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try


    End Sub


    Private Sub generateQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list__Device_id()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ComboBox1.Text = ""

        list__Device_id()

        lblcompid.Text = "--"
        lbldeivcestatus.Text = "--"
        lbldistance.Text = "--"


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If ComboBox1.Text <> "" Then
            QrCodeImgControl1.Text = ComboBox1.Text

        Else

            MsgBox("Please Select Device Id", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical)


        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


        'did = ComboBox1.Text
        did1 = CInt(TextBox1.Text)


        Dim img As Image = DirectCast(QrCodeImgControl1.Image.Clone, Image)
        Dim sfile As New SaveFileDialog
        sfile.Filter = "Image Files(*.jpg)|*.jpg| All Files(*.*)|*.*"
        sfile.InitialDirectory = "C:\HMI App"
        sfile.FileName = "Device Id " & did1
        Dim ipath As String
        ipath = sfile.FileName
        Dim fpath As String
        Dim fna As String

        fna = "C:\HMI App\" & did1 & ".jpg"

        fpath = "C:\HMI App"

        If File.Exists(fna) Then
            MsgBox("Batch No: " & did1 & " QR code Alread Exist")

        Else
            If sfile.ShowDialog = DialogResult.OK Then

                If Directory.Exists(fpath) Then

                    img = QrCodeImgControl1.Image

                    img.Save(sfile.FileName, Imaging.ImageFormat.Jpeg)


                End If

            Else


            End If

        End If




















        'Dim r As String
        'Dim sfd As New SaveFileDialog
        'Dim OPF As New OpenFileDialog
        'Dim fname As String
        'Dim na As String
        'na = ComboBox1.Text.ToString
        'Dim folder As String = "E:\files"
        'fname = na & ".jpg"
        ''sfd.InitialDirectory = "E:\files"
        'sfd.FileName = ComboBox1.Text

        'Try

        '    r = MsgBox("Do you want to save QR code", MsgBoxStyle.YesNo + MsgBoxStyle.Question)


        '    If r = MsgBoxResult.Yes Then
        '        Dim img As Image
        '        sfd.Filter = "Image Files(*.jpg)|*.jpg| All Files(*.*)|*.*"
        '        'opens a save dialog box for saving the settings

        '        If sfd.ShowDialog = DialogResult.OK Then
        '            img = QrCodeImgControl1.Image
        '            img.Save(sfd.FileName, Imaging.ImageFormat.Jpeg)
        '        End If

        '        MsgBox("Qr Code has been saved", MsgBoxStyle.Information + MsgBoxStyle.OkCancel)

        '    Else

        '        MsgBox("Qr Code not saved", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)

        '    End If




        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim id As String = ""
        TextBox1.Text = ComboBox1.Text


        id = ComboBox1.Text


        Dim reader As MySqlDataReader
        Try
            mycon.Open()
            Dim query As String
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            'query = "select * from user_register_table where first_name='" & txtiusername.Text & "'"
            query = "select * from device_table where device_id=" & id & " and c_id='" & Trim(cu_cid) & "'"
            cmd = New MySqlCommand(query, mycon)
            reader = cmd.ExecuteReader
            While reader.Read

                Dim cid = reader.GetString("company_id")
                Dim dist = reader.GetString("device_ distance")
                Dim dstt = reader.GetString("device_status")



                lblcompid.Text = cid
                lbldistance.Text = dist & " M"

                If dstt = "1" Then

                    lbldeivcestatus.Text = "Active"

                ElseIf dstt = "0" Then

                    lbldeivcestatus.Text = "Deactive"


                End If





            End While
            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally
            mycon.Dispose()

        End Try


    End Sub
End Class













