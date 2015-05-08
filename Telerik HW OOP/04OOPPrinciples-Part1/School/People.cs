namespace School
{
    public class People : Comments 
    {        
        public string Name { get; private set; }

        public People(string name)
        {
            this.Name = name;
        }
    }
}
