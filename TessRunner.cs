using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;

namespace TSAR
{
    enum Language
    {
        Korean,
        ChineseTrad,
        Russian,
        English
    }
    class TessRunner
    {
        public delegate void OnComplete();
        public TessRunner()
        {
            _tessFileName = @"e:\tools\Tesseract-OCR\tesseract.exe";

            _worker = new BackgroundWorker();
            _worker.DoWork +=
                new DoWorkEventHandler(backgroundWorker_DoWork);

            _worker.RunWorkerCompleted +=
            new RunWorkerCompletedEventHandler(
                backgroundWorker_RunWorkerCompleted);
        }

        private static string languageToString(Language language)
        {
            switch(language)
            {
                case Language.Korean: return "kor";
                case Language.ChineseTrad: return "chi_tra";
                case Language.Russian: return "rus";
                case Language.English: return "eng";
                default:
                    throw new ArgumentException($"Unknown language {language}");
            }
        }

        private struct StartInfo
        {
            public string imageFileName;
            public string outputFileNamePattern;
            public Language[] languages;
            public bool singleLine;
        }

        public void Run(string imageFileName, bool singleLine, Language[] languages, OnComplete onComplete)
        {
            if (_worker.IsBusy)
                return;

            _onComplete = onComplete;

            string outputFileNamePattern = @"e:\project\csharp\TSAR\temp\" + "tess_out";

            _worker.RunWorkerAsync(new StartInfo {
                imageFileName = imageFileName,
                languages = languages,
                outputFileNamePattern = outputFileNamePattern,
                singleLine = singleLine
            });
            
        }

        private void backgroundWorker_DoWork(object sender,
          DoWorkEventArgs e)
        {
            var startInfo = (StartInfo)e.Argument;
            string languageStr = startInfo.languages.Aggregate(
                                    "", 
                                    (current, next) => current != "" ? current + "+" + languageToString(next) : languageToString(next));

            Process process = new Process();
            process.StartInfo.FileName = _tessFileName;

            process.StartInfo.ArgumentList.Add(startInfo.imageFileName);
            process.StartInfo.ArgumentList.Add(startInfo.outputFileNamePattern);
            process.StartInfo.ArgumentList.Add("-l");
            process.StartInfo.ArgumentList.Add(languageStr);
            process.StartInfo.ArgumentList.Add("--psm");
            process.StartInfo.ArgumentList.Add(startInfo.singleLine ? "7" : "6");
            process.StartInfo.ArgumentList.Add("--oem");
            process.StartInfo.ArgumentList.Add("1");
            process.StartInfo.ArgumentList.Add("makebox");
            process.StartInfo.ArgumentList.Add("txt");

            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();// Waits here for the process to exit.
        }

        private void backgroundWorker_RunWorkerCompleted(
         object sender, RunWorkerCompletedEventArgs e)
        {
            _onComplete();
        }

        private readonly BackgroundWorker _worker;
        private readonly string _tessFileName;
        private OnComplete _onComplete;
    }
}
