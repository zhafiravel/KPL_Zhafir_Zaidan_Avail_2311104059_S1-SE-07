using System.Windows.Forms;

public class DisplayDevice : IObserver
{
    private string deviceName;
    private ListBox outputBox;

    public DisplayDevice(string name, ListBox listBox)
    {
        deviceName = name;
        outputBox = listBox;
    }

    public void Update(float temperature)
    {
        outputBox.Items.Add($"{deviceName} menerima update: Suhu sekarang {temperature}°C");
    }
}
