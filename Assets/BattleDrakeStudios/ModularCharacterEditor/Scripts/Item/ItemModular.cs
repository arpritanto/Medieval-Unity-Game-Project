﻿using BattleDrakeStudios.ModularCharacters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleDrakeStudios.ModularCharacters {
    [CreateAssetMenu(fileName = "NewItem", menuName = "Items/Base")]
    public class ItemModular : ScriptableObject {
        public string itemName;
        public ModularArmor modularArmor;
    }
}

