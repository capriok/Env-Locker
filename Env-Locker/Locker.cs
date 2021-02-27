using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using Newtonsoft;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Env_Locker
{
    struct Project
    {
        public string name;
    }
    public partial class Locker : Form
    {
        List<Project> lockerList = new List<Project>()
        {
            new Project(){ name = "BoardMaster" },
            new Project(){ name = "SQLifting" },
            new Project(){ name = "Oversites" }
        };

        public Locker()
        {
            InitializeComponent();
        }
        private void Locker_Load(object sender, EventArgs e)
        {
            ProjectPanel_Paint();
        }

        public void ProjectPanel_Paint()
        {
            for (var i = 0; i < lockerList.Count; i++)
            {
                Button panelB = new Button();
                panelB.Text = lockerList[i].name;
                panelB.BackColor = System.Drawing.Color.Maroon;
                panelB.Cursor = System.Windows.Forms.Cursors.Hand;
                panelB.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
                panelB.FlatAppearance.BorderSize = 0;
                panelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                panelB.Font = new System.Drawing.Font("Montserrat", 9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panelB.ForeColor = System.Drawing.Color.White;
                panelB.Location = new System.Drawing.Point(10, (i * 45) + 10);
                panelB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                panelB.Name = "SideFlowLockerButton2";
                panelB.Size = new System.Drawing.Size(225, 35);
                panelB.TabIndex = 6;
                panelB.UseVisualStyleBackColor = false;
                ProjectPanel.Controls.Add(panelB);
            }
        }
        private void NewLockerB_Click(object sender, EventArgs e)
        {
            if (NewProjectMenu.Visible == true)
                NewProjectMenu.Visible = false;
            else
                NewProjectMenu.Visible = true;
        }
        private void NLMenuSubmitB_Click(object sender, EventArgs e)
        {
            Project newLockerItem = new Project() { name = NPMenuInput.Text };
            lockerList.Add(newLockerItem);

            // serialize JSON directly to a file
            //using (StreamWriter file = File.CreateText(@"c:\movie.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, lockerList);
            //}

            ProjectPanel_Paint();
        }

        private void NLMenuInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
