﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrMetadataElementNew
    Inherits ClimsoftVer4.ucrPage

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrElementSelectorSearch = New ClimsoftVer4.ucrComboboxNew()
        Me.lblSearchElement = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ucrDataLinkElementID = New ClimsoftVer4.ucrComboboxNew()
        Me.lblAbbreviation = New System.Windows.Forms.Label()
        Me.ucrTextboxAbbreviation = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ucrTextboxName = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextboxDescription = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.ucrTextBoxScale = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblScale = New System.Windows.Forms.Label()
        Me.ucrTextBoxUpperLimit = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblUpperlimit = New System.Windows.Forms.Label()
        Me.ucrTextBoxLowerLimit = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.ucrTextBoxUnit = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.ucrDataLinkType = New ClimsoftVer4.ucrComboboxNew()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrCheckBoxSelected = New ClimsoftVer4.ucrCheckboxNew()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.ucrCheckBoxTotalRequired = New ClimsoftVer4.ucrCheckboxNew()
        Me.lblTotalRequired = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.ucrNavigatorElement = New ClimsoftVer4.ucrNavigator()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrElementSelectorSearch
        '
        Me.ucrElementSelectorSearch.Location = New System.Drawing.Point(632, 50)
        Me.ucrElementSelectorSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrElementSelectorSearch.Name = "ucrElementSelectorSearch"
        Me.ucrElementSelectorSearch.Size = New System.Drawing.Size(237, 26)
        Me.ucrElementSelectorSearch.TabIndex = 0
        '
        'lblSearchElement
        '
        Me.lblSearchElement.AutoSize = True
        Me.lblSearchElement.Location = New System.Drawing.Point(514, 54)
        Me.lblSearchElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchElement.Name = "lblSearchElement"
        Me.lblSearchElement.Size = New System.Drawing.Size(108, 17)
        Me.lblSearchElement.TabIndex = 25
        Me.lblSearchElement.Text = "Search Element"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(268, 126)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 17)
        Me.lblID.TabIndex = 26
        Me.lblID.Text = "ID"
        '
        'ucrDataLinkElementID
        '
        Me.ucrDataLinkElementID.Location = New System.Drawing.Point(397, 124)
        Me.ucrDataLinkElementID.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrDataLinkElementID.Name = "ucrDataLinkElementID"
        Me.ucrDataLinkElementID.Size = New System.Drawing.Size(237, 26)
        Me.ucrDataLinkElementID.TabIndex = 27
        '
        'lblAbbreviation
        '
        Me.lblAbbreviation.AutoSize = True
        Me.lblAbbreviation.Location = New System.Drawing.Point(268, 162)
        Me.lblAbbreviation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbbreviation.Name = "lblAbbreviation"
        Me.lblAbbreviation.Size = New System.Drawing.Size(87, 17)
        Me.lblAbbreviation.TabIndex = 28
        Me.lblAbbreviation.Text = "Abbreviation"
        '
        'ucrTextboxAbbreviation
        '
        Me.ucrTextboxAbbreviation.Location = New System.Drawing.Point(397, 158)
        Me.ucrTextboxAbbreviation.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTextboxAbbreviation.Name = "ucrTextboxAbbreviation"
        Me.ucrTextboxAbbreviation.Size = New System.Drawing.Size(237, 25)
        Me.ucrTextboxAbbreviation.TabIndex = 29
        Me.ucrTextboxAbbreviation.TextboxValue = ""
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(268, 194)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 30
        Me.lblName.Text = "Name"
        '
        'ucrTextboxName
        '
        Me.ucrTextboxName.Location = New System.Drawing.Point(397, 190)
        Me.ucrTextboxName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTextboxName.Name = "ucrTextboxName"
        Me.ucrTextboxName.Size = New System.Drawing.Size(237, 25)
        Me.ucrTextboxName.TabIndex = 31
        Me.ucrTextboxName.TextboxValue = ""
        '
        'ucrTextboxDescription
        '
        Me.ucrTextboxDescription.Location = New System.Drawing.Point(397, 224)
        Me.ucrTextboxDescription.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTextboxDescription.Name = "ucrTextboxDescription"
        Me.ucrTextboxDescription.Size = New System.Drawing.Size(237, 25)
        Me.ucrTextboxDescription.TabIndex = 32
        Me.ucrTextboxDescription.TextboxValue = ""
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(268, 228)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 33
        Me.lblDescription.Text = "Description"
        '
        'ucrTextBoxScale
        '
        Me.ucrTextBoxScale.Location = New System.Drawing.Point(397, 256)
        Me.ucrTextBoxScale.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTextBoxScale.Name = "ucrTextBoxScale"
        Me.ucrTextBoxScale.Size = New System.Drawing.Size(237, 25)
        Me.ucrTextBoxScale.TabIndex = 34
        Me.ucrTextBoxScale.TextboxValue = ""
        '
        'lblScale
        '
        Me.lblScale.AutoSize = True
        Me.lblScale.Location = New System.Drawing.Point(268, 261)
        Me.lblScale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScale.Name = "lblScale"
        Me.lblScale.Size = New System.Drawing.Size(43, 17)
        Me.lblScale.TabIndex = 35
        Me.lblScale.Text = "Scale"
        '
        'ucrTextBoxUpperLimit
        '
        Me.ucrTextBoxUpperLimit.Location = New System.Drawing.Point(397, 288)
        Me.ucrTextBoxUpperLimit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTextBoxUpperLimit.Name = "ucrTextBoxUpperLimit"
        Me.ucrTextBoxUpperLimit.Size = New System.Drawing.Size(237, 25)
        Me.ucrTextBoxUpperLimit.TabIndex = 36
        Me.ucrTextBoxUpperLimit.TextboxValue = ""
        '
        'lblUpperlimit
        '
        Me.lblUpperlimit.AutoSize = True
        Me.lblUpperlimit.Location = New System.Drawing.Point(268, 294)
        Me.lblUpperlimit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpperlimit.Name = "lblUpperlimit"
        Me.lblUpperlimit.Size = New System.Drawing.Size(80, 17)
        Me.lblUpperlimit.TabIndex = 37
        Me.lblUpperlimit.Text = "Upper Limit"
        '
        'ucrTextBoxLowerLimit
        '
        Me.ucrTextBoxLowerLimit.Location = New System.Drawing.Point(397, 318)
        Me.ucrTextBoxLowerLimit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTextBoxLowerLimit.Name = "ucrTextBoxLowerLimit"
        Me.ucrTextBoxLowerLimit.Size = New System.Drawing.Size(237, 25)
        Me.ucrTextBoxLowerLimit.TabIndex = 38
        Me.ucrTextBoxLowerLimit.TextboxValue = ""
        '
        'lblLowerLimit
        '
        Me.lblLowerLimit.AutoSize = True
        Me.lblLowerLimit.Location = New System.Drawing.Point(268, 327)
        Me.lblLowerLimit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLowerLimit.Name = "lblLowerLimit"
        Me.lblLowerLimit.Size = New System.Drawing.Size(79, 17)
        Me.lblLowerLimit.TabIndex = 39
        Me.lblLowerLimit.Text = "Lower Limit"
        '
        'ucrTextBoxUnit
        '
        Me.ucrTextBoxUnit.Location = New System.Drawing.Point(397, 352)
        Me.ucrTextBoxUnit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTextBoxUnit.Name = "ucrTextBoxUnit"
        Me.ucrTextBoxUnit.Size = New System.Drawing.Size(237, 25)
        Me.ucrTextBoxUnit.TabIndex = 40
        Me.ucrTextBoxUnit.TextboxValue = ""
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(268, 361)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(33, 17)
        Me.lblUnit.TabIndex = 41
        Me.lblUnit.Text = "Unit"
        '
        'ucrDataLinkType
        '
        Me.ucrDataLinkType.Location = New System.Drawing.Point(397, 387)
        Me.ucrDataLinkType.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrDataLinkType.Name = "ucrDataLinkType"
        Me.ucrDataLinkType.Size = New System.Drawing.Size(237, 26)
        Me.ucrDataLinkType.TabIndex = 42
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(268, 394)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(40, 17)
        Me.lblType.TabIndex = 43
        Me.lblType.Text = "Type"
        '
        'ucrCheckBoxSelected
        '
        Me.ucrCheckBoxSelected.CheckBoxText = "CheckBox1"
        Me.ucrCheckBoxSelected.Location = New System.Drawing.Point(396, 417)
        Me.ucrCheckBoxSelected.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrCheckBoxSelected.Name = "ucrCheckBoxSelected"
        Me.ucrCheckBoxSelected.Size = New System.Drawing.Size(238, 30)
        Me.ucrCheckBoxSelected.TabIndex = 44
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(268, 425)
        Me.lblSelected.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(63, 17)
        Me.lblSelected.TabIndex = 45
        Me.lblSelected.Text = "Selected"
        '
        'ucrCheckBoxTotalRequired
        '
        Me.ucrCheckBoxTotalRequired.CheckBoxText = "CheckBox1"
        Me.ucrCheckBoxTotalRequired.Location = New System.Drawing.Point(396, 447)
        Me.ucrCheckBoxTotalRequired.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrCheckBoxTotalRequired.Name = "ucrCheckBoxTotalRequired"
        Me.ucrCheckBoxTotalRequired.Size = New System.Drawing.Size(238, 30)
        Me.ucrCheckBoxTotalRequired.TabIndex = 46
        '
        'lblTotalRequired
        '
        Me.lblTotalRequired.AutoSize = True
        Me.lblTotalRequired.Location = New System.Drawing.Point(269, 454)
        Me.lblTotalRequired.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRequired.Name = "lblTotalRequired"
        Me.lblTotalRequired.Size = New System.Drawing.Size(102, 17)
        Me.lblTotalRequired.TabIndex = 47
        Me.lblTotalRequired.Text = "Total Required"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.btnClear)
        Me.GroupBox13.Controls.Add(Me.btnView)
        Me.GroupBox13.Controls.Add(Me.btnDelete)
        Me.GroupBox13.Controls.Add(Me.btnUpdate)
        Me.GroupBox13.Controls.Add(Me.btnSave)
        Me.GroupBox13.Controls.Add(Me.btnAddNew)
        Me.GroupBox13.Location = New System.Drawing.Point(23, 482)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox13.Size = New System.Drawing.Size(775, 42)
        Me.GroupBox13.TabIndex = 48
        Me.GroupBox13.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(523, 6)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(647, 6)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 28)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(398, 6)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(275, 6)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(151, 6)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(27, 6)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(100, 28)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "AddNew"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'ucrNavigatorElement
        '
        Me.ucrNavigatorElement.Location = New System.Drawing.Point(227, 538)
        Me.ucrNavigatorElement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrNavigatorElement.Name = "ucrNavigatorElement"
        Me.ucrNavigatorElement.Size = New System.Drawing.Size(488, 30)
        Me.ucrNavigatorElement.TabIndex = 49
        '
        'ucrMetadataElementNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNavigatorElement)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.lblTotalRequired)
        Me.Controls.Add(Me.ucrCheckBoxTotalRequired)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrCheckBoxSelected)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrDataLinkType)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.ucrTextBoxUnit)
        Me.Controls.Add(Me.lblLowerLimit)
        Me.Controls.Add(Me.ucrTextBoxLowerLimit)
        Me.Controls.Add(Me.lblUpperlimit)
        Me.Controls.Add(Me.ucrTextBoxUpperLimit)
        Me.Controls.Add(Me.lblScale)
        Me.Controls.Add(Me.ucrTextBoxScale)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.ucrTextboxDescription)
        Me.Controls.Add(Me.ucrTextboxName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ucrTextboxAbbreviation)
        Me.Controls.Add(Me.lblAbbreviation)
        Me.Controls.Add(Me.ucrDataLinkElementID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblSearchElement)
        Me.Controls.Add(Me.ucrElementSelectorSearch)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ucrMetadataElementNew"
        Me.Size = New System.Drawing.Size(901, 592)
        Me.GroupBox13.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrElementSelectorSearch As ucrComboboxNew
    Friend WithEvents lblSearchElement As Label
    Friend WithEvents lblID As Label
    Friend WithEvents ucrDataLinkElementID As ucrComboboxNew
    Friend WithEvents lblAbbreviation As Label
    Friend WithEvents ucrTextboxAbbreviation As ucrTextBoxNew
    Friend WithEvents lblName As Label
    Friend WithEvents ucrTextboxName As ucrTextBoxNew
    Friend WithEvents ucrTextboxDescription As ucrTextBoxNew
    Friend WithEvents lblDescription As Label
    Friend WithEvents ucrTextBoxScale As ucrTextBoxNew
    Friend WithEvents lblScale As Label
    Friend WithEvents ucrTextBoxUpperLimit As ucrTextBoxNew
    Friend WithEvents lblUpperlimit As Label
    Friend WithEvents ucrTextBoxLowerLimit As ucrTextBoxNew
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents ucrTextBoxUnit As ucrTextBoxNew
    Friend WithEvents lblUnit As Label
    Friend WithEvents ucrDataLinkType As ucrComboboxNew
    Friend WithEvents lblType As Label
    Friend WithEvents ucrCheckBoxSelected As ucrCheckboxNew
    Friend WithEvents lblSelected As Label
    Friend WithEvents ucrCheckBoxTotalRequired As ucrCheckboxNew
    Friend WithEvents lblTotalRequired As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents ucrNavigatorElement As ucrNavigator
End Class