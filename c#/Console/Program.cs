using Console.Solutions;
using System;


//System.Console.WriteLine(LongestHarmoniousSubsequence.Solution(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 }));

//System.Console.WriteLine(PossibleStringCount.Solution("abbcccc"));

//System.Console.WriteLine(KthCharacterInString.Solution(10));

//System.Console.WriteLine(TheKthCharacterInStringTwo.Solution(456402, new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1 }));

//System.Console.WriteLine(LuckyInteger.Solution(new int[] { 4, 3, 2, 2, 4, 1, 3, 4, 3 }));

//System.Console.WriteLine(IsPlaindrome.Solution(1123321));

//System.Console.WriteLine(FindTheDifference.Solution("abcd", "abcde"));

//System.Console.WriteLine(AddStrings.Solution("3876620623801494171", "6529364523802684779"));

//System.Console.WriteLine(LongestUncommonSequence.Solution("aefawfawfawfaw", "aefawfeawfwafwaef"));

//System.Console.WriteLine(NumberOfSegmentsInAString.Solution("Hello, my name is John"));

//System.Console.WriteLine(StudentAttendanceRecord.Solution("PPALLP"));

//System.Console.WriteLine(JewelsAndStones.Solution("aA", "aAAbbbb"));

//System.Console.WriteLine(UniqueMossCodeWords.Solution(new string[] { "gin", "zen", "gig", "msg" }));

//System.Console.WriteLine(NumberOfUniqueEmails.Solution(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" }));

//System.Console.WriteLine(DefangingIpAddress.Solution("1.1.1.1"));

//System.Console.WriteLine(RingAndRods.Solution("B0R0G0R9R0B0G0"));

//System.Console.WriteLine(GoatLatin.Solution("I speak Goat Latin"));

//System.Console.WriteLine(LicenceKeyFormatting.Solution("2-4A0r7-4k", 4));

//System.Console.WriteLine(MaxNumberOfBalloons.Solution("krhizmmgmcrecekgyljqkldocicziihtgpqwbticmvuyznragqoyrukzopfmjhjjxemsxmrsxuqmnkrzhgvtgdgtykhcglurvppvcwhrhrjoislonvvglhdciilduvuiebmffaagxerjeewmtcwmhmtwlxtvlbocczlrppmpjbpnifqtlninyzjtmazxdbzwxthpvrfulvrspycqcghuopjirzoeuqhetnbrcdakilzmklxwudxxhwilasbjjhhfgghogqoofsufysmcqeilaivtmfziumjloewbkjvaahsaaggteppqyuoylgpbdwqubaalfwcqrjeycjbbpifjbpigjdnnswocusuprydgrtxuaojeriigwumlovafxnpibjopjfqzrwemoinmptxddgcszmfprdrichjeqcvikynzigleaajcysusqasqadjemgnyvmzmbcfrttrzonwafrnedglhpudovigwvpimttiketopkvqw"));

//System.Console.WriteLine(CountPairsLessThanTarget.Solution(new int[] { -1, 1, 2, 3, 1}, 2));

//System.Console.WriteLine(ReversePrefixOfWord.Solution("abcdefd", 'd'));

//System.Console.WriteLine(ArithmeticTriplets.Solution(new int[] { 4, 5, 6, 7, 8, 9 }, 2));

//System.Console.WriteLine(MinimunAverageOfSmallestAndLargestElements.Solution(new int[] { 7, 8, 3, 4, 15, 13, 4, 1 }));

//System.Console.WriteLine(FirstPlanedrome.Solution(new string[] { "abc", "car", "ada", "racecar", "cool" }));

//System.Console.WriteLine(MergeTwoDimensionalArraysBySummingValues.Solution(new int[][] {
//    new int[] { 2, 4 },
//    new int[] { 3, 6 },
//    new int[] { 5, 5 }
//}, new int[][] {
//    new int[] { 1, 3 },
//    new int[] { 4, 3 }
//}));

//System.Console.WriteLine(ReverseString.Solution("Let's take LeetCode contest"));

//System.Console.WriteLine(DIStringMatch.Solution("IDID"));

//System.Console.WriteLine(LexiographicallySmallestPlaindrome.Solution("egcfe"));

//var result = FindKDistinctIndices.Solution(new int[] { 2, 2, 2, 2, 2 }, 2, 2);

//foreach(var r in result)
//{
//    System.Console.WriteLine(r);
//}

//foreach(int data in MinNumbersOfOperationsToMoveAllBallsIntoEachBox.Solution("001011"))
//{
//    System.Console.WriteLine(data);
//} 

//foreach (int data in PartitionArrayAccordingToGivenPivot.Solution(new int[] { 9, 12, 5, 10, 14, 3, 10 }, 10))
//{
//    System.Console.WriteLine(data);
//}

//System.Console.WriteLine(CountMaximunNumberOfBitwistORSubsets.Solution(new int[] { 3, 2, 1, 5 }));

//foreach(int data in BuildArrayFromPermutation.Solution(new int[] { 5, 0, 1, 2, 3, 4 }))
//{
//    System.Console.WriteLine(data);
//}

//foreach(int data in FindTheOriginalArrayOfPrefixXor.Solution(new int[] { 5, 2, 0, 3, 1 }))
//{
//    System.Console.WriteLine(data);
//}

//foreach(IList<int> data in GroupThePeopleGivenTheGroupTheyBelongTo.Solution(new int[] { 3, 3, 3, 3, 3, 1, 3 }))
//{
//    foreach(int i in data)
//    {
//        System.Console.WriteLine(i);
//    }
//}

//foreach(int data in FindThePrefixCommonArrayOfTwoArrays.Solution(new int[] { 1, 3, 2, 4 },new int[] { 3, 1, 2, 4 }))
//{
//    System.Console.WriteLine(data);
//}

//foreach (IList<int> data in ConvertAnArrayInto2DArrayWithConditions.Solution(new int[] { 1, 2, 3, 4 }))
//{
//    foreach (int i in data)
//    {
//        System.Console.WriteLine(i);
//    }
//    System.Console.WriteLine("----");
//}

//System.Console.WriteLine(MaxIncreaseToCitySkyLine.Solution(new int[][] { [3, 0, 8, 4], [2, 4, 5, 7], [9, 2, 6, 3], [0, 3, 1, 0] }));

//MaximunBinaryTree.Solution(new int[] { 3, 2, 1, 6, 0, 5 });

foreach (int[] array in SortTheStudentByTheirKthScore.Solution(new int[][] { [10, 6, 9, 1], [7, 5, 11, 2], [4, 8, 3, 15] },2))
{
    string row = string.Empty;
    foreach(int data in array)
    {
        row += data;
    }
    System.Console.WriteLine(row);
}