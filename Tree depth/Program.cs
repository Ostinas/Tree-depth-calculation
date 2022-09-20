using Tree_depth;

//Structure that was provided
Branch tree = new Branch();
Branch branch1 = new Branch();
Branch branch2 = new Branch();
Branch branch3 = new Branch();
Branch branch4 = new Branch();
Branch branch5 = new Branch();
Branch branch6 = new Branch();
Branch branch7 = new Branch();
Branch branch8 = new Branch();
Branch branch9 = new Branch();
branch7.Add(branch8);
branch4.Add(branch7);
branch4.Add(branch9);
branch3.Add(branch6);
branch1.Add(branch5);
branch1.Add(branch3);
branch1.Add(branch4);
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("The depth of the tree is: {0}", tree.GetDepth());

// A linear tree with 5 nodes
Branch LinearTree = new Branch();
Branch LinearBranch = new Branch();
Branch LinearBranch2 = new Branch();
Branch LinearBranch3 = new Branch();
Branch LinearBranch4 = new Branch();
Branch LinearBranch5 = new Branch();
LinearBranch4.Add(LinearBranch5);
LinearBranch3.Add(LinearBranch4);
LinearBranch2.Add(LinearBranch3);
LinearBranch.Add(LinearBranch2);
LinearTree.Add(LinearBranch);
Console.WriteLine("The depth of the tree is: {0}", LinearTree.GetDepth());