using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Keluar_dengan_esc : MonoBehaviour
{
    private Player_control player_control;
    private InputAction keluar;
    [Space]
    [SerializeField] private GameObject panel_keluar;
    [SerializeField] private bool iskeluar;
    [Space]
    public Animator anim_exit;

    // Start is called before the first frame update
    void Awake()
    {
        player_control = new Player_control();
    }

    private void OnEnable()
    {
        keluar = player_control.Menu.Exit;
        keluar.Enable();

        keluar.performed += exit;
    }

    private void OnDisable()
    {
        keluar.Disable();
    }

    public void exit(InputAction.CallbackContext context)
    {
        iskeluar = !iskeluar;
        if (iskeluar)
        {
            panel_keluar.SetActive(true);

        }
        else
        {
            StartCoroutine(exit_ke_menu());
        }

        
        IEnumerator exit_ke_menu()
        {
            anim_exit.SetTrigger("exit");
            yield return new WaitForSeconds(1.2f);
            panel_keluar.SetActive(false);

        }
    }

}
