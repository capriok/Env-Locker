
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
            this.Side.SuspendLayout();
            this.NewProjectMenu.SuspendLayout();
            this.NPMenuInputWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // Side
            // 
            this.Side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            this.NewProjectMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NewProjectMenu.Controls.Add(this.NPMenuInputWrap);
            this.NewProjectMenu.Controls.Add(this.NPMenuSubmitB);
            this.NewProjectMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewProjectMenu.Location = new System.Drawing.Point(0, 659);
            this.NewProjectMenu.Margin = new System.Windows.Forms.Padding(0);
            this.NewProjectMenu.Name = "NewProjectMenu";
            this.NewProjectMenu.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.NewProjectMenu.Size = new System.Drawing.Size(325, 146);
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
            this.NPMenuInputWrap.Size = new System.Drawing.Size(298, 39);
            this.NPMenuInputWrap.TabIndex = 6;
            // 
            // NPMenuInput
            // 
            this.NPMenuInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NPMenuInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NPMenuInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NPMenuInput.Location = new System.Drawing.Point(15, 10);
            this.NPMenuInput.Margin = new System.Windows.Forms.Padding(0);
            this.NPMenuInput.Name = "NPMenuInput";
            this.NPMenuInput.Size = new System.Drawing.Size(268, 19);
            this.NPMenuInput.TabIndex = 5;
            this.NPMenuInput.TextChanged += new System.EventHandler(this.NLMenuInput_TextChanged);
            // 
            // NPMenuSubmitB
            // 
            this.NPMenuSubmitB.BackColor = System.Drawing.Color.Maroon;
            this.NPMenuSubmitB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NPMenuSubmitB.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.NPMenuSubmitB.FlatAppearance.BorderSize = 0;
            this.NPMenuSubmitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPMenuSubmitB.Font = new System.Drawing.Font("Montserrat", 9F);
            this.NPMenuSubmitB.ForeColor = System.Drawing.Color.White;
            this.NPMenuSubmitB.Location = new System.Drawing.Point(14, 81);
            this.NPMenuSubmitB.Margin = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.NPMenuSubmitB.Name = "NPMenuSubmitB";
            this.NPMenuSubmitB.Size = new System.Drawing.Size(300, 35);
            this.NPMenuSubmitB.TabIndex = 5;
            this.NPMenuSubmitB.Text = "Add";
            this.NPMenuSubmitB.UseVisualStyleBackColor = false;
            this.NPMenuSubmitB.Click += new System.EventHandler(this.NLMenuSubmitB_Click);
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
            this.NewProjectB.Location = new System.Drawing.Point(254, 94);
            this.NewProjectB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.NewProjectB.Name = "NewProjectB";
            this.NewProjectB.Size = new System.Drawing.Size(60, 35);
            this.NewProjectB.TabIndex = 2;
            this.NewProjectB.UseVisualStyleBackColor = false;
            this.NewProjectB.Click += new System.EventHandler(this.NewLockerB_Click);
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
            this.ProjectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ProjectPanel.Location = new System.Drawing.Point(0, 147);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(325, 658);
            this.ProjectPanel.TabIndex = 2;
            // 
            // Locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1171, 800);
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
    }
}