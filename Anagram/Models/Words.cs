using System.Collections.Generic;
namespace Anagram.Models
{
  public class Word
  {
    public string Description {get; set;}
    public char[] DescriptionArr{ get; set;}
    private static Dictionary<string, char[]> _instances = new Dictionary<string, char[]> {};

    public Word(string description)
    {
      this.Description = description;
    }

    public void AddToDict(string description)
    {
      char[] DescriptionArr = description.ToCharArray();
      _instances.Add(description, DescriptionArr);
    }

    public static Dictionary<string, char[]> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}