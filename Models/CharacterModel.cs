namespace Bragon_Ball_c_.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }

     
        public string Name { get; set; }  

      
        public string Power { get; set; }  

        public string Race { get; set; }

        public string Image { get; set; }


        public CharacterModel(string name, string power, string race, string image)
        {
            Name = name;
            Power = power;
            Race = race;
            Image = image;
        }
    }
}
