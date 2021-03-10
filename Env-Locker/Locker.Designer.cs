namespace Env_Locker
{
  partial class Locker
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locker));
            this.Side = new System.Windows.Forms.Panel();
            this.NewProjectMenu = new System.Windows.Forms.Panel();
            this.NPMenuInputWrap = new System.Windows.Forms.Panel();
            this.NPMenuInput = new System.Windows.Forms.TextBox();
            this.NPMenuSubmitB = new System.Windows.Forms.Button();
            this.ProjectPanelLabel = new System.Windows.Forms.Label();
            this.NewProjectB = new System.Windows.Forms.Button();
            this.SideAppTitle = new System.Windows.Forms.Label();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.ProjectInputWrap = new System.Windows.Forms.Panel();
            this.ProjectHead = new System.Windows.Forms.Panel();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.ProjectDeleteB = new System.Windows.Forms.Button();
            this.ProjectInput = new System.Windows.Forms.TextBox();
            this.Side.SuspendLayout();
            this.NewProjectMenu.SuspendLayout();
            this.NPMenuInputWrap.SuspendLayout();
            this.ProjectInputWrap.SuspendLayout();
            this.ProjectHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // Side
            // 
            this.Side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Side.Controls.Add(this.NewProjectMenu);
            this.Side.Controls.Add(this.ProjectPanelLabel);
            this.Side.Controls.Add(this.NewProjectB);
            this.Side.Controls.Add(this.SideAppTitle);
            this.Side.Controls.Add(this.ProjectPanel);
            this.Side.Location = new System.Drawing.Point(0, 0);
            this.Side.Margin = new System.Windows.Forms.Padding(0);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(325, 805);
            this.Side.TabIndex = 1;
            // 
            // NewProjectMenu
            // 
            this.NewProjectMenu.AutoSize = true;
            this.NewProjectMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewProjectMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NewProjectMenu.Controls.Add(this.NPMenuInputWrap);
            this.NewProjectMenu.Controls.Add(this.NPMenuSubmitB);
            this.NewProjectMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewProjectMenu.Location = new System.Drawing.Point(0, 668);
            this.NewProjectMenu.Margin = new System.Windows.Forms.Padding(0);
            this.NewProjectMenu.Name = "NewProjectMenu";
            this.NewProjectMenu.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.NewProjectMenu.Size = new System.Drawing.Size(325, 137);
            this.NewProjectMenu.TabIndex = 4;
            this.NewProjectMenu.Visible = false;
            // 
            // NPMenuInputWrap
            // 
            this.NPMenuInputWrap.AutoSize = true;
            this.NPMenuInputWrap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NPMenuInputWrap.BackColor = System.Drawing.SystemColors.Window;
            this.NPMenuInputWrap.Controls.Add(this.NPMenuInput);
            this.NPMenuInputWrap.Location = new System.Drawing.Point(14, 20);
            this.NPMenuInputWrap.Margin = new System.Windows.Forms.Padding(0);
            this.NPMenuInputWrap.Name = "NPMenuInputWrap";
            this.NPMenuInputWrap.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.NPMenuInputWrap.Size = new System.Drawing.Size(298, 38);
            this.NPMenuInputWrap.TabIndex = 6;
            // 
            // NPMenuInput
            // 
            this.NPMenuInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NPMenuInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NPMenuInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.NPMenuInput.Location = new System.Drawing.Point(15, 10);
            this.NPMenuInput.Margin = new System.Windows.Forms.Padding(0);
            this.NPMenuInput.Name = "NPMenuInput";
            this.NPMenuInput.Size = new System.Drawing.Size(268, 18);
            this.NPMenuInput.TabIndex = 5;
            this.NPMenuInput.TextChanged += new System.EventHandler(this.NPMenuInput_TextChanged);
            // 
            // NPMenuSubmitB
            // 
            this.NPMenuSubmitB.BackColor = System.Drawing.Color.Maroon;
            this.NPMenuSubmitB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NPMenuSubmitB.Enabled = false;
            this.NPMenuSubmitB.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.NPMenuSubmitB.FlatAppearance.BorderSize = 0;
            this.NPMenuSubmitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPMenuSubmitB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPMenuSubmitB.ForeColor = System.Drawing.Color.White;
            this.NPMenuSubmitB.Location = new System.Drawing.Point(14, 72);
            this.NPMenuSubmitB.Margin = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.NPMenuSubmitB.Name = "NPMenuSubmitB";
            this.NPMenuSubmitB.Size = new System.Drawing.Size(300, 35);
            this.NPMenuSubmitB.TabIndex = 5;
            this.NPMenuSubmitB.Text = "Submit";
            this.NPMenuSubmitB.UseVisualStyleBackColor = false;
            this.NPMenuSubmitB.Click += new System.EventHandler(this.NPMenuSubmitB_Click);
            // 
            // ProjectPanelLabel
            // 
            this.ProjectPanelLabel.AccessibleName = "";
            this.ProjectPanelLabel.AutoSize = true;
            this.ProjectPanelLabel.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ProjectPanelLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectPanelLabel.Location = new System.Drawing.Point(9, 97);
            this.ProjectPanelLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ProjectPanelLabel.Name = "ProjectPanelLabel";
            this.ProjectPanelLabel.Size = new System.Drawing.Size(93, 27);
            this.ProjectPanelLabel.TabIndex = 5;
            this.ProjectPanelLabel.Text = "Projects";
            // 
            // NewProjectB
            // 
            this.NewProjectB.BackColor = System.Drawing.Color.Maroon;
            this.NewProjectB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProjectB.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.NewProjectB.FlatAppearance.BorderSize = 0;
            this.NewProjectB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProjectB.Image = ((System.Drawing.Image)(resources.GetObject("NewProjectB.Image")));
            this.NewProjectB.Location = new System.Drawing.Point(268, 97);
            this.NewProjectB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.NewProjectB.Name = "NewProjectB";
            this.NewProjectB.Size = new System.Drawing.Size(44, 35);
            this.NewProjectB.TabIndex = 2;
            this.NewProjectB.UseVisualStyleBackColor = false;
            this.NewProjectB.Click += new System.EventHandler(this.NewProjectB_Click);
            // 
            // SideAppTitle
            // 
            this.SideAppTitle.AccessibleName = "";
            this.SideAppTitle.AutoSize = true;
            this.SideAppTitle.Font = new System.Drawing.Font("Montserrat", 22F);
            this.SideAppTitle.ForeColor = System.Drawing.Color.White;
            this.SideAppTitle.Location = new System.Drawing.Point(46, 19);
            this.SideAppTitle.Name = "SideAppTitle";
            this.SideAppTitle.Size = new System.Drawing.Size(226, 51);
            this.SideAppTitle.TabIndex = 2;
            this.SideAppTitle.Text = "Env Locker";
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ProjectPanel.Location = new System.Drawing.Point(0, 147);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(325, 658);
            this.ProjectPanel.TabIndex = 2;
            // 
            // ProjectInputWrap
            // 
            this.ProjectInputWrap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProjectInputWrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ProjectInputWrap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProjectInputWrap.Controls.Add(this.ProjectHead);
            this.ProjectInputWrap.Controls.Add(this.ProjectInput);
            this.ProjectInputWrap.Location = new System.Drawing.Point(325, 0);
            this.ProjectInputWrap.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectInputWrap.Name = "ProjectInputWrap";
            this.ProjectInputWrap.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.ProjectInputWrap.Size = new System.Drawing.Size(870, 805);
            this.ProjectInputWrap.TabIndex = 7;
            // 
            // ProjectHead
            // 
            this.ProjectHead.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProjectHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ProjectHead.Controls.Add(this.ProjectLabel);
            this.ProjectHead.Controls.Add(this.ProjectDeleteB);
            this.ProjectHead.Location = new System.Drawing.Point(-2, -2);
            this.ProjectHead.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ProjectHead.Name = "ProjectHead";
            this.ProjectHead.Size = new System.Drawing.Size(870, 55);
            this.ProjectHead.TabIndex = 7;
            this.ProjectHead.Visible = false;
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AccessibleName = "";
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ProjectLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel.Location = new System.Drawing.Point(12, 18);
            this.ProjectLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(0, 27);
            this.ProjectLabel.TabIndex = 6;
            // 
            // ProjectDeleteB
            // 
            this.ProjectDeleteB.BackColor = System.Drawing.Color.Maroon;
            this.ProjectDeleteB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectDeleteB.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ProjectDeleteB.FlatAppearance.BorderSize = 0;
            this.ProjectDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectDeleteB.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.ProjectDeleteB.ForeColor = System.Drawing.Color.White;
            this.ProjectDeleteB.Location = new System.Drawing.Point(673, 10);
            this.ProjectDeleteB.Margin = new System.Windows.Forms.Padding(10);
            this.ProjectDeleteB.Name = "ProjectDeleteB";
            this.ProjectDeleteB.Size = new System.Drawing.Size(180, 35);
            this.ProjectDeleteB.TabIndex = 6;
            this.ProjectDeleteB.Text = "Delete Project";
            this.ProjectDeleteB.UseVisualStyleBackColor = false;
            this.ProjectDeleteB.Click += new System.EventHandler(this.ProjectDeleteB_Click);
            // 
            // ProjectInput
            // 
            this.ProjectInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ProjectInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProjectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ProjectInput.ForeColor = System.Drawing.Color.White;
            this.ProjectInput.Location = new System.Drawing.Point(15, 63);
            this.ProjectInput.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectInput.Multiline = true;
            this.ProjectInput.Name = "ProjectInput";
            this.ProjectInput.Size = new System.Drawing.Size(836, 728);
            this.ProjectInput.TabIndex = 5;
            this.ProjectInput.Visible = false;
            this.ProjectInput.TextChanged += new System.EventHandler(this.ProjectInput_TextChanged);
            // 
            // Locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1187, 800);
            this.Controls.Add(this.ProjectInputWrap);
            this.Controls.Add(this.Side);
            this.Name = "Locker";
            this.Text = "Environment Variable Locker";
            this.Load += new System.EventHandler(this.Locker_Load);
            this.Side.ResumeLayout(false);
            this.Side.PerformLayout();
            this.NewProjectMenu.ResumeLayout(false);
            this.NewProjectMenu.PerformLayout();
            this.NPMenuInputWrap.ResumeLayout(false);
            this.NPMenuInputWrap.PerformLayout();
            this.ProjectInputWrap.ResumeLayout(false);
            this.ProjectInputWrap.PerformLayout();
            this.ProjectHead.ResumeLayout(false);
            this.ProjectHead.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel Side;
    private System.Windows.Forms.Label SideAppTitle;
    private System.Windows.Forms.Label ProjectPanelLabel;
    private System.Windows.Forms.Button NewProjectB;
    private System.Windows.Forms.Panel NewProjectMenu;
    private System.Windows.Forms.Panel NPMenuInputWrap;
    private System.Windows.Forms.TextBox NPMenuInput;
    private System.Windows.Forms.Button NPMenuSubmitB;
    private System.Windows.Forms.Panel ProjectPanel;
    private System.Windows.Forms.Panel ProjectInputWrap;
    private System.Windows.Forms.TextBox ProjectInput;
    private System.Windows.Forms.Button ProjectDeleteB;
    private System.Windows.Forms.Panel ProjectHead;
    private System.Windows.Forms.Label ProjectLabel;
  }
}
