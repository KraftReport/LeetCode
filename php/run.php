<?php

require_once './solutions/FindMissingAndRepeatedValues.php';
require_once './solutions/SortThePeople.php';
require_once './solutions/FindCommonElementBetweenTwoArrays.php';
require_once './solutions/CheckIfPangram.php'; 
require_once './solutions/MaximunNumbersOfWordsYouCanType.php';
require_once './solutions/KthDistinctStringInAnArray.php';
require_once './Solutions/FindMaximunNumberOfStringPairs.php';
require_once './Solutions/FineTheDifferenceOfTwoArrays.php';

use Solutions\KthDistinctStringInAnArray;
use Solutions\SortThePeople;
use Solutions\FindCommonElementBetweenTwoArrays;
use Solutions\CheckIfPangram;
use Solutions\FindMissingAndRepeatedValues;
use Solutions\MaximunNumbersOfWordsYouCanType; 
use Solutions\FindMaximunNumberOfStringPairs;
use Solutions\FineTheDifferenceOfTwoArrays;


// var_dump(value: new SortThePeople()->solution(names: ["Mary","John","Emma"],heights: [180,165,170]));

// var_dump(new FindCommonElementBetweenTwoArrays()->solution([2,3,2],[1,2]));

// var_dump(new CheckIfPangram()->solution("leetcode"));

// var_dump(new FindMissingAndRepeatedValues()->solution([[1,3],[2,2]]));

// var_dump(new MaximunNumbersOfWordsYouCanType()->solution("hello world","ad"));

// var_dump(new KthDistinctStringInAnArray()->solution(["a","b","a"],3));

// var_dump(new FindMaximunNumberOfStringPairs()->solution(["cd","ac","dc","ca","zz"]));

var_dump(new FineTheDifferenceOfTwoArrays()->solution([1,2,3],[2,4,6]));