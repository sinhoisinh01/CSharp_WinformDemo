namespace Service
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Model;

    public class HighScoreFileService
    {
        private const string SourceFile = @"../../../Service/HighScoreData.txt";

        public HighScoreFileService()
        {

        }

        public static List<HighScoreItem> GetHighScoreItemList()
        {
            List<HighScoreItem> highScoreItems = new List<HighScoreItem>();
            FileStream fileStream = new FileStream(SourceFile, FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                int index = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    HighScoreItem highScoreItem = new HighScoreItem();
                    if (index % 2 == 0)
                    {
                        highScoreItem.PlayerName = line;
                    }
                    else
                    {
                        Int32.TryParse(line, out int playerScore);
                        highScoreItem.PlayerScore = playerScore;
                    }
                    highScoreItems.Add(highScoreItem);
                    index++;
                }
            }

            return highScoreItems;
        }

        public static List<HighScoreItem> AddHighScoreItemToFile(HighScoreItem item)
        {
            string[] lines = { item.PlayerName, item.PlayerScore.ToString() };
            File.WriteAllLines(SourceFile, lines);

            return GetHighScoreItemList();
        }
    }
}
