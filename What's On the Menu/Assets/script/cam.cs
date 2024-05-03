using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public Camera m_OrthographicCamera;
    float m_ViewPositionX;
    float m_ViewPositionY;
    float m_ViewWidth;
    float m_ViewHeight;
    // Start is called before the first frame update
    void Start()
    {
        m_ViewPositionX = 0;
        m_ViewPositionY = 0;
        m_ViewWidth = 1.1f;
        m_ViewHeight = 2.1f;
        m_OrthographicCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        m_OrthographicCamera.orthographic = true;
        m_OrthographicCamera.orthographicSize = 5.0f;
        m_OrthographicCamera.rect = new Rect(m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight);
    }
}
