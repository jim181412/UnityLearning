using UnityEngine;

public class UsingKeyboardMoving : MonoBehaviour
{
    private float _movingSpeed = 5.0f; // The speed at which the cube moves forward
    private float turningSpeed = 5.0f;

    public float MovingSpeed
    {
        get { return _movingSpeed; }
        set { _movingSpeed = value;  }
    }
    

    // This method will keep rendering
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {

            print(Time.deltaTime);
            //using
            this.transform.Translate(0, 0, 1 , Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            //using
            this.transform.Translate(0, 0, -1, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            //using
            this.transform.Translate(1, 0, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            //using
            this.transform.Translate(-1, 0, 0, Space.World);
        }

    }
}