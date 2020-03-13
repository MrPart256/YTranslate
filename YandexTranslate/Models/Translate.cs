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
                case "English":
                    lp.InputLang = Lang.En;
                    break;
                case "Russian":
                    lp.InputLang = Lang.Ru;
                    break;
                case "Deutsch":
                    lp.InputLang = Lang.De;
                    break;
            }
           
            #endregion
            #region OutputLang
            switch (outputLang)
            {
                case "English":
                    lp.OutputLang = Lang.En;
                    break;
                
                case "Russian":
                    lp.OutputLang = Lang.Ru;
                    break;
                case "Deutsch":
                    lp.OutputLang = Lang.De;
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
