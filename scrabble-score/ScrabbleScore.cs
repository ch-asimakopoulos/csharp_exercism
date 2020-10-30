using System;
using System.Linq;
public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;
        foreach(char ch in input.ToLower()) {
            switch(ch) {
                case char th when new [] {'a','e','i','o','u','l','n','r','s','t'}.Contains(ch):
                    score++;
                    break;
                case char th when new [] {'d','g'}.Contains(ch):
                    score += 2;
                    break;
                case char th when new [] {'b','c','m','p'}.Contains(ch):
                    score += 3;
                    break;
                case char th when new [] {'f','h','v','w','y'}.Contains(ch):
                    score +=4;
                    break;
                case char th when new [] {'k'}.Contains(ch):
                    score += 5;
                    break;
                case char th when new [] {'j','x'}.Contains(ch):
                    score += 8;
                    break;
                 case char th when new [] {'q','z'}.Contains(ch):
                    score += 10;
                    break;
                default: 
                    break;                                   
            }
        }
        return score;
    }
}