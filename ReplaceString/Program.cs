using System;
using System.Diagnostics;

namespace StringReplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var text = "àáäâãçèéëêìíïîòóöõùúüû";
            var text = "àáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüûàáäâãçèéëêìíïîòóöõùúüû";

            var watch = new Stopwatch();

            // watch.Start();
            // var replacedText = text.RemoveCharacters();
            // watch.Stop();
            // var elapsedReplace = watch.Elapsed;

            // watch.Reset();

            // watch.Start();
            // var replacedTextRegex = text.RemoveCharactersRegex();
            // watch.Stop();
            // var elapsedReplaceWithRegex = watch.Elapsed;

            // watch.Reset();

            // watch.Start();
            // var replacedTextStringbuilder = text.RemoveCharactersStringbuiler();
            // watch.Stop();
            // var elapsedReplaceWithStringbuilder = watch.Elapsed;

            // watch.Reset();

            watch.Start();
            var replacedTextOptimized = text.RemoveCharactersOptimized();
            watch.Stop();
            var elapsedReplaceOptimized = watch.Elapsed;

            Console.WriteLine($"Run Teste on text \"{text}\"");
            // Console.WriteLine($"With 'Replace String' : \"{replacedText}\" => {elapsedReplace.TotalMilliseconds}ms - 0%");
            // Console.WriteLine($"With 'Replace String With Regex' : \"{replacedTextRegex}\" => {elapsedReplaceWithRegex.TotalMilliseconds}ms");
            // Console.WriteLine($"With 'Replace String With StringBuilder' : \"{replacedTextStringbuilder}\" => {elapsedReplaceWithStringbuilder.TotalMilliseconds}ms");
            Console.WriteLine($"With 'Replace String Optimized' : \"{replacedTextOptimized}\" => {elapsedReplaceOptimized.TotalMilliseconds}ms");

            Console.ReadLine();
        }
    }
}
