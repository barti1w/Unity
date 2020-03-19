using UnityEngine;

public class RuchKamery : MonoBehaviour
{
    public Transform Gracz;    
    public Vector3 Perspektywa;
    private Vector3 PozycjaGracza;
    void Start()
    {
        PozycjaGracza = Gracz.position;
    }

   
    void Update()
    {
        transform.position = PozycjaGracza + Perspektywa;
    }
}
