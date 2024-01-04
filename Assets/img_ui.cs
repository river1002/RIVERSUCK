using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class img_ui : MonoBehaviour
{
    public Transform objectToFollow; // �]�m�n���H������
    public Image moveButton; // �]�m�A�����s

    private Vector3 initialButtonPosition; // ��l���s��m
    private Vector3 initialObjectPosition; // ��l�����m
    public float objectMoveSpeed; // ���󲾰ʳt��
    void Start()
    {
        // �x�s��l���s�M�����m
        initialButtonPosition = moveButton.transform.position;
        initialObjectPosition = objectToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {

        // ������󪺲��ʦV�q
        Vector3 objectMovement = (objectToFollow.position - initialObjectPosition) * objectMoveSpeed;


        // �N���󪺲��ʦV�q���Ψ���s����m
        moveButton.transform.position += objectMovement;

        // ��s��l���s��m
        initialButtonPosition = objectToFollow.position;
        initialObjectPosition = objectToFollow.position;
    }
}
