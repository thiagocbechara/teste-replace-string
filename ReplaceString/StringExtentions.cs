using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringReplace{
    public static class StringExtensionClass
    {
        public static string RemoveCharacters(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var aux = text;
            var symbolTable = new Dictionary<char, char[]>();
            symbolTable.Add('a', new char[] { 'à', 'á', 'ä', 'â', 'ã' });
            symbolTable.Add('c', new char[] { 'ç' });
            symbolTable.Add('e', new char[] { 'è', 'é', 'ë', 'ê' });
            symbolTable.Add('i', new char[] { 'ì', 'í', 'ï', 'î' });
            symbolTable.Add('o', new char[] { 'ò', 'ó', 'ö', 'ô', 'õ' });
            symbolTable.Add('u', new char[] { 'ù', 'ú', 'ü', 'û' });
            symbolTable.Add('A', new char[] { 'À', 'Á', 'Ä', 'Â', 'Ã' });
            symbolTable.Add('C', new char[] { 'Ç' });
            symbolTable.Add('E', new char[] { 'È', 'É', 'Ë', 'Ê' });
            symbolTable.Add('I', new char[] { 'Ì', 'Í', 'Ï', 'Î' });
            symbolTable.Add('O', new char[] { 'Ò', 'Ó', 'Ö', 'Ô', 'Õ' });
            symbolTable.Add('U', new char[] { 'Ù', 'Ú', 'Ü', 'Û' });

            foreach (var key in symbolTable.Keys)
            {
                foreach (var symbol in symbolTable[key])
                {
                    aux = aux.Replace(symbol, key);
                }
            }

            return aux;
        }

        public static string RemoveCharactersRegex(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var symbolTable = new Dictionary<string, string>
            {
                { "a", "à|á|ä|â|ã" },
                { "c", "ç" },
                { "e", "è|é|ë|ê" },
                { "i", "ì|í|ï|î" },
                { "o", "ò|ó|ö|ô|õ" },
                { "u", "ù|ú|ü|û" },
                { "A", "À|Á|Ä|Â|Ã" },
                { "C", "Ç" },
                { "E", "È|É|Ë|Ê" },
                { "I", "Ì|Í|Ï|Î" },
                { "O", "Ò|Ó|Ö|Ô|Õ" },
                { "U", "Ù|Ú|Ü|Û" }
            };

            foreach (var key in symbolTable.Keys)
            {
                text = Regex.Replace(text, symbolTable[key], key);
            }

            return text;
        }

        public static string RemoveCharactersStringbuiler(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var aux = new StringBuilder(text);
            var symbolTable = new Dictionary<char, char[]>();
            symbolTable.Add('a', new char[] { 'à', 'á', 'ä', 'â', 'ã' });
            symbolTable.Add('c', new char[] { 'ç' });
            symbolTable.Add('e', new char[] { 'è', 'é', 'ë', 'ê' });
            symbolTable.Add('i', new char[] { 'ì', 'í', 'ï', 'î' });
            symbolTable.Add('o', new char[] { 'ò', 'ó', 'ö', 'ô', 'õ' });
            symbolTable.Add('u', new char[] { 'ù', 'ú', 'ü', 'û' });
            symbolTable.Add('A', new char[] { 'À', 'Á', 'Ä', 'Â', 'Ã' });
            symbolTable.Add('C', new char[] { 'Ç' });
            symbolTable.Add('E', new char[] { 'È', 'É', 'Ë', 'Ê' });
            symbolTable.Add('I', new char[] { 'Ì', 'Í', 'Ï', 'Î' });
            symbolTable.Add('O', new char[] { 'Ò', 'Ó', 'Ö', 'Ô', 'Õ' });
            symbolTable.Add('U', new char[] { 'Ù', 'Ú', 'Ü', 'Û' });

            foreach (var key in symbolTable.Keys)
            {
                foreach (var symbol in symbolTable[key])
                {
                    aux.Replace(symbol, key);
                }
            }

            return aux.ToString();
        }

        public static string RemoveCharactersOptimized(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var symbolTable = new char[][]
            {
                new char[] { 'a', 'à', 'á', 'ä', 'â', 'ã' },
                new char[] { 'c', 'ç' },
                new char[] { 'e', 'è', 'é', 'ë', 'ê' },
                new char[] { 'i', 'ì', 'í', 'ï', 'î' },
                new char[] { 'o', 'ò', 'ó', 'ö', 'ô', 'õ' },
                new char[] { 'u', 'ù', 'ú', 'ü', 'û' },
                new char[] { 'A', 'À', 'Á', 'Ä', 'Â', 'Ã' },
                new char[] { 'C', 'Ç' },
                new char[] { 'E', 'È', 'É', 'Ë', 'Ê' },
                new char[] { 'I', 'Ì', 'Í', 'Ï', 'Î' },
                new char[] { 'O', 'Ò', 'Ó', 'Ö', 'Ô', 'Õ' },
                new char[] { 'U', 'Ù', 'Ú', 'Ü', 'Û' },
            };

            for (var i = 0; i < symbolTable.Length; i++)
            {
                for (var j = 1; j < symbolTable[i].Length; j++)
                {
                    text = text.Replace(symbolTable[i][j], symbolTable[i][0]);
                }
            }
            return text;
        }
    }
}