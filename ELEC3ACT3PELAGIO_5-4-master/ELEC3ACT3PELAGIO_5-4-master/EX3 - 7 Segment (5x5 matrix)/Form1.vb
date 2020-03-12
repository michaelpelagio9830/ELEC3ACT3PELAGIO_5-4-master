Public Class Form1
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        If Btn.Text = "S T A R T" Then
            Timer.Start()
            Btn.Text = "S T O P"
            Btn.BackColor = Color.Black
        Else
            Timer.Stop()
            Btn.Text = "S T A R T"
            Btn.BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        num.Text += 1

        If num.Text = 1 Then
            AA.BackColor = Color.Gray
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.Gray
            AE.BackColor = Color.Gray

            BA.BackColor = Color.Gray
            BB.BackColor = Color.Gray
            BC.BackColor = Color.FromArgb(255, 255, 26)
            BD.BackColor = Color.Gray
            BE.BackColor = Color.Gray

            CA.BackColor = Color.Gray
            CB.BackColor = Color.Gray
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.Gray
            CE.BackColor = Color.Gray

            DA.BackColor = Color.Gray
            DB.BackColor = Color.Gray
            DC.BackColor = Color.FromArgb(255, 255, 26)
            DD.BackColor = Color.Gray
            DE.BackColor = Color.Gray

            EA.BackColor = Color.Gray
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.Gray

        ElseIf num.Text = 2 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.Gray
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.FromArgb(255, 255, 26)

            CA.BackColor = Color.FromArgb(255, 255, 26)
            CB.BackColor = Color.FromArgb(255, 255, 26)
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.FromArgb(255, 255, 26)
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.FromArgb(255, 255, 26)
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.Gray

            EA.BackColor = Color.FromArgb(255, 255, 26)
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.FromArgb(255, 255, 26)

        ElseIf num.Text = 3 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.Gray
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.FromArgb(255, 255, 26)

            CA.BackColor = Color.Gray
            CB.BackColor = Color.FromArgb(255, 255, 26)
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.FromArgb(255, 255, 26)
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.Gray
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.FromArgb(255, 255, 26)

            EA.BackColor = Color.FromArgb(255, 255, 26)
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.FromArgb(255, 255, 26)

        ElseIf num.Text = 4 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.Gray
            AC.BackColor = Color.Gray
            AD.BackColor = Color.Gray
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.FromArgb(255, 255, 26)
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.FromArgb(255, 255, 26)

            CA.BackColor = Color.FromArgb(255, 255, 26)
            CB.BackColor = Color.FromArgb(255, 255, 26)
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.FromArgb(255, 255, 26)
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.Gray
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.FromArgb(255, 255, 26)

            EA.BackColor = Color.Gray
            EB.BackColor = Color.Gray
            EC.BackColor = Color.Gray
            ED.BackColor = Color.Gray
            EE.BackColor = Color.FromArgb(255, 255, 26)

        ElseIf num.Text = 5 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.FromArgb(255, 255, 26)
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.Gray

            CA.BackColor = Color.FromArgb(255, 255, 26)
            CB.BackColor = Color.FromArgb(255, 255, 26)
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.FromArgb(255, 255, 26)
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.Gray
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.FromArgb(255, 255, 26)

            EA.BackColor = Color.FromArgb(255, 255, 26)
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.FromArgb(255, 255, 26)

        ElseIf num.Text = 6 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.FromArgb(255, 255, 26)
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.Gray

            CA.BackColor = Color.FromArgb(255, 255, 26)
            CB.BackColor = Color.FromArgb(255, 255, 26)
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.FromArgb(255, 255, 26)
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.FromArgb(255, 255, 26)
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.FromArgb(255, 255, 26)

            EA.BackColor = Color.FromArgb(255, 255, 26)
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.FromArgb(255, 255, 26)

        ElseIf num.Text = 7 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.Gray
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.FromArgb(255, 255, 26)
            BE.BackColor = Color.Gray

            CA.BackColor = Color.Gray
            CB.BackColor = Color.Gray
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.Gray
            CE.BackColor = Color.Gray

            DA.BackColor = Color.Gray
            DB.BackColor = Color.Gray
            DC.BackColor = Color.FromArgb(255, 255, 26)
            DD.BackColor = Color.Gray
            DE.BackColor = Color.Gray

            EA.BackColor = Color.Gray
            EB.BackColor = Color.Gray
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.Gray
            EE.BackColor = Color.Gray

        ElseIf num.Text = 8 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.FromArgb(255, 255, 26)
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.FromArgb(255, 255, 26)

            CA.BackColor = Color.FromArgb(255, 255, 26)
            CB.BackColor = Color.FromArgb(255, 255, 26)
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.FromArgb(255, 255, 26)
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.FromArgb(255, 255, 26)
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.FromArgb(255, 255, 26)

            EA.BackColor = Color.FromArgb(255, 255, 26)
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.FromArgb(255, 255, 26)

        ElseIf num.Text = 9 Then
            AA.BackColor = Color.FromArgb(255, 255, 26)
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.FromArgb(255, 255, 26)

            BA.BackColor = Color.FromArgb(255, 255, 26)
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.FromArgb(255, 255, 26)

            CA.BackColor = Color.FromArgb(255, 255, 26)
            CB.BackColor = Color.FromArgb(255, 255, 26)
            CC.BackColor = Color.FromArgb(255, 255, 26)
            CD.BackColor = Color.FromArgb(255, 255, 26)
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.Gray
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.FromArgb(255, 255, 26)

            EA.BackColor = Color.FromArgb(255, 255, 26)
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.FromArgb(255, 255, 26)

        Else
            num.Text = 0

            AA.BackColor = Color.Gray
            AB.BackColor = Color.FromArgb(255, 255, 26)
            AC.BackColor = Color.FromArgb(255, 255, 26)
            AD.BackColor = Color.FromArgb(255, 255, 26)
            AE.BackColor = Color.Gray

            BA.BackColor = Color.FromArgb(255, 255, 26)
            BB.BackColor = Color.Gray
            BC.BackColor = Color.Gray
            BD.BackColor = Color.Gray
            BE.BackColor = Color.FromArgb(255, 255, 26)

            CA.BackColor = Color.FromArgb(255, 255, 26)
            CB.BackColor = Color.Gray
            CC.BackColor = Color.Gray
            CD.BackColor = Color.Gray
            CE.BackColor = Color.FromArgb(255, 255, 26)

            DA.BackColor = Color.FromArgb(255, 255, 26)
            DB.BackColor = Color.Gray
            DC.BackColor = Color.Gray
            DD.BackColor = Color.Gray
            DE.BackColor = Color.FromArgb(255, 255, 26)

            EA.BackColor = Color.Gray
            EB.BackColor = Color.FromArgb(255, 255, 26)
            EC.BackColor = Color.FromArgb(255, 255, 26)
            ED.BackColor = Color.FromArgb(255, 255, 26)
            EE.BackColor = Color.Gray

            Timer.Stop()
            Btn.Text = "S T A R T"
            Btn.BackColor = Color.Red
        End If
    End Sub
End Class
