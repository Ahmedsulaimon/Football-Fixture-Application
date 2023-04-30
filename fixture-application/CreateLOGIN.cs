using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
public partial class CreateLOGIN : Form
{
public CreateLOGIN()
{
InitializeComponent();
}

private void btnCreate_Click(object sender, EventArgs e)
{
lblinvalidCreation.Text = "";
lblUserNameError.Text = "";
lblerrorMessage.Text = "";  
bool username = ValidUserName();
bool password = ValidPassWord();
}
private void textBox1_TextChanged(object sender, EventArgs e) { }


//functions to allow users generate valid inputs
public bool ValidUserName()
{
string UserNameError = "";
string Location = "UserNameAndPassWord.txt";
List<string> LoginInfo = new List<string>();

if (File.Exists(Location))
{
LoginInfo = File.ReadAllLines(Location).ToList();
}
bool
number = false,
letter = false,
lenghtOfUserName = txtCreateUsername.Text.Length >= 5 ? true : false;

//requirement to created a username.
foreach (char UserInput in txtCreateUsername.Text)
{            
if (char.IsDigit(UserInput)) number = true;            
else if (char.IsLetter(UserInput)) letter = true;  
}
//Error Message
if (!letter) UserNameError += "username must contain a letter\n";    
else if (!lenghtOfUserName) UserNameError += "username must contain atleast 5 characters\n";
else if(!number) UserNameError += "username must contain atleast 1 digit";
 
 lblUserNameError.Text = UserNameError;
return false;
}

public bool ValidPassWord()
{
string errorMessage = "";
string CreationError = "";
string Location = "UserNameAndPassWord.txt";
List<string> LoginInfo = new List<string>();
           
if (File.Exists(Location)) LoginInfo = File.ReadAllLines(Location).ToList();
      
 bool
upper = false,
digit = false,
specialChar = false,
length = txtCreatePassword.Text.Length >= 8 ? true : false;
bool exists = false;

foreach (char requirement in txtCreatePassword.Text)
{
if (char.IsUpper(requirement)) upper = true;
else if (char.IsDigit(requirement)) digit = true;
else  if (!char.IsLetterOrDigit(requirement)) specialChar = true;           
}
//Error Message
if (!length) errorMessage += "password must contain atleast 8 characters\n";       
else if (!upper) errorMessage += "password must contain atleast 1 uppercase letter\n";
else if (!digit) errorMessage += "password must contain atleast 1 digit\n";    
else if (!specialChar) errorMessage += "password must contain a special character";
foreach(var Login in LoginInfo)
{
if (LoginInfo.Contains(txtCreateUsername.Text) && LoginInfo.Contains(txtCreatePassword.Text))
{
 exists = true;
}
}
           
 if (exists)
{
 CreationError += "Username and Password already exist.";
}
else
{
LoginInfo.Add(txtCreateUsername.Text);
File.WriteAllLines(Location, LoginInfo);
LoginInfo.Add(txtCreatePassword.Text);
File.WriteAllLines(Location, LoginInfo);
}

lblinvalidCreation.Text = CreationError;
lblerrorMessage.Text = errorMessage;  
return true;  
}       
private void label4_Click(object sender, EventArgs e) { }
private void label5_Click(object sender, EventArgs e) { }
private void CreateLOGIN_Load(object sender, EventArgs e){}
private void txtCreatePassword_TextChanged(object sender, EventArgs e){}
}
}
