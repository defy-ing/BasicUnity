using UnityEngine;

public class LoopExample : MonoBehaviour
{
    
    void Start()
    {
        //for문 : 1부터 10까지 출력

        /* for (int i=1; i<=10; i++)
         {
             Debug.Log("Count" + i);
         }*/

        int Counter = 0;
        while (Counter<5)
        {
            Debug.Log("While Count: " + Counter);
            Counter++;
        }


    }

    
    
}
