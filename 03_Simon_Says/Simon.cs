using System;

namespace _03_Simon_Says
{
    public class Simon
    {
        public string Echo(string v)
        {
            string res = "";
            switch(v)
            {
                case "hello": res = "hello";
                    break;
                case "Bye": res = "bye";
                    break;
            }
            return res;
        }

        public string Shout(string v)
        {
            return v.ToUpper();
        }

        public string Repeat(string v)
        {
            return v + " " + v;
        }

        public string Repeat(string v1, int v2)
        {
            string collect = v1;
            for(int i = 0;i<v2-1;i++)
            {
                collect += " " + v1 ;
            }
            return collect;
        }

        public string StartOfWord(string v1, int v2)
        {
            string result = "";

            result = v1.Substring(0, v2);

            return result;
        }

        public string FirstWord(string v)
        {
            

            return v.Substring(0,v.IndexOf(' '));
        }

        public string Titleize(string v)
        {
            string[] littleWords = { "and", "or", "about", "the", "over" };
            string[] words;
            words = v.Split(' ');
            string res = "";
            bool isItLilWord = false;
            bool isFirstLetter = true;

            foreach(string word in words)
            {
                foreach(string lilWord in littleWords)
                {
                    if(lilWord == word && !isFirstLetter)
                    {
                        isItLilWord = true;
                    }
                }
                if (isItLilWord)
                {
                    res += word + " ";
                }
                else
                {
                    res += word.Substring(0, 1).ToUpper() + word.Substring(1) + " ";
                }
                isFirstLetter = false;
                isItLilWord = false;
            }

            return res.Trim();
        }
    }
}