﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrentMovie))
        Me.MoPic = New System.Windows.Forms.PictureBox()
        Me.MovieName = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.MovieDate = New System.Windows.Forms.Label()
        Me.Rate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.actors = New System.Windows.Forms.Label()
        Me.MovieGenre = New System.Windows.Forms.Label()
        Me.Urating = New System.Windows.Forms.TrackBar()
        Me.uR = New System.Windows.Forms.Label()
        Me.rateInfo = New System.Windows.Forms.Label()
        Me.CloseCuMovie = New System.Windows.Forms.PictureBox()
        Me.RatebtnPanel = New System.Windows.Forms.Panel()
        Me.RateBtn = New System.Windows.Forms.Label()
        Me.AddRemPanel = New System.Windows.Forms.Panel()
        Me.AddRem = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.MoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Urating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseCuMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RatebtnPanel.SuspendLayout()
        Me.AddRemPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MoPic
        '
        Me.MoPic.BackColor = System.Drawing.Color.Transparent
        Me.MoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MoPic.Image = Global.IMDB.My.Resources.Resources._200
        Me.MoPic.Location = New System.Drawing.Point(25, 25)
        Me.MoPic.Name = "MoPic"
        Me.MoPic.Size = New System.Drawing.Size(208, 306)
        Me.MoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MoPic.TabIndex = 0
        Me.MoPic.TabStop = False
        '
        'MovieName
        '
        Me.MovieName.BackColor = System.Drawing.Color.Transparent
        Me.MovieName.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MovieName.Location = New System.Drawing.Point(265, 25)
        Me.MovieName.Name = "MovieName"
        Me.MovieName.Size = New System.Drawing.Size(300, 40)
        Me.MovieName.TabIndex = 1
        Me.MovieName.Text = "Name"
        Me.MovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Transparent
        Me.Description.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Description.Location = New System.Drawing.Point(25, 397)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(540, 281)
        Me.Description.TabIndex = 2
        Me.Description.Text = "Description"
        '
        'MovieDate
        '
        Me.MovieDate.BackColor = System.Drawing.Color.Transparent
        Me.MovieDate.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MovieDate.Location = New System.Drawing.Point(417, 122)
        Me.MovieDate.Name = "MovieDate"
        Me.MovieDate.Size = New System.Drawing.Size(148, 23)
        Me.MovieDate.TabIndex = 5
        Me.MovieDate.Text = "date"
        Me.MovieDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Rate
        '
        Me.Rate.BackColor = System.Drawing.Color.Transparent
        Me.Rate.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rate.Location = New System.Drawing.Point(261, 75)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(304, 24)
        Me.Rate.TabIndex = 6
        Me.Rate.Text = "rate"
        Me.Rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(265, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Released Date :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(590, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(265, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Actors :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'actors
        '
        Me.actors.BackColor = System.Drawing.Color.Transparent
        Me.actors.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.actors.Location = New System.Drawing.Point(417, 174)
        Me.actors.Name = "actors"
        Me.actors.Size = New System.Drawing.Size(148, 44)
        Me.actors.TabIndex = 10
        '
        'MovieGenre
        '
        Me.MovieGenre.BackColor = System.Drawing.Color.Transparent
        Me.MovieGenre.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.MovieGenre.Location = New System.Drawing.Point(25, 334)
        Me.MovieGenre.Name = "MovieGenre"
        Me.MovieGenre.Size = New System.Drawing.Size(208, 29)
        Me.MovieGenre.TabIndex = 13
        '
        'Urating
        '
        Me.Urating.BackColor = System.Drawing.SystemColors.Control
        Me.Urating.LargeChange = 1
        Me.Urating.Location = New System.Drawing.Point(311, 260)
        Me.Urating.Name = "Urating"
        Me.Urating.Size = New System.Drawing.Size(131, 45)
        Me.Urating.TabIndex = 14
        Me.Urating.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.Urating.Visible = False
        '
        'uR
        '
        Me.uR.BackColor = System.Drawing.Color.Transparent
        Me.uR.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.uR.Location = New System.Drawing.Point(446, 260)
        Me.uR.Name = "uR"
        Me.uR.Size = New System.Drawing.Size(59, 45)
        Me.uR.TabIndex = 15
        Me.uR.Text = "uR"
        Me.uR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.uR.Visible = False
        '
        'rateInfo
        '
        Me.rateInfo.BackColor = System.Drawing.Color.Transparent
        Me.rateInfo.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rateInfo.Location = New System.Drawing.Point(261, 237)
        Me.rateInfo.Name = "rateInfo"
        Me.rateInfo.Size = New System.Drawing.Size(304, 20)
        Me.rateInfo.TabIndex = 17
        Me.rateInfo.Text = "rateInfo"
        Me.rateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rateInfo.Visible = False
        '
        'CloseCuMovie
        '
        Me.CloseCuMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseCuMovie.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.CloseCuMovie.Location = New System.Drawing.Point(561, 3)
        Me.CloseCuMovie.Name = "CloseCuMovie"
        Me.CloseCuMovie.Size = New System.Drawing.Size(24, 24)
        Me.CloseCuMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseCuMovie.TabIndex = 18
        Me.CloseCuMovie.TabStop = False
        '
        'RatebtnPanel
        '
        Me.RatebtnPanel.BackColor = System.Drawing.Color.Transparent
        Me.RatebtnPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.RatebtnPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RatebtnPanel.Controls.Add(Me.RateBtn)
        Me.RatebtnPanel.Location = New System.Drawing.Point(351, 269)
        Me.RatebtnPanel.Name = "RatebtnPanel"
        Me.RatebtnPanel.Size = New System.Drawing.Size(125, 23)
        Me.RatebtnPanel.TabIndex = 19
        '
        'RateBtn
        '
        Me.RateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RateBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RateBtn.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RateBtn.ForeColor = System.Drawing.Color.White
        Me.RateBtn.Location = New System.Drawing.Point(0, 0)
        Me.RateBtn.Name = "RateBtn"
        Me.RateBtn.Size = New System.Drawing.Size(125, 23)
        Me.RateBtn.TabIndex = 0
        Me.RateBtn.Text = "Rate this movie"
        Me.RateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddRemPanel
        '
        Me.AddRemPanel.BackColor = System.Drawing.Color.Transparent
        Me.AddRemPanel.BackgroundImage = CType(resources.GetObject("AddRemPanel.BackgroundImage"), System.Drawing.Image)
        Me.AddRemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddRemPanel.Controls.Add(Me.AddRem)
        Me.AddRemPanel.Location = New System.Drawing.Point(265, 313)
        Me.AddRemPanel.Name = "AddRemPanel"
        Me.AddRemPanel.Size = New System.Drawing.Size(300, 23)
        Me.AddRemPanel.TabIndex = 20
        '
        'AddRem
        '
        Me.AddRem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddRem.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddRem.ForeColor = System.Drawing.Color.White
        Me.AddRem.Location = New System.Drawing.Point(0, 0)
        Me.AddRem.Name = "AddRem"
        Me.AddRem.Size = New System.Drawing.Size(300, 23)
        Me.AddRem.TabIndex = 0
        Me.AddRem.Text = "Add/Rem"
        Me.AddRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.RatebtnPanel)
        Me.Panel1.Controls.Add(Me.uR)
        Me.Panel1.Controls.Add(Me.Urating)
        Me.Panel1.Controls.Add(Me.AddRemPanel)
        Me.Panel1.Controls.Add(Me.rateInfo)
        Me.Panel1.Controls.Add(Me.CloseCuMovie)
        Me.Panel1.Controls.Add(Me.MoPic)
        Me.Panel1.Controls.Add(Me.MovieGenre)
        Me.Panel1.Controls.Add(Me.MovieName)
        Me.Panel1.Controls.Add(Me.Rate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MovieDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.actors)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Description)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 688)
        Me.Panel1.TabIndex = 21
        '
        'CurrentMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 698)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CurrentMovie"
        Me.Text = "CurrentMovie"
        CType(Me.MoPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Urating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseCuMovie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RatebtnPanel.ResumeLayout(False)
        Me.AddRemPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MoPic As PictureBox
    Friend WithEvents MovieName As Label
    Friend WithEvents Description As Label
    Friend WithEvents MovieDate As Label
    Friend WithEvents Rate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents actors As Label
    Friend WithEvents MovieGenre As Label
    Friend WithEvents Urating As TrackBar
    Friend WithEvents uR As Label
    Friend WithEvents rateInfo As Label
    Friend WithEvents CloseCuMovie As PictureBox
    Friend WithEvents RatebtnPanel As Panel
    Friend WithEvents RateBtn As Label
    Friend WithEvents AddRemPanel As Panel
    Friend WithEvents AddRem As Label
    Friend WithEvents Panel1 As Panel
End Class
