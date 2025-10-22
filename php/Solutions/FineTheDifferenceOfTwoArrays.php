<?php

namespace Solutions;

class FineTheDifferenceOfTwoArrays{

    public function solution($nums1, $nums2){
        $result = [[],[]];
        $dictionary1 = array_count_values($nums1);
        $dictionary2 = array_count_values($nums2);

        foreach($nums1 as $num1){
            if(!array_key_exists($num1,$dictionary2)){
                if(!in_array($num1,$result[0])){
                    $result[0][] = $num1;
                }
            }
        }

        foreach($nums2 as $num2){
            if(!array_key_exists($num2,$dictionary1)){
                if(!in_array($num2,$result[1])){
                    $result[1][] = $num2;
                }
            }
        }

        return $result;
    }
}