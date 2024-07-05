using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

public class TypingGame
{
    private List<string> wordList = new List<string>
    {
        "apple", "banana", "orange", "grape", "pear",
        "watermelon", "pineapple", "strawberry", "blueberry", "kiwi"
        // 여기에 추가적으로 단어를 넣을 수 있습니다.
    };

    private Random random = new Random();
    private int score = 0;
    private Stopwatch stopwatch = new Stopwatch();

    public void Start()
    {
        Console.Title = "Typing Game";
        Console.CursorVisible = false;
        Console.WriteLine("Welcome to Typing Game!");
        Console.WriteLine("Type the word and press Enter to start. Type 'exit' to quit.");

        while (true)
        {
            Console.WriteLine("\nPress Enter to start the game...");
            if (Console.ReadLine().ToLower() == "exit")
                break;

            score = 0;
            PlayGame();
            Console.WriteLine($"\nGame Over! Your score: {score}");
            Console.WriteLine("Press Enter to restart or type 'exit' to quit.");
        }
    }

    private void PlayGame()
    {
        stopwatch.Reset();
        stopwatch.Start();

        while (true)
        {
            string targetWord = GetRandomWord();
            Console.Clear();
            Console.WriteLine($"Type this word: {targetWord}");
            Console.WriteLine();

            Console.Write("Your typing: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (input.ToLower() == targetWord)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Thread.Sleep(1000); // 잠시 대기
        }

        stopwatch.Stop();
    }

    private string GetRandomWord()
    {
        int index = random.Next(wordList.Count);
        return wordList[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        TypingGame game = new TypingGame();
        game.Start();
    }
}
