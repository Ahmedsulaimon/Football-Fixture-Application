using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace HW
{
public partial class FixtureApplication : Form
{
public FixtureApplication()
{
    InitializeComponent();
}

private void btnCreateFixture_Click(object sender, EventArgs e)
{
lblDateError.Text = "";
FixtureDetail fixtures = new FixtureDetail();
fixtures.SetHomeTeam(txtHomeTeam.Text);
fixtures.SetAwayTeam(txtAwayTeam.Text);
fixtures.Settime(txttime.Text);
score initialScore = new score();
initialScore.SetHomeTeamGoal(Convert.ToInt32(numericUpDown1.Value));
initialScore.SetAwayTeamGoal(Convert.ToInt32(numericUpDown2.Value));
bool dateIsOk = fixtures.SetEnteredDate(txtdate.Text);

if (dateIsOk == false) lblDateError.Text = "Incorrect date";
else
{
lstFixtureList.Items.Add(fixtures);
lstScore.Items.Add(initialScore);
}
txtAwayTeam.Text = "";
txtHomeTeam.Text = "";
txtdate.Text = "";
txttime.Text = "";
}
 private void btnDelete_Click_1(object sender, EventArgs e)
{
            if (lstFixtureList.SelectedIndex >= 0)
            {
                string link = lstFixtureList.SelectedItem.ToString();
                lstScore.Items.RemoveAt(lstFixtureList.SelectedIndex);
                lstFixtureList.Items.RemoveAt(lstFixtureList.SelectedIndex);
                String Path = "FixtureInfo.txt";
                List<string> FixtureList = new List<string>();
                if (File.Exists(Path))
                {
                    FixtureList = File.ReadAllLines(Path).ToList();
                }

                for (int i = 0; i < FixtureList.Count;)
                {
                    if (FixtureList[i] == link)
                    {
                        FixtureList.RemoveAt(i);
                        FixtureList.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                File.WriteAllLines(Path, FixtureList);

            }
        }
private void txtHomeTeam_TextChanged(object sender, EventArgs e) { }
private void FixtureApplication_Load(object sender, EventArgs e){}

private void btnNewScore_Click(object sender, EventArgs e)
{
if (lstScore.SelectedIndex >= 0)
{
score Selected = lstScore.SelectedItem as score;
Selected.SetHomeTeamGoal(Convert.ToInt32(numericUpDown1.Value));
Selected.SetAwayTeamGoal(Convert.ToInt32(numericUpDown2.Value));
int index = lstScore.SelectedIndex;
lstScore.Items[index] = lstScore.Items[index];
  String Path = "FixtureInfo.txt";
   List<string> FixtureList = new List<string>();
   if (File.Exists(Path))
   {
     FixtureList = File.ReadAllLines(Path).ToList();

                    for (int i = 0; i < FixtureList.Count; i++)
                    {
                        if (FixtureList[i] == lstFixtureList.Items[lstScore.SelectedIndex].ToString())
                        {
                            FixtureList[i+1] = Selected.we();
                        }
                    }

                    File.WriteAllLines(Path, FixtureList);
                    numericUpDown2.Value = 0;
                    numericUpDown1.Value = numericUpDown2.Value;
                }
                
}
}
private void txtAwayTeam_TextChanged(object sender, EventArgs e) {}
        
}
}

