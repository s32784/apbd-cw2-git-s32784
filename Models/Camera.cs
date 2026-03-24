namespace APBD_TASK2.Models;



public class Camera : Equipment
{
    public int RamGB { get; set; }

    public int MaxImageSize { get; set; }

    public Camera(string name, int ram, int size)
        : base(name)
    {
        RamGB = ram;
        MaxImageSize = size;
    }

    
}