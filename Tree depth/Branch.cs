using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tree_depth
{
    /// <summary>
    /// Class for the tree structure with a constructor, add and depth calculation methods.
    /// </summary>
    class Branch
    {
        // The parent node of a branch
        private Branch Parent { get; set; }
        // List of branches of the parent node
        private List<Branch> Branches { get; set; }
        
        // Branch constructor method
        public Branch()
        {
            Branches = new List<Branch>();
        }
        /// <summary>
        /// Method to add a branch to the tree
        /// </summary>
        /// <param name="branch">Branch that will be added</param>
        public void Add(Branch branch)
        {
            branch.Parent = this;
            Branches.Add(branch);
        }
        /// <summary>
        /// Recursive method for calculation of the depth of the tree
        /// </summary>
        /// <param name="parent">The node of which the branches are checked</param>
        /// <param name="depth">The depth level of a branch in the tree</param>
        /// <returns>The depth of the tree structure</returns>
        private int TreeDepth(Branch parent, int depth)
        {
            int result = depth;
            foreach (var branch in parent.Branches)
            {
                result = Math.Max(result, TreeDepth(branch, depth + 1));
            }
            return result;
        }
        /// <summary>
        /// Public method to call the recursive TreeDepth calculation method
        /// </summary>
        /// <returns>The depth of the tree structure</returns>
        public int GetDepth()
        {
            return TreeDepth(this, 1);
        }
    }
}
