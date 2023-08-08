namespace ChallengeApp
{
    public class Employee
    {
        private List<int> mark = new List<int>();
        public Employee(string name)
        {
            this.Name = name;
            
           

        }
        public string Name { get; private set; }
        

        

        public int Result
        {
            get
            {
                return this.mark.Sum();
            }
        }

        public void AddMark(int mark)
        {
            this.mark.Add(mark);
        }
        public void RemoveMark(int mark)
        {
            this.mark.Remove(mark);
        }
        public void AddBonus(int mark)
        {
            this.mark.Add(mark);
           this.mark.Add(mark);
        }

    }
}

