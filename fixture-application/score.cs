using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class score
    {
        int HomeTeamGoal = 0;
         int AwayTeamGoal = 0;

        public int GetHomeTeamGoal()
        {
            int HomeGoal = HomeTeamGoal;
            return HomeGoal;
        }
        public int GetAwayTeamGoal()
        {
            int AwayGoal = AwayTeamGoal;
            return AwayGoal;
        }
        public void SetHomeTeamGoal(int NewHomeTeamGoal)
        {
            HomeTeamGoal = NewHomeTeamGoal;
        }
        public void SetAwayTeamGoal(int NewAwayTeamGoal)
        {
            AwayTeamGoal = NewAwayTeamGoal;
        }
       public string we(){
            string test = HomeTeamGoal + " " + "-" + " " + AwayTeamGoal;
            return test;
        }
public override string ToString()
{

            return we();
}
}
}
