using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgmentAria : MonoBehaviour
{
    
    public Text JudgmentText;
    void Update()
    {
        //ÉåÅ[ÉìÇP
        if (Input.GetKeyDown(KeyCode.D))
        {
            
            
            RaycastHit2D hit2D = Physics2D.CircleCast(new Vector2(-43, -50), 1, Vector2.zero);
            if (hit2D)
            {
                
                float distance = Mathf.Abs( hit2D.transform.position.y - transform.position.y);
                if (distance < 3)
                {
                    JudgmentText.text = "PERFECT";
                    
                }
                else if(distance < 5)
                {
                    JudgmentText.text = "OK";
                    
                }
                else
                {
                    JudgmentText.text = "BAD";
                    
                }
                Destroy(hit2D.collider.gameObject);
            }


        }
        //ÉåÅ[ÉìÇQ
        if (Input.GetKeyDown(KeyCode.F))
        {
            

            RaycastHit2D hit2D = Physics2D.CircleCast(new Vector2(-10, -50), 1, Vector2.zero);
            if (hit2D)
            {
                
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
                if (distance < 3)
                {
                    Debug.Log("Good");
                }
                else if (distance < 5)
                {
                    Debug.Log("OK");
                }
                else
                {
                    Debug.Log("BAD");
                }
                Destroy(hit2D.collider.gameObject);
            }


        }
        //ÉåÅ[ÉìÇR
        if (Input.GetKeyDown(KeyCode.J))
        {
            

            RaycastHit2D hit2D = Physics2D.CircleCast(new Vector2(10, -50), 1, Vector2.zero);
            if (hit2D)
            {
                
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
                if (distance < 3)
                {
                    Debug.Log("Good");
                }
                else if (distance < 5)
                {
                    Debug.Log("OK");
                }
                else
                {
                    Debug.Log("BAD");
                }
                Destroy(hit2D.collider.gameObject);
            }


        }

        //ÉåÅ[ÉìÇS
        if (Input.GetKeyDown(KeyCode.K))
        {

            RaycastHit2D hit2D = Physics2D.CircleCast(new Vector2(43, -50), 1, Vector2.zero);
            if (hit2D)
            {
                
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
                if (distance < 3)
                {
                    Debug.Log("Good");
                }
                else if (distance < 5)
                {
                    Debug.Log("OK");
                }
                else
                {
                    Debug.Log("BAD");
                }
                Destroy(hit2D.collider.gameObject);
            }


        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(new Vector2(-50, -50), 5);
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(new Vector2(-20, -50), 5);
    }
}
