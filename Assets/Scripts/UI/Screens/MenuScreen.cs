using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTemplateProjects.UI.Screens
{
    public class MenuScreen: Screen
    {
        [SerializeField] private Button PlayButton;
        [SerializeField] private Button ShopButton;

        [SerializeField] private Screen PlayScreen;
        [SerializeField] private Screen ShopScreen;
        
        private void OnEnable()
        {
            PlayButton.onClick.AddListener(ActivateGamePlayScreen);
            ShopButton.onClick.AddListener(OpenShop);
        }

        private void OnDisable()
        {
            PlayButton.onClick.RemoveAllListeners();
            ShopButton.onClick.RemoveAllListeners();
        }

        private void ActivateGamePlayScreen()
        {
            PlayScreen.SetActive(true);

            SetActive(false);
        }

        private void OpenShop()
        {
            ShopScreen.SetActive(true);
            
            SetActive(false);
        }
    }
}