using System.Text.Json.Serialization;
using System.IO;

class Weapon{

    public string name {get; set;}
    public int damageMin {get; set;}
    public int damageMax {get; set;}

   public int Attack(){

        return Random.Shared.Next(damageMin,damageMax);

   }






}