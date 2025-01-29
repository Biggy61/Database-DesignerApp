﻿namespace DatabaseViewForm;

partial class DatabaseViewForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        UserListView = new System.Windows.Forms.ListView();
        idCol = new System.Windows.Forms.ColumnHeader();
        nameCol = new System.Windows.Forms.ColumnHeader();
        dateCreated = new System.Windows.Forms.ColumnHeader();
        dateModified = new System.Windows.Forms.ColumnHeader();
        PasswordTextBox = new System.Windows.Forms.TextBox();
        FetchButton = new System.Windows.Forms.Button();
        ErrorLabel = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        Insert_TextBox = new System.Windows.Forms.TextBox();
        Insert_Button = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        Delete_TextBox = new System.Windows.Forms.TextBox();
        Delete_Button = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // UserListView
        // 
        UserListView.AccessibleName = "UserListView";
        UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idCol, nameCol, dateCreated, dateModified });
        UserListView.Location = new System.Drawing.Point(142, 43);
        UserListView.Name = "UserListView";
        UserListView.Size = new System.Drawing.Size(371, 257);
        UserListView.TabIndex = 0;
        UserListView.UseCompatibleStateImageBehavior = false;
        UserListView.View = System.Windows.Forms.View.Details;
        // 
        // idCol
        // 
        idCol.Name = "idCol";
        idCol.Text = "Id";
        idCol.Width = 71;
        // 
        // nameCol
        // 
        nameCol.Name = "nameCol";
        nameCol.Text = "name";
        // 
        // dateCreated
        // 
        dateCreated.Name = "dateCreated";
        dateCreated.Text = "dateCreated";
        dateCreated.Width = 92;
        // 
        // dateModified
        // 
        dateModified.Name = "dateModified";
        dateModified.Text = "dateModified";
        dateModified.Width = 107;
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        PasswordTextBox.Location = new System.Drawing.Point(416, 383);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(172, 23);
        PasswordTextBox.TabIndex = 1;
        PasswordTextBox.Enter += PasswordTextBox_Enter;
        PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
        PasswordTextBox.Leave += PasswordTextBox_Leave;
        // 
        // FetchButton
        // 
        FetchButton.AccessibleName = "FetchButton";
        FetchButton.Location = new System.Drawing.Point(610, 383);
        FetchButton.Name = "FetchButton";
        FetchButton.Size = new System.Drawing.Size(75, 23);
        FetchButton.TabIndex = 2;
        FetchButton.Text = "fetch";
        FetchButton.UseVisualStyleBackColor = true;
        FetchButton.Click += FetchButton_Click;
        // 
        // ErrorLabel
        // 
        ErrorLabel.AccessibleName = "ErrorLabel";
        ErrorLabel.Location = new System.Drawing.Point(314, 401);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(100, 23);
        ErrorLabel.TabIndex = 3;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Vladimir Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(586, 43);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(128, 51);
        label1.TabIndex = 4;
        label1.Text = "Insert";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Insert_TextBox
        // 
        Insert_TextBox.AccessibleName = "Insert_TextBox";
        Insert_TextBox.Location = new System.Drawing.Point(610, 97);
        Insert_TextBox.Name = "Insert_TextBox";
        Insert_TextBox.Size = new System.Drawing.Size(100, 23);
        Insert_TextBox.TabIndex = 5;
        // 
        // Insert_Button
        // 
        Insert_Button.AccessibleName = "Insert_Button";
        Insert_Button.Location = new System.Drawing.Point(622, 136);
        Insert_Button.Name = "Insert_Button";
        Insert_Button.Size = new System.Drawing.Size(75, 23);
        Insert_Button.TabIndex = 6;
        Insert_Button.Text = "Insert";
        Insert_Button.UseVisualStyleBackColor = true;
        Insert_Button.Click += Insert_Button_Click;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Vladimir Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(597, 175);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(128, 51);
        label2.TabIndex = 7;
        label2.Text = "Delete";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Delete_TextBox
        // 
        Delete_TextBox.AccessibleName = "Delete_TextBox";
        Delete_TextBox.Location = new System.Drawing.Point(614, 229);
        Delete_TextBox.Name = "Delete_TextBox";
        Delete_TextBox.Size = new System.Drawing.Size(100, 23);
        Delete_TextBox.TabIndex = 8;
        // 
        // Delete_Button
        // 
        Delete_Button.AccessibleName = "Delete_Button";
        Delete_Button.Location = new System.Drawing.Point(622, 277);
        Delete_Button.Name = "Delete_Button";
        Delete_Button.Size = new System.Drawing.Size(75, 23);
        Delete_Button.TabIndex = 9;
        Delete_Button.Text = "Delete";
        Delete_Button.UseVisualStyleBackColor = true;
        Delete_Button.Click += Delete_Button_Click;
        // 
        // DatabaseViewForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Delete_Button);
        Controls.Add(Delete_TextBox);
        Controls.Add(label2);
        Controls.Add(Insert_Button);
        Controls.Add(Insert_TextBox);
        Controls.Add(label1);
        Controls.Add(ErrorLabel);
        Controls.Add(FetchButton);
        Controls.Add(PasswordTextBox);
        Controls.Add(UserListView);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Delete_Button;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox Delete_TextBox;

    private System.Windows.Forms.TextBox Insert_TextBox;
    private System.Windows.Forms.Button Insert_Button;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.Button FetchButton;

    private System.Windows.Forms.TextBox PasswordTextBox;

    private System.Windows.Forms.ColumnHeader dateCreated;
    private System.Windows.Forms.ColumnHeader dateModified;

    private System.Windows.Forms.ColumnHeader nameCol;

    private System.Windows.Forms.ColumnHeader idCol;

    private System.Windows.Forms.ListView UserListView;

    #endregion
}