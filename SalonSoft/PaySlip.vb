Public Class PaySlip 

    Private Sub PaySlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Text = Date.Now.ToString
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim salary As Integer = LabelControl7.Text
        LabelControl7.Text = TextEdit5.Text - TextEdit2.Text

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Y As Integer = 5
        Dim S As String
        Dim z As String
        Dim MyFont As Font = New Font("Tahoma", 10, FontStyle.Bold)

        e.Graphics.DrawImage(Salon_Settings.PictureEdit1.Image, 40, Y)
        Y = 120
        Y += CInt(MyFont.GetHeight)
        Y += CInt(MyFont.GetHeight)
        Y += CInt(MyFont.GetHeight)
        Y += CInt(MyFont.GetHeight)
        Y += CInt(MyFont.GetHeight)
        Y += CInt(MyFont.GetHeight)

        'Print Heading
        e.Graphics.DrawString(vbNewLine + Salon_Settings.SalonNameTextEdit.Text + vbNewLine + "Phone: " + Salon_Settings.PhoneNumberTextEdit.Text + vbNewLine + "Building: " + Salon_Settings.BuildingTextEdit.Text + vbNewLine + "Slogan: " + Salon_Settings.SloganTextEdit.Text + vbNewLine + Now.ToString, MyFont, Brushes.Black, 10, Y)
        Y += CInt(MyFont.GetHeight)

        Y += 2 * CInt(MyFont.GetHeight)
        MyFont = New Font("Tahoma", 10, FontStyle.Regular)
        Y += 2 * CInt(MyFont.GetHeight)
        e.Graphics.DrawString(vbNewLine + vbNewLine + "---------------------------------------------------------------- ", MyFont, Brushes.Black, 2, Y)
        Y += CInt(MyFont.GetHeight)
        e.Graphics.DrawString(vbNewLine + vbNewLine + "                      PAYSLIP            ", MyFont, Brushes.Black, 2, Y)
        Y += CInt(MyFont.GetHeight)

        e.Graphics.DrawString(vbNewLine + vbNewLine + "---------------------------------------------------------------- ", MyFont, Brushes.Black, 2, Y)
        S = Space(100)
        z = Space(180)
        Mid(S, 1) = vbNewLine + vbNewLine + vbNewLine + "DATE AND TIME : "
        Mid(z, 35 - Len(TextEdit1.Text + " ") - 1, Len(TextEdit1.Text + " ") + 1) = TextEdit1.Text + " "
        e.Graphics.DrawString(S, MyFont, Brushes.Black, 2, Y)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + z, MyFont, Brushes.Black, 100, Y)

        Y += CInt(MyFont.GetHeight)

        S = Space(100)
        z = Space(180)
        Mid(S, 1) = vbNewLine + vbNewLine + vbNewLine + "EMPLOYEE NAME : "
        Mid(z, 35 - Len(TextEdit4.Text + " ") - 1, Len(TextEdit4.Text + " ") + 1) = TextEdit4.Text + " "
        e.Graphics.DrawString(S, MyFont, Brushes.Black, 2, Y)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + z, MyFont, Brushes.Black, 100, Y)



        Y += CInt(MyFont.GetHeight)

        S = Space(100)
        z = Space(180)
        Mid(S, 1) = vbNewLine + vbNewLine + vbNewLine + "ADVANCE : "
        Mid(z, 35 - Len(TextEdit2.Text + " ") - 1, Len(TextEdit2.Text + " ") + 1) = TextEdit2.Text + " "
        e.Graphics.DrawString(S, MyFont, Brushes.Black, 2, Y)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + z, MyFont, Brushes.Black, 100, Y)


        Y += CInt(MyFont.GetHeight)

        S = Space(100)
        z = Space(180)
        Mid(S, 1) = vbNewLine + vbNewLine + vbNewLine + "TOTAL COMISSION : "
        Mid(z, 35 - Len(TextEdit5.Text + " ") - 1, Len(TextEdit5.Text + " ") + 1) = TextEdit5.Text + " "
        e.Graphics.DrawString(S, MyFont, Brushes.Black, 2, Y)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + z, MyFont, Brushes.Black, 100, Y)


        Y += CInt(MyFont.GetHeight)

        S = Space(100)
        z = Space(180)
        Mid(S, 1) = vbNewLine + vbNewLine + vbNewLine + "SALARY : "
        Mid(z, 35 - Len(LabelControl7.Text + " ") - 1, Len(LabelControl7.Text + " ") + 1) = LabelControl7.Text + " "
        e.Graphics.DrawString(S, MyFont, Brushes.Black, 2, Y)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + z, MyFont, Brushes.Black, 100, Y)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + vbNewLine + "---------------------------------------------------------------- ", MyFont, Brushes.Black, 2, Y)

        MyFont = New Font("Tahoma", 10, FontStyle.Regular)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "Processed by: ", MyFont, Brushes.Black, 2, Y)
        e.Graphics.DrawString(vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "Developed By Nimo Mohammed Issa" + vbNewLine + "www.salonsoft.com", MyFont, Brushes.Black, 2, Y)
        e.HasMorePages = False
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        PrintDialog1.ShowDialog()
        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        PrintDocument1.Print()
        Me.Close()
    End Sub
End Class