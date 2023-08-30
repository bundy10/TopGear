using TopGear.interfaces;

namespace TopGear.models;

public class car
{
    private readonly ITransmission _transmission;

    public car(ITransmission transmission)
    {
        _transmission = transmission;
    }
}