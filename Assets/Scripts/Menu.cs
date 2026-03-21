using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private Button botonJugar;
    private Button botonAyuda;
    private Button botonCreditos;
    
    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonJugar = root.Q<Button>("Jugar");
        botonAyuda = root.Q<Button>("Ayuda");
        botonCreditos = root.Q<Button>("Creditos");

        //callbacks (1)
        botonJugar.RegisterCallback<ClickEvent>(AbrirJugar);
        botonAyuda.RegisterCallback<ClickEvent>(AbrirAyuda);
        botonCreditos.RegisterCallback<ClickEvent>(AbrirCreditos);
    }

    void OnDisable()
    {
        botonJugar.UnregisterCallback<ClickEvent>(AbrirJugar);
        botonAyuda.UnregisterCallback<ClickEvent>(AbrirAyuda);
        botonCreditos.UnregisterCallback<ClickEvent>(AbrirCreditos);
    }
    
    void  AbrirJugar(ClickEvent evt)
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    void AbrirAyuda (ClickEvent evt){
        SceneManager.LoadScene("Ayuda");
    }

    void AbrirCreditos (ClickEvent evt){
        SceneManager.LoadScene("Creditos");
    }
}

