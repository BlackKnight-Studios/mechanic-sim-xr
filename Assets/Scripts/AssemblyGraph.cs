using System.Collections.Generic;
using UnityEngine;

namespace OmegaGaze.MechanicSim
{
    public class AssemblyPart
    {
        public string PartId;
        public bool IsDisassembled;
        public List<string> PrerequisitePartIds = new List<string>();
    }

    public class AssemblyGraph
    {
        private Dictionary<string, AssemblyPart> _parts = new Dictionary<string, AssemblyPart>();

        public void RegisterPart(string id, params string[] prerequisites)
        {
            var part = new AssemblyPart { PartId = id };
            part.PrerequisitePartIds.AddRange(prerequisites);
            _parts[id] = part;
        }

        public bool CanDisassemble(string id)
        {
            if (!_parts.TryGetValue(id, out var part)) return false;
            foreach (var req in part.PrerequisitePartIds)
            {
                if (_parts.TryGetValue(req, out var reqPart) && !reqPart.IsDisassembled)
                    return false;
            }
            return true;
        }
    }
}
