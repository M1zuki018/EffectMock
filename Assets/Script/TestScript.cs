using UnityEngine;
using UnityEngine.VFX;

public class TestScript : MonoBehaviour
{
    [SerializeField] private VisualEffect _vfx;
    [SerializeField] private KeyCode _keyCord = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(_keyCord))
        {
            _vfx.SendEvent("OnPlay");
        }
    }
}
