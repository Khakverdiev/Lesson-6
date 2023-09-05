Device device = new("Device", "Abstract class");
Kettle kettle = new("Midea MK-8008", "Electric kettle with automatic switch-off");
Microwave microwave = new("LG", "Microwave");
Automobile automobile = new("BMW I8", "Maximum power of the power plant");
Steamboat steamboat = new("Steamboat", "ordinary steamer");

device.Show();
device.Description();
device.Sound();

kettle.Show();
kettle.Description();
kettle.Sound();

microwave.Show();
microwave.Description();
microwave.Sound();

automobile.Show();
automobile.Description();
automobile.Sound();

steamboat.Show();
steamboat.Description();
steamboat.Sound();

class Device
{

    protected string name;
    protected string description;

    public Device()
    {

    }
    public Device(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Show()
    {
        Console.WriteLine($"Device name: {name} ");
    }

    public void Description()
    {
        Console.WriteLine($"Device Description: {description}");
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Device sound:  {name} ...");
        Console.WriteLine();
    }
}

class Kettle : Device
{

    public Kettle()
    {

    }
    public Kettle(string name, string description) 
        : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Kettle {name} makes the sound of boiling water.");
        Console.WriteLine();
    }
}

class Microwave : Device
{
    public Microwave()
    {

    }
    public Microwave(string name, string description) 
        : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Microwave {name} makes a heating sound.");
        Console.WriteLine();
    }
}

class Automobile : Device
{
    public Automobile()
    {

    }
    public Automobile(string name, string description) 
        : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Automobile {name} makes an engine sound.");
        Console.WriteLine();
    }
}

class Steamboat : Device
{
    public Steamboat()
    {

    }

    public Steamboat(string name, string description) 
        : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Steamboat {name} makes the sound of a ship's engine.");
        Console.WriteLine();
    }
}