using System;
using System.Collections.Generic;

namespace VisitorPattern {
    internal class Person : IAsset {
        public List<IAsset> Assets = new List<IAsset>();

        public void Accept(IVisitor visitor) {
            foreach (IAsset asset in Assets) {
                asset.Accept(visitor);
            }
        }
    }
}