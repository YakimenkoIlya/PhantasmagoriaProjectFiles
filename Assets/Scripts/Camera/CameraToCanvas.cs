using UnityEngine;
using UnityEngine.UI;

//����� ����������� ����������� � ������ �������� � �������� ���� � �������� ������� �����
public class CameraToCanvas : MonoBehaviour
{
    public RawImage image; //�������� ��� ����������� � ������ ��������

    private WebCamTexture webCamTexture; //����������� � ������ ��������

    //�������� ��������� ���������� ������ � ��������� �������, � ������ �� �������
    void Start()
    {
        if (Application.isMobilePlatform && !WebCamTexture.devices.Length.Equals(0))
        {
            string deviceName = WebCamTexture.devices[0].name;
            webCamTexture = new WebCamTexture(deviceName);
            webCamTexture.Play();
        }
    }

    // �������� ����������� � ������ �� ��������
    void Update()
    {
        image.texture = webCamTexture;
    }
}
