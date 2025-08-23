using Google.Cloud.Translation.V2;

namespace ABFLERPWEBAPI.Services
{
    public class TranslationService
    {
        private readonly TranslationClient client;

        public TranslationService(string apiKey)
        {
            client = TranslationClient.CreateFromApiKey(apiKey);
        }

        public string TranslateToBangla(string text)
        {
            var response = client.TranslateText(text, "bn"); // 'bn' is the language code for Bangla
            return response.TranslatedText;
        }
    }
}
