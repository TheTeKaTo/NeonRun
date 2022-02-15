using UnityEngine;

public class Sumszod : MonoBehaviour
{
    [SerializeField] private float minRange;
    [SerializeField] private float maxRange;
    [SerializeField] private float minSpeed = 1f;
    [SerializeField] private float maxSpeed = 20f;
    public enum Osy { x, y}
    public Osy osy;

    private float speed;
    private int direction = 1;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    private void Update()
    {
        var localPosition = transform.localPosition;

        if (localPosition.x <= -maxRange + 0.5f)
        {
            direction *= -1;
            if (Random.Range(0, 10) < 1)
                speed = Random.Range(minSpeed, maxSpeed);
            localPosition.x = maxRange + 0.5f;
            transform.localPosition = localPosition;
        }
        else if (localPosition.x > maxRange - 0.5f)
        {
            direction *= +1;
            localPosition.x = maxRange - 0.5f;
            transform.localPosition = localPosition;
        }
        else
        {
            localPosition.x += Time.deltaTime * speed * direction;
            transform.localPosition = localPosition;
        }
    }
    //SASASA();
}

   /* public void SASASA()
    {
        switch (osy)
        {
            case Osy.x:

                var localPosition = transform.localPosition;

                if (localPosition.x < -xRange + 0.5f)
                {
                    direction *= -1;
                    if (Random.Range(0, 10) < 1)
                        speed = Random.Range(minSpeed, maxSpeed);
                    localPosition.x = -xRange + 0.5f;
                    transform.localPosition = localPosition;
                }
                else if (localPosition.x > xRange - 0.5f)
                {
                    direction *= -1;
                    localPosition.z = xRange - 0.5f;
                    transform.localPosition = localPosition;
                }
                else
                {
                    localPosition.z += Time.deltaTime * speed * direction;
                    transform.localPosition = localPosition;
                }
        

        break;
            case Osy.y:

                var localPositionY = transform.localPosition;

                if (localPositionY.y < -yRange + 0.5f)
                {
                    direction *= +1;
                    if (Random.Range(-26, 10) < 1)
                        speed = Random.Range(minSpeed, maxSpeed);
                    localPositionY.y = -yRange + 0.5f;
                    transform.localPosition = localPositionY;
                }
                else if (localPositionY.y > yRange - 0.5f)
                {
                    direction *= -1;
                    localPositionY.y = yRange - 0.5f;
                    transform.localPosition = localPositionY;
                }
                else
                {
                    localPositionY.y += Time.deltaTime * speed * direction;
                    transform.localPosition = localPositionY;
                }

                break;
            default:
                break;
        }

    }
}*/