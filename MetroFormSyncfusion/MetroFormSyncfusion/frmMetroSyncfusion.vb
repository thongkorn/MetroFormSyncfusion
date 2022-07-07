#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / email : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' / 
' / Purpose: Metro Form with Syncfusion Community.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Public Class frmMetroSyncfusion

    Private Sub frmMetroSyncfusion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.BorderThickness = 5
        Me.CaptionBarColor = Color.SeaGreen
        Me.BorderColor = Color.SeaGreen
        Me.CaptionBarHeight = 40
        Me.ShowIcon = False '/ Form not show icon.
        Me.DropShadow = True
        Me.CaptionButtonHoverColor = System.Drawing.Color.Red
        '//
        Dim CaptionLabel1 As Syncfusion.Windows.Forms.CaptionLabel = New Syncfusion.Windows.Forms.CaptionLabel
        With CaptionLabel1
            CaptionLabel1.Font = New System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            .Text = "Metro Form Syncfusion Community"
            .ForeColor = System.Drawing.Color.White
            .Name = "CaptionLabel1"
            .Size = New System.Drawing.Size(400, 34)
            .Location = New Point(33, 5)
        End With
        '/ Add CaptionLabel with code.
        Me.CaptionLabels.Add(CaptionLabel1)
    End Sub
End Class
