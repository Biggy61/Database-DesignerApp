using System.ComponentModel;

namespace DatabaseViewForm.Nav;

partial class Navigation
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
        LanguageButton = new System.Windows.Forms.Button();
        UserButton = new System.Windows.Forms.Button();
        LanguageRegistrationButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new System.Drawing.Point(387, 230);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new System.Drawing.Size(105, 55);
        LanguageButton.TabIndex = 0;
        LanguageButton.Text = "Language";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // UserButton
        // 
        UserButton.Location = new System.Drawing.Point(209, 230);
        UserButton.Name = "UserButton";
        UserButton.Size = new System.Drawing.Size(105, 55);
        UserButton.TabIndex = 1;
        UserButton.Text = "User";
        UserButton.UseVisualStyleBackColor = true;
        UserButton.Click += UserButton_Click;
        // 
        // LanguageRegistrationButton
        // 
        LanguageRegistrationButton.Location = new System.Drawing.Point(551, 230);
        LanguageRegistrationButton.Name = "LanguageRegistrationButton";
        LanguageRegistrationButton.Size = new System.Drawing.Size(105, 55);
        LanguageRegistrationButton.TabIndex = 2;
        LanguageRegistrationButton.Text = "Language  Registration";
        LanguageRegistrationButton.UseVisualStyleBackColor = true;
        LanguageRegistrationButton.Click += LanguageRegistrationButton_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Vladimir Script", 36F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(263, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(305, 105);
        label1.TabIndex = 3;
        label1.Text = "Navigation";
        // 
        // Navigation
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(label1);
        Controls.Add(LanguageRegistrationButton);
        Controls.Add(UserButton);
        Controls.Add(LanguageButton);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1049, 819);
        Load += Navigation_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button UserButton;
    private System.Windows.Forms.Button LanguageRegistrationButton;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button LanguageButton;

    #endregion
}