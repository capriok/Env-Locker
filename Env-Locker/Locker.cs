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
using System.Resources;

namespace Env_Locker
{
  struct Project
  {
    public string name;
  }

  public partial class Locker : Form
  {
    List<Project> projectList = new List<Project>()
        {
            new Project(){ name = "BoardMaster" },
            new Project(){ name = "SQLifting" },
            new Project(){ name = "Oversites" }
        };
    Project activeProject;
    public Locker()
    {
      InitializeComponent();
    }
    private void Locker_Load(object sender, EventArgs e)
    {
      ProjectPanel_Paint();
    }

    private string capitalize (string str)  => str.First().ToString().ToUpper() + str.Substring(1);
    public void ProjectPanel_Paint()
    {
      ProjectPanel.Controls.Clear();

      for (var i = 0; i < projectList.Count; i++)
      {
        Button projectB = new Button();
        projectB.Text = capitalize(projectList[i].name);
        projectB.BackColor = Color.Maroon;
        projectB.Cursor = Cursors.Hand;
        projectB.FlatAppearance.BorderSize = 0;
        projectB.FlatStyle = FlatStyle.Flat;
        projectB.Font = new Font("Cabrilli", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        projectB.ForeColor = Color.White;
        projectB.Location = new Point(10, (i * 45) + 10);
        projectB.Margin = new Padding(0, 0, 10, 0);
        projectB.Name = "SideFlowLockerButton2";
        projectB.Size = new Size(225, 35);
        projectB.TabIndex = 6;
        projectB.UseVisualStyleBackColor = false;
        projectB.Click += new EventHandler(ProjectB_Click);

        ProjectPanel.Controls.Add(projectB);
      }
    }

    public void OpenNPMenu() => NewProjectMenu.Visible = true;
    public void CloseNPMenu()
    {
      NPMenuInput.Text = "";
      NewProjectMenu.Visible = false;
    }
    public void CreateProject()
    {

    }
    public void ActivateProject()

    {
      ProjectLabel.Text = activeProject.name;
      ProjectHead.Visible = true;
      ProjectInput.Visible = true;
    }
    public void DeactivateProject()

    {
      ProjectLabel.Text = "";
      ProjectHead.Visible = false;
      ProjectInput.Visible = false;
    }
    public string GetProjectFile(string n)
    {
      return $"C:\\Users\\capri\\AppData\\Roaming\\EnvLocker\\{n}.txt";
    }

    private void NewProjectB_Click(object sender, EventArgs e)
    {
      bool menuIsOpen = NewProjectMenu.Visible == true;
      if (menuIsOpen)
        CloseNPMenu();
      else
        OpenNPMenu();
    }
    private void NPMenuSubmitB_Click(object sender, EventArgs e)
    {
      if (projectList.Exists(p => p.name.ToLower() == NPMenuInput.Text.ToLower()))
      {
        NPMenuSubmitB.Text = "Already Exists";
        return;
      }

      Project newLockerItem = new Project() { name = NPMenuInput.Text };
      projectList.Add(newLockerItem);

      string fileName = GetProjectFile(capitalize(NPMenuInput.Text));
      File.Create(fileName).Close();

      activeProject = projectList.Find(p => p.name.ToLower() == newLockerItem.name.ToLower());

      ActivateProject();
      CloseNPMenu();

      ProjectPanel_Paint();
    }
    private void NPMenuInput_TextChanged(object sender, EventArgs e)
    {
      NPMenuSubmitB.Text = "Submit";

      if (NPMenuInput.Text.Length >= 3)
        NPMenuSubmitB.Enabled = true;
      else
        NPMenuSubmitB.Enabled = false;
    }
    private void ProjectB_Click(object sender, EventArgs e)
    {
      Button btn = (Button)sender;

      string fileName = GetProjectFile(btn.Text);

      if (!File.Exists(fileName)) File.Create(fileName).Close();
      StreamReader reader = new StreamReader(fileName);
      string allLines = reader.ReadToEnd();

      reader.Close();
      reader.Dispose();

      activeProject = projectList.Find(p => p.name.ToLower() == btn.Text.ToLower());
      ProjectInput.Text = allLines;
      ProjectDeleteB.Enabled = true;

      CloseNPMenu();
      ActivateProject();
    }

    private void ProjectInput_TextChanged(object sender, EventArgs e)
    {

      string fileName = GetProjectFile(activeProject.name);

      StreamWriter writer = new StreamWriter(fileName);
      writer.Write(ProjectInput.Text);

      writer.Close();
      writer.Dispose();
    }

    private void ProjectDeleteB_Click(object sender, EventArgs e)
    {
      activeProject = projectList[0];
      ProjectInput.Text = "";

      DeactivateProject();

      string fileName = GetProjectFile(activeProject.name);
      if (File.Exists(fileName)) File.Delete(fileName);

      projectList.Remove(activeProject);

      ProjectPanel_Paint();
    }
  }
}
