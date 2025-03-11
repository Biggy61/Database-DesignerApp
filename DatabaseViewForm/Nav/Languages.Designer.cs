using System.ComponentModel;

namespace DatabaseViewForm.Nav;

partial class Languages
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BackButton = new System.Windows.Forms.Button();
        idCol = new System.Windows.Forms.ColumnHeader();
        nameCol = new System.Windows.Forms.ColumnHeader();
        dateCreated = new System.Windows.Forms.ColumnHeader();
        dateModified = new System.Windows.Forms.ColumnHeader();
        UserListView = new System.Windows.Forms.ListView();
        FetchButton = new System.Windows.Forms.Button();
        InsertLanguages_Button = new System.Windows.Forms.Button();
        DeleteLanguages_Button = new System.Windows.Forms.Button();
        InsertLanguages_TextBox = new System.Windows.Forms.TextBox();
        DeleteLanguages_TextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        ErrorLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // BackButton
        // 
        BackButton.Location = new System.Drawing.Point(260, 248);
        BackButton.Name = "BackButton";
        BackButton.Size = new System.Drawing.Size(117, 60);
        BackButton.TabIndex = 0;
        BackButton.Text = "Back";
        BackButton.UseVisualStyleBackColor = true;
        BackButton.Click += BackButton_Click;
        // 
        // idCol
        // 
        idCol.Name = "idCol";
        idCol.Text = "Id";
        idCol.Width = 106;
        // 
        // nameCol
        // 
        nameCol.Name = "nameCol";
        nameCol.Text = "Name";
        nameCol.Width = 120;
        // 
        // dateCreated
        // 
        dateCreated.Name = "dateCreated";
        dateCreated.Text = "Date Created";
        dateCreated.Width = 139;
        // 
        // dateModified
        // 
        dateModified.Name = "dateModified";
        dateModified.Text = "Date Modified";
        dateModified.Width = 200;
        // 
        // UserListView
        // 
        UserListView.AccessibleName = "UserListView";
        UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idCol, nameCol, dateCreated, dateModified });
        UserListView.Location = new System.Drawing.Point(66, 28);
        UserListView.Name = "UserListView";
        UserListView.Size = new System.Drawing.Size(460, 214);
        UserListView.TabIndex = 0;
        UserListView.UseCompatibleStateImageBehavior = false;
        UserListView.View = System.Windows.Forms.View.Details;
        // 
        // FetchButton
        // 
        FetchButton.Location = new System.Drawing.Point(544, 154);
        FetchButton.Name = "FetchButton";
        FetchButton.Size = new System.Drawing.Size(117, 60);
        FetchButton.TabIndex = 1;
        FetchButton.Text = "Fetch";
        FetchButton.UseVisualStyleBackColor = true;
        FetchButton.Click += FetchButton_Click;
        // 
        // InsertLanguages_Button
        // 
        InsertLanguages_Button.Location = new System.Drawing.Point(698, 133);
        InsertLanguages_Button.Name = "InsertLanguages_Button";
        InsertLanguages_Button.Size = new System.Drawing.Size(75, 38);
        InsertLanguages_Button.TabIndex = 2;
        InsertLanguages_Button.Text = "Insert";
        InsertLanguages_Button.UseVisualStyleBackColor = true;
        InsertLanguages_Button.Click += InsertLanguages_Click;
        // 
        // DeleteLanguages_Button
        // 
        DeleteLanguages_Button.Location = new System.Drawing.Point(698, 289);
        DeleteLanguages_Button.Name = "DeleteLanguages_Button";
        DeleteLanguages_Button.Size = new System.Drawing.Size(75, 38);
        DeleteLanguages_Button.TabIndex = 3;
        DeleteLanguages_Button.Text = "Delete";
        DeleteLanguages_Button.UseVisualStyleBackColor = true;
        DeleteLanguages_Button.MouseClick += DeleteLanguages_Button_Click;
        // 
        // InsertLanguages_TextBox
        // 
        InsertLanguages_TextBox.Location = new System.Drawing.Point(673, 83);
        InsertLanguages_TextBox.Name = "InsertLanguages_TextBox";
        InsertLanguages_TextBox.Size = new System.Drawing.Size(150, 23);
        InsertLanguages_TextBox.TabIndex = 4;
        InsertLanguages_TextBox.KeyDown += InsertLanguages_TextBox_KeyDown;
        // 
        // DeleteLanguages_TextBox
        // 
        DeleteLanguages_TextBox.Location = new System.Drawing.Point(667, 248);
        DeleteLanguages_TextBox.Name = "DeleteLanguages_TextBox";
        DeleteLanguages_TextBox.Size = new System.Drawing.Size(150, 23);
        DeleteLanguages_TextBox.TabIndex = 5;
        DeleteLanguages_TextBox.KeyDown += DeleteLanguages_TextBox_KeyDown;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(673, 39);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 6;
        label1.Text = "Insert";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(667, 191);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 7;
        label2.Text = "Delete";
        // 
        // ErrorLabel
        // 
        ErrorLabel.Location = new System.Drawing.Point(409, 271);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(241, 93);
        ErrorLabel.TabIndex = 8;
        // 
        // Languages
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(ErrorLabel);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(DeleteLanguages_TextBox);
        Controls.Add(InsertLanguages_TextBox);
        Controls.Add(DeleteLanguages_Button);
        Controls.Add(InsertLanguages_Button);
        Controls.Add(FetchButton);
        Controls.Add(UserListView);
        Controls.Add(BackButton);
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Size = new System.Drawing.Size(1079, 842);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.TextBox InsertLanguages_TextBox;
    private System.Windows.Forms.TextBox DeleteLanguages_TextBox;

    private System.Windows.Forms.Button InsertLanguages_Button;
    private System.Windows.Forms.Button DeleteLanguages_Button;

    private System.Windows.Forms.Button FetchButton;

    private System.Windows.Forms.ColumnHeader idCol;
    private System.Windows.Forms.ColumnHeader nameCol;
    private System.Windows.Forms.ColumnHeader dateCreated;
    private System.Windows.Forms.ColumnHeader dateModified;
    private System.Windows.Forms.ListView UserListView;

    private System.Windows.Forms.Button BackButton;

    #endregion
}