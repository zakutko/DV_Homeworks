using System.Text.RegularExpressions;

namespace UkrainianStringLibrary
{
    public static class UkrainianStringUtils
    {
        private static readonly char[] Vowels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
        private static readonly char[] Consonants =
        {
            'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'
        };

        public static int CountVowels(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return input.ToLower().Count(c => Vowels.Contains(c));
        }

        public static int CountConsonants(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return input.ToLower().Count(c => Consonants.Contains(c));
        }

        public static string ReverseString(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return new string(input.Reverse().ToArray());
        }

        public static string RemoveDuplicates(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        public static string RemovePunctuation(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return Regex.Replace(input, @"\p{P}", "");
        }
    }
}
