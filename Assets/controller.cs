using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    public Image image;

    public void SetRed()
    {
        image.color = Color.red;
    }

    public void SetGreen()
    {
        image.color = Color.green;
    }

    public void SetBlue()
    {
        image.color = Color.blue;
    }
}
