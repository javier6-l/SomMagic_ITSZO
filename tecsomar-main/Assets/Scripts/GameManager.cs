using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Ui de Scrolls Menu
    public event Action OnMainMenu;
    public event Action OnTurismoMenu;
    public event Action OnLeyendasMenu;
    public event Action OnMapaMenu;
    public event Action OnComidaTipicaMenu;
    public event Action OnImperdiblesMenu;
    public event Action OnSabiasQueMenu;
    public event Action OnProductoTuristicoMenu;
    public event Action OnInformacionAdicionalMenu;

    //Ui de Scrolls SubTurismo
    public event Action OnSTCategoriasEdificios;
    public event Action OnSTCategoriasIglesias;
    public event Action OnSTCategoriasJardines;

    //Ui de Scrolls SubTurismo CategoriasEdificios
    public event Action OnSTCECasaCultura;
    public event Action OnSTCEMuseo;
    public event Action OnSTCEHotelHidalgo;
    public event Action OnSTCEPresidencia;
    public event Action OnSTCEPlazuelaBelemMata;

    //Ui de Scrolls SubTurismo CategoriasIglesias
    public event Action OnSTCISantoDomingo;
    public event Action OnSTCISanJuanBautista;
    public event Action OnSTCISoledad;
    public event Action OnSTCISanFrancisco;

    //Ui de Scrolls SubTurismo CategoriasJardines
    public event Action OnSTCJJardinConstitucion;
    public event Action OnSTCJJardinZaragoza;



    //Ui de la Realidad Aumentada
    public event Action OnRATemploDeSantoDomingo;
    public event Action OnRAJardinZaragoza;
    public event Action OnRAHotelHidalgo;
    public event Action OnRAParroquiaDeSanJuanButista;
    public event Action OnRAMuseoMunicipal;
    public event Action OnRAJardinConstitucion;
    public event Action OnRAPrecidenciaMunicipal;
    public event Action OnRAConjuntoArquitectonicoDeSanFrancisco;
    public event Action OnRAPlazuelaBelenMata;
    public event Action OnRAConjuntoArquitectonicoDeLaSoledad;
    public event Action OnRACasaDeCultura;

    //Ui de scrolls
    public event Action OnRegresarLeyendas;
    public event Action OnFantasmaPuente;
    public event Action OnCerroSombreretillo;
    public event Action OnCatrinaItinerante;

    //UI de RA 
    public event Action OnUIRA;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // OnMainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Menu activado");
    }

    public void TurismoMenu()
    {
        OnTurismoMenu?.Invoke();
        Debug.Log("Turismo menu activado");
    }
    public void LeyendasMenu()
    {
        OnLeyendasMenu?.Invoke();
        Debug.Log("Leyendas menu activado");
    }
    public void MapaMenu()
    {
        OnMapaMenu?.Invoke();
        Debug.Log("Mapa menu activado");
    }
    public void ComidaTipicaMenu()
    {
        OnComidaTipicaMenu?.Invoke();
        Debug.Log("Comida menu activado");
    }
    public void ImperdiblesMenu()
    {
        OnImperdiblesMenu?.Invoke();
        Debug.Log("Imperdibles menu activado");
    }
    public void SabiasQueMenu()
    {
        OnSabiasQueMenu?.Invoke();
        Debug.Log("SabiasQue menu activado");
    }

    public void ProductoTuristicoMenu()
    {
        OnProductoTuristicoMenu?.Invoke();
        Debug.Log("ProductoTuristico menu activado");
    }
    public void InformacionAdicionalMenu()
    {
        OnInformacionAdicionalMenu?.Invoke();
        Debug.Log("InformacionAdicional menu activado");
    }

    //Ui de la Realidad Aumentada
    public void RATemploDeSantoDomingo()
    {
        OnRATemploDeSantoDomingo?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAJardinZaragoza()
    {
        OnRAJardinZaragoza?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAHotelHidalgo()
    {
        OnRAHotelHidalgo?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAParroquiaDeSanJuanButista()
    {
        OnRAParroquiaDeSanJuanButista?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAMuseoMunicipal()
    {
        OnRAMuseoMunicipal?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAJardinConstitucion()
    {
        OnRAJardinConstitucion?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAPrecidenciaMunicipal()
    {
        OnRAPrecidenciaMunicipal?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAConjuntoArquitectonicoDeSanFrancisco()
    {
        OnRAConjuntoArquitectonicoDeSanFrancisco?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAPlazuelaBelenMata()
    {
        OnRAPlazuelaBelenMata?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAConjuntoArquitectonicoDeLaSoledad()
    {
        OnRAConjuntoArquitectonicoDeLaSoledad?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RACasaDeCultura()
    {
        OnRACasaDeCultura?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }



    //Ui de scrolls
    public void RegresarLeyendas()
    {
        OnRegresarLeyendas?.Invoke();
        Debug.Log("RegresarLeyendas menu activado");
    }

    public void FantasmaPuente()
    {
        OnFantasmaPuente?.Invoke();
        Debug.Log("FantasmaPuente menu activado");
    }

    public void CerroSombreretillo()
    {
        OnCerroSombreretillo?.Invoke();
        Debug.Log("CerroSombreretillo menu activado");
    }

    public void CatrinaItinerante()
    {
        OnCatrinaItinerante?.Invoke();
        Debug.Log("CatrinaItinerante menu activado");
    }

    //Ui de RA
    public void UIRA()
    {
        OnUIRA?.Invoke();
        Debug.Log("UIRA menu activado");
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    //Ui de Scrolls SubTurismo
    public void STCategoriasEdificios()
    {
        OnSTCategoriasEdificios?.Invoke();
        Debug.Log("CategoriasEdificios activado");
    }
    public void STCategoriasIglesias()
    {
        OnSTCategoriasIglesias?.Invoke();
        Debug.Log("CategoriasIglesias activado");
    }
    public void STCategoriasJardines()
    {
        OnSTCategoriasJardines?.Invoke();
        Debug.Log("CategoriasJardines activado");
    }

    //Ui de Scrolls SubTurismo CategoriasEdificios
    public void STCECasaCultura()
    {
        OnSTCECasaCultura?.Invoke();
        Debug.Log("STCECasaCultura activado");
    }
    public void STCEMuseo()
    {
        OnSTCEMuseo?.Invoke();
        Debug.Log("STCEMuseo activado");
    }
    public void STCEHotelHidalgo()
    {
        OnSTCEHotelHidalgo?.Invoke();
        Debug.Log("STCEHotelHidalgo activado");
    }
    public void STCEPresidencia()
    {
        OnSTCEPresidencia?.Invoke();
        Debug.Log("STCEPresidencia activado");
    }
    public void STCEPlazuelaBelemMata()
    {
        OnSTCEPlazuelaBelemMata?.Invoke();
        Debug.Log("STCEPlazuelaBelemMata activado");
    }

    //Ui de Scrolls SubTurismo CategoriasIglesias
    public void STCISantoDomingo()
    {
        OnSTCISantoDomingo?.Invoke();
        Debug.Log("STCISantoDomingo activado");
    }
    public void STCISanJuanBautista()
    {
        OnSTCISanJuanBautista?.Invoke();
        Debug.Log("STCISanJuanBautista activado");
    }
    public void STCISoledad()
    {
        OnSTCISoledad?.Invoke();
        Debug.Log("STCISoledad activado");
    }
    public void STCISanFrancisco()
    {
        OnSTCISanFrancisco?.Invoke();
        Debug.Log("STCISanFrancisco activado");
    }

    //Ui de Scrolls SubTurismo CategoriasJardines
    public void STCJJardinConstitucion()
    {
        OnSTCJJardinConstitucion?.Invoke();
        Debug.Log("STCJJardinConstitucion activado");
    }
    public void STCJJardinZaragoza()
    {
        OnSTCJJardinZaragoza?.Invoke();
        Debug.Log("STCJJardinZaragoza activado");
    }


}
