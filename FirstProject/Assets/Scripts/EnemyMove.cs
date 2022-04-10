using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    int randval = 0;

    int temp = 0;

    Vector2 min = new Vector2(-2.25f, -3.75f);

    Vector2 max = new Vector2(2.25f, 3.75f);

    private void Update()
    {
        EnemyMovement();
    }

    void EnemyMovement()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            randval = Random.Range(1, 5);

            temp = randval;
            for (int i = 0; i < i + 1; i++)
            {
                randval = Random.Range(1, 5);
                if (randval != temp)
                    break;
                else
                    continue;
            }
            switch (randval)
            {
                case 1:
                    if (transform.position.x < 2.25f)
                        transform.Translate(new Vector2(1.5f, 0));
                    else
                        transform.Translate(new Vector2(-1.5f, 0));
                    break;
                    
                case 2:
                    if (transform.position.x > -2.25f)
                        transform.Translate(new Vector2(-1.5f, 0));
                    else
                        transform.Translate(new Vector2(1.5f, 0));
                    break;
                case 3:
                    if (transform.position.y < 3.75f)
                        transform.Translate(new Vector2(0, 1.5f));
                    else
                        transform.Translate(new Vector2(0, -1.5f));
                    break;
                case 4:
                    if (transform.position.y > -3.75f)
                        transform.Translate(new Vector2(0, -1.5f));
                    else
                        transform.Translate(new Vector2(0, 1.5f));
                    break;
            }

        }
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, min.x, max.x), Mathf.Clamp(transform.position.y, min.y, max.y));
    }
}
