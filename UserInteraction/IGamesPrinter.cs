using GameDataParser.Model;

namespace GameDataParser.UserInteraction;

public interface IGamesPrinter
{
    void Print(List<VideoGames> videoGames);
}