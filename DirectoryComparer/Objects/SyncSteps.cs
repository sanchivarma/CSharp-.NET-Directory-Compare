using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectoryComparer.Objects
{
    /// <summary>
    /// Object for SyncSteps
    /// </summary>
    public class SyncSteps
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string Action { get; set; }
    }
}
