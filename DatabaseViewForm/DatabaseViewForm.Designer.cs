namespace DatabaseViewForm;

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
        PasswordTextBox.Location = new System.Drawing.Point(314, 375);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(172, 23);
        PasswordTextBox.TabIndex = 1;
        PasswordTextBox.Enter += PasswordTextBox_Enter;
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
        // DatabaseViewForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(FetchButton);
        Controls.Add(PasswordTextBox);
        Controls.Add(UserListView);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button FetchButton;

    private System.Windows.Forms.TextBox PasswordTextBox;

    private System.Windows.Forms.ColumnHeader dateCreated;
    private System.Windows.Forms.ColumnHeader dateModified;

    private System.Windows.Forms.ColumnHeader nameCol;

    private System.Windows.Forms.ColumnHeader idCol;

    private System.Windows.Forms.ListView UserListView;

    #endregion
}