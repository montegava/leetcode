// See https://aka.ms/new-console-template for more information

using Week1.common;
using Week2.find_duplicate_file_in_system;
using Week2.MICROSOFT;
using Week2.remove_duplicate_letters;using Solution = Week2.cousins_in_binary_tree_ii.Solution;

//var res = new Solution().RemoveDuplicateLetters("bcabc");
//new ms1().SetZeroes(new int[][]{ [0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5] });

//new Solution2().FindDuplicate(new string[]{ "root/a 1.txt(abcd) 2.txt(efsfgh)", "root/c 3.txt(abdfcd)", "root/c/d 4.txt(efggdfh)" });

//new Solution().ReplaceValueInTree(BinaryTree.BuildTree(new int?[] { 5, 4, 9, 1, 10, null, 7 }));

//new Week2.restore_ip_addresses.Solution().RestoreIpAddresses("101023");

new Week2.height_of_binary_tree_after_subtree_removal_queries.Solution().TreeQueries(
    BinaryTree.BuildTree(new int?[] { 1, null, 5, 3, null, 2, 4 }), new[] { 3, 5, 4, 2, 4 });

Console.WriteLine("Hello, World!");

 