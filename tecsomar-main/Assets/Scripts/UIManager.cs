using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenuCanvas;
    [SerializeField]
    private GameObject turismoMenuCanvas;
    [SerializeField]
    private GameObject leyendasMenuCanvas;
    [SerializeField]
    private GameObject mapaMenuCanvas;
    [SerializeField]
    private GameObject comidaTipicaMenuCanvas;
    [SerializeField]
    private GameObject imperdiblesMenuCanvas;
    [SerializeField]
    private GameObject sabiasQueMenuCanvas;
    [SerializeField]
    private GameObject productoTuristicoMenuCanvas;
    [SerializeField]
    private GameObject informacionAdicionalMenuCanvas;

    //Ui de la Realidad Aumentada
    [SerializeField]
    private GameObject RATemploDeSantoDomingoCanvas;
    [SerializeField]
    private GameObject RAJardinZaragozaCanvas;
    [SerializeField]
    private GameObject RAHotelHidalgoCanvas;
    [SerializeField]
    private GameObject RAParroquiaDeSanJuanButistaCanvas;
    [SerializeField]
    private GameObject RAMuseoMunicipalCanvas;
    [SerializeField]
    private GameObject RAJardinConstitucionCanvas;
    [SerializeField]
    private GameObject RAPrecidenciaMunicipalCanvas;
    [SerializeField]
    private GameObject RAConjuntoArquitectonicoDeSanFranciscoCanvas;
    [SerializeField]
    private GameObject RAPlazuelaBelenMataCanvas;
    [SerializeField]
    private GameObject RAConjuntoArquitectonicoDeLaSoledadCanvas;
    [SerializeField]
    private GameObject RACasaDeCultura;

    //Ui de Scrolls 

    [SerializeField]
    private GameObject FantasmaPuente;
    [SerializeField]
    private GameObject CerroSombreretillo;
    [SerializeField]
    private GameObject CatrinaItinerante;

    //Ui de Scrolls 
    [SerializeField]
    private GameObject UIRA;

    //Ui de Scrolls SubTurismo
    [SerializeField]
    private GameObject STCategoriasEdificios;
    [SerializeField]
    private GameObject STCategoriasIglesias;
    [SerializeField]
    private GameObject STCategoriasJardines;

    //Ui de Scrolls SubTurismo CategoriasEdificios
    [SerializeField]
    private GameObject STCECasaCultura;
    [SerializeField]
    private GameObject STCEMuseo;
    [SerializeField]
    private GameObject STCEHotelHidalgo;
    [SerializeField]
    private GameObject STCEPresidencia;
    [SerializeField]
    private GameObject STCEPlazuelaBelemMata;

    //Ui de Scrolls SubTurismo CategoriasIglesias
    [SerializeField]
    private GameObject STCISantoDomingo;
    [SerializeField]
    private GameObject STCISanJuanBautista;
    [SerializeField]
    private GameObject STCISoledad;
    [SerializeField]
    private GameObject STCISanFrancisco;

    //Ui de Scrolls SubTurismo CategoriasJardines
    [SerializeField]
    private GameObject STCJJardinConstitucion;
    [SerializeField]
    private GameObject STCJJardinZaragoza;







    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnTurismoMenu += ActivateTurismoMenu;
        GameManager.instance.OnLeyendasMenu += ActivateLeyendasMenu;
        GameManager.instance.OnMapaMenu += ActivateMapaMenu;
        GameManager.instance.OnComidaTipicaMenu += ActivateComidaTipicaMenu;
        GameManager.instance.OnImperdiblesMenu += ActivateImperdiblesMenu;
        GameManager.instance.OnSabiasQueMenu += ActivateSabiasQueMenu;
        GameManager.instance.OnProductoTuristicoMenu += ActivateProductoTuristicoMenu;
        GameManager.instance.OnInformacionAdicionalMenu += ActivateInformacionAdicionalMenu;

        //Ui de la Realidad Aumentada
        GameManager.instance.OnRATemploDeSantoDomingo += ActivateRATemploDeSantoDomingo;
        GameManager.instance.OnRAJardinZaragoza += ActivateRAJardinZaragoza;
        GameManager.instance.OnRAHotelHidalgo += ActivateRAHotelHidalgo;
        GameManager.instance.OnRAParroquiaDeSanJuanButista += ActivateRAParroquiaDeSanJuanButista;
        GameManager.instance.OnRAMuseoMunicipal += ActivateRAMuseoMunicipal;
        GameManager.instance.OnRAJardinConstitucion += ActivateRAJardinConstitucion;
        GameManager.instance.OnRAPrecidenciaMunicipal += ActivateRAPrecidenciaMunicipal;
        GameManager.instance.OnRAConjuntoArquitectonicoDeSanFrancisco += ActivateRAConjuntoArquitectonicoDeSanFrancisco;
        GameManager.instance.OnRAPlazuelaBelenMata += ActivateRAPlazuelaBelenMata;
        GameManager.instance.OnRAConjuntoArquitectonicoDeLaSoledad += ActivateAConjuntoArquitectonicoDeLaSoledad;
        GameManager.instance.OnRACasaDeCultura += ActivateCasaDeCultura;

        //Ui de scrolls
        GameManager.instance.OnRegresarLeyendas += ActivateLeyendasMenu;
        GameManager.instance.OnFantasmaPuente += ActivateFantasmaPuente;
        GameManager.instance.OnCerroSombreretillo += ActivateCerroSombreretillo;
        GameManager.instance.OnCatrinaItinerante += ActivateCatrinaItinerante;

        //Ui de scrolls
        GameManager.instance.OnUIRA += ActivateUIRA;

        //Ui de Scrolls SubTurismo
        GameManager.instance.OnSTCategoriasEdificios += ActivateCategoriasEdificios;
        GameManager.instance.OnSTCategoriasIglesias += ActivateCategoriasIglesias;
        GameManager.instance.OnSTCategoriasJardines += ActivateCategoriasJardines;

        //Ui de Scrolls SubTurismo CategoriasEdificios
        GameManager.instance.OnSTCECasaCultura += ActivateCasaCultura;
        GameManager.instance.OnSTCEMuseo += ActivateMuseo;
        GameManager.instance.OnSTCEHotelHidalgo += ActivateHotelHidalgo;
        GameManager.instance.OnSTCEPresidencia += ActivatePresidencia;
        GameManager.instance.OnSTCEPlazuelaBelemMata += ActivatePlazuelaBelemMata;

        //Ui de Scrolls SubTurismo CategoriasIglesias
        GameManager.instance.OnSTCISantoDomingo += ActivateSantoDomingo;
        GameManager.instance.OnSTCISanJuanBautista += ActivateSanJuanBautista;
        GameManager.instance.OnSTCISoledad += ActivateSoledad;
        GameManager.instance.OnSTCISanFrancisco += ActivateSanFrancisco;

        //Ui de Scrolls SubTurismo CategoriasJardines
        GameManager.instance.OnSTCJJardinConstitucion += ActivateJardinConstitucion;
        GameManager.instance.OnSTCJJardinZaragoza += ActivateJardinZaragoza;

        ActivateMainMenu();
    }


    private void ActivateMainMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, true);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(leyendasMenuCanvas, false);
        ActivarDesactivarMenu(mapaMenuCanvas, false);
        ActivarDesactivarMenu(comidaTipicaMenuCanvas, false);
        ActivarDesactivarMenu(imperdiblesMenuCanvas, false);
        ActivarDesactivarMenu(sabiasQueMenuCanvas, false);
        ActivarDesactivarMenu(productoTuristicoMenuCanvas, false);
        ActivarDesactivarMenu(informacionAdicionalMenuCanvas, false);
        ActivarDesactivarMenu(FantasmaPuente, false);
        ActivarDesactivarMenu(CerroSombreretillo, false);
        ActivarDesactivarMenu(CatrinaItinerante, false);
        ActivarDesactivarMenu(UIRA, false);

        //RA
        ActivarDesactivarMenu(RACasaDeCultura, false);
        ActivarDesactivarMenu(RAMuseoMunicipalCanvas, false);
        ActivarDesactivarMenu(RAPrecidenciaMunicipalCanvas, false);
        ActivarDesactivarMenu(RAHotelHidalgoCanvas, false);
        ActivarDesactivarMenu(RAPlazuelaBelenMataCanvas, false);
        ActivarDesactivarMenu(RATemploDeSantoDomingoCanvas, false);
        ActivarDesactivarMenu(RAParroquiaDeSanJuanButistaCanvas, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeLaSoledadCanvas, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeSanFranciscoCanvas, false);
        ActivarDesactivarMenu(RAJardinZaragozaCanvas, false);
        ActivarDesactivarMenu(RAJardinConstitucionCanvas, false);

        //Ui de Scrolls SubTurismo
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(STCategoriasJardines, false);

        //Ui de Scrolls SubTurismo CategoriasEdificios
        ActivarDesactivarMenu(STCECasaCultura, false);
        ActivarDesactivarMenu(STCEMuseo, false);
        ActivarDesactivarMenu(STCEHotelHidalgo, false);
        ActivarDesactivarMenu(STCEPresidencia, false);
        ActivarDesactivarMenu(STCEPlazuelaBelemMata, false);

        //Ui de Scrolls SubTurismo CategoriasIglesias
        ActivarDesactivarMenu(STCISantoDomingo, false);
        ActivarDesactivarMenu(STCISanJuanBautista, false);
        ActivarDesactivarMenu(STCISoledad, false);
        ActivarDesactivarMenu(STCISanFrancisco, false);

        //Ui de Scrolls SubTurismo CategoriasJardines
        ActivarDesactivarMenu(STCJJardinConstitucion, false);
        ActivarDesactivarMenu(STCJJardinZaragoza, false);

    }

    private void DesactivateAll()
    {
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(leyendasMenuCanvas, false);
        ActivarDesactivarMenu(mapaMenuCanvas, false);
        ActivarDesactivarMenu(comidaTipicaMenuCanvas, false);
        ActivarDesactivarMenu(imperdiblesMenuCanvas, false);
        ActivarDesactivarMenu(sabiasQueMenuCanvas, false);
        ActivarDesactivarMenu(productoTuristicoMenuCanvas, false);
        ActivarDesactivarMenu(informacionAdicionalMenuCanvas, false);
        //RA
        ActivarDesactivarMenu(RACasaDeCultura, false);
        ActivarDesactivarMenu(RAMuseoMunicipalCanvas, false);
        ActivarDesactivarMenu(RAPrecidenciaMunicipalCanvas, false);
        ActivarDesactivarMenu(RAHotelHidalgoCanvas, false);
        ActivarDesactivarMenu(RAPlazuelaBelenMataCanvas, false);
        ActivarDesactivarMenu(RATemploDeSantoDomingoCanvas, false);
        ActivarDesactivarMenu(RAParroquiaDeSanJuanButistaCanvas, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeLaSoledadCanvas, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeSanFranciscoCanvas, false);
        ActivarDesactivarMenu(RAJardinZaragozaCanvas, false);
        ActivarDesactivarMenu(RAJardinConstitucionCanvas, false);

        //UI de scroll
        ActivarDesactivarMenu(FantasmaPuente, false);
        ActivarDesactivarMenu(CerroSombreretillo, false);
        ActivarDesactivarMenu(CatrinaItinerante, false);
        ActivarDesactivarMenu(UIRA, false);

        //Ui de Scrolls SubTurismo
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false); 
        ActivarDesactivarMenu(STCategoriasJardines, false);

        //Ui de Scrolls SubTurismo CategoriasEdificios
        ActivarDesactivarMenu(STCECasaCultura, false);
        ActivarDesactivarMenu(STCEMuseo, false);
        ActivarDesactivarMenu(STCEHotelHidalgo, false);
        ActivarDesactivarMenu(STCEPresidencia, false);
        ActivarDesactivarMenu(STCEPlazuelaBelemMata, false);

        //Ui de Scrolls SubTurismo CategoriasIglesias
        ActivarDesactivarMenu(STCISantoDomingo, false);
        ActivarDesactivarMenu(STCISanJuanBautista, false);
        ActivarDesactivarMenu(STCISoledad, false);
        ActivarDesactivarMenu(STCISanFrancisco, false);

        //Ui de Scrolls SubTurismo CategoriasJardines
        ActivarDesactivarMenu(STCJJardinConstitucion, false);
        ActivarDesactivarMenu(STCJJardinZaragoza, false);
    }


    private void ActivateProductoTuristicoMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(productoTuristicoMenuCanvas, true);
    }

    private void ActivateInformacionAdicionalMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(informacionAdicionalMenuCanvas, true);
    }

    private void ActivateImperdiblesMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(imperdiblesMenuCanvas, true);

    }

    private void ActivateComidaTipicaMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(comidaTipicaMenuCanvas, true);
    }

    private void ActivateSabiasQueMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(sabiasQueMenuCanvas, true);
    }

    private void ActivateMapaMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(mapaMenuCanvas, true);
    }

    private void ActivateLeyendasMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        //Scrolls 
        ActivarDesactivarMenu(FantasmaPuente, false);
        ActivarDesactivarMenu(CerroSombreretillo, false);
        ActivarDesactivarMenu(CatrinaItinerante, false);
        ActivarDesactivarMenu(UIRA, false);
        ActivarDesactivarMenu(leyendasMenuCanvas, true);
    }

    private void ActivateTurismoMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasJardines, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(turismoMenuCanvas, true);

    }

    //Ui de la Realidad Aumentada
    //Función de Scrolls SubTurismo CategoriasEdificios
    private void ActivateCasaDeCultura()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCECasaCultura, false);
        ActivarDesactivarMenu(RACasaDeCultura, true);
    }
    private void ActivateRAMuseoMunicipal()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCEMuseo, false);
        ActivarDesactivarMenu(RAMuseoMunicipalCanvas, true);
    }
    private void ActivateRAPrecidenciaMunicipal()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCEPresidencia, false);
        ActivarDesactivarMenu(RAPrecidenciaMunicipalCanvas, true);
    }
    private void ActivateRAHotelHidalgo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCEHotelHidalgo, false);
        ActivarDesactivarMenu(RAHotelHidalgoCanvas, true);
    }
    private void ActivateRAPlazuelaBelenMata()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(STCEPlazuelaBelemMata, false);
        ActivarDesactivarMenu(RAPlazuelaBelenMataCanvas, true);
    }

    //Función de Scrolls SubTurismo CategoriasIglesias
    private void ActivateRATemploDeSantoDomingo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(STCISantoDomingo, false);
        ActivarDesactivarMenu(RATemploDeSantoDomingoCanvas, true);
    }
    private void ActivateRAParroquiaDeSanJuanButista()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(STCISanJuanBautista, false);
        ActivarDesactivarMenu(RAParroquiaDeSanJuanButistaCanvas, true);
    }
    private void ActivateAConjuntoArquitectonicoDeLaSoledad()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(STCISoledad, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeLaSoledadCanvas, true);
    }
    private void ActivateRAConjuntoArquitectonicoDeSanFrancisco()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(STCISanFrancisco, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeSanFranciscoCanvas, true);
    }

    //Función de Scrolls SubTurismo CategoriasJardines
    private void ActivateRAJardinZaragoza()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasJardines, false);
        ActivarDesactivarMenu(STCJJardinZaragoza, false);
        ActivarDesactivarMenu(RAJardinZaragozaCanvas, true);
    }
    private void ActivateRAJardinConstitucion()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasJardines, false);
        ActivarDesactivarMenu(STCJJardinConstitucion, false);
        ActivarDesactivarMenu(RAJardinConstitucionCanvas, true);
    }

    //Metodos del scroll
    private void ActivateFantasmaPuente()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(FantasmaPuente, true);
    }

    private void ActivateCerroSombreretillo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(CerroSombreretillo, true);
    }

    private void ActivateCatrinaItinerante()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(CatrinaItinerante, true);
    }

    private void ActivateUIRA()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(CatrinaItinerante, true);

        DesactivateAll();
        UIRA.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        //UIRA.GetComponentInChildren<GenRAScript>().setTitulo(txt);
    }
    //Función de Scrolls SubTurismo
    private void ActivateCategoriasEdificios()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, true);

    }
    private void ActivateCategoriasIglesias()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, true);

    }
    private void ActivateCategoriasJardines()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasJardines, true);


    }
    //Función de Scrolls SubTurismo CategoriasEdificios
    private void ActivateCasaCultura()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(RACasaDeCultura, false);
        ActivarDesactivarMenu(STCECasaCultura, true);

    }
    private void ActivateMuseo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(RAMuseoMunicipalCanvas, false);
        ActivarDesactivarMenu(STCEMuseo, true);

    }
    private void ActivateHotelHidalgo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(RAHotelHidalgoCanvas, false);
        ActivarDesactivarMenu(STCEHotelHidalgo, true);


    }
    private void ActivatePresidencia()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(RAPrecidenciaMunicipalCanvas, false);
        ActivarDesactivarMenu(STCEPresidencia, true);

    }
    private void ActivatePlazuelaBelemMata()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasEdificios, false);
        ActivarDesactivarMenu(RAPlazuelaBelenMataCanvas, false);
        ActivarDesactivarMenu(STCEPlazuelaBelemMata, true);

    }

    //Función de Scrolls SubTurismo CategoriasIglesias
    private void ActivateSantoDomingo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(RATemploDeSantoDomingoCanvas, false);
        ActivarDesactivarMenu(STCISantoDomingo, true);

    }
    private void ActivateSanJuanBautista()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(RAParroquiaDeSanJuanButistaCanvas, false);
        ActivarDesactivarMenu(STCISanJuanBautista, true);

    }
    private void ActivateSoledad()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeLaSoledadCanvas, false);
        ActivarDesactivarMenu(STCISoledad, true);

    }
    private void ActivateSanFrancisco()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasIglesias, false);
        ActivarDesactivarMenu(RAConjuntoArquitectonicoDeSanFranciscoCanvas, false);
        ActivarDesactivarMenu(STCISanFrancisco, true);

    }

    //Función de Scrolls SubTurismo CategoriasJardines
    private void ActivateJardinConstitucion()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasJardines, false);
        ActivarDesactivarMenu(RAJardinConstitucionCanvas, false);
        ActivarDesactivarMenu(STCJJardinConstitucion, true);

    }
    private void ActivateJardinZaragoza()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(STCategoriasJardines, false);
        ActivarDesactivarMenu(RAJardinZaragozaCanvas, false);
        ActivarDesactivarMenu(STCJJardinZaragoza, true);
    }



    private void ActivarDesactivarMenu(GameObject menu, bool activarDesactivar)
    {
        for (int i = 0; i < menu.transform.childCount; i++)
        {
            Transform child = menu.transform.GetChild(i);
            if (activarDesactivar == true)
            {
                child.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
            }
            else
            {
                child.transform.DOScale(new Vector3(0, 0, 0), 0.5f);
            }
        }

        Debug.Log(menu.name + "-" + menu.transform.childCount + "-" + activarDesactivar.ToString());
    }


}
