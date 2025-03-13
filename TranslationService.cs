public class TranslationService
{
    private Dictionary<string, Dictionary<string, string>> _translations;

    public TranslationService()
    {
        _translations = new Dictionary<string, Dictionary<string, string>>();

        AddTranslation("en", "homelabel999", "");
        AddTranslation("es", "homelabel999", "");
        //ISO 639-1 Language, Identificator, Text
    }

    private void AddTranslation(string languageCode, string key, string value)
    {
        if (!_translations.ContainsKey(languageCode))
        {
            _translations[languageCode] = new Dictionary<string, string>();
        }

        _translations[languageCode][key] = value;
    }

    public string Translate(string languageCode, string key)
    {
        if (_translations.ContainsKey(languageCode) && _translations[languageCode].ContainsKey(key))
        {
            return _translations[languageCode][key];
        }

        return _translations["en"].ContainsKey(key) ? _translations["en"][key] : key;
    }
}
