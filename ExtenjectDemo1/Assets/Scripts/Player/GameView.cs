using System;
using UnityEngine;
using TMPro;
using Zenject;
using System.Collections;

namespace ExtenjectDemo1
{
    public class GameView : MonoBehaviour
    {
        SignalBus SignalBus;
        Settings GUISettings;

        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI healthText;
        public GameObject Game;
        public GameObject MainMenu;

        [Inject]
        public void Construct(Settings settings, SignalBus signalBus)
        {
            SignalBus = signalBus;

            GUISettings = settings;

            SignalBus.Subscribe<OnHealthUpdated>(OnHealthUpdated);
            SignalBus.Subscribe<OnScoreUpdated>(OnScoreUpdated);
            SignalBus.Subscribe<Die>(DoDie);
        }

        public void Start()
        {
            healthText.text = string.Empty;
            scoreText.text = string.Empty;
            Game.SetActive(false);
        }

        public void OnScoreUpdated(OnScoreUpdated signal)
        {
            scoreText.text = signal.NewScore.ToString();
        }

        public void OnHealthUpdated(OnHealthUpdated signal)
        {
            healthText.text = signal.NewHealth.ToString();
        }

        public void DoDie()
        {
            StartCoroutine(DieWithDelay());
        }

        public void DoTakeDamage()
        {
            SignalBus.Fire(new TakeDamage() { Damage = GUISettings.Damage });
        }

        public void DoGainPoints()
        {
            SignalBus.Fire(new ScoreUpdate() { PointsGained = GUISettings.Points });
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void Play()
        {
            Game.SetActive(true);
            MainMenu.SetActive(false);
            SignalBus.Fire<StartGame>();
        }

        public void OnDestroy()
        {
            SignalBus.Unsubscribe<OnScoreUpdated>(OnScoreUpdated);
            SignalBus.Unsubscribe<OnHealthUpdated>(OnHealthUpdated);
            SignalBus.Unsubscribe<Die>(DoDie);
        }

        IEnumerator DieWithDelay()
        {
            yield return new WaitForSeconds(2f);

            Game.SetActive(false);
            MainMenu.SetActive(true);
        }

        [Serializable]
        public class Settings
        {
            public int Damage;
            public int Points;
        }
    } 
}
