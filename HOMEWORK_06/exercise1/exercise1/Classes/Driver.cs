namespace Classes
{
    internal class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
       
        public bool IsChosen { get; set; }
        public Driver()
        {
        }
        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
    }
}