namespace Static_Class_Attributes
{
    public class Goals
    {
        public string Team;

        public static int GoalCounter;

        public Goals(string team)
        {
            Team = team;
            GoalCounter++;
        }

        public int getGoals()
        {
            return GoalCounter;
        }
    }
}