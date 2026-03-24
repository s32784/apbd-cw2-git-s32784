namespace APBD_TASK2.Models;



public class Projector : Equipment
{
    public int Brightness { get; set; }

    public int ImageResolution { get; set; }

    public Projector(string name, int brightness, int resolution)
        : base(name)
    {
        Brightness = brightness;
        ImageResolution = resolution;
    }

    
}