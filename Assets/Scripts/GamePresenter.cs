using System;
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
            _character = new Character(100);
        }

    #endregion
    }
}