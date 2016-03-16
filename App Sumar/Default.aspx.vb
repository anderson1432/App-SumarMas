
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim MathServiceClass As New WebService()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim x, y, z As Integer

        x = Integer.Parse(TextBox1.Text)
        y = Integer.Parse(TextBox2.Text)

        z = MathServiceClass.WebAdd(x, y)
        Label1.Text = z.ToString
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim x, y, z As Integer

        x = Integer.Parse(TextBox1.Text)
        y = Integer.Parse(TextBox2.Text)

        z = MathServiceClass.WebMultiply(x, y)
        Label1.Text = z.ToString
    End Sub





End Class
