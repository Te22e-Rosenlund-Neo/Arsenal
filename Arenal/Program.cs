using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

// Weapon vapen = new Weapon{
//     name = "GreatAxe",
//     damageMin = 4,
//     damageMax = 9
// };

// string json = JsonSerializer.Serialize<Weapon>(vapen);
// File.WriteAllText(@"Weapon.json", json);

string jsonString = File.ReadAllText(@"Weapon.json");


Weapon vapen = JsonSerializer.Deserialize<Weapon>(jsonString);


//I wont check for ccorrect user input, so dont do that 
Console.WriteLine("How many times do you want to attack the player");
int amountOfAttacks = Convert.ToInt32(Console.ReadLine());
int TotalDamage = 0;
while(amountOfAttacks > 0){
    int dmg = vapen.Attack();
    Console.WriteLine("attack did" + dmg + "amount of damage");

    TotalDamage += dmg;
    amountOfAttacks -= 1;


}
Console.WriteLine(TotalDamage);
Console.ReadLine();
