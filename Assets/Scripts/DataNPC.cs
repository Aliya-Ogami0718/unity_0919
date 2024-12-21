using UnityEngine;

namespace Aliya
{
    /// <Summary>
    /// NPC資料
    /// </Summary>
    
    [CreateAssetMenu(menuName = "ALiya/NPC")]
    public class DataNPC : ScriptableObject
    {
        [Header("NPC AI 要分析的句子")]
        public string[] sentences;
    }
}