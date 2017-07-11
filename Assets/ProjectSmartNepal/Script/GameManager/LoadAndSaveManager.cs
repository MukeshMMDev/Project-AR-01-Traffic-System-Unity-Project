using System;
using UnityEngine;

public class LoadAndSaveManager : MonoBehaviour
{
    float _x;
    float _y;
    float _z;

    private GameObject _ground;

    // Use this for initialization
    void Start()
    {
        _ground = GameObject.FindGameObjectWithTag(ConstantTags.TagGround);
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void ClickedLoad()
    {
        _x = PlayerPrefs.GetFloat(ConstantPlayerPerf.GroundX, 0);
        _y = PlayerPrefs.GetFloat(ConstantPlayerPerf.GroundY, 0);
        _z = PlayerPrefs.GetFloat(ConstantPlayerPerf.GroundZ, 0);

        _ground.transform.localPosition= new Vector3(_x, _y, _z);
        Debug.Log("Loaded Position (x,y,z)=" + _x + "," + _y + "," + _z);

        _x = PlayerPrefs.GetFloat(ConstantPlayerPerf.GroundRotationX, 0);
        _y = PlayerPrefs.GetFloat(ConstantPlayerPerf.GroundRotationY, 0);
        _z = PlayerPrefs.GetFloat(ConstantPlayerPerf.GroundRotationZ, 0);

        _ground.transform.eulerAngles = new Vector3(_x, _y, _z);
        Debug.Log("Loaded Rotation (x,y,z)=" + _x + "," + _y + "," + _z);
    }

    public void ClickedSave()
    {
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundX, _ground.transform.localPosition.x);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundY, _ground.transform.localPosition.y);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundZ, _ground.transform.localPosition.z);
        Debug.Log("Save Position (x,y,z)=" +
                  _ground.transform.localPosition.x + "," +
                  _ground.transform.localPosition.y + "," +
                  _ground.transform.localPosition.z);

       PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundRotationX, _ground.transform.localRotation.eulerAngles.x);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundRotationY, _ground.transform.localRotation.eulerAngles.y);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundRotationZ, _ground.transform.localRotation.eulerAngles.z);

        Debug.Log("Save Rotation (x,y,z)=" +
                  _ground.transform.rotation.eulerAngles.x + "," +
                  _ground.transform.rotation.eulerAngles.y + "," +
                  _ground.transform.rotation.eulerAngles.z);
    }

    public void ClickedReset()
    {
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundX, 0);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundY, 0);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundZ, 0);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundRotationX, 0);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundRotationY, 0);
        PlayerPrefs.SetFloat(ConstantPlayerPerf.GroundRotationZ, 0);
        ClickedLoad();
    }
}