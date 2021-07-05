namespace Players_and_monsters
{
    public class Hero
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public Hero(string name, int lvl)
        {
            this.Name = name;
            this.Lvl = lvl;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Name} Level: {this.Lvl}"; 
        }
    }
}
