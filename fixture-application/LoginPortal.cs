using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HW
{
public partial class LoginPortal : Form
{
public LoginPortal()
{
 InitializeComponent();
}
 private void label1_Click(object sender, EventArgs e){ }

private void btnLOGIN_Click(object sender, EventArgs e)
{
lblResult.Text = "";
bool check = Check();
if(check == true)
{
FixtureApplication FixtureLinkPage = new FixtureApplication();
FixtureLinkPage.ShowDialog();
}         
}

private void btncreateLOGIN_Click(object sender, EventArgs e)
{
CreateLOGIN NewLOGIN = new CreateLOGIN();
NewLOGIN.ShowDialog();
}

 private void btncreateLOGIN_TextChanged(object sender, EventArgs e) { }           
private void btnLOGIN_TextChanged(object sender, EventArgs e){}

public bool Check()
{
 string Error = "";
string Location = "UserNameAndPassWord.txt";
List<string> LoginInfo = new List<string>();

if (File.Exists(Location)) LoginInfo = File.ReadAllLines(Location).ToList();
           
if (LoginInfo.Contains(txtUserName.Text) && LoginInfo.Contains(txtPassWord.Text)) return true;
 else Error += "Invalid Username and password";       

lblResult.Text = Error;
return false;
}
 private void label3_Click(object sender, EventArgs e){}
}
}

