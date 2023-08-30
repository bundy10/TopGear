using TopGear.models;

namespace TopGear;

public class Game
{
    private readonly List<car> _cars;

    public Game(List<car> cars)
    {
        _cars = cars;
    }
}