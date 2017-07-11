using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCar : MonoBehaviour
{
    public bool _playing = false;
    private GameObject[] _cars;
    private Vector3[] _savedCarsPositions;
    public float MovementSpeed = 5;

    // Use this for initialization
    void Start()
    {

        _cars = GameObject.FindGameObjectsWithTag(ConstantTags.TagCar);
        _savedCarsPositions = new Vector3[_cars.Length];

        for (int i = 0; i < _cars.Length; i++)
        {
            _savedCarsPositions[i] = _cars[i].transform.localPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_playing)
        {
            foreach (GameObject car in _cars)
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
            for (int i = 0; i < _cars.Length; i++)
            {
                _cars[i].transform.localPosition = _savedCarsPositions[i];
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