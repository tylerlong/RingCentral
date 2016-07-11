namespace RingCentral
{
    public partial class Language
    {
    }

    public static class LanguageExtensions
    {
        public static Language Language(this Dictionary dictionary, string _id = null)
        {
            return new Language(dictionary, _id);
        }
    }
}