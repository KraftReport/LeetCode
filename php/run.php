<?php

use Solutions\SortThePeople;

require_once './solutions/SortThePeople.php';

print_r(new SortThePeople()->solution(["Mary","John","Emma"],[180,165,170]));