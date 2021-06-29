using UnityEngine;

public class BAR : MonoBehaviour, IFloat
{
    private float m_Max, m_Width;
    public listen m_Listener;
    void Start()
    {
        m_Max = resource.Find(m_Listener.resourceName).GetMaxValue();
        m_Width = GetComponent<RectTransform>().rect.width;
    }

    public void Use(float value)
    {
        // 00 -> maxValue => 00 -> width
        transform.localPosition = new Vector3(
            (value / m_Max - 1) * m_Width,
            0,
            0);
    }
}

