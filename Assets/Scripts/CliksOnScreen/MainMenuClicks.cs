using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//����� ������������ ������� ��� ������ ���������� ���� ����������
public class MainMenuClicks : MonoBehaviour
{
    public Transform tutorialPopup; //����������� ���� ���������

    //������� �� ����� ����� �������� �����
    public void ToPrelevelClick()
    {
        SceneManager.LoadScene("PrelevelScene");
    }

    //�������� ���� ���������
    public void ToTutorialClick()
    {
        tutorialPopup.gameObject.SetActive(true);
        tutorialPopup.SetAsLastSibling();
    }

    //�������� ���� ���������
    public void BackFromTutorial()
    {
        tutorialPopup.gameObject.SetActive(false);
    }
}
