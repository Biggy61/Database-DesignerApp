using System.ComponentModel;

namespace DatabaseViewForm.Nav;

partial class Users
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
        BackButton = new System.Windows.Forms.Button();
        idCol = new System.Windows.Forms.ColumnHeader();
        nameCol = new System.Windows.Forms.ColumnHeader();
        dateCreated = new System.Windows.Forms.ColumnHeader();
        dateModified = new System.Windows.Forms.ColumnHeader();
        UserListView = new System.Windows.Forms.ListView();
        FetchButton = new System.Windows.Forms.Button();
        Insert_Button = new System.Windows.Forms.Button();
        Delete_Button = new System.Windows.Forms.Button();
        Insert_TextBox = new System.Windows.Forms.TextBox();
        Delete_TextBox = new System.Windows.Forms.TextBox();
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
        UserListView.SelectedIndexChanged += UserListView_SelectedIndexChanged;
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
        // Insert_Button
        // 
        Insert_Button.Location = new System.Drawing.Point(698, 133);
        Insert_Button.Name = "Insert_Button";
        Insert_Button.Size = new System.Drawing.Size(75, 38);
        Insert_Button.TabIndex = 2;
        Insert_Button.Text = "Insert";
        Insert_Button.UseVisualStyleBackColor = true;
        // 
        // Delete_Button
        // 
        Delete_Button.Location = new System.Drawing.Point(698, 289);
        Delete_Button.Name = "Delete_Button";
        Delete_Button.Size = new System.Drawing.Size(75, 38);
        Delete_Button.TabIndex = 3;
        Delete_Button.Text = "Delete";
        Delete_Button.UseVisualStyleBackColor = true;
        Delete_Button.MouseClick += Delete_Button_Click;
        // 
        // Insert_TextBox
        // 
        Insert_TextBox.Location = new System.Drawing.Point(673, 83);
        Insert_TextBox.Name = "Insert_TextBox";
        Insert_TextBox.Size = new System.Drawing.Size(150, 23);
        Insert_TextBox.TabIndex = 4;
        Insert_TextBox.KeyDown += Insert_TextBox_KeyDown;
        // 
        // Delete_TextBox
        // 
        Delete_TextBox.Location = new System.Drawing.Point(667, 248);
        Delete_TextBox.Name = "Delete_TextBox";
        Delete_TextBox.Size = new System.Drawing.Size(150, 23);
        Delete_TextBox.TabIndex = 5;
        Delete_TextBox.KeyDown += Delete_TextBox_KeyDown;
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
        // Users
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
        Controls.Add(ErrorLabel);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(Delete_TextBox);
        Controls.Add(Insert_TextBox);
        Controls.Add(Delete_Button);
        Controls.Add(Insert_Button);
        Controls.Add(FetchButton);
        Controls.Add(UserListView);
        Controls.Add(BackButton);
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Size = new System.Drawing.Size(1079, 842);
        Click += Insert_Button_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.TextBox Insert_TextBox;
    private System.Windows.Forms.TextBox Delete_TextBox;

    private System.Windows.Forms.Button Insert_Button;
    private System.Windows.Forms.Button Delete_Button;

    private System.Windows.Forms.Button FetchButton;

    private System.Windows.Forms.ColumnHeader idCol;
    private System.Windows.Forms.ColumnHeader nameCol;
    private System.Windows.Forms.ColumnHeader dateCreated;
    private System.Windows.Forms.ColumnHeader dateModified;
    private System.Windows.Forms.ListView UserListView;

    private System.Windows.Forms.Button BackButton;

    #endregion
}