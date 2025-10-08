<?php
namespace Solutions;

class SortThePeople{

    public function solution($names,$heights){ 
        for($i = 0; $i < count($heights); $i++){
            $heightKey = $heights[$i];
            $nameKey = $names[$i];
            $j = $i - 1;

            while($j >= 0 && $heights[$j] < $heightKey){
                $heights[$j+1] = $heights[$j];
                $names[$j+1] = $names[$j];
                $j--;
            }

            $heights[$j+1] = $heightKey;
            $names[$j+1] = $nameKey;
        } 
        return $names;
    }

}