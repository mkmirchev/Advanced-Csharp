namespace DefiningClasses
{
    public class Person
    {
        //Definy fields
        private string name;
        private int age;

        //Define constructor
        public Person()
        {

        }
        //Define properties 
        public string Name 
        {
            get { return this.name;}
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Value can not be below 0.");
                }
                else
                {
                    this.age = value;
                }
            } 
        }     
    }
}
