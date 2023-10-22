 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float move;
    float time =0;
    void Start()
    {
        move = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(move,0 , 0));
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-move, 0, 0));
        }
        time += Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if(time>2)
        {
            if (collision.tag == "banana")
            {
                GameObject.Find("PointObject").GetComponent<CountPoint>().UpdateBanana();
                collision.gameObject.SetActive(false);
            }
            else if (collision.tag == "apple")
            {
                GameObject.Find("PointObject").GetComponent<CountPoint>().UpdateAplle();
                collision.gameObject.SetActive(false);
            }
            else if (collision.tag == "bomb")
            {
                GameObject.Find("PointObject").GetComponent<CountPoint>().UpdateBomb();
                collision.gameObject.SetActive(false);
            }
        }
       
    }
}
