﻿using ACT.FoxCommon.core;

namespace ACT.FoxTTS
{
    public class MainController : MainControllerBase
    {

        public delegate void OnLanguageChangedDelegate(bool fromView, string lang);

        public event OnLanguageChangedDelegate LanguageChanged;

        public void NotifyLanguageChanged(bool fromView, string lang)
        {
            LanguageChanged?.Invoke(fromView, lang);
        }

        public delegate void OnTTSEngineChangedDelegate(bool fromView, string engine);

        public event OnTTSEngineChangedDelegate TTSEngineChanged;

        public void NotifyTTSEngineChanged(bool fromView, string engine)
        {
            TTSEngineChanged?.Invoke(fromView, engine);
        }
    }
}
