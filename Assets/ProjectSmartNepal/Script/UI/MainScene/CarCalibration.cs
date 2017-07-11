using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCalibration : MonoBehaviour
{
    public GameObject[] Cars;
    public GameObject Ground;
    public GameObject GroundGrid;
    public GameObject[] CalabrationUi;

    public void UpButtonClicked()
    {
        /* for (int i = 0; i < Cars.Length; i++)
         {
             Cars[i].transform.position = Cars[i].transform.position + Cars[i].transform.up;
         }*/
        Ground.transform.position = Ground.transform.position + Ground.transform.up;
    }

    public void DownButtonClicked()
    {
        Ground.transform.position = Ground.transform.position - Ground.transform.up;
    }

    public void LeftButtonClicked()
    {
        Ground.transform.position = Ground.transform.position - Ground.transform.right;
    }

    public void RightButtonClicked()
    {
        Ground.transform.position = Ground.transform.position + Ground.transform.right;
    }

    public void ForwardButtonClicked()
    {
        Ground.transform.position = Ground.transform.position + Ground.transform.forward;
    }

    public void BackwardButtonClicked()
    {
        Ground.transform.position = Ground.transform.position - Ground.transform.forward;
    }

    public void RotationUpButtonClicked()
    {
        Ground.transform.Rotate(Vector3.right, 10);
    }

    public void RotationDownButtonClicked()
    {
        Ground.transform.Rotate(Vector3.right, -10);
    }

    public void RotationLeftButtonClicked()
    {
        Ground.transform.Rotate(Vector3.forward, 10);
    }

    public void RotationRightButtonClicked()
    {
        Ground.transform.Rotate(Vector3.forward, -10);
    }

    public void RotationForwardButtonClicked()
    {
        Ground.transform.Rotate(Vector3.up, 10);
    }

    public void RotationBackwardButtonClicked()
    {
        Ground.transform.Rotate(Vector3.up, -10);
    }

    public void Hide_Calabration_UI_ButtonClicked()
    {
        foreach (GameObject ui in CalabrationUi)
        {
            ui.SetActive(!ui.activeSelf);
        }
    }

    public void Hide_GridButton_Clicked()
    {
        GroundGrid.SetActive(!GroundGrid.activeSelf);
    }

    public void LoadMainWithTrafficLightScene_Clicked()
    {
       SceneManager.LoadScene(Constant.SceneMainWithTrafficLight);
    }

    public void LoadMain_Clicked()
    {
        SceneManager.LoadScene(Constant.SceneMain);
    }
}