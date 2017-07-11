using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGroup0Car : MonoBehaviour
{
    public bool _playing = false;
    private GameObject[] _carsGroup0;
    private Vector3[] _savedCarsPositions;
    public float MovementSpeed = 5;

    // Use this for initialization
    void Start()
    {
        _carsGroup0 = GameObject.FindGameObjectsWithTag(ConstantTags.TagGroup0Car);
        _savedCarsPositions = new Vector3[_carsGroup0.Length];

        for (int i = 0; i < _carsGroup0.Length; i++)
        {
            _savedCarsPositions[i] = _carsGroup0[i].transform.localPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_playing)
        {
            foreach (GameObject car in _carsGroup0)
            {
                car.transform.Translate(transform.right * MovementSpeed * Time.deltaTime, Space.Self);
                //car.transform.position += car.transform.forward * Time.deltaTime * MovementSpeed;
            }
        }
    }

    public void PlayButtonClicked()
    {
        if (!_playing)
        {
            StartCoroutine(WaitAndRunCar(4));
           
        }
        else
        {
            _playing = !_playing;
            StopCoroutine(WaitAndRunCar(4));
            for (int i = 0; i < _carsGroup0.Length; i++)
            {
                _carsGroup0[i].transform.localPosition = _savedCarsPositions[i];
            }
        }

       
        
    }

    public IEnumerator WaitAndRunCar(float delayInSecs)
    {
        yield return new WaitForSeconds(delayInSecs);

        _playing = !_playing;

        if (!_playing)
        {
            for (int i = 0; i < _carsGroup0.Length; i++)
            {
                _carsGroup0[i].transform.localPosition = _savedCarsPositions[i];
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