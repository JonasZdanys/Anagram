using System;
using System.Linq;

public class Anagram
{
    private string theWord;
    private char[] letters;
    public Anagram(string baseWord)
    {
        theWord = baseWord;
        letters = baseWord.ToCharArray().OrderBy(x => x).ToArray();
    }
    public string[] FindAnagrams(string[] potentialMatches)
    {
        var anagrams = potentialMatches.Where(word => IsAnagram(word)).ToArray();
        return anagrams;

    }
    public bool IsAnagram(string givenWord)
    {
        var potencialAnagram = givenWord.ToCharArray().OrderBy(x => x).ToArray();
        return letters.SequenceEqual(potencialAnagram);
    }
}