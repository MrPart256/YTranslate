using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexLinguistics.NET;

namespace YandexTranslate
{
    class TTranslate
    {
        YandexLinguistics.NET.Translator translator;
        const string translatorKey = ""; //put your api key here
        public TTranslate()
        {
            translator = new Translator(translatorKey);
            
        }
        public LangPair GetLangPair(string inputLang,string outputLang)
        {
            LangPair lp = new LangPair();
            #region InputLang

            switch (inputLang)
            {
                case "Английский":
                    lp.InputLang = Lang.En;
                    break;
                case "Русский":
                    lp.InputLang = Lang.Ru;
                    break;
                case "Немецкий":
                    lp.InputLang = Lang.De;
                    break;
            }
           
            #endregion
            #region OutputLang
            switch (outputLang)
            {
                case "Английский":
                   
                    lp.OutputLang = Lang.En;
                    break;
                case "Немецкий":
                    lp.OutputLang = Lang.De;
                    break;
                case "Русский":
                    lp.OutputLang = Lang.Ru;
                    break;
            }
            
            #endregion
            return lp;
            }
        public  string Translator(string wordToTranslate,LangPair langPair)
        {
            return translator.Translate(wordToTranslate, langPair).Text;
         
        }
    }
}
