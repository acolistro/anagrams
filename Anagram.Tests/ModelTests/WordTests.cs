using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;


namespace Anagram.Tests
{
  [TestClass]
  public class WordsTests : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "bread";
      Word newWord = new Word(description);
      string result = newWord.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "beard";
      Word newWord = new Word(description);
      string updatedDescription = "bat";
      newWord.Description = updatedDescription;
      string result = newWord.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyDictionary_WordDictionary()
    {
      Dictionary<string, char[]> newDictionary = new Dictionary<string, char[]>();
      Dictionary<string, char[]> result = Word.GetAll();
      CollectionAssert.AreEqual(newDictionary, result);
    }

    [TestMethod]
    public void GetAll_ReturnsWords_WordDictionary()
    {
      string word1 = "beard";
      string word2 = "bread";
      // char[] word1Arr = {'b', 'e', 'a', 'r', 'd'};
      // char[] word2Arr = {'b', 'r', 'e', 'a', 'd'};
      Word newWord1 = new Word(word1);
      Word newWord2 = new Word(word2);

      Dictionary<string, char[]> newDictionary = new Dictionary<string, char[]>{ {"beard", word1.ToCharArray()}, {word2, word2.ToCharArray()} };

      newWord1.AddToDict(word1);
      newWord2.AddToDict(word2);
      Dictionary<string, char[]> result = Word.GetAll();
      // foreach(KeyValuePair<string, char[]> kvp in result)
      // {
      //   Console.WriteLine("Key = {0}", kvp.Key);
      //   foreach(char letter in kvp.Value)
      //   {
      //     Console.WriteLine("Letter = {0}", letter);
      //   }
      // };
      // foreach(KeyValuePair<string, char[]> kvp in newDictionary)
      // {
      //   Console.WriteLine("Key = {0}", kvp.Key);
      //   foreach(char letter in kvp.Value)
      //   {
      //     Console.WriteLine("Letter = {0}", letter);
      //   }
      // };
      CollectionAssert.AreEqual( newDictionary["beard"], result["beard"]);
      CollectionAssert.AreEqual( newDictionary["bread"], result["bread"]);
      CollectionAssert.AreEqual( newDictionary.Keys, result.Keys );
      //fuctionality os correct but no test found to compare collection of collections. 
    }
  }


}