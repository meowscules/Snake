using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;

namespace Snake
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static List<CultureInfo> m_Languages = new List<CultureInfo>();
        public static string language = "en-US";

        public static CultureInfo Language
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                if (value == System.Threading.Thread.CurrentThread.CurrentUICulture) return;

                //1. Меняем язык приложения:
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;

                //2. Создаём ResourceDictionary для новой культуры
                ResourceDictionary dict = new ResourceDictionary();
                switch (value.Name)
                {
                    case "ja-JP":
                        App.language = "ja-JP";
                        dict.Source = new Uri(String.Format("Resources/Lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    case "es-ES":
                        App.language = "es-ES";
                        dict.Source = new Uri(String.Format("Resources/Lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    case "it-IT":
                        App.language = "it-IT";
                        dict.Source = new Uri(String.Format("Resources/Lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    case "fr-FR":
                        App.language = "fr-FR";
                        dict.Source = new Uri(String.Format("Resources/Lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    case "ru-RU":
                        App.language = "ru-RU";
                        dict.Source = new Uri(String.Format("Resources/Lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    case "de-DE":
                        App.language = "de-DE";
                        dict.Source = new Uri(String.Format("Resources/Lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    default:
                        App.language = "en-US";
                        dict.Source = new Uri("Resources/Lang.xaml", UriKind.Relative);
                        break;
                }

                //3. Находим старую ResourceDictionary и удаляем его и добавляем новую ResourceDictionary
                ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                              where d.Source != null && d.Source.OriginalString.StartsWith("Resources/Lang.")
                                              select d).First();

                if (oldDict != null)
                {
                    int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                    Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
                else
                {
                    Application.Current.Resources.MergedDictionaries.Add(dict);
                }

                //4. Вызываем евент для оповещения всех окон.
                //LanguageChanged(Application.Current, new EventArgs());
            }
        }

        public static List<CultureInfo> Languages
        {
            get
            {
                return m_Languages;
            }
        }

        public App()
        {
            m_Languages.Clear();
            m_Languages.Add(new CultureInfo("en-US"));//Нейтральная культура для этого проекта
            m_Languages.Add(new CultureInfo("ru-RU"));
            m_Languages.Add(new CultureInfo("de-DE"));
            m_Languages.Add(new CultureInfo("fr-FR"));
            m_Languages.Add(new CultureInfo("it-IT"));
            m_Languages.Add(new CultureInfo("es-ES"));
            m_Languages.Add(new CultureInfo("ja-JP"));
        }
    }
}
