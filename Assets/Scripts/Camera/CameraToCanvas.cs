using UnityEngine;
using UnityEngine.UI;

//Класс отображения изображения с камеры телефона в качестве фона в основной игровой сцене
public class CameraToCanvas : MonoBehaviour
{
    public RawImage image; //Картинка под изображение с камеры телефона

    private WebCamTexture webCamTexture; //Изображение с камеры телефона

    //Проверка поддержки устройства камеры и включение таковой, в случае ее наличия
    void Start()
    {
        if (Application.isMobilePlatform && !WebCamTexture.devices.Length.Equals(0))
        {
            string deviceName = WebCamTexture.devices[0].name;
            webCamTexture = new WebCamTexture(deviceName);
            webCamTexture.Play();
        }
    }

    // Передача изображения с камеры на картинку
    void Update()
    {
        image.texture = webCamTexture;
    }
}
