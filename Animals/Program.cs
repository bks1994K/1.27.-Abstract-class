using Animals;

BirdAnimal cormorant = new BirdAnimal("Baklan");
cormorant.Eat(new[] { "worm" }, new[] { 2.9 });
cormorant.Play();
cormorant.Fly();
Console.WriteLine();

FishAnimal[] fishes = new FishAnimal[]
    {
    new FishAnimal ("Nemo"),
    new FishAnimal ("Dori"),
    };
for (int i = 0; i < fishes.Length; i++)
{
    fishes[i].Eat(new[] { "mollusk" }, new[] { 0.5 });
    fishes[i].Play();
    fishes[i].Swim();
    fishes[i].Eat(new[] { "seaweed" }, new[] { 5.5 });
}
Console.WriteLine();

PrimateAnimal caesar = new PrimateAnimal("Caesar");
caesar.Eat(new[] { "bananas" }, new[] { 100d });
caesar.Play();
caesar.Climb();


