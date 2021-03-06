namespace Adam.albadre.omnisharp.Models
{
    public class Character
    {
        public int Id { get; set; }
        
        public string Name { get ; set; } = "Frodo";
        
        public int Hitpoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defence { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get ; set; } = RpgClass.Knight;

        internal static void Add(Character newCharacter)
        {
            throw new NotImplementedException();
        }
    }
}