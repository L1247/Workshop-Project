using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Workshop.Scripts
{
    public class GamePresenter : MonoBehaviour
    {
    #region Private Variables

        // Mode
        private Character _character;

        // view
        [SerializeField]
        private Image _image_HealthBar;


    #endregion

    #region Unity events

        private void Start()
        {
            _character                  = new Character(100);
            _character._currentHp
                      .Subscribe(hp =>
                      {
                          UpdateHPBar(hp);
                      });
        }

        private void UpdateHPBar(int hp)
        {
            var characterMAXHp = _character._maxHp;
            _image_HealthBar.fillAmount = (float)hp / characterMAXHp;
        }

        [ContextMenu("Heal")]
        private void Heal()
        {
            _character.Heal(10);
        }

        [ContextMenu("TakeDamage")]
        private void TakeDamage()
        {
            _character.TakeDamage(10);
        }



    #endregion
    }
}