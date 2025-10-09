<?php

require_once './solutions/SortThePeople.php';
require_once './solutions/FindCommonElementBetweenTwoArrays.php';

use Solutions\SortThePeople;
use Solutions\FindCommonElementBetweenTwoArrays;



// print_r(value: new SortThePeople()->solution(names: ["Mary","John","Emma"],heights: [180,165,170]));

print_r(new FindCommonElementBetweenTwoArrays()->solution([2,3,2],[1,2]));