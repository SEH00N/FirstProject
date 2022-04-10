using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //public static PlayerMove Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = FindObjectOfType<PlayerMove>();
    //        }
    //        return instance;
    //    }
    //}
    //private static PlayerMove instance;

    Vector2 min = new Vector2(-2.25f, -3.75f);

    Vector2 max = new Vector2(2.25f, 3.75f);

    void Update()
    {
        PlayerMovement();
        PlayerDie();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            UIManager.Instance.HpDecrease();
            SpawnManger.Instance.SpawnEnemy();
        }

        if (collision.CompareTag("Score"))
        {
            Destroy(collision.gameObject);
            UIManager.Instance.GetScore();
            SpawnManger.Instance.SpawnScore();
        }

    }

    void PlayerDie()
    {
        if (UIManager.Instance.hp.fillAmount <= 0)
            gameObject.SetActive(false);
    }

    void PlayerMovement()
    {
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Translate(new Vector2(1.5f, 0));
        if(Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Translate(new Vector2(-1.5f, 0));
        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.Translate(new Vector2(0, 1.5f));
        if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.Translate(new Vector2(0, -1.5f));
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, min.x, max.x), Mathf.Clamp(transform.position.y, min.y, max.y));
    }
}

