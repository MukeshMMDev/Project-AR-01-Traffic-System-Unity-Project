using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGroup1Car : MonoBehaviour
{
    public bool _playing = false;
    private GameObject[] _carsGroup1;
    private Vector3[] _savedCarsPositions;
    public float MovementSpeed = 5;

    // Use this for initialization
    void Start()
    {

        _carsGroup1 = GameObject.FindGameObjectsWithTag(ConstantTags.TagGroup1Car);
        _savedCarsPositions = new Vector3[_carsGroup1.Length];

        for (int i = 0; i < _carsGroup1.Length; i++)
        {
            _savedCarsPositions[i] = _carsGroup1[i].transform.localPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_playing)
        {
            foreach (GameObject car in _carsGroup1)
            {
                car.transform.Translate(transform.right * MovementSpeed * Time.deltaTime, Space.Self);
                //car.transform.position += car.transform.forward * Time.deltaTime * MovementSpeed;
            }
        }
    }

    public void PlayButtonClicked()
    {
        _playing = !_playing;

        if (!_playing)
        {
            for (int i = 0; i < _carsGroup1.Length; i++)
            {
                _carsGroup1[i].transform.localPosition = _savedCarsPositions[i];
            }
        }
    }

    public void SpeedIncreaseButtonClicked()
    {
        MovementSpeed = MovementSpeed + 1;
    }

    public void SpeedDecreaseButtonClicked()
    {
        MovementSpeed = MovementSpeed - 1;
    }
}