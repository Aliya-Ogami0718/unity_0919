using UnityEngine;

namespace Aliya
{
    /// <Summary>
    /// NPC���
    /// </Summary>
    
    [CreateAssetMenu(menuName = "ALiya/NPC")]
    public class DataNPC : ScriptableObject
    {
        [Header("NPC AI �n���R���y�l")]
        public string[] sentences;
    }
}