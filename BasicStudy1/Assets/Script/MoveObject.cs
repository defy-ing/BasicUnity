using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5.0f;//�̵� �ӵ�





   
    void Update()
    {
        /*Vector3 a = Vector3.right; //���� ���� ����(�� 1�� ũ��� �����Ǿ� ����) +�ӵ��� ���� ����


        //Ű�Է¿� ���� �̵�
        float move=Input.GetAxis("Horizontal");
        //�̵� ���� -> ����*���ǵ�*Ÿ�ӵ�ŸŸ��

        transform.Translate(Vector3.right * move * speed * Time.deltaTime);*/

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);


        transform.position += move * speed * Time.deltaTime; //�ε巴�� ������
        transform.Translate(move * speed * Time.deltaTime);

    }
}
