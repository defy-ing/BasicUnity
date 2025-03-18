using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5.0f;//이동 속도





   
    void Update()
    {
        /*Vector3 a = Vector3.right; //방향 설정 벡터(다 1의 크기로 설정되어 있음) +속도도 설정 가능


        //키입력에 따라 이동
        float move=Input.GetAxis("Horizontal");
        //이동 공식 -> 방향*스피드*타임델타타임

        transform.Translate(Vector3.right * move * speed * Time.deltaTime);*/

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);


        transform.position += move * speed * Time.deltaTime; //부드럽게 움직임
        transform.Translate(move * speed * Time.deltaTime);

    }
}
