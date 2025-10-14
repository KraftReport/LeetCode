<?php

namespace Solutions;

class KthDistinctStringInAnArray{

    public function solution($arr,$k){
        $dictionary = array_count_values($arr);
        $count = 0;

        foreach ($arr as $element) {
            if ($dictionary[$element] == 1) {  
                $count++;
                if ($count == $k) {
                    return $element;
                }
            }
        }

        return "";
    }
}