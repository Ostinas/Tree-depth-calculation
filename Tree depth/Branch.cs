using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tree_depth
{
    internal class Branch
    {
        private Branch Parent { get; set; }
        private List<Branch> Branches { get; set; }

        public Branch()
        {
            Branches = new List<Branch>();
        }

        public void Add(Branch branch)
        {
            branch.Parent = this;
            Branches.Add(branch);
        }
        private int TreeHeight(Branch parent, int depth)
        {
            int result = depth;
            foreach (var branch in parent.Branches)
            {
                result = Math.Max(result, TreeHeight(branch, depth + 1));
            }
            return result;
        }
        
        public int GetHeight()
        {
            return TreeHeight(this, 0);
        }
    }
}
