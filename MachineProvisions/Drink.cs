namespace MachineProvisions
{
  class Drink
  {
    public string Type { get; set; }
    public bool IsCooked { get; set; }

    public Drink(string type) {
      Type = type;
      IsCooked = false;
    }
  }
}