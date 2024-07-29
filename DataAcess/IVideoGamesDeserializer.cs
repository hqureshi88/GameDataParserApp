using GameDataParser.Model;

namespace GameDataParser.DataAccess;

public interface IVideoGamesDeserializer
{
    List<VideoGames> DeserializeFrom(string fileName, string fileContents);
}