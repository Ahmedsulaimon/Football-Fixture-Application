using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
 class FixtureDetail
{
string HomeTeam = "";
string AwayTeam = "";
string EnteredDate = "";
string time = "";
public string GetHomeTeam() 
{
return HomeTeam;
}
public string GetAwayTeam()
{
return AwayTeam;
}
public string GetEnteredDate()
{
return EnteredDate;
}
public string Gettime()
{
return time;
}
public void SetHomeTeam(string NewHomeTeam)
{
HomeTeam = NewHomeTeam;
}
public void SetAwayTeam(string NewAwayTeam)
{
AwayTeam = NewAwayTeam;
}
public void Settime(string Newtime)
{
    time = Newtime;
}
public bool SetEnteredDate(string NewDate)
{
DateTime ConvertedDate;
bool convertedVal = DateTime.TryParse(NewDate, out ConvertedDate);

if (convertedVal)
{
EnteredDate = NewDate;
return true;
}
else
{
return false;
}
}


public string compilation()
{ 
 score t = new score();
String Path = "FixtureInfo.txt";
List<string> FixtureList = new List<string>();
if (File.Exists(Path))
{
FixtureList = File.ReadAllLines(Path).ToList();
}
string fixture = HomeTeam + " " + "Vs" + " " + AwayTeam + "--" + EnteredDate + "--" + time;
FixtureList.Add(fixture);
File.WriteAllLines(Path, FixtureList);
            FixtureList.Add(t.we());
            File.WriteAllLines(Path, FixtureList);
            return fixture;
}

public override string ToString()
{
 return compilation();
}
}
}


